import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import * as hook from './hook';

/**
 * 通过 id 查找元素
 * @param {string|number} id
 * @returns {MenuItem}
 */
function findById(id) {
    return findItem((e) => e.id === id);
}
export { findById };

/**
 * 通过 title 查找元素
 * @param {string} title
 * @returns {MenuItem}
 */
function findByTitle(title) {
    return findItem((e) => e.title === title);
}
export { findByTitle };

export const getMenu = () => {
    return [
        {
            type: 'tab',
            item: [
                {
                    title: '充值',
                    item: [
                        {
                            type: 'input',
                            title: '金额',
                            val: '6',
                            callback: e => {
  if (o.call?.充值?.charge) { // 使用可选链避免未定义错误
    o.call.充值.charge(e.val, 2, 1);
  } else {
    console.error("充值方法未正确初始化");
  }
}
                            },
 
                        },
                        /*{
                            type: 'button',
                            title: '充值',
                            callback: (data) => {
                                hook.call.充值.charge(parseInt(data.val));
                            },
                        },*/
                        {
                            type: 'switch',
                            title: '无敌',
                            val: Mod.var.switch1,
                            callback: (data) => {
                                Mod.var.switch1 = data.val;
                            },
                        },
                        {
                            type: 'switch',
                            title: '自杀',
                            val: Mod.var.switch2,
                            callback: (data) => {
                                Mod.var.switch2 = data.val;
                            },
                        },
                    ],
                },
                {
                    title: '关于',
                    item: [
                        {
                            type: 'text',
                            val: 'Mod: ' + Mod.name,
                        },
                        {
                            type: 'text',
                            val: 'Version: ' + Mod.version,
                        },
                        {
                            type: 'text',
                            val: 'Build: ' + Mod.build,
                        },
                        {
                            type: 'text',
                            val: 'CoreVersionCode: ' + runtime.coreVersionCode,
                        },
                        {
                            type: 'button',
                            title: 'Dump unity',
                            callback: (data) => {
                                Il2Cpp.perform(() => {
                                    console.log('Unity Version:', Il2Cpp.unityVersion);
                                    console.log('Dump Start');
                                    Il2Cpp.dump();
                                    console.log('Dump Complete');
                                });
                            },
                        },
                    ],
                },
            ],
            default: 1,
        },
    ];
};
