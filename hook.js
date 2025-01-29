import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import logger from './logger';
import game from './game';

export const hook = () => {
    logger.toast('start hook');
    Il2Cpp.perform(() => {
        logger.toast('unity Version: ', Il2Cpp.unityVersion);

        // 钩子方法，重写为空函数
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("update105Log").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateCoinLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateGoldLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemLIstLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateMyData").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("getAllChargeOrder").implementation = function () { };

        exports.call = {
            充值: {
                charge: {
                    // 重写 "chargeByOther105" 方法
                    chargeByOther105: function (charge_val, func_, sub_func_) {
                        this.method("chargeByOther105").invoke(charge_val, func_, sub_func_);
                        logger.toast("arg:","charge_val");
                    }
                }
            }
        };
    });
};
