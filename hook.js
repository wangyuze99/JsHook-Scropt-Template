import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import logger from './logger';
import game from './game';

export const hook = () => {
    logger.toast('start hook');
    Il2Cpp.perform(() => {
        logger.toast('unity Version: ', Il2Cpp.unityVersion);

        // Prevent logging methods
        function preventLog() {
            game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("update105Log").implementation = function () { };
            game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateLog").implementation = function () { };
            game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateCoinLog").implementation = function () { };
            game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateGoldLog").implementation = function () { };
            game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemLog").implementation = function () { };
            game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemLIstLog").implementation = function () { };
            game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateMyData").implementation = function () { };
        }

        // Hook chargeByOhter105 method
        game.assembly().class('QianYi.Game.Hero.V_Charge_Sys_UI').method("chargeByOther105").implementation = function (charge_val, func_, sub_func_) {
            logger.toast('Hooked chargeByOhter105 called with parameters:', {
                charge_val: charge_val,
                func_: func_,
                sub_func_: sub_func_
            });

            // Custom logic: Set charge_val to 6 and func_ to 2
            const newChargeVal = 6;
            const newFunc_ = 2;
            const newSubFunc_ = sub_func_; // You can set this to any value

            logger.toast('Hooked chargeByOhter105 executed with custom parameters:', {
                charge_val: newChargeVal,
                func_: newFunc_,
                sub_func_: newSubFunc_
            });

            // Do not call the original method
            // this.method("chargeByOther105").invoke(charge_val, func_, sub_func_);
        };

        // Call preventLog function
        preventLog();
    });
};

export const call = {
    充值: {
        charge: function (charge_val, func_, sub_func_) {
            // Call the hooked chargeByOhter105 method
            game.assembly().class('QianYi.Game.Hero.V_Charge_Sys_UI').method("chargeByOther105").invoke(charge_val, func_, sub_func_);
        }
    }
};
