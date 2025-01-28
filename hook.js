import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import logger from './logger';
import game from './game';

export const hook = () => {
    logger.toast('start hook');
    Il2Cpp.perform(() => {
        logger.toast('unity Version: ', Il2Cpp.unityVersion);



        
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
        game.assembly().class('GamePlay.PlayerObj').method("UpdateLogic").implementation = function (dt) {
            this.method("UpdateLogic").invoke(dt);
            if (Mod.var.switch2 && this.field('GroupID').value != 99 && this.method("get_IsMonster").invoke()) {
                this.method("OnHPZero").invoke(true, true, this);
            }
        };
    });
};
