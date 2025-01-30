import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import logger from './logger';
import game from './game';

export const hook = () => {
    logger.toast('start hook');
    Il2Cpp.perform(() => {
        logger.toast('unity Version: ', Il2Cpp.unityVersion);
        /** 阻止log */
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("update105Log").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateCoinLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateGoldLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemListLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateMyData").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("getAllChargeOrder").implementation = function () { };

        /** charge */
        import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import logger from './logger';
import game from './game';

export const hook = () => {
    logger.toast('开始 Hook');
    Il2Cpp.perform(() => {
        logger.toast('Unity 版本: ' + Il2Cpp.unityVersion);

        // 获取目标类和方法
        const targetClass = Il2Cpp.Domain.assembly("Assembly-CSharp").image.class("QianYi.Game.Hero.V_Charge_Sys_UI");
        const targetMethod = targetClass.method("chargeByOhter105");

        // 检查方法是否存在
        if (!targetMethod) {
            logger.log('未找到 chargeByOhter105 方法');
            return;
        }

        // 打印方法信息
        logger.info('方法参数数量:', targetMethod.parameterCount);
        logger.info('方法参数类型:', targetMethod.parameters.map(p => p.type.name).join(', '));
        logger.info('方法返回类型:', targetMethod.returnType.name);

        // Hook 方法
        targetMethod.implementation = function (charge_val, func_, sub_func_) {
            // 获取当前实例
            const instance = this.try();
            if (!instance) {
                logger.info('未找到 V_Charge_Sys_UI 实例');
                return;
            }

            // 根据 Mod.var.switch3 修改参数
            if (Mod.var.switch3) {
                logger.info('已启用 Charge 修改');
                return instance.method("chargeByOhter105").invoke(6, 2, "test");
            } else {
                logger.info('调用原方法');
                return instance.method("chargeByOhter105").invoke(charge_val, func_, sub_func_);
            }
        };


        /* 怪自杀 */
        game.assembly().class('QianYi.Game.Hero.MonsterObj').method("changeHp").implementation = function (val, damageType) {
            this.method("changeHp").invoke(val, damageType);
            if (Mod.var.switch2) {
                this.method("changeHp").invoke(99999999, 0);
            }
        };
    });
};
