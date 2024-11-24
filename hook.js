import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import { logger } from './logger';

export const hook = () => {
    logger.toast('start hook');
    Il2Cpp.perform(() => {
        logger.toast('unity Version: ', Il2Cpp.unityVersion);
    });
};