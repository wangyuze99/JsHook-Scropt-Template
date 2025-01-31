import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import logger from './logger';
import game from './game';

export const hook = () => {
    logger.toast('start hook');
    Il2Cpp.perform(() => {
        logger.toast('unity Version: ', Il2Cpp.unityVersion);

        // Hook 方法
        const className = 'QianYi.Game.Hero.MyHttpUtil';
        const classRef = game.assembly().class(className);

        const methodsToHook = [
            'update105Log',
            'updateLog',
            'updateCoinLog',
            'updateGoldLog',
            'updateItemLog',
            'updateItemListLog',
            'updateMyData',
            'getAllChargeOrder'
        ];

        methodsToHook.forEach(methodName => {
            const method = classRef.method(methodName);
            method.implementation = function () { };
        });

        // 特殊方法处理
        const call = {
            充值: {
                charge: {
                    getSeasonInfo: () => {
                        const method = classRef.method('getSeasonInfo');
                        method.implementation = function () {
                            this.method('getSeasonInfo').invoke(this);
                        };
                    }
                }
            }
        };
    });
};
