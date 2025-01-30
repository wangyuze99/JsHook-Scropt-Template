import 'frida-il2cpp-bridge'
import { Mod } from './mod'
export const getMenu = () => {
    return [
        {
            type: 'tab',
            item: [
                {
                    title: 'tab1',
                    item: [
                        {
                            type: 'switch',
                            title: '6',
                            val: Mod.var.switch3,
                            callback: (data) => {
                                Mod.var.switch3 = data.val;
                            }
                        },
                        {
                            type: 'slider',
                            title: 'funcval',
                            val: Mod.var.slider2,
                            min: 2,
                            max: 20,
                            callback: (data) => {
                                Mod.var.slider2 = parseInt(data.val);
                            }
                        },
                        {
                            type: 'slider',
                            title: 'subfuncval',
                            val: Mod.var.slider3,
                            min: 0,
                            max: 100,
                            callback: (data) => {
                                Mod.var.slider3 = parseInt(data.val);
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
                        },
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
}   
