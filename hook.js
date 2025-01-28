import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import logger from './logger';
import game from './game';

export const hook = () => {
    logger.toast('start hook');
    Il2Cpp.perform(() => {
        logger.toast('unity Version: ', Il2Cpp.unityVersion);
        function prevenlog() {
        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("update105Log").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateLog").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateCoinLog").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateGoldLog").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemLog").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateItemLIstLog").implementation = function () { };

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("updateMyData").implementation = function () { };
        }

        game.assembly().class('QianYi.Game.Hero.MyHttpUtil').method("getAllChargeOrder").implementation = function () { };

exports.call = {
     充值 :{
         charge: {
        /** 受击扣血函数 */
        game.assembly().class('QianYi.Game.Hero.V_Charge_Sys_UI').method("chargeByOther105").implementation = function (charge_val, func_, sub_func_) {
            this.method("chargeByOther105").invoke(charge_val, func_, sub_func_)
            //if (chage_val == 6){
            //logger.toast("执行失败")
         //   }
            }
        },
  /*      
        game.assembly().class('GamePlay.PlayerObj').method("UpdateLogic").implementation = function (dt) {
            this.method("UpdateLogic").invoke(dt);
            if (Mod.var.switch2 && this.field('GroupID').value != 99 && this.method("get_IsMonster").invoke()) {
                this.method("OnHPZero").invoke(true, true, this);
            }
        };*/
},
};
