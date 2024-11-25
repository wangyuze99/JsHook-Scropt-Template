import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import logger from './logger';
import game from './game';

export const hook = () => {
    logger.toast('start hook');
    Il2Cpp.perform(() => {
        logger.toast('unity Version: ', Il2Cpp.unityVersion);

        /** 受击扣血函数 */
        game.assembly().class('GamePlay.PlayerObj').method("DealDamage").implementation = function (hpLoss) {
            const count = Mod.var.slider1;
            if (this.method("get_IsMonster").invoke()) {
                /* 重复伤害 */
                for (let index = 0; index < count; index++) {
                    this.method("DealDamage").invoke(hpLoss);
                }
            } else {
                /* 攻击我就反伤 */
                for (let index = 0; index < count; index++) {
                    hpLoss.field('Attacker').value.method("DealDamage").invoke(hpLoss);
                }
                if (!Mod.var.switch1) {
                    this.method("DealDamage").invoke(hpLoss);
                }
            }
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