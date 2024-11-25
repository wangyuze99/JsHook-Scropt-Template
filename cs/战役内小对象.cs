// Assembly-CSharp
enum GamePlay.PlayerObjType : System.Enum
{
    System.Int32 value__; // 0x10
    static GamePlay.PlayerObjType None = 0;
    static GamePlay.PlayerObjType MainHero = 1; // 英雄
    static GamePlay.PlayerObjType Monster = 2; // 怪物
    static GamePlay.PlayerObjType Summoned = 4; // 召唤物
    
}

// Assembly-CSharp
class GamePlay.BattleStatistic : System.Object
{
    GamePlay.BattleBase Owner; // 0x10
    GamePlay.BattleStatisticsRec Data; // 0x18
    Unity.Mathematics.FixedPoint.Fp m_LastPlayerHP; // 0x20
    System.Void .ctor(GamePlay.BattleBase owner); // 0x03d77cd0
    System.Void Release(); // 0x03d77df8
    System.Void ClearOnStageChange(); // 0x03d77dfc
    System.Void OnPlayerKill(GamePlay.PlayerObj plAtt, GamePlay.PlayerObj plTarg); // 0x03d77f40
    System.Void DoUpdate(Unity.Mathematics.FixedPoint.Fp dt); // 0x03d783a0
    System.Void OnActorDamage(GamePlay.PlayerObj monster, GamePlay.ActorHpLoss damage); // 0x03d78508
}
// Assembly-CSharp
struct GamePlay.ActorHpLoss : System.ValueType
{
    GamePlay.ActorBase Attacker; // 0x10
    GamePlay.PlayerHPChangeReason Reason; // 0x18
    Unity.Mathematics.FixedPoint.Fp HPDelta; // 0x1c
    EAttrElementType Element; // 0x24
    System.Void Reset(); // 0x03d649b8
    GamePlay.ActorHpLoss Clone(); // 0x03d64a80
    System.String ToString(); // 0x03d64b4c
}
// Assembly-CSharp
enum GamePlay.PlayerHPChangeReason : System.Enum
{
    System.Int32 value__; // 0x10
    static GamePlay.PlayerHPChangeReason Hit = 0;
    static GamePlay.PlayerHPChangeReason Buff = 1;
    static GamePlay.PlayerHPChangeReason Other = 3;
    
}
// Assembly-CSharp
enum EAttrElementType : System.Enum // 伤害属性
{
    System.Int32 value__; // 0x10
    static EAttrElementType None = 0;
    static EAttrElementType Fire = 1;
    static EAttrElementType Ice = 2;
    static EAttrElementType Thunder = 3;
    static EAttrElementType Poison = 4;
    static EAttrElementType Dark = 5;
    static EAttrElementType Light = 6;
    static EAttrElementType Blade = 7;
    static EAttrElementType Chaos = 8;
    static EAttrElementType Count = 9;
    
}