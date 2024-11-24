import { Mod } from './mod';
import { hook } from './hook';
import { getMenu } from './menu';
import { logger } from './logger';


logger.toast('start hook');
Il2Cpp.perform(() => {
    logger.toast('unity Version: ', Il2Cpp.unityVersion);
});

function 追踪() {
    const mach = {
        classname: '', noclassname: '', methodname: '', nomethodname: '', parameter: '', noparameter: ''
    };
    {/** 网络请求 */
        mach.classname = 'GearEngine.Network.*ProtocolHandler';
        mach.nomethodname = 'TaskUpdate|Deserialize|OnResp|HeartBeat|OnNotice|Resolve|OnDel';
        mach.noparameter = 'GearEngine.Network';
    }
    mach.methodname = 'SelectChap';
    mach.classname = 'PioneerAcademyProtocolHandler';
    // mach.nomethodname = 'update|MoveNext|SetContentAnchoredPosition|get_Instance';

    logger.debug("开始追踪---");
    Il2Cpp.trace(true)//是否打印参数
        .verbose(true)//是否打印完全一样的堆栈
        .assemblies(Il2Cpp.domain.assembly("Assembly-CSharp"))
        // .filterClasses(klass => new RegExp(mach.classname, 'i').test(klass.fullName)
        //     && !new RegExp(mach.noclassname, 'i').test(klass.fullName))
        .filterClasses(klass => new RegExp(mach.classname, 'i').test(klass.fullName))
        // .filterClasses(klass => !new RegExp(mach.noclassname, 'i').test(klass.fullName))
        // .filterMethods(method => new RegExp(mach.methodname).test(method.name)
        // && !new RegExp(mach.nomethodname, 'i').test(method.name))
        .filterMethods(method => new RegExp(mach.methodname, 'i').test(method.name))
        // .filterMethods(method => !new RegExp(mach.nomethodname, 'i').test(method.name))
        // .filterParameters(parameter => !new RegExp(mach.noparameter, 'i').test(parameter.toString()))// 没有参数的会被过滤
        .and()
        .attach();
    logger.debug("追踪结束---");
}