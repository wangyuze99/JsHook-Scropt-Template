import 'frida-il2cpp-bridge';

import { Mod } from './mod';

import logger from './logger';

import game from './game';



export const hook = () => {

    logger.toast('start hook');

    Il2Cpp.perform(() => {

        logger.toast('unity Version: ', Il2Cpp.unityVersion);

        /** 阻止log */
        function preventLog() {

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("update105Log").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateLog").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateCoinLog").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateGoldLog").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemLog").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemLIstLog").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateMyData").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("getAllChargeOrder").implementation = function () { };
        }


        /** 受击扣血函数 */

        game.assembly().class('QianYi.Game.Hero.V_Charge_Sys_UI').method("chargeByOther105").implementation = function (charge_val, func_, sub_func_) {
    if (Mod.var.slider3) {
        // 使用滑动条的值
        charge_val = Mod.var.slider1;
        func_ = Mod.var.slider2;
        sub_func_ = Mod.var.slider3;
    }
    
    // 调用原方法
    this.method("chargeByOther105").invoke(charge_val, func_, sub_func_);
        };

        /* 怪自杀 */

      /*  game.assembly().class('QianYi.Game.Hero.MonsterObj').method("changeHp").implementation = function (val , damageType, damageObj) {

            this.method("changeHp").invoke(val, damageType);

            if (Mod.var.switch2) {

                this.method("changeHp").invoke(99999999, 0 );

            }

        };*/

    });

};
