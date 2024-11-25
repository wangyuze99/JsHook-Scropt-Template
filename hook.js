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
                /* 不是boss直接自杀 */
                if (this.field('GroupID').value != 99) {
                    this.method("OnHPZero").invoke(true, true, hpLoss.field('Attacker').value);
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
    });
};