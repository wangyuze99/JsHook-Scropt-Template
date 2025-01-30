import Il2cpp from 'frida-il2cpp-bridge';
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
        game.assembly().class('QianYi.Game.Hero.V_Charge_Sys_UI').method("chargeByOhter105").implementation = function (charge_val, func_, sub_func_) {
            const instance = Il2cpp.gc.choose(game.assembly().class('QianYi.Game.Hero.V_Charge_Sys_UI'));
            if (Mod.var.switch3) {
                this.method("chargeByOhter105").invoke(instance[0], 6, 2, "test");
            } else {
                this.method("chargeByOhter105").invoke(instance[0], charge_val, func_, sub_func_);
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
