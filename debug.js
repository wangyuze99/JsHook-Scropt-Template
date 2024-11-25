import 'frida-il2cpp-bridge';
import logger from './logger';
import game from './game';


logger.toast('start hook');
Il2Cpp.perform(() => {
    logger.toast('unity Version: ', Il2Cpp.unityVersion);

    game.assembly().class('GamePlay.BattleStatistic').method("OnActorDamage").implementation = function (monster, damage) {
        // logger.debug(
        //     '是否是怪物:', monster.method("get_IsMonster").invoke(),
        //     '伤害:', damage.field('HPDelta').value,
        // );
        this.method("OnActorDamage").invoke(monster, damage);
    };
    /** 受击扣血函数 */
    game.assembly().class('GamePlay.PlayerObj').method("DealDamage").implementation = function (hpLoss) {
        const count = 20;
        if (this.method("get_IsMonster").invoke()) {
            // logger.debug(
            //     'GroupID', this.field('GroupID').value,
            //     'AIName', this.field('m_DefaultAIName').value,
            //     this.field('GroupID').value != 99,
            // );
            // for (let index = 0; index < count; index++) {
            //     this.method("DealDamage").invoke(hpLoss);
            // }
        } else {
            const PlayerSkillMgr = this.method('get_SkillMgr').invoke();
            const get_LastSkill = PlayerSkillMgr.method('get_LastSkill').invoke();
            logger.debug(get_LastSkill)
            // for (let index = 0; index < count; index++) {
            //     hpLoss.field('Attacker').value.method("DealDamage").invoke(hpLoss);
            // }
        }
    };
    /** hp 为0死亡函数 */
    game.assembly().class('GamePlay.PlayerObj').method("OnHPZero").implementation = function (triggerDieLogic, triggerDieScript, killer) {
        this.method("OnHPZero").invoke(triggerDieLogic, triggerDieScript, killer);
        // logger.debug(
        //     '死亡逻辑:', triggerDieLogic,
        //     '死亡脚本:', triggerDieScript,
        //     '攻击者:', killer,
        // );
    };
    /* 怪自杀 */
    // game.assembly().class('GamePlay.PlayerObj').method("UpdateLogic").implementation = function (dt) {
    //     this.method("UpdateLogic").invoke(dt);
    //     if (this.field('GroupID').value != 99 && this.method("get_IsMonster").invoke()) {
    //         // logger.debug(this)
    //         this.method("OnHPZero").invoke(true, true, this);
    //     }
    // };
    // 追踪();
    // gc('GamePlay.PlayerSkill', (obj, jsObj) => {
    //     logger.debug(
    //         '', obj.method('GetJson').invoke(),
    //     );
    // });
});

function gc(classname, fun) {
    logger.debug('开始GC查找');
    let count = 0;
    Il2Cpp.gc.choose(game.assembly().class(classname)).forEach((e) => {
        count++;
        fun(e, game.convertObject(e));
    });
    logger.debug('GC查找完成,总数:', count);
}

function 追踪() {
    const mach = {
        classname: '', noclassname: '', methodname: '', nomethodname: '', parameter: '', noparameter: ''
    };
    mach.classname = 'GamePlay.PlayerObj';
    mach.noclassname = 'ui';
    mach.methodname = 'Potential';
    mach.nomethodname = 'GetSpPotentialId';
    logger.debug("开始追踪---");
    Il2Cpp.trace(true)//是否打印参数
        .verbose(true)//是否打印完全一样的堆栈
        .assemblies(Il2Cpp.domain.assembly("Assembly-CSharp"))
        // .filterClasses(klass => new RegExp(mach.classname, 'i').test(klass.fullName) && !new RegExp(mach.noclassname, 'i').test(klass.fullName))
        // .filterClasses(klass => new RegExp(mach.classname, 'i').test(klass.fullName))
        // .filterClasses(klass => !new RegExp(mach.noclassname, 'i').test(klass.fullName))
        .filterMethods(method => new RegExp(mach.methodname).test(method.name) && !new RegExp(mach.nomethodname, 'i').test(method.name))
        // .filterMethods(method => new RegExp(mach.methodname, 'i').test(method.name))
        // .filterMethods(method => !new RegExp(mach.nomethodname, 'i').test(method.name))
        // .filterParameters(parameter => !new RegExp(mach.noparameter, 'i').test(parameter.toString()))// 没有参数的会被过滤
        .and()
        .attach();
    logger.debug("追踪结束---");
}