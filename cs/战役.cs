
// Assembly-CSharp
class JsPort.BattleUtilsJs : System.Object
{
    static GamePlay.MonsterStartParams s_MonsterStartParam; // 0x0
    static System.Boolean s_dieShowing; // 0x8
    static System.Void InitPostProcess(GamePlay.PlayerObj pl); // 0x03ad1234
    static GamePlay.PlayerObj SummonMonster(GamePlay.ActorBase actor, JsPort.BattleUtilsJs.SummonMonsterParams paramsTable); // 0x03ad1334
    static GamePlay.ActorBase CreateGainBall(GamePlay.PlayerObj player, Unity.Mathematics.FixedPoint.Fp2 pos, Unity.Mathematics.FixedPoint.Fp bulletId, System.String buffId, Unity.Mathematics.FixedPoint.Fp buffDur, Unity.Mathematics.FixedPoint.Fp buffStr); // 0x03ad1c40
    static System.Void PlayerWormHoleMove(GamePlay.ActorBase plo, Unity.Mathematics.FixedPoint.Fp2 vFrom, Unity.Mathematics.FixedPoint.Fp2 vTo, Unity.Mathematics.FixedPoint.Fp speed, GamePlay.ActorBase teleporter, System.Nullable<System.Boolean> startFromCenter, System.String addBuff); // 0x03acf5d8
    static System.Int32 GetSanBuffCount(); // 0x03ad1c48
    static System.Int32[] GetTeacherSkills(STFesActor fesActor); // 0x03ad1ff4
    static System.Void SetAvatarLight(); // 0x03ad217c
    static System.Void TeleportBulletsAfterPlayerSelfTeleport(GamePlay.PlayerObj plself, GamePlay.BattleBase btt); // 0x03ad2454
    static System.Void TeleportSummonedPlayersAfterPlayerSelfTeleport(GamePlay.PlayerObj plself, GamePlay.BattleBase btt); // 0x03ad25c8
    static System.Void DestroySummonedPlayersByCaster(GamePlay.PlayerObj caster, GamePlay.BattleBase btt, System.Boolean immediate); // 0x03ad26fc
    static System.Void PlayerSelfPlayDeadAudio(GamePlay.PlayerObj playerSelf); // 0x03ad287c
    static System.Void CheckFixMonsterOutsideBounds(); // 0x03ad295c
    static System.Void CheckFixPlayerSelfOutsideBounds(); // 0x03ad2d3c
    static System.Void ApplyPotentialDamageAttrToPlayer(System.Collections.Generic.List<System.UInt32> potentialIds, GamePlay.PlayerObj pl); // 0x03ad30f8
    static System.Void BuffAddHpMaxOrShield_5101(GamePlay.PlayerObj pl, Unity.Mathematics.FixedPoint.Fp armorAddR, Unity.Mathematics.FixedPoint.Fp buffStr, Unity.Mathematics.FixedPoint.Fp buffDur); // 0x03ad3624
    static System.Void tr4301_AddDamageByHealthFlaskUseCount(GamePlay.PlayerObj player, GamePlay.PlayerTriggerNode tr4301); // 0x03ad3860
    static System.Void tr4302_AddDamageByBlessSerieCount(GamePlay.PlayerObj player, GamePlay.PlayerTriggerNode tr4302); // 0x03ad3b28
    static System.Void tr4310_AddDamageBySanBuffCount(GamePlay.PlayerObj player, GamePlay.PlayerTriggerNode tr4310, System.Int32 count); // 0x03ad3ef0
    static System.Void tr4312_AddMaxHpByPerfectTimes(GamePlay.PlayerObj player, GamePlay.PlayerTriggerNode tr4312, System.Int32 perfectTimes); // 0x03ad4270
    static System.Void tr4313_AddDamageByDoubleBlessCount(GamePlay.PlayerObj player, GamePlay.PlayerTriggerNode tr4313, System.Int32 doubleBlessCount); // 0x03ad4498
    static System.Void tr4314_AddDamageByCurrentCoin(GamePlay.PlayerObj player, GamePlay.PlayerTriggerNode tr4314, System.Int32 coinNum); // 0x03ad4730
    static System.Void tr9014_AddAtkDamageByHpMax(GamePlay.PlayerObj player, GamePlay.PlayerTriggerNode tr9014); // 0x03ad4ab8
    static System.Void tr9015_AddSkillDamageByHpMax(GamePlay.PlayerObj player, GamePlay.PlayerTriggerNode tr9015); // 0x03ad4cb8
    static System.Int32 GetBlessSerieCount(GamePlay.PlayerObj player); // 0x03ad3e24
    static System.Void SubossAddBuffTeam(); // 0x03ad4eb8
    static System.Void DisablePassiveBless(); // 0x03ad590c
    static System.Void ShowBattleFtgYHCTeam(); // 0x03ad5dc0
    static System.Void DeleteHuDie(); // 0x03ad62a0
    static System.Void DeleteIceBullet(); // 0x03ad6578
    static Unity.Mathematics.FixedPoint.Fp GenerateBossEliteMonsterOnce(GamePlay.PlayerObj player, System.Int32 bossId, System.Boolean left, System.Boolean isFinalBoss); // 0x03ad6708
    static System.Void DeleteEliteGenMonsters(); // 0x03ad7288
    static GamePlay.PlayerObj GetOtherPlayerObj(GamePlay.PlayerObj selfPlayer); // 0x03ad74e8
    static System.Void .cctor(); // 0x03ad7774
}
