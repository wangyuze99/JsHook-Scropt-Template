import 'frida-il2cpp-bridge';
import { Mod } from './mod';
import hook from './hook';

/**
 * 通过 id 查找元素
 * @param {string|number} id
 * @returns {MenuItem}
 */
function findById(id) {
    return findItem((e) => e.id == id);
}
exports.findById = findById;

/**
 * 通过 title 查找元素
 * @param {string} title
 * @returns {MenuItem}
 */
function findByTitle(title) {
    return findItem((e) => e.title == title);
}
exports.findByTitle = findByTitle;

export const getMenu = () => {
    return [
        {
            type: 'tab',
            item: [
                {
    
                    title: '充值',
                    item: [
                        {
                            type: "input",
                            title: "金额",
                            val: "6",
                            callback: (data) => {
                                Il2Cpp.perform((() => {
                                game.assembly().class('QianYi.Game.Hero.V_Charge_Sys_UI').method("chargeByOhter105").implementation = function(charge_val, func_, sub_func_);
                               this.method("chargeByOhter105").invoke(data.val, 2, sub_func_);
                            
    });
}
                        },
                        {
                            type: "switch",
                            title: "无敌",
                            val: Mod.var.switch1,
                            callback: (data) => {
                                Mod.var.switch1 = data.val;
                            }
                        },
                        {
                            type: "switch",
                            title: "自杀",
                            val: Mod.var.switch2,
                            callback: (data) => {
                                Mod.var.switch2 = data.val;
                            }
                        }
                    ]
                },
                {
                    title: '关于',
                    item: [
                        {
                            type: 'text',
                            val: 'Mod: ' + Mod.name
                        },
                        {
                            type: 'text',
                            val: 'Version: ' + Mod.version
                        },
                        {
                            type: 'text',
                            val: 'Build: ' + Mod.build
                        },
                        {
                            type: 'text',
                            val: 'CoreVersionCode: ' + runtime.coreVersionCode
                        },
                        {
                            type: 'button',
                            title: 'Dump unity',
                            callback: (data) => {
                                Il2Cpp.perform(() => {
                                    console.log(Il2Cpp.unityVersion);
                                    console.log('Dump Start');
                                    Il2Cpp.dump();
                                    console.log('Dump Complete');
                                });
                            }
                        }
                    ]
                }
            ],
            default: 1
        }
    ]
};
