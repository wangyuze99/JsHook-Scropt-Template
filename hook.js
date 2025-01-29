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
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemListLog").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateMyData").implementation = function () { };
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("getAllChargeOrder").implementation = function () { };

        exports.call = {
      "充值": {
        charge: function(amount, type, source) {
          const targetClass = Il2Cpp.domain.assembly("Assembly-CSharp").image.class("QianYi.Game.Hero.V_Charge_Sys_UI");
          const method = targetClass.method("chargeByOther105");
          if (method) {
            method.invoke(amount, type, source);
            a.default.toast(`成功充值: ${amount}`);
          } else {
            console.error("方法chargeByOther105不存在");
          }
        }
      }
    };
  });
};
