export default {
    /** 检查当前环境是否是 JsHook */
    isJsHook: typeof crypto != 'undefined',
    /** 获取行号[异常] */
    getLine() {
        const err = new Error();
        const stack = err.stack.split('\n');
        // 从堆栈跟踪信息中提取调用位置
        const callerLine = stack[2];
        return callerLine.match(/:(\d+):\d+\)$/)[1];
    },
    /** 只有在调试时才会输出 */
    debug(message, ...optionalParams) {
        if (!this.isJsHook) {
            console.log(message, ...optionalParams);
        }
    },
    /** 打印日志并且弹出弹窗 */
    info(message, ...optionalParams) {
        if (this.isJsHook) {
            // console.log(`[line ${this.getLine()}]:`, message, ...optionalParams);
            console.log(message, ...optionalParams);
            message = JSON.stringify(message);
            optionalParams.forEach(element => {
                message += ` ${element}`;
            });
            toast(message);
        }
    },
    /** 显示 Toast 提示 */
    toast(message, ...optionalParams) {
        if (this.isJsHook) {
            message = JSON.stringify(message);
            optionalParams.forEach(element => {
                message += ` ${element}`;
            });
            toast(message);
        } else {
            console.log(message, ...optionalParams);
        }
    },
    /**
     *  以表格形式打印对象
     * @param {object} data 打印的对象数组
     * @param {string[]} columns 需要打印的字段,如果为空则打印全部
     */
    table(data, columns = null) {
        if (this.isJsHook) return;
        if (!Array.isArray(data) || data.length === 0) {
            console.log("没有可用的数据显示在表格中.");
            return;
        }
        // 过滤空值
        data = data.filter(e => e != null);
        // 如果没有指定列，则打印所有列
        const headers = columns || Object.keys(data[0]);

        // 转字符串
        data.forEach(e => {
            headers.forEach(header => {
                let str = e[header].toString();
                /** 把集合|字典截短,并统计元素个数 */
                if (str.includes('System.Collections.Generic.')) {
                    e[header] = `${str.replace(/System.Collections.Generic./, '')}:${e[header].method("get_Count")?.invoke()}`;
                }
                else { e[header] = str; }
            });
        });

        // 计算每列的最大宽度
        const colWidths = headers.map(header => Math.max(header.length, ...data.map(row => String(row[header] || '').length)));

        // ANSI 转义码定义，用于设置颜色
        const RESET = "\x1b[0m";
        const RED = "\x1b[31m";

        // 表格顶部和底部的边框[◜◝◟◞⌜⌝⌞⌟⌏⌎⌍⌌◸◹◺◿◤◥◣◢]
        const borderTop = `+${colWidths.map(width => '-'.repeat(width + 2)).join('+')}+`;
        const borderBottom = borderTop;

        // 表格头行
        const headerRow = `| ${headers.map((header, index) => header.padEnd(colWidths[index])).join(' | ')} |`;

        // 数据行，每行是一个数组，包含每列的值
        const rows = data.map(row => headers.map(header => String(row[header] || '')));

        // 检查每列中的值是否不同
        const uniqueColumns = headers.map((header, index) => {
            const values = rows.map(row => row[index]);
            return new Set(values).size !== 1;
        });

        // 根据 uniqueColumns 设置颜色
        const coloredRows = rows.map(row =>
            `| ${row.map((value, index) => {
                const coloredValue = uniqueColumns[index] ? `${RED}${value}${RESET}` : value;
                return coloredValue.padEnd(colWidths[index] + (uniqueColumns[index] ? RED.length + RESET.length : 0));
            }).join(' | ')} |`
        );

        // 列之间的分隔符
        const separator = `+${colWidths.map(width => '-'.repeat(width + 2)).join('+')}+`;

        // 打印表格
        console.log(borderTop); // 顶部边框
        console.log(headerRow); // 头行
        console.log(separator); // 分隔符
        coloredRows.forEach(row => console.log(row)); // 每行数据
        console.log(borderBottom); // 底部边框
        console.log(`总行数:${data.length}`); // 底部边框
    }
};
