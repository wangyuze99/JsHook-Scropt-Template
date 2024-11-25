
// Assembly-CSharp
class GamePlay.ActorHitResult : System.Object
{
    GamePlay.ActorBase Attacker; // 0x10
    GamePlay.ActorBase Target; // 0x18
    GamePlay.HitBox AttackBox; // 0x20
    GamePlay.BehitBox BehitBox; // 0x28
    GamePlay.BattleActorBehitType BeHitType; // 0x30
    GamePlay.ActionHitData HitData; // 0x38
    GamePlay.ActorCriticalDamageType DamageType; // 0x40
    SkillDamageFixedPointWrap SkillDamageConf; // 0x48
    GamePlay.SkillStartSrcState Ssss; // 0x50
    Unity.Mathematics.FixedPoint.Fp IncomingDamageScale; // 0x78
    GamePlay.ActorHitResultDamageDetail DamageDetail; // 0x80
    Unity.Mathematics.FixedPoint.Fp AttackFace; // 0x88
    Unity.Mathematics.FixedPoint.Fp TargetFaceBeforeHit; // 0x90
    Unity.Mathematics.FixedPoint.Fp TargetHitTurnFace; // 0x98
    System.Boolean DestPassiveActionEnable; // 0xa0
    GamePlay.ActionType DestActionType; // 0xa4
    System.String DestActionName; // 0xa8
    System.Boolean IsDead; // 0xb0
    System.Int32 SpecFlag; // 0xb4
    System.Int32 AttBoxGroup; // 0xb8
    System.Boolean HitEffEnable; // 0xbc
    GamePlay.PlayerHitResultEffectParams HitEff; // 0xc0
    System.Collections.Generic.List<GamePlay.CriwareAudio> HitAudios; // 0xe0
    Unity.Mathematics.FixedPoint.Fp2 TargetBePushSpeed; // 0xe8
    Unity.Mathematics.FixedPoint.Fp2 TargetSpeed; // 0xf8
    Unity.Mathematics.FixedPoint.Fp BehitArmorType; // 0x108
    Unity.Mathematics.FixedPoint.Fp DeltaArmorType; // 0x110
    System.Int32 ComboNum; // 0x118
    GamePlay.ActorHitFreezeResult HitFreeze; // 0x120
    System.Boolean NotifyActionHitEvents; // 0x128
    System.Boolean NotifyBuffHitEvents; // 0x129
    static System.Collections.Generic.Stack<GamePlay.ActorHitResult> s_Pool; // 0x0
    static System.Boolean op_Implicit(GamePlay.ActorHitResult v); // 0x03d6379c
    System.Void Reset(); // 0x03d6381c
    GamePlay.ActorHitResult Clone(); // 0x03d63b44
    System.Void CopyFrom(GamePlay.ActorHitResult other); // 0x03d63d14
    System.Void Recycle(); // 0x03d640c8
    Unity.Mathematics.FixedPoint.Fp get_DamageTotal(); // 0x03d6419c
    System.Int32 get_SkillGroup(); // 0x03d6420c
    EAttrElementType get_DamageElement(); // 0x03d642cc
    System.Int32 get_BehitBoxIndex(); // 0x03d642e8
    System.Void MultiplyTotalDamageScaleBy(Unity.Mathematics.FixedPoint.Fp mul); // 0x03d64368
    System.String ToString(); // 0x03d64454
    static GamePlay.ActorHitResult New(); // 0x03d63bfc
    System.Void .ctor(); // 0x03d647c0
    static System.Void .cctor(); // 0x03d64920
}