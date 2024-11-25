
// Assembly-CSharp
class GamePlay.ActorBase : System.Object
{
    System.String m_actionGroupID; // 0x10
    System.Action<GamePlay.ActorHitResult> OnInteract; // 0x18
    GamePlay.ActorSettings m_actorSettings; // 0x20
    VisualObject SmoothObject; // 0x28
    GamePlay.ActorModel ActorModel; // 0x30
    GamePlay.ActorActivity ActiveState; // 0x38
    GamePlay.IInput Input; // 0x40
    GamePlay.ActorBehitBoxMgr BehitBoxMgr; // 0x48
    GamePlay.ActorActionColliderMgr ColliderBoxMgr; // 0x50
    GamePlay.ActorPosition ActorPosition; // 0x58
    GamePlay.ActorDir ActorDir; // 0x60
    GamePlay.ActorMotionMgr MotionMgr; // 0x68
    GamePlay.ActorAttrMgr Attr; // 0x70
    GamePlay.ActionMgr <ActionMgr>k__BackingField; // 0x78
    GamePlay.ActorAttackBoxManager AttackBoxMgr; // 0x80
    GamePlay.BuffMgr <BuffMgr>k__BackingField; // 0x88
    GamePlay.ActorScriptMgr ScriptMgr; // 0x90
    GamePlay.ActorTiming ActorTimingCtrl; // 0x98
    GamePlay.ActorDelayActions ActorDelayActions; // 0xa0
    GamePlay.ActorTargetMgr TargetMgr; // 0xa8
    GamePlay.ActorBlackList <ActorBlackList>k__BackingField; // 0xb0
    GamePlay.ActorCountDown ActionCountDown; // 0xb8
    GamePlay.ActorBehitHistory ActorBehitHistory; // 0xc0
    GamePlay.ActionFpValueHolder <FpValueHolder>k__BackingField; // 0xc8
    GamePlay.PlayerReplaceMgr <ReplaceMgr>k__BackingField; // 0xd0
    GamePlay.ActorBattleModuleManager BattleModuleManager; // 0xd8
    GamePlay.ActorTagMgr TagMgr; // 0xe0
    GamePlay.ActorLog Logger; // 0xe8
    System.Int32 <Faction>k__BackingField; // 0xf0
    GamePlay.ParamSet <ExtParams>k__BackingField; // 0xf8
    Unity.Mathematics.FixedPoint.Fp2 <SceneCollideSize>k__BackingField; // 0x100
    Unity.Mathematics.FixedPoint.Fp2 <DefaultBehitBoxSize>k__BackingField; // 0x110
    System.Boolean LimitAudioEvent; // 0x120
    System.String PlayerID; // 0x128
    System.UInt64 PlayerIDForFS64; // 0x130
    System.Boolean <WaitActor>k__BackingField; // 0x138
    System.Int32 GrassID; // 0x13c
    System.Boolean <IsVisibleGrass>k__BackingField; // 0x140
    System.Boolean <IsVisibleHide>k__BackingField; // 0x141
    System.Single LogicAlpha; // 0x144
    System.Single GrassAlpha; // 0x148
    System.Boolean <NetActor>k__BackingField; // 0x14c
    System.Boolean <PVPActor>k__BackingField; // 0x14d
    System.Boolean <PVPExit>k__BackingField; // 0x14e
    System.Int32 <PVPTreasureBox>k__BackingField; // 0x150
    System.Boolean <PreMove>k__BackingField; // 0x154
    System.Boolean <PreDir>k__BackingField; // 0x155
    System.Boolean <PreRunAnim>k__BackingField; // 0x156
    System.Boolean <IsPickState>k__BackingField; // 0x157
    System.Int32 <PickType>k__BackingField; // 0x158
    System.Boolean <IsPickSend>k__BackingField; // 0x15c
    System.Int32 <UseItemID>k__BackingField; // 0x160
    GamePlay.PlayerObj <pickObj>k__BackingField; // 0x168
    Unity.Mathematics.FixedPoint.Fp <pickCurTime>k__BackingField; // 0x170
    Unity.Mathematics.FixedPoint.Fp <pickTotalTime>k__BackingField; // 0x178
    System.Boolean <showPickProgress>k__BackingField; // 0x180
    Unity.Mathematics.FixedPoint.Fp <bePickTime>k__BackingField; // 0x181
    System.Int32 <bePickId>k__BackingField; // 0x18c
    System.Int32 <bePickCount>k__BackingField; // 0x190
    System.Int32 <bePickParentUid>k__BackingField; // 0x194
    System.Int32 <bePickContentId>k__BackingField; // 0x198
    System.Single <ReviveInteractRate>k__BackingField; // 0x19c
    Unity.Mathematics.FixedPoint.Fp <ReviveHpPer>k__BackingField; // 0x1a0
    System.Int32 <SelfReviveCount>k__BackingField; // 0x1a8
    System.Single <OpenInteractRate>k__BackingField; // 0x1ac
    System.Collections.Generic.List<DropBoxInfo> DropAccumulated; // 0x1b0
    System.Boolean <nearDeath>k__BackingField; // 0x1b8
    Unity.Mathematics.FixedPoint.Fp <nearDeathTime>k__BackingField; // 0x1b9
    GamePlay.InteractableObj interactDeadObj; // 0x1c8
    System.Boolean <realDead>k__BackingField; // 0x1d0
    System.Int32 <netIndex>k__BackingField; // 0x1d4
    System.Int32 <netState>k__BackingField; // 0x1d8
    System.Int32 UniqueId; // 0x1dc
    Unity.Mathematics.FixedPoint.Fp <Time>k__BackingField; // 0x1e0
    UnityEngine.GameObject m_gameObjectForServer; // 0x1e8
    GamePlay.ActorBase m_Caster; // 0x1f0
    GamePlay.ActorBase m_rootCaster; // 0x1f8
    Unity.Mathematics.FixedPoint.Fp m_currentScale; // 0x200
    Unity.Mathematics.FixedPoint.Fp2 m_logicPosition; // 0x208
    System.Boolean m_LogicActiveState; // 0x218
    System.Boolean m_RenderActiveState; // 0x219
    System.Boolean m_RenderActiveStateLocked; // 0x21a
    System.Boolean m_AudioActiveState; // 0x21b
    Unity.Mathematics.FixedPoint.Fp m_RendererRotation; // 0x21c
    System.Boolean <CinemaControl>k__BackingField; // 0x224
    System.String get_ActionGroupID(); // 0x03c99e7c
    System.Void set_ActionGroupID(System.String value); // 0x03c99ec0
    System.String get_ActionScriptName(); // 0x03c99ec8
    GamePlay.ActorSettings get_ActorSettings(); // 0x03c99f0c
    GamePlay.ActionMgr get_ActionMgr(); // 0x03c99f14
    System.Void set_ActionMgr(GamePlay.ActionMgr value); // 0x03c99f1c
    GamePlay.BuffMgr get_BuffMgr(); // 0x03c99f24
    System.Void set_BuffMgr(GamePlay.BuffMgr value); // 0x03c99f2c
    GamePlay.ActorBlackList get_ActorBlackList(); // 0x03c99f34
    System.Void set_ActorBlackList(GamePlay.ActorBlackList value); // 0x03c99f3c
    GamePlay.ActionFpValueHolder get_FpValueHolder(); // 0x03c99f44
    System.Void set_FpValueHolder(GamePlay.ActionFpValueHolder value); // 0x03c99f4c
    GamePlay.PlayerReplaceMgr get_ReplaceMgr(); // 0x03c99f54
    System.Void set_ReplaceMgr(GamePlay.PlayerReplaceMgr value); // 0x03c99f5c
    GamePlay.ActorEffectMgr get_EffectMgr(); // 0x03c8f6c4
    static System.Boolean op_Implicit(GamePlay.ActorBase obj); // 0x03c8ec64
    System.String get_ActorName(); // 0x03c99f64
    System.Int32 get_Faction(); // 0x03c99fb8
    System.Void set_Faction(System.Int32 value); // 0x03c99fc0
    GamePlay.ParamSet get_ExtParams(); // 0x03c99fc8
    System.Void set_ExtParams(GamePlay.ParamSet value); // 0x03c99fd0
    Unity.Mathematics.FixedPoint.Fp2 get_SceneCollideSize(); // 0x03c99fd8
    System.Void set_SceneCollideSize(Unity.Mathematics.FixedPoint.Fp2 value); // 0x03c99fe4
    Unity.Mathematics.FixedPoint.Fp2 get_DefaultBehitBoxSize(); // 0x03c99fec
    System.Void set_DefaultBehitBoxSize(Unity.Mathematics.FixedPoint.Fp2 value); // 0x03c99ff8
    GamePlay.RectFp get_GlobalSceneColliderRect(); // 0x03c9a000
    System.Boolean get_WaitActor(); // 0x03c9a0a8
    System.Void set_WaitActor(System.Boolean value); // 0x03c9a0b0
    System.Boolean get_IsVisibleGrass(); // 0x03c9a0bc
    System.Void set_IsVisibleGrass(System.Boolean value); // 0x03c9a0c4
    System.Boolean get_IsVisibleHide(); // 0x03c9a0d0
    System.Void set_IsVisibleHide(System.Boolean value); // 0x03c9a0d8
    System.Boolean get_NetActor(); // 0x03c9a0e4
    System.Void set_NetActor(System.Boolean value); // 0x03c9a0ec
    System.Boolean get_PVPActor(); // 0x03c9a0f8
    System.Void set_PVPActor(System.Boolean value); // 0x03c9a100
    System.Boolean get_PVPExit(); // 0x03c9a10c
    System.Void set_PVPExit(System.Boolean value); // 0x03c9a114
    System.Int32 get_PVPTreasureBox(); // 0x03c9a120
    System.Void set_PVPTreasureBox(System.Int32 value); // 0x03c9a128
    System.Boolean get_PreMove(); // 0x03c9a130
    System.Void set_PreMove(System.Boolean value); // 0x03c9a138
    System.Boolean get_PreDir(); // 0x03c9a144
    System.Void set_PreDir(System.Boolean value); // 0x03c9a14c
    System.Boolean get_PreRunAnim(); // 0x03c9a158
    System.Void set_PreRunAnim(System.Boolean value); // 0x03c9a160
    System.Boolean get_IsPickState(); // 0x03c9a16c
    System.Void set_IsPickState(System.Boolean value); // 0x03c9a174
    System.Int32 get_PickType(); // 0x03c9a180
    System.Void set_PickType(System.Int32 value); // 0x03c9a188
    System.Boolean get_IsPickSend(); // 0x03c9a190
    System.Void set_IsPickSend(System.Boolean value); // 0x03c9a198
    System.Int32 get_UseItemID(); // 0x03c9a1a4
    System.Void set_UseItemID(System.Int32 value); // 0x03c9a1ac
    GamePlay.PlayerObj get_pickObj(); // 0x03c9a1b4
    System.Void set_pickObj(GamePlay.PlayerObj value); // 0x03c9a1bc
    Unity.Mathematics.FixedPoint.Fp get_pickCurTime(); // 0x03c9a1cc
    System.Void set_pickCurTime(Unity.Mathematics.FixedPoint.Fp value); // 0x03c9a1d4
    Unity.Mathematics.FixedPoint.Fp get_pickTotalTime(); // 0x03c9a1dc
    System.Void set_pickTotalTime(Unity.Mathematics.FixedPoint.Fp value); // 0x03c9a1e4
    System.Boolean get_showPickProgress(); // 0x03c9a1ec
    System.Void set_showPickProgress(System.Boolean value); // 0x03c9a1f4
    Unity.Mathematics.FixedPoint.Fp get_bePickTime(); // 0x03c9a200
    System.Void set_bePickTime(Unity.Mathematics.FixedPoint.Fp value); // 0x03c9a20c
    System.Int32 get_bePickId(); // 0x03c9a218
    System.Void set_bePickId(System.Int32 value); // 0x03c9a220
    System.Int32 get_bePickCount(); // 0x03c9a228
    System.Void set_bePickCount(System.Int32 value); // 0x03c9a230
    System.Int32 get_bePickParentUid(); // 0x03c9a238
    System.Void set_bePickParentUid(System.Int32 value); // 0x03c9a240
    System.Int32 get_bePickContentId(); // 0x03c9a248
    System.Void set_bePickContentId(System.Int32 value); // 0x03c9a250
    System.Single get_ReviveInteractRate(); // 0x03c9a258
    System.Void set_ReviveInteractRate(System.Single value); // 0x03c9a260
    Unity.Mathematics.FixedPoint.Fp get_ReviveHpPer(); // 0x03c9a268
    System.Void set_ReviveHpPer(Unity.Mathematics.FixedPoint.Fp value); // 0x03c9a270
    System.Int32 get_SelfReviveCount(); // 0x03c9a278
    System.Void set_SelfReviveCount(System.Int32 value); // 0x03c9a280
    System.Single get_OpenInteractRate(); // 0x03c9a288
    System.Void set_OpenInteractRate(System.Single value); // 0x03c9a290
    System.Boolean get_nearDeath(); // 0x03c9a298
    System.Void set_nearDeath(System.Boolean value); // 0x03c9a2a0
    Unity.Mathematics.FixedPoint.Fp get_nearDeathTime(); // 0x03c9a2ac
    System.Void set_nearDeathTime(Unity.Mathematics.FixedPoint.Fp value); // 0x03c9a2b8
    System.Boolean get_realDead(); // 0x03c9a2c4
    System.Void set_realDead(System.Boolean value); // 0x03c9a2cc
    System.Int32 get_netIndex(); // 0x03c9a2d8
    System.Void set_netIndex(System.Int32 value); // 0x03c9a2e0
    System.Int32 get_netState(); // 0x03c9a2e8
    System.Void set_netState(System.Int32 value); // 0x03c9a2f0
    System.Int32 get_BaseID(); // 0x03c98148
    Unity.Mathematics.FixedPoint.Fp2 get_BornPosition(); // 0x03c9a2f8
    Unity.Mathematics.FixedPoint.Fp get_Time(); // 0x03c9a324
    System.Void set_Time(Unity.Mathematics.FixedPoint.Fp value); // 0x03c9a32c
    GamePlay.ActorBase get_Caster(); // 0x03c9a334
    System.Void set_Caster(GamePlay.ActorBase value); // 0x03c9a33c
    GamePlay.ActorBase get_RootCaster(); // 0x03c9a37c
    System.Void set_RootCaster(GamePlay.ActorBase value); // 0x03c9a38c
    System.String ToString(); // 0x03c9a39c
    System.Single get_Dir(); // 0x03c9a424
    System.Void set_Dir(System.Single value); // 0x03c9a48c
    Unity.Mathematics.FixedPoint.Fp get_DirFp(); // 0x03c9365c
    System.Void set_DirFp(Unity.Mathematics.FixedPoint.Fp value); // 0x03c9a4fc
    Unity.Mathematics.FixedPoint.Fp2 get_PositionFp(); // 0x03c9a784
    System.Void set_PositionFp(Unity.Mathematics.FixedPoint.Fp2 value); // 0x03c9a794
    UnityEngine.Vector2 get_Position(); // 0x03c9a898
    System.Void set_Position(UnityEngine.Vector2 value); // 0x03c9a8fc
    Unity.Mathematics.FixedPoint.Fp get_Scale(); // 0x03c9a980
    System.Void set_Scale(Unity.Mathematics.FixedPoint.Fp value); // 0x03c9a988
    System.Boolean get_LogicActiveState(); // 0x03c9aa80
    System.Boolean get_RenderActiveState(); // 0x03c9aa88
    System.Boolean get_RenderActiveStateLocked(); // 0x03c9aa90
    System.Boolean get_AudioActiveState(); // 0x03c9aa98
    Unity.Mathematics.FixedPoint.Fp get_RendererRotation(); // 0x03c9aaa0
    System.Boolean get_CinemaControl(); // 0x03c9aaac
    System.Void set_CinemaControl(System.Boolean value); // 0x03c9aab4
    UnityEngine.GameObject get_gameObject(); // 0x03c911dc
    ActorVisualBase get_Renderer(); // 0x03c9aac0
    NOAH.Criware.CriwareAudioAssist get_AudioAssist(); // 0x03c9ab3c
    CriWare.CriAtomExPlayback PlayAudio(System.String audioCue); // 0x03c9abc8
    CriWare.CriAtomExPlayback TsPlayAudio(System.Int32 cueId); // 0x03c9ad34
    System.Void InitPubComponents(); // 0x03c9ae4c
    System.Void initScript(); // 0x03c9b804
    System.Void AutoSetCollisionLayerMaskByActorResistance(); // 0x03c999c4
    System.Void UpdateAll(GamePlay.DeltaTimeAndScale dt); // 0x03c9b8e0
    System.Void UpdateLogic(GamePlay.DeltaTimeAndScale dt); // 0x03c9b9d4
    System.Void UpdateVisual(GamePlay.DeltaTimeAndScale delta); // 0x03c9bbf8
    System.Void SyncTransform(); // 0x03c9bca8
    System.Void DeactivateOnDeadEnd(); // 0x03c9becc
    System.Void DeactivateOnDeadEndOnForce(); // 0x03c9bf70
    System.Void ReleaseOnRecycle(); // 0x03c9c014
    System.Void ReleaseFinal(); // 0x03c9c570
    System.Boolean IsAirMove(); // 0x03c9c620
    System.Boolean IsLockableTargetBy(GamePlay.ActorBase srcActor); // 0x03c9c6d0
    System.Void ChangeFaction(System.Int32 fac); // 0x03c9c8b0
    Unity.Mathematics.FixedPoint.Fp DealDamage(GamePlay.ActorHpLoss hpLoss); // 0x03c9c93c
    Unity.Mathematics.FixedPoint.Fp DealDamageSimple(GamePlay.ActorBase Attacker, Unity.Mathematics.FixedPoint.Fp HPDelta, EAttrElementType Element); // 0x03c9c9e8
    System.Void ChangeSceneColliderSize(Unity.Mathematics.FixedPoint.Fp2 size); // 0x03c9cc38
    System.Void NotifyBeHit(GamePlay.ActorHitResult hitResult); // 0x03c9cccc
    System.Void NotifyInteract(GamePlay.ActorHitResult hitResult); // 0x03c9ccd0
    System.Void NotifyHitOther(GamePlay.ActorHitResult hitResult, System.Int32 callDepth); // 0x03c9cd7c
    System.Void NotifyCasterDie(GamePlay.ActorBase caster); // 0x03c9cd80
    System.Void OnActionChangeEmpty(GamePlay.GameActionLogic actionLogic); // 0x03c9ce40
    System.Void OnActionChangeToDestroy(); // 0x03c9cfa4
    System.Void OnActionExit(GamePlay.GameActionLogic actionOld); // 0x03c9d064
    System.Void OnActionChanged(GamePlay.GameActionLogic actionOld, GamePlay.GameActionLogic actionCur); // 0x03c9d1c0
    System.Void OnNewActionStartUpdate(GamePlay.GameActionLogic actionLast, GamePlay.GameActionLogic actionCur); // 0x03c9d3dc
    System.Void OnDirChanged(Unity.Mathematics.FixedPoint.Fp oldDir, Unity.Mathematics.FixedPoint.Fp newDir); // 0x03c9d5b0
    System.Void refreshVisualTransformScale(); // 0x03c9b5fc
    System.Void FixPreDir(); // 0x03c9a6f0
    System.Void FixPreAnim(); // 0x03c9d78c
    System.Void setVisualTransformScale(System.Single dir); // 0x03c9d644
    Unity.Mathematics.FixedPoint.Fp GetArmorType(); // 0x03c9d810
    System.Boolean IsAttackable(); // 0x03c9d8b4
    System.Int32 GetInvincipalLevel(); // 0x03c9d92c
    System.Void OnHPZero(System.Boolean triggerDieLogic, System.Boolean triggerDieScript, GamePlay.ActorBase killer); // 0x03c9d9a4
    Unity.Mathematics.FixedPoint.Fp2 TransformPointToGlobal(Unity.Mathematics.FixedPoint.Fp2 localPos, GamePlay.ActorGetDirectionType dirType); // 0x03c9d9a8
    Unity.Mathematics.FixedPoint.Fp2 TransformPointToLocal(Unity.Mathematics.FixedPoint.Fp2 globalPos); // 0x03c9da84
    Unity.Mathematics.FixedPoint.Fp2 TransformDirToGlobal(Unity.Mathematics.FixedPoint.Fp2 localDir, GamePlay.ActorGetDirectionType dirType); // 0x03c9dc24
    Unity.Mathematics.FixedPoint.Fp2 TransformDirToLocal(Unity.Mathematics.FixedPoint.Fp2 localDir, GamePlay.ActorGetDirectionType dirType); // 0x03c9dc40
    Unity.Mathematics.FixedPoint.Fp2 GetGlobalPosByBindPosType(GamePlay.ActorBindPos bindPos); // 0x03c9dcfc
    System.Void SetRendererRotation(Unity.Mathematics.FixedPoint.Fp rot); // 0x03c9e344
    System.Void OnBuffUpdate(GamePlay.Buff bf); // 0x03c9e490
    System.Void OnBuffRemove(System.String idx); // 0x03c9e52c
    System.Void BuffChangedPostRefresh(); // 0x03c9e5a8
    System.Void NotifyHitWallOrGround(RaycastHit2DWarp rc, Unity.Mathematics.FixedPoint.Fp2 physicalVelocity); // 0x03c9e5ac
    System.Boolean OnBattleDamageBeHitCalcStage(GamePlay.ActorHitResult hitRes, GamePlay.PlayerHitResultCalcStage calcStage); // 0x03c9e5b0
    System.Void OnBattleDamageHitCalcStage(GamePlay.ActorHitResult hitRes, GamePlay.PlayerHitResultCalcStage calcStage); // 0x03c9e628
    System.Void updateTiming(GamePlay.DeltaTimeAndScale dt); // 0x03c9e62c
    System.Void SetLogicActive(System.Boolean active); // 0x03c9e7c0
    System.Void SetRenderActiveLock(System.Boolean locked); // 0x03c9e818
    System.Boolean SetRenderActive(System.Boolean active); // 0x03c9e8ac
    System.Boolean SetAudioActive(System.Boolean active); // 0x03c9e9b8
    System.Void SetVisibleGrass(System.Boolean visible); // 0x03c9e9d8
    System.Void SetVisibleHide(System.Boolean visible); // 0x03c9e9dc
    System.Void SetLogicAlpha(System.Single val); // 0x03c9e9e0
    System.Void SetGrassAlpha(System.Single val); // 0x03c9ea8c
    System.Single GetReviveInteractTime(Unity.Mathematics.FixedPoint.Fp time); // 0x03c9eaa4
    System.Single GetOpenInteractTime(System.Single time); // 0x03c9eb1c
    System.Void SetPostionVector3(UnityEngine.Vector3 pos); // 0x03c9eb30
    System.Void SetNearDeath(System.Boolean val); // 0x03c96740
    System.Void UpdateNearDeath(Unity.Mathematics.FixedPoint.Fp dt); // 0x03c9ec94
    System.Void OnMpChanged(Unity.Mathematics.FixedPoint.Fp fp, System.Int32 order); // 0x03c9ef28
    System.Void BindGameObjectForServer(UnityEngine.GameObject go); // 0x03c9ef2c
    System.Void DoDrawGizmos(); // 0x03c9efa8
    System.Void DebugDump(System.Text.StringBuilder sb); // 0x03c9f024
    System.Boolean EffectBaseReplace(System.String& effName); // 0x03c9f028
    System.Void EffectSkinReplace(System.String& effName); // 0x03c9f110
    System.Void .ctor(); // 0x03c9f1d4
}


// Assembly-CSharp
class GamePlay.BulletObj : GamePlay.ActorBase
{
    BulletConfigFixedPointWrap BulletConf; // 0x228
    GamePlay.SkillStartSrcState Ssss; // 0x230
    GamePlay.ActorHitResult LastHitResultInCurAction; // 0x258
    Unity.Mathematics.FixedPoint.Fp DamageScale; // 0x260
    System.Boolean CanBeHit; // 0x268
    System.Boolean m_AlreadyNotifiedPlayerDie; // 0x269
    System.Int32 GetInvincipalLevel(); // 0x03ce007c
    System.Boolean IsAttackable(); // 0x03ce0130
    System.Void Init(GamePlay.ActionLogicGroup actionLogicGroup, GamePlay.ActorSettings actorSettings, BulletConfigFixedPointWrap bulletConf); // 0x03ce01c4
    System.Void StartBullet(GamePlay.ActorBase caster, SkillActivateFixedPointWrap skill, System.String action, Unity.Mathematics.FixedPoint.Fp2 startDir); // 0x03ce0b3c
    System.Void UpdateLogic(GamePlay.DeltaTimeAndScale dt); // 0x03ce1330
    System.Void UpdateVisual(GamePlay.DeltaTimeAndScale dt); // 0x03ce18e8
    System.Void ChangeDir2(Unity.Mathematics.FixedPoint.Fp2 dirInput); // 0x03ce11f0
    Unity.Mathematics.FixedPoint.Fp2 GetDir2(); // 0x03ce1a44
    System.Void OnActionChanged(GamePlay.GameActionLogic actionOld, GamePlay.GameActionLogic actionCur); // 0x03ce1acc
    System.Void OnActionChangeEmpty(GamePlay.GameActionLogic actionLogic); // 0x03ce1c80
    System.Void OnActionChangeToDestroy(); // 0x03ce1ddc
    System.Void OnActionExit(GamePlay.GameActionLogic actionOld); // 0x03ce1e6c
    Unity.Mathematics.FixedPoint.Fp DealDamage(GamePlay.ActorHpLoss hpLoss); // 0x03ce20d4
    System.Void NotifyHitOther(GamePlay.ActorHitResult hitResult, System.Int32 callDepth); // 0x03ce2250
    System.Void NotifyBeHit(GamePlay.ActorHitResult hitResult); // 0x03ce24b0
    System.Boolean OnBattleDamageBeHitCalcStage(GamePlay.ActorHitResult hitRes, GamePlay.PlayerHitResultCalcStage calcStage); // 0x03ce257c
    System.Void OnBattleDamageHitCalcStage(GamePlay.ActorHitResult hitRes, GamePlay.PlayerHitResultCalcStage calcStage); // 0x03ce265c
    System.Void OnHPZero(System.Boolean triggerDieLogic, System.Boolean triggerDieScript, GamePlay.ActorBase killer); // 0x03ce2718
    System.Void ReleaseOnRecycle(); // 0x03ce28a4
    System.Void DebugDump(System.Text.StringBuilder sb); // 0x03ce2954
    System.Void .ctor(); // 0x03ce29d0
}

// Assembly-CSharp
class GamePlay.PlayerObj : GamePlay.ActorBase
{
    GamePlay.PlayerAIBase <AI>k__BackingField; // 0x228
    GamePlay.PlayerTriggerMgr <TriggerMgr>k__BackingField; // 0x230
    GamePlay.PlayerSkillMgr <SkillMgr>k__BackingField; // 0x238
    GamePlay.BattlePlayerStatistics <Statistics>k__BackingField; // 0x240
    System.Int32 GroupID; // 0x248
    System.Int32 <AttrType>k__BackingField; // 0x24c
    GamePlay.ActorDieEffectAndPrior DieEffectDefault; // 0x250
    GamePlay.ActorDieEffectAndPrior DieEffectBeHit; // 0x260
    GamePlay.PlayerUIInfoBoardSettings InfoBoardSettings; // 0x270
    GamePlay.PlayerUIInfoBoard <UIInfoBoard>k__BackingField; // 0x278
    Unity.Mathematics.FixedPoint.Fp <LastFallGroundDamageRate>k__BackingField; // 0x280
    GamePlay.ActorHitResult LastBehitResult; // 0x288
    Unity.Mathematics.FixedPoint.Fp LastBehitTimeStamp; // 0x290
    GamePlay.ActorHitResult LastHitResultInCurAction; // 0x298
    Unity.Mathematics.FixedPoint.Fp LastHitResultInCurActionTimeStamp; // 0x2a0
    GamePlay.ActorHpLoss LastHpLoss; // 0x2a8
    GamePlay.PlayerCombo Combo; // 0x2c0
    GamePlay.PlayerComboKill ComboKill; // 0x2c8
    GamePlay.PlayerObjType m_playerObjType; // 0x2d0
    System.Boolean m_AlreadyNotifiedPlayerDie; // 0x2d4
    System.Boolean m_FinishedBornAction; // 0x2d5
    System.Boolean m_PassiveHitWallAlready; // 0x2d6
    System.Boolean m_PassiveHitGroundAlready; // 0x2d7
    System.String m_DefaultAIName; // 0x2d8
    System.String m_AISurfixByBuff; // 0x2e0
    GamePlay.PlayerArmorFX ArmorFx; // 0x2e8
    GamePlay.PlayerMpFX MpFx; // 0x2f0
    System.Boolean <CurrentDieEffect>k__BackingField; // 0x2f8
    GamePlay.DieEffectConfig <CurrentDieEffectConf>k__BackingField; // 0x300
    Unity.Mathematics.FixedPoint.Fp CurrentDieEffectTime; // 0x308
    GamePlay.PlayerGrab <Grab>k__BackingField; // 0x310
    GamePlay.PlayerMpRevert <MpRevert>k__BackingField; // 0x318
    GamePlay.PlayerInstructionMatch <InstructionMatch>k__BackingField; // 0x320
    GamePlay.BattleSkillBtnListAutoSwitchMethod SkillButtonSwitch; // 0x328
    Unity.Mathematics.FixedPoint.Fp m_LastUpdateHP; // 0x32c
    System.Int32 MonsterScore; // 0x334
    System.Int32 PvpCapacity; // 0x338
    GamePlay.SkillStartSrcState m_lastHitSsss; // 0x340
    System.Action<GamePlay.GameActionLogic,GamePlay.GameActionLogic> ActionChangeEvent; // 0x368
    GamePlay.PlayerAIBase get_AI(); // 0x03d08498
    System.Void set_AI(GamePlay.PlayerAIBase value); // 0x03d084a0
    GamePlay.PlayerTriggerMgr get_TriggerMgr(); // 0x03d084b0
    System.Void set_TriggerMgr(GamePlay.PlayerTriggerMgr value); // 0x03d084b8
    GamePlay.PlayerSkillMgr get_SkillMgr(); // 0x03d084c8
    System.Void set_SkillMgr(GamePlay.PlayerSkillMgr value); // 0x03d084d0
    GamePlay.BattlePlayerStatistics get_Statistics(); // 0x03d084e0
    System.Void set_Statistics(GamePlay.BattlePlayerStatistics value); // 0x03d084e8
    System.Int32 get_AttrType(); // 0x03d084f8
    System.Void set_AttrType(System.Int32 value); // 0x03d08500
    GamePlay.PlayerSkill get_LastSkill(); // 0x03d027d8
    GamePlay.PlayerUIInfoBoard get_UIInfoBoard(); // 0x03d08508
    System.Void set_UIInfoBoard(GamePlay.PlayerUIInfoBoard value); // 0x03d08510
    Unity.Mathematics.FixedPoint.Fp get_LastFallGroundDamageRate(); // 0x03d08520
    System.Void set_LastFallGroundDamageRate(Unity.Mathematics.FixedPoint.Fp value); // 0x03d08528
    GamePlay.PlayerObjType get_PlayerObjType(); // 0x03d08530
    System.Void set_PlayerObjType(GamePlay.PlayerObjType value); // 0x03d08538
    System.Boolean get_IsMonster(); // 0x03d08540
    System.Boolean get_CurrentDieEffect(); // 0x03d0854c
    System.Void set_CurrentDieEffect(System.Boolean value); // 0x03d08554
    GamePlay.DieEffectConfig get_CurrentDieEffectConf(); // 0x03d08560
    System.Void set_CurrentDieEffectConf(GamePlay.DieEffectConfig value); // 0x03d08568
    GamePlay.PlayerGrab get_Grab(); // 0x03d08578
    System.Void set_Grab(GamePlay.PlayerGrab value); // 0x03d08580
    GamePlay.PlayerMpRevert get_MpRevert(); // 0x03d08590
    System.Void set_MpRevert(GamePlay.PlayerMpRevert value); // 0x03d08598
    GamePlay.PlayerInstructionMatch get_InstructionMatch(); // 0x03d085a8
    System.Void set_InstructionMatch(GamePlay.PlayerInstructionMatch value); // 0x03d085b0
    System.Void add_ActionChangeEvent(System.Action<GamePlay.GameActionLogic,GamePlay.GameActionLogic> value); // 0x03d085c0
    System.Void remove_ActionChangeEvent(System.Action<GamePlay.GameActionLogic,GamePlay.GameActionLogic> value); // 0x03d08674
    System.Void Init(GamePlay.ActionLogicGroup actionGroup, GamePlay.ActorSettings actorSettings); // 0x03d08728
    System.Void InitPlayerObjComponents(); // 0x03d09008
    System.Void PlayBornAction(Unity.Mathematics.FixedPoint.Fp2 bornPos); // 0x03d0917c
    System.Void initSelfActorInput(); // 0x03d0923c
    System.Void initReplicaInput(System.Boolean autonomous); // 0x03d09304
    System.Void InitMonsterInput(); // 0x03d09414
    System.Void InitAsHero(); // 0x03d094c0
    System.Void UpdatgeVisualScale(System.Single visualScale); // 0x03d09678
    System.Void InitAsSelfPlayer(); // 0x03d098bc
    System.Void InitAsReplicaPlayer(System.Boolean autonomous); // 0x03d099f4
    System.Void InitAsMonsterPlayer(MonsterConfigFixedPointWrap monConf); // 0x03d0a178
    GamePlay.PlayerUIInfoBoard InitInfoBoardOnBorn(); // 0x03d095a0
    GamePlay.PlayerUIInfoBoard RecheckInfoBoard(System.Boolean forceRefresh); // 0x03d0ab40
    System.Void hideInfoBoard(); // 0x03d0ada4
    System.Void onBornOK(); // 0x03d0ae4c
    System.Void UpdateLogic(GamePlay.DeltaTimeAndScale dt); // 0x03d0af7c
    System.Void UpdateVisual(GamePlay.DeltaTimeAndScale dt); // 0x03d0ba7c
    System.Void updateRendererShowHide(); // 0x03d0bcb8
    System.Void UpdatePickBox(); // 0x03d0b88c
    System.Void DeactivateOnDeadEnd(); // 0x03d0bdfc
    System.Void ReleaseOnRecycle(); // 0x03d0c0ac
    System.Void ReleaseFinal(); // 0x03d0c374
    System.Void OnEnterStage(); // 0x03d0c424
    System.Void SetAISurfixByBuff(System.String aiSurfix); // 0x03d0c4ac
    System.Void StartAI(System.String aiName, System.Boolean checkSurfix, System.Boolean isDefaultAI, GamePlay.ParamSet pSet); // 0x03d09b9c
    System.Void StartDefaultAI(); // 0x03d0c53c
    System.Void StopAI(System.Boolean release); // 0x03d0c5e4
    System.Void OnActionExit(GamePlay.GameActionLogic actionOld); // 0x03d0c87c
    System.Void OnActionChanged(GamePlay.GameActionLogic actionOld, GamePlay.GameActionLogic actionCur); // 0x03d0ca00
    Unity.Mathematics.FixedPoint.Fp DealDamage(GamePlay.ActorHpLoss hpLoss); // 0x03d0cc64
    System.Boolean OnBattleDamageBeHitCalcStage(GamePlay.ActorHitResult hitRes, GamePlay.PlayerHitResultCalcStage calcStage); // 0x03d0d1d0
    System.Void OnBattleDamageHitCalcStage(GamePlay.ActorHitResult hitRes, GamePlay.PlayerHitResultCalcStage calcStage); // 0x03d0d2c8
    System.Void NotifyBeHit(GamePlay.ActorHitResult hitResult); // 0x03d0d39c
    System.Void NotifyHitOther(GamePlay.ActorHitResult hitResult, System.Int32 callDepth); // 0x03d0d794
    System.Void ProcHealableHpOnHit(GamePlay.ActorHitResult hitres); // 0x03d0def0
    System.Void UseHealthFlask(System.Boolean air); // 0x03d0e188
    System.Void ChangeAddHpAction(System.Boolean air); // 0x03d0e2e0
    System.Void NotifyKillOther(GamePlay.PlayerObj other); // 0x03d0e3b0
    System.Void NotifyShieldBreak(); // 0x03d0e584
    System.Void OnHPZero(System.Boolean triggerDieLogic, System.Boolean triggerDieScript, GamePlay.ActorBase killer); // 0x03d0e71c
    System.Void DestroyInteractableObj(); // 0x03d0efd8
    System.Void AddDropToAccumulated(System.Int32 id, System.Int32 num, System.Int32 contentId, System.Int32 uid); // 0x03d0f1a4
    System.Void AddPotentialPVP(System.Int32 id); // 0x03d1026c
    System.Void AddBlessPVP(System.Int32 id, System.Int32 quality); // 0x03d10328
    System.Void AddDropItemCommandPVP(System.Int32 x); // 0x03d10534
    System.Void AddPotentialCommandPVP(System.Int32 x, System.Int32 y); // 0x03d10610
    System.Void AddBlessCommandPVP(System.Int32 x, System.Int32 y); // 0x03d106fc
    System.Void AddWormHoleCommandPVP(System.Int32 x, System.Int32 y, System.Int32 z); // 0x03d107e8
    System.Void AddExitCommandPVP(System.Int32 x); // 0x03d108dc
    System.Void AddOpenBoxCommandPVP(System.Int32 x); // 0x03d109b8
    System.Void AddPotentialRemoveCommandPVP(System.Int32 x); // 0x03d10a94
    System.Int32 AddPotentialAddCommandPVP(System.Int32 x); // 0x03d10b70
    System.Void CreateDropItem(System.Int32 uid); // 0x03d11020
    System.Void RemovePotentialBoxPVP(System.Int32 uid); // 0x03d11430
    System.Boolean AddPotentialBoxPVP(System.Int32 uid); // 0x03d0f958
    System.Void CalcPotentialTotalAttr(); // 0x03d11aa0
    System.Void PlayerWormHoleMove(Unity.Mathematics.FixedPoint.Fp2 vFrom, Unity.Mathematics.FixedPoint.Fp2 vTo, Unity.Mathematics.FixedPoint.Fp speed, System.Boolean startFromCenter, System.String addBuff); // 0x03d11f1c
    System.Void EnterPickState(GamePlay.PlayerObj dropObj, System.Int32 pickType); // 0x03d12218
    System.Void ClearPickState(System.Boolean succeed); // 0x03d12458
    System.Void UpdatePickState(Unity.Mathematics.FixedPoint.Fp dt); // 0x03d0b8ec
    System.Void ForcePlayDieEffect(); // 0x03d124e0
    System.Void Revive(Unity.Mathematics.FixedPoint.Fp2 pos); // 0x03d12664
    Unity.Mathematics.FixedPoint.Fp GetArmorType(); // 0x03d129b0
    System.Int32 GetInvincipalLevel(); // 0x03d12aa8
    System.Boolean IsAttackable(); // 0x03d12b6c
    System.Void BuffChangedPostRefresh(); // 0x03d12c00
    System.Void NotifyHitWallOrGround(RaycastHit2DWarp rc, Unity.Mathematics.FixedPoint.Fp2 physicalVelocity); // 0x03d12cb8
    System.Void notifyPassiveHitWall(); // 0x03d1341c
    System.Void notifyPassiveHitGround(); // 0x03d13524
    System.Void StartDieEffect(GamePlay.ActorDieEffectAndPrior dieEffect); // 0x03d0ed64
    System.Void crDieEffect(GamePlay.DieEffectConfig conf); // 0x03d1362c
    System.Void SetVisibleGrass(System.Boolean visible); // 0x03d13984
    System.Void SetVisibleHide(System.Boolean visible); // 0x03d139d4
    System.Boolean SetRenderActive(System.Boolean visible); // 0x03d13a24
    System.Boolean NecessarilyUpdate(); // 0x03d0b87c
    System.Void AddMPOnHit(GamePlay.ActorHitResult hitres); // 0x03d0d98c
    System.Void OnMpChanged(Unity.Mathematics.FixedPoint.Fp fp, System.Int32 order); // 0x03d13a74
    System.Void FullReset(); // 0x03d13b64
    System.Int32 GetStageClearDelayTimeMs(); // 0x03d13efc
    System.String ToString(); // 0x03d13f9c
    System.Void DebugDump(System.Text.StringBuilder sb); // 0x03d14098
    System.Void .ctor(); // 0x03d14114
}

// Assembly-CSharp
class GamePlay.SceneDestructableActor : GamePlay.ActorBase
{
    GamePlay.SceneDestructableActorPlacement SrcModel; // 0x228
    WorldGen.SceneDestructableActorPlacementFixed SrcModelFixed; // 0x230
    System.Int32 GroupID; // 0x238
    System.String m_effectPlayerName; // 0x240
    System.String m_onPlayingName; // 0x248
    System.Int32 m_currentPhaseIndex; // 0x250
    NOAH.VFX.VFXEffectPlayer[] m_vfxsConst; // 0x258
    NOAH.VFX.VFXEffectPlayer[] m_vfxsOnHit; // 0x260
    Unity.Mathematics.FixedPoint.Fp m_durationVfxOnHit; // 0x268
    System.Boolean m_vfxOnHitPlaying; // 0x270
    System.String ToString(); // 0x03d22184
    System.Void Init(GamePlay.ActorSettings actorSettings, GamePlay.SceneDestructableActorPlacement placement); // 0x03d22210
    System.Void UpdateLogic(GamePlay.DeltaTimeAndScale dt); // 0x03d23410
    System.Void UpdateVisual(GamePlay.DeltaTimeAndScale delta); // 0x03d2357c
    Unity.Mathematics.FixedPoint.Fp DealDamage(GamePlay.ActorHpLoss hpLoss); // 0x03d23580
    System.Void setAudioAssist(); // 0x03d22eb4
    System.Void setBehitBox(); // 0x03d22bf4
    System.Void OnHPZero(System.Boolean triggerDieLogic, System.Boolean triggerDieScript, GamePlay.ActorBase killer); // 0x03d23784
    System.Void NotifyBeHit(GamePlay.ActorHitResult hitResult); // 0x03d239ec
    System.Void NotifyInteract(GamePlay.ActorHitResult hitResult); // 0x03d23ce4
    System.Boolean ChangeVfxDir(GamePlay.ActorHitResult hitResult, NOAH.VFX.VFXEffectPlayer[] effects); // 0x03d2404c
    System.Boolean SearchAndChangePhase(GamePlay.ActorHitResult hitResult); // 0x03d230b0
    System.Void DeactivateVfxs(NOAH.VFX.VFXEffectPlayer[] vfxs); // 0x03d24258
    System.Void ActivateVfxs(NOAH.VFX.VFXEffectPlayer[] vfxs); // 0x03d22fc0
    System.Void OnDrawGizmos(); // 0x03d24328
    System.Void DebugDump(System.Text.StringBuilder sb); // 0x03d243a4
    System.Void .ctor(); // 0x03d24420
}