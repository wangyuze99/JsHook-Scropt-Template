import logger from './logger';
export default {
    /**
     * @returns {Il2Cpp.Image}
     */
    assembly() { return Il2Cpp.domain.assembly("Assembly-CSharp").image; },
    /**
     * @returns {Il2Cpp.Class}
     */
    sysUInt32() { return Il2Cpp.corlib.class("System.UInt32"); },
    /**
     * @returns {Il2Cpp.Class}
     */
    sysUInt64() { return Il2Cpp.corlib.class("System.UInt64"); },
    /**
     * @returns {Il2Cpp.Class}
     */
    sysByte() { return Il2Cpp.corlib.class("System.Byte"); },
    /**
     * @returns {Il2Cpp.Class}
     */
    sysString() { return Il2Cpp.corlib.class("System.String"); },
    /**
     * @returns {Il2Cpp.Object}
     */
    getListByClazz(clazz) { return Il2Cpp.corlib.class('System.Collections.Generic.List`1').inflate(clazz).new(); },
    /**
     *  把游戏对象的字段名和值转换为js对象
     * @param {Il2Cpp.Object} object 游戏对象
     * @param {string[]} fields 需要获取文本的字段
     * @returns {object} js对象
     */
    convertObject(object, fields = null) {
        if (object == 'null') { return null; }
        return object.class.fields.reduce((acc, field) => {
            if (!field.isStatic) {
                let v = object.field(field.name).value;
                if (fields && fields.includes(field.name)) { acc[field.name] = game.getText(v); }
                else { acc[field.name] = v; }
            }
            return acc;
        }, {});
    },
    /**
     *  把游戏类的字段名和值转换为js对象
     * @param {Il2Cpp.Class} clazz 游戏类
     * @returns {object} js对象
     */
    convertClass(clazz) {
        return clazz.fields.reduce((acc, field) => {
            if (field.isStatic) { acc[field.name] = field.value; }
            return acc;
        }, {});
    },
    /**
     * @callback listDataCallback
     * @param {Il2Cpp.Object} item 
     */
    /**
     *  遍历列表,并且把每个元素作用于函数
     * @param {Il2Cpp.Object} list 需要遍历的集合
     * @param {listDataCallback} callback 回调函数
     * @param {boolean} isPrint  是否打印
     */
    iterList(list, callback = null, isPrint = true) {
        if (this.isNull(list)) {
            logger.debug('列表为空');
            return;
        }
        if (isPrint) logger.debug('-------------------------------------------------------------------------------------');
        for (let index = 0; index < list.method("get_Count").invoke(); index++) {
            const element = list.method("get_Item").invoke(index);
            if (callback) {
                callback(element);
            } else if (isPrint) {
                logger.debug("\t 项目:", element);
            }
        }
        if (isPrint) logger.debug("列表:", list, "总数:", list.method("get_Count").invoke());
    },
    /**
     * @callback dicDataCallback
     * @param {Il2Cpp.Object} key
     * @param {Il2Cpp.Object} val
     */
    /**
     *  遍历字典,并且把每个元素作用于函数
     * @param {Il2Cpp.Object} dic 需要遍历的字典
     * @param {dicDataCallback} callback  回调函数
     * @param {boolean} isPrint  是否打印
     */
    iterDic(dic, callback = null, isPrint = true) {
        if (this.isNull(dic)) {
            logger.debug('字典为空');
            return;
        }
        if (isPrint) logger.debug('+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++');
        let Enumerator = dic.method("System.Collections.IDictionary.GetEnumerator").invoke();
        while (Enumerator.method("MoveNext").invoke()) {
            let itme = Enumerator.method("get_Current").invoke();
            let key = itme.field('key').value;
            let value = dic.method("get_Item").invoke(key);
            if (callback) {
                callback(key, value);
            } else if (isPrint) {
                logger.debug('key:', key, '\tval:', value);
            }
        }
        if (isPrint) logger.debug("字典:", dic, '总数', dic.method("get_Count").invoke());
    },
    /** 判断游戏对象是否为空 */
    isNull(obj) {
        return obj == 'null' || obj == null;
    },
};