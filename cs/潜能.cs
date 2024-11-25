
// Assembly-CSharp
class GamePlay.PlayerSkillMgr : System.Object
{
    GamePlay.PlayerObj Owner; // 0x10
    System.Int32 SkillCastSessionIdIncremented; // 0x18
    GamePlay.PlayerSkill <LastSkill>k__BackingField; // 0x20
    GamePlay.PlayerSkillChain <LastSkillChain>k__BackingField; // 0x28
    GamePlay.PlayerSkillChain[] m_SkChains; // 0x30
    System.Boolean <ShouldRebuildSkillChains>k__BackingField; // 0x38
    static System.Collections.Generic.List<SkillActivateFixedPointWrap> s_skConfForActorCached; // 0x0
    static System.Collections.Generic.List<GamePlay.PlayerSkill> s_skListCached; // 0x8
    static System.Collections.Generic.HashSet<System.Int32> s_occupiedOrdersCached; // 0x10
    GamePlay.PlayerSkillGroup m_MpLowTipGroup; // 0x3c
    System.Single MpLowTipDelayMax; // 0x40
    System.Single m_MpLowTipDelayRemain; // 0x44
    static GamePlay.PlayerSkillGroup[] s_AutoCreateGroups; // 0x18
    GamePlay.PlayerSkill get_LastSkill(); // 0x03d29740
    System.Void set_LastSkill(GamePlay.PlayerSkill value); // 0x03d29748
    GamePlay.PlayerSkillChain get_LastSkillChain(); // 0x03d29750
    System.Void set_LastSkillChain(GamePlay.PlayerSkillChain value); // 0x03d29758
    System.Boolean get_ShouldRebuildSkillChains(); // 0x03d29760
    System.Void set_ShouldRebuildSkillChains(System.Boolean value); // 0x03d29768
    System.Int32 get_Count(); // 0x03d29774
    GamePlay.PlayerSkillChain get_Item(GamePlay.PlayerSkillGroup skGroup); // 0x03d29790
    System.Void .ctor(GamePlay.PlayerObj pl); // 0x03d297d0
    System.Void InitSkills(); // 0x03d142f0
    System.Void InitOneCommonSkillChain(GamePlay.PlayerSkillGroup skGroup); // 0x03d29d4c
    System.Void InitTeacherSkillChain(System.Int32 actorId, System.Int32 skillId, GamePlay.PlayerSkillGroup skGroup, System.Single attrLv, System.Single teacherDamMul); // 0x03d2a544
    System.Void InitTeacherSkillChainFp(System.Int32 actorId, System.Int32 skillId, GamePlay.PlayerSkillGroup skGroup, Unity.Mathematics.FixedPoint.Fp attrLv, Unity.Mathematics.FixedPoint.Fp teacherDamMul); // 0x03d2a670
    System.Void InitSummonSkillChain(System.Boolean overrideIcon, System.Int32 srcTriggerId, System.String icon); // 0x03d2ada4
    System.Void Clear(); // 0x03d2ae40
    System.Void DoUpdate(Unity.Mathematics.FixedPoint.Fp dt); // 0x03d2af30
    System.Boolean SkillChangePreCall(GamePlay.PlayerSkill psk, GamePlay.PlayerSkillChain chain); // 0x03d275f4
    System.Void SkillStartImplement(GamePlay.PlayerSkill psk, Unity.Mathematics.FixedPoint.Fp2 lastInputDir, GamePlay.PlayerSkillChain chain); // 0x03d27f58
    System.Void onSkillChangedPostProc(GamePlay.PlayerSkill oldsk, GamePlay.PlayerSkill newsk, GamePlay.PlayerSkillChain chain); // 0x03d2b448
    System.Boolean checkSkillValid(SkillActivateFixedPointWrap skact); // 0x03d29940
    System.Void NotifyActionChanged(GamePlay.GameActionLogic actionOld, GamePlay.GameActionLogic actionCur); // 0x03d2bbcc
    System.Void NotifyBehit(GamePlay.ActorHitResult hitResult); // 0x03d2be54
    System.Void NotifySkillCDZero(GamePlay.PlayerSkillChain skChain); // 0x03d25fdc
    System.Void NotifySkillTimeOutReset(GamePlay.PlayerSkillChain sc, GamePlay.PlayerSkill psk); // 0x03d269c4
    System.Boolean ChangeSkillByActionName(System.String actionName, GamePlay.PlayerSkillGroup skGroupReq, GamePlay.ActionSwitchSkillCheck skcheck); // 0x03d2bfb4
    System.Boolean FindSkillAndChainByActionName(System.String actionName, GamePlay.PlayerSkillChain& skChain, GamePlay.PlayerSkill& skill); // 0x03d2c150
    GamePlay.PlayerSkill FindSkillByActionName(System.String actionName); // 0x03d2c2cc
    System.Void MarkSkillChainNeedRebuild(); // 0x03d2c468
    GamePlay.PlayerSkill FindSkillBySkillAttr(System.Int32 actorId, System.Int32 order); // 0x03d2c4e8
    GamePlay.PlayerSkill FindSkillBySkillId(System.Int32 skillId); // 0x03d2c6b4
    System.Void SetChainCD(System.Int32 chain, Unity.Mathematics.FixedPoint.Fp cd, Unity.Mathematics.FixedPoint.Fp cdmax); // 0x03d2c820
    System.Void SetMute(System.Int32 chain, Unity.Mathematics.FixedPoint.Fp mute); // 0x03d2c8ec
    System.Void ResetChain(System.Int32 chain, Unity.Mathematics.FixedPoint.Fp cd); // 0x03d2c9a4
    System.Void mpTipUpdate(System.Single dt); // 0x03d2b178
    System.Void MpLowTip(GamePlay.PlayerSkillGroup skGroup); // 0x03d27ba0
    System.Void ForceChangeLastSkill(GamePlay.PlayerSkillChain skc, GamePlay.PlayerSkill lastSk); // 0x03d2ca68
    System.Void DebugDump(System.Text.StringBuilder sb); // 0x03d2cb70
    static System.Void .cctor(); // 0x03d2cbec
}

// Assembly-CSharp
class GamePlay.PlayerSkillChain : System.Object
{
    GamePlay.PlayerSkillMgr Owner; // 0x10
    System.Collections.Generic.List<GamePlay.PlayerSkill> SkillList; // 0x18
    GamePlay.PlayerSkillChain.ChainStatus <Status>k__BackingField; // 0x20
    System.Int32 SkillType; // 0x24
    GamePlay.PlayerSkillChainCurSkill Cur; // 0x28
    GamePlay.PlayerSkillChainCurSkill LastSkill; // 0x30
    GamePlay.PlayerSkill <NextSkillPredict>k__BackingField; // 0x38
    Unity.Mathematics.FixedPoint.Fp <CoolDownRemain>k__BackingField; // 0x40
    Unity.Mathematics.FixedPoint.Fp <CoolDownTotal>k__BackingField; // 0x48
    System.Int32 <MuteBy>k__BackingField; // 0x50
    Unity.Mathematics.FixedPoint.Fp <MuteRemain>k__BackingField; // 0x54
    Unity.Mathematics.FixedPoint.Fp <LastMuteMax>k__BackingField; // 0x5c
    System.Int32 <CastTimes>k__BackingField; // 0x64
    GamePlay.InputCmd m_Input; // 0x68
    GamePlay.PlayerSkillChain.ChainStatus get_Status(); // 0x03d25c44
    System.Void set_Status(GamePlay.PlayerSkillChain.ChainStatus value); // 0x03d25c4c
    GamePlay.PlayerSkill get_NextSkillPredict(); // 0x03d25c54
    System.Void set_NextSkillPredict(GamePlay.PlayerSkill value); // 0x03d25c5c
    Unity.Mathematics.FixedPoint.Fp get_CoolDownRemain(); // 0x03d25c64
    System.Void set_CoolDownRemain(Unity.Mathematics.FixedPoint.Fp value); // 0x03d25c6c
    Unity.Mathematics.FixedPoint.Fp get_CoolDownTotal(); // 0x03d25c74
    System.Void set_CoolDownTotal(Unity.Mathematics.FixedPoint.Fp value); // 0x03d25c7c
    System.Int32 get_MuteBy(); // 0x03d25c84
    System.Void set_MuteBy(System.Int32 value); // 0x03d25c8c
    Unity.Mathematics.FixedPoint.Fp get_MuteRemain(); // 0x03d25c94
    System.Void set_MuteRemain(Unity.Mathematics.FixedPoint.Fp value); // 0x03d25c9c
    Unity.Mathematics.FixedPoint.Fp get_LastMuteMax(); // 0x03d25ca4
    System.Void set_LastMuteMax(Unity.Mathematics.FixedPoint.Fp value); // 0x03d25cac
    System.Int32 get_CastTimes(); // 0x03d25cb4
    System.Void set_CastTimes(System.Int32 value); // 0x03d25cbc
    GamePlay.PlayerSkill get_FirstSkill(); // 0x03d25cc4
    System.Int32 get_Count(); // 0x03d25d3c
    GamePlay.PlayerSkill get_Item(System.Int32 index); // 0x03d25d88
    GamePlay.InputCmd get_Input(); // 0x03d25e24
    System.Void SetCoolDown(Unity.Mathematics.FixedPoint.Fp f, System.Boolean autoProcStateChange); // 0x03d25e2c
    System.Void ChangeCoolDownBy(Unity.Mathematics.FixedPoint.Fp f); // 0x03d26068
    System.Void SetStatus(GamePlay.PlayerSkillChain.ChainStatus st); // 0x03d25f50
    System.Void Init(GamePlay.PlayerSkillMgr owner, System.Collections.Generic.List<GamePlay.PlayerSkill> skList, GamePlay.PlayerSkillGroup skGroup); // 0x03d26138
    System.Void autoGetInputType(); // 0x03d26488
    System.Void DoUpdate(Unity.Mathematics.FixedPoint.Fp dt); // 0x03d266c4
    System.Boolean DoUpdateAndCheckInputSucc(Unity.Mathematics.FixedPoint.Fp dt); // 0x03d26aa8
    System.Boolean checkInputSucc_StandardBtns(GamePlay.InputCmdState inputSt); // 0x03d26bec
    System.Void CheckTipMpNotEnough(); // 0x03d27900
    System.Void Reset(); // 0x03d27c34
    System.Void ClearCurSkill(); // 0x03d26928
    System.Boolean StartSkill(GamePlay.PlayerSkill skNew, GamePlay.ActionSwitchSkillCheck skcheck); // 0x03d27d30
    System.Boolean startSkill(GamePlay.PlayerSkill skNew, Unity.Mathematics.FixedPoint.Fp2 inputDir); // 0x03d27764
    System.Void SetMute(System.Int32 muteBy, Unity.Mathematics.FixedPoint.Fp muteTime); // 0x03d282a0
    System.Void ClearMute(); // 0x03d2833c
    GamePlay.PlayerSkill predictNextSkill(); // 0x03d2661c
    GamePlay.PlayerSkill FindAStartingSkillForPredict(); // 0x03d285e8
    GamePlay.PlayerSkill FindByPreSkillOrder(System.Int32 order); // 0x03d283f0
    static System.Int32 indexOfNoGC(System.Collections.Generic.IList<System.Int32> src, System.Int32 find); // 0x03d287b4
    GamePlay.PlayerSkill FindByActionName(System.String actionName); // 0x03d288f4
    GamePlay.PlayerSkill findNextSkillMatchPreOrderAndInputDir(); // 0x03d27088
    GamePlay.PlayerSkill findStartingSkillMatchInputDir(); // 0x03d273c4
    GamePlay.PlayerSkill PredictNextSkillByInputDir(UnityEngine.Vector2 inputDir, System.Int32 reqTriggerId, System.Boolean ignoreOrder); // 0x03d28a18
    GamePlay.PlayerSkill FindAStartingSkillForPredictByInputDir(GamePlay.InputCmd inp, UnityEngine.Vector2 inputDir, System.Int32 reqTriggerId); // 0x03d28eb0
    GamePlay.PlayerSkill FindByPreSkillOrderByInputDir(GamePlay.InputCmd inp, System.Int32 order, UnityEngine.Vector2 inputDir, System.Int32 reqTriggerId); // 0x03d28b28
    System.String ToString(); // 0x03d291e0
    System.Void DebugDump(System.Text.StringBuilder sb); // 0x03d295e0
    System.Void .ctor(); // 0x03d2965c
}
// Assembly-CSharp
class GamePlay.PlayerSkill : System.Object
{
    GamePlay.PlayerSkillChain Owner; // 0x10
    System.Int32 SkillId; // 0x18
    System.Int32 ActorId; // 0x1c
    SkillActivateFixedPointWrap SkillActivate; // 0x20
    System.Int32 AttrOrder; // 0x28
    Unity.Mathematics.FixedPoint.Fp Level; // 0x2c
    SkillAttrFixedPointWrap Attr; // 0x38
    System.Int32 SourceTriggerId; // 0x40
    GamePlay.InputCmd Input; // 0x44
    Unity.Mathematics.FixedPoint.Fp[] m_muteSkills; // 0x48
    System.Collections.Generic.List<GamePlay.PlayerSkillMpSlotCache> MpLimitCaches; // 0x50
    GamePlay.PlayerSkillGroup get_SkillType(); // 0x03d24678
    System.Boolean get_IsStartingSkill(); // 0x03d24694
    System.Int32 get_MuteCount(); // 0x03d24750
    Unity.Mathematics.FixedPoint.Fp GetMuteTime(System.Int32 i); // 0x03d2476c
    System.Boolean get_MpLimitValid(); // 0x03d2485c
    Unity.Mathematics.FixedPoint.Fp get_MpLimitCached(); // 0x03d248ac
    System.Void .ctor(); // 0x03d2495c
    System.Void .ctor(SkillActivateFixedPointWrap skActivate, System.Int32 attrOrder, Unity.Mathematics.FixedPoint.Fp lv, Unity.Mathematics.FixedPoint.Fp teacherDamMul); // 0x03d24a14
    System.String ToString(); // 0x03d25014
    System.Void RefreshAttr(Unity.Mathematics.FixedPoint.Fp teacherDamMul); // 0x03d24ed8
    Unity.Mathematics.FixedPoint.Fp AttrValue(System.Int32 index); // 0x03d25130
    Unity.Mathematics.FixedPoint.Fp AttrTeacherDamageMul(); // 0x03d25258
    Unity.Mathematics.FixedPoint.Fp AttrDamage(); // 0x03d25314
    System.Boolean IsCostSp(); // 0x03d253d0
    System.String GetJson(); // 0x03d2557c
}