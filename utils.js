import logger from "./logger";

export default {
    /** 用户等级 */
    lv: 0,
    /** 使用信息 */
    useLog: {},
    /** 发送使用信息到服务器 */
    sendUseInfo() {
        http.post('https://qzwdyz.top/quiz/use-info/send-log', JSON.stringify(utils.useLog), {
            "content-type": "application/json"
        }, {
            success: function (result) {
                if (JSON.parse(result).code != 200) {
                    logger.info(result);
                    app.exitApp();
                }
            },
            error: function (err) {
                logger.info("鸡了朋友,服务器噶了!", err);
                app.exitApp();
            }
        });
    },
    /** 异常处理,如果报错提示在哪个方法出现错误 */
    exCatch(codeToRun, ...args) {
        try {
            // 执行传入的代码块
            codeToRun(...args);
        } catch (error) {
            logger.info(`[${codeToRun.name}]出现错误:${error.message}`);
            logger.debug(`[${codeToRun.name}]出现错误:${error.message}`);
            if (error.stack) {
                const stackLines = error.stack.split('\n');
                // 第一行通常包含异常信息，从第二行开始是调用栈信息
                if (stackLines.length > 1) {
                    const callerInfo = stackLines[1];
                    logger.info('Exception occurred at:', callerInfo);
                    logger.debug('Exception occurred at:', callerInfo);
                }
            }
        }
    },
    /** 捕获异常并且发送使用信息 */
    exCatch2(codeToRun, ...args) {
        utils.useLog.functionName = codeToRun.name;
        utils.useLog.dateTime = new Date().format("yyyy-MM-dd HH:mm:ss");
        // utils.sendUseInfo();
        utils.exCatch(codeToRun, ...args);
    },
    /** 如果验证失败退出 app */
    网络验证({ versions, name }, callBack) {
        const nowDate = new Date().format("yyyy-MM-dd HH:");
        const androidID = device.getAndroidID();
        http.post('https://qzwdyz.top/quiz/device/verify', JSON.stringify({
            "deviceId": crypto.rc4Encrypt(nowDate, androidID),
            "versions": versions,
        }), {
            "content-type": "application/json"
        }, {
            success: function (result) {
                result = JSON.parse(result);
                if (result.code != 200) {
                    logger.info(result.message);
                    app.exitApp();
                }
                // 获取登录的设备等级
                utils.lv = result.data.lv;
                // 获取登录的卡号
                utils.useLog.username = result.data.username;
                logger.info(`卡号:${result.data.username}\n到期时间:${result.data.endTime}\n卡密等级:${result.data.lv}\n版本:${versions}`);
                /** 获取本地加密串 */
                let md5Android = crypto.md5(androidID + nowDate + versions + result.data.lv);
                if (!new RegExp(md5Android, 'i').test(result.data.android) && !new RegExp(result.data.android, 'i').test(md5Android)) {
                    logger.info(`卡密验证失败!!!!`);
                    /** 退出app */
                    setTimeout(() => { app.exitApp(); }, 1000);
                }
                // ui显示
                if (callBack) { callBack(name); }
            },
            error: function (err) {
                /** 退出app */
                setTimeout(() => { app.exitApp(); }, 1000);
                logger.info("请求失败!!", err);
            }
        });

    },
    /** 如果验证失败退出 app */
    本地验证(id, data = '2024-02-01', callBack) {
        if (new RegExp(id, 'i').test(device.getAndroidID()) && new Date() < new Date(data)) {
            if (/f55d505cbaed768b|613cdf10b09bee3c/.test(device.getAndroidID())) { utils.lv = 100; }
            if (/645bc74c05a3af78|41f0db53aeda002b/.test(device.getAndroidID())) { utils.lv = 3; }
            if (callBack) { callBack('max'); }
            logger.info("验证成功!!");
        } else {
            logger.info("验证失败!!");
            setTimeout(() => { app.exitApp(); }, 1000);
        }
    }
};