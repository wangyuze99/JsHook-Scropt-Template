
// Unity.Mathematics.FixedPoint
struct Unity.Mathematics.FixedPoint.Fp : System.ValueType, System.IEquatable<Unity.Mathematics.FixedPoint.Fp>, System.IComparable<Unity.Mathematics.FixedPoint.Fp>
{
    System.Int64 value; // 0x10
    static System.UInt32 LUTSize; // 0x0
    static System.Int32 ExpLimitMin; // 0x4
    static System.Int32 ExpLimitMax; // 0x8
    static System.Int64 INF = 9223372036854775806;
    static System.Int64 NEGINF = -9223372036854775806;
    static System.Int64 NAN = 9223372036854775807;
    static System.Int64 MINVALUE = -9223372036854775805;
    static System.Int64 MAXVALUE = 9223372036854775805;
    static System.Int64 LOG2MAX = 133143986176;
    static System.Int64 LOG2MIN = -137438953472;
    static Unity.Mathematics.FixedPoint.Fp Inf; // 0xc
    static Unity.Mathematics.FixedPoint.Fp NegInf; // 0x14
    static Unity.Mathematics.FixedPoint.Fp NaN; // 0x1c
    static Unity.Mathematics.FixedPoint.Fp MaxValue; // 0x24
    static Unity.Mathematics.FixedPoint.Fp MinValue; // 0x2c
    static Unity.Mathematics.FixedPoint.Fp atan2Constant; // 0x34
    static System.Int64 ONE = 4294967296;
    static System.Int64 TWO = 8589934592;
    static System.Int64 THREE = 12884901888;
    static System.Int64 ZERO = 0;
    static System.Int64 PI = 13493037704;
    static System.Int64 PI_OVER_2 = 6746518852;
    static System.Int64 PI_OVER_3 = 4497679234;
    static System.Int64 PI_OVER_4 = 3373259426;
    static System.Int64 PI_OVER_180 = 74961320;
    static System.Int64 PI_OVER_180_INVERSE = 246083499207;
    static System.Int64 PI_TIMES_2 = 26986075409;
    static System.Int64 E = 11674931554;
    static System.Int64 LN_2 = 2977044471;
    static System.Int64 LN_10 = 9889527670;
    static System.Int64 ONE_OVER_3 = 1431655765;
    static System.Int64 ONE_OVER_4 = 1073741824;
    static System.Int64 ONE_OVER_6 = 715827882;
    static System.Int64 ONE_OVER_8 = 536870912;
    static System.Int64 ONE_OVER_12 = 357913941;
    static System.Int64 ONE_OVER_24 = 178956970;
    static System.Int64 ONE_OVER_720 = 5965232;
    static System.Int64 ONE_E_MINUS_5 = 42949;
    static System.Int64 ONE_E_MINUS_6 = 4294;
    static System.Int64 ONE_E_MINUS_7 = 429;
    static System.Int64 ONE_E_MINUS_8 = 42;
    static System.Int64 FIVE_E_MINUS_3 = 21474836;
    static System.Int64 POINT_1 = 429496729;
    static System.Int64 POINT_2 = 858993459;
    static System.Int64 POINT_3 = 1288490188;
    static System.Int64 POINT_4 = 1717986918;
    static System.Int64 POINT_5 = 2147483648;
    static System.Int64 POINT_01 = 42949672;
    static System.Int64 POINT_02 = 85899345;
    static System.Int64 POINT_03 = 128849018;
    static System.Int64 POINT_04 = 171798691;
    static System.Int64 POINT_05 = 214748364;
    static System.Int64 POINT_001 = 4294967;
    static System.Int64 POINT_002 = 8589934;
    static System.Int64 POINT_003 = 12884901;
    static System.Int64 POINT_004 = 17179869;
    static System.Int64 POINT_005 = 21474836;
    static System.Int64 POINT_0001 = 429496;
    static System.Int64 EPSILON = 4294;
    static System.Int64 POINT_0002 = 858993;
    static System.Int64 POINT_0003 = 1288490;
    static System.Int64 POINT_0004 = 1717986;
    static System.Int64 POINT_0005 = 2147483;
    static System.Int64 POINT_98 = 4209067950;
    static System.Int64 POINT_9995 = 4292819812;
    static System.Int64 POINT_9999 = 4294537799;
    static System.Int64 POINT_99999 = 4294924346;
    static System.Int64 TWO_POINT_30258509 = 9889527657;
    static Unity.Mathematics.FixedPoint.Fp One; // 0x3c
    static Unity.Mathematics.FixedPoint.Fp Two; // 0x44
    static Unity.Mathematics.FixedPoint.Fp Three; // 0x4c
    static Unity.Mathematics.FixedPoint.Fp Zero; // 0x54
    static Unity.Mathematics.FixedPoint.Fp Pi; // 0x5c
    static Unity.Mathematics.FixedPoint.Fp PiOver2; // 0x64
    static Unity.Mathematics.FixedPoint.Fp PiOver3; // 0x6c
    static Unity.Mathematics.FixedPoint.Fp PiOver4; // 0x74
    static Unity.Mathematics.FixedPoint.Fp PiOver180; // 0x7c
    static Unity.Mathematics.FixedPoint.Fp PiOver180Inverse; // 0x84
    static Unity.Mathematics.FixedPoint.Fp PiTimes2; // 0x8c
    static Unity.Mathematics.FixedPoint.Fp EFp; // 0x94
    static Unity.Mathematics.FixedPoint.Fp Ln2; // 0x9c
    static Unity.Mathematics.FixedPoint.Fp Ln10; // 0xa4
    static Unity.Mathematics.FixedPoint.Fp OneOver3; // 0xac
    static Unity.Mathematics.FixedPoint.Fp OneOver4; // 0xb4
    static Unity.Mathematics.FixedPoint.Fp OneOver6; // 0xbc
    static Unity.Mathematics.FixedPoint.Fp OneOver8; // 0xc4
    static Unity.Mathematics.FixedPoint.Fp OneOver12; // 0xcc
    static Unity.Mathematics.FixedPoint.Fp OneOver24; // 0xd4
    static Unity.Mathematics.FixedPoint.Fp OneOver720; // 0xdc
    static Unity.Mathematics.FixedPoint.Fp OneEMinus5; // 0xe4
    static Unity.Mathematics.FixedPoint.Fp OneEMinus6; // 0xec
    static Unity.Mathematics.FixedPoint.Fp OneEMinus7; // 0xf4
    static Unity.Mathematics.FixedPoint.Fp OneEMinus8; // 0xfc
    static Unity.Mathematics.FixedPoint.Fp FiveEMinus3; // 0x104
    static Unity.Mathematics.FixedPoint.Fp Point1; // 0x10c
    static Unity.Mathematics.FixedPoint.Fp Point2; // 0x114
    static Unity.Mathematics.FixedPoint.Fp Point3; // 0x11c
    static Unity.Mathematics.FixedPoint.Fp Point4; // 0x124
    static Unity.Mathematics.FixedPoint.Fp Point5; // 0x12c
    static Unity.Mathematics.FixedPoint.Fp Point01; // 0x134
    static Unity.Mathematics.FixedPoint.Fp Point02; // 0x13c
    static Unity.Mathematics.FixedPoint.Fp Point03; // 0x144
    static Unity.Mathematics.FixedPoint.Fp Point04; // 0x14c
    static Unity.Mathematics.FixedPoint.Fp Point05; // 0x154
    static Unity.Mathematics.FixedPoint.Fp Point001; // 0x15c
    static Unity.Mathematics.FixedPoint.Fp Point002; // 0x164
    static Unity.Mathematics.FixedPoint.Fp Point003; // 0x16c
    static Unity.Mathematics.FixedPoint.Fp Point004; // 0x174
    static Unity.Mathematics.FixedPoint.Fp Point005; // 0x17c
    static Unity.Mathematics.FixedPoint.Fp Point0001; // 0x184
    static Unity.Mathematics.FixedPoint.Fp Epsilon; // 0x18c
    static Unity.Mathematics.FixedPoint.Fp Point0002; // 0x194
    static Unity.Mathematics.FixedPoint.Fp Point0003; // 0x19c
    static Unity.Mathematics.FixedPoint.Fp Point0004; // 0x1a4
    static Unity.Mathematics.FixedPoint.Fp Point0005; // 0x1ac
    static Unity.Mathematics.FixedPoint.Fp Point98; // 0x1b4
    static Unity.Mathematics.FixedPoint.Fp Point9995; // 0x1bc
    static Unity.Mathematics.FixedPoint.Fp Point9999; // 0x1c4
    static Unity.Mathematics.FixedPoint.Fp Point99999; // 0x1cc
    static Unity.Mathematics.FixedPoint.Fp TwoPoint30258509; // 0x1d4
    static System.Int64[] ASinLUT; // 0x1e0
    static System.Int64[] ExpLUT; // 0x1e8
    static System.Int64[] SinLUT; // 0x1f0
    static System.Int64[] TanLUT; // 0x1f8
    static Unity.Mathematics.FixedPoint.Fp op_Addition(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06270574
    static Unity.Mathematics.FixedPoint.Fp op_Subtraction(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06270760
    static Unity.Mathematics.FixedPoint.Fp op_Multiply(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x0627094c
    static Unity.Mathematics.FixedPoint.Fp op_Multiply(Unity.Mathematics.FixedPoint.Fp x, System.Int32 y); // 0x06270d38
    static Unity.Mathematics.FixedPoint.Fp op_Multiply(System.Int32 y, Unity.Mathematics.FixedPoint.Fp x); // 0x06270d9c
    static Unity.Mathematics.FixedPoint.Fp op_Division(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06270f34
    static Unity.Mathematics.FixedPoint.Fp op_Division(Unity.Mathematics.FixedPoint.Fp x, System.Int32 y); // 0x062711f4
    static Unity.Mathematics.FixedPoint.Fp op_Modulus(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06271304
    static Unity.Mathematics.FixedPoint.Fp op_UnaryNegation(Unity.Mathematics.FixedPoint.Fp x); // 0x062713ac
    static Unity.Mathematics.FixedPoint.Fp op_UnaryPlus(Unity.Mathematics.FixedPoint.Fp x); // 0x06271408
    static Unity.Mathematics.FixedPoint.Fp op_Increment(Unity.Mathematics.FixedPoint.Fp x); // 0x0627140c
    static Unity.Mathematics.FixedPoint.Fp op_Decrement(Unity.Mathematics.FixedPoint.Fp x); // 0x0627146c
    static System.Boolean op_Equality(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06270f00
    static System.Boolean op_Equality(Unity.Mathematics.FixedPoint.Fp x, System.Int32 y); // 0x062714cc
    static System.Boolean op_Inequality(Unity.Mathematics.FixedPoint.Fp x, System.Int32 y); // 0x06271554
    static System.Boolean op_Inequality(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x062715c4
    static System.Boolean op_GreaterThan(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06270f14
    static System.Boolean op_LessThan(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06271628
    static System.Boolean op_GreaterThanOrEqual(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06271654
    static System.Boolean op_LessThanOrEqual(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06271680
    static Unity.Mathematics.FixedPoint.Fp op_Explicit(System.Double doubleValue); // 0x062716ac
    static System.Double op_Explicit(Unity.Mathematics.FixedPoint.Fp fp); // 0x06271778
    static Unity.Mathematics.FixedPoint.Fp op_Explicit(System.Single floatValue); // 0x0627178c
    static System.Single op_Explicit(Unity.Mathematics.FixedPoint.Fp fp); // 0x062717e8
    static Unity.Mathematics.FixedPoint.Fp op_Implicit(System.Int32 intValue); // 0x06270f0c
    static System.Int32 op_Explicit(Unity.Mathematics.FixedPoint.Fp x); // 0x06270ce4
    static Unity.Mathematics.FixedPoint.Fp op_Explicit(System.Int64 longValue); // 0x0627184c
    static Unity.Mathematics.FixedPoint.Fp op_Explicit(System.UInt32 intValue); // 0x06271854
    static System.UInt32 op_Explicit(Unity.Mathematics.FixedPoint.Fp x); // 0x0627185c
    System.Boolean Equals(Unity.Mathematics.FixedPoint.Fp other); // 0x062718b0
    System.Int32 CompareTo(Unity.Mathematics.FixedPoint.Fp other); // 0x06271918
    System.Boolean Equals(System.Object obj); // 0x06271920
    System.Int32 GetHashCode(); // 0x062719ac
    System.String ToString(); // 0x062719b4
    System.String ToString(System.String format, System.IFormatProvider formatProvider); // 0x06271be0
    static System.String ToStringExInfo(Unity.Mathematics.FixedPoint.Fp x); // 0x06271a80
    static System.Int32 Sign(Unity.Mathematics.FixedPoint.Fp x); // 0x06271c94
    static System.Int32 IsInf(Unity.Mathematics.FixedPoint.Fp x); // 0x06271cac
    static System.Int32 IsInf(System.Int64 value); // 0x06271d18
    static System.Boolean IsNaN(Unity.Mathematics.FixedPoint.Fp x); // 0x06271d38
    static Unity.Mathematics.FixedPoint.Fp Abs(Unity.Mathematics.FixedPoint.Fp x); // 0x06271d48
    static Unity.Mathematics.FixedPoint.Fp FastAbs(Unity.Mathematics.FixedPoint.Fp x); // 0x06271dc4
    static Unity.Mathematics.FixedPoint.Fp Floor(Unity.Mathematics.FixedPoint.Fp x); // 0x06271dd0
    static Unity.Mathematics.FixedPoint.Fp Ceiling(Unity.Mathematics.FixedPoint.Fp x); // 0x06271dd8
    static System.UInt64 FractionalPart(Unity.Mathematics.FixedPoint.Fp x); // 0x06271e60
    static System.Int64 IntegerPart(Unity.Mathematics.FixedPoint.Fp x); // 0x06271e68
    static Unity.Mathematics.FixedPoint.Fp Round(Unity.Mathematics.FixedPoint.Fp x); // 0x06271e70
    static Unity.Mathematics.FixedPoint.Fp FastAdd(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06271f10
    static Unity.Mathematics.FixedPoint.Fp FastSub(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06271f18
    static System.Int64 AddOverflowHelper(System.Int64 x, System.Int64 y, System.Boolean& overflow); // 0x06270738
    static System.Boolean SignEqual(System.Int64 xValue, System.Int64 yValue); // 0x06271f20
    static Unity.Mathematics.FixedPoint.Fp FastMul(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x06271f30
    static Unity.Mathematics.FixedPoint.Fp FastMod(Unity.Mathematics.FixedPoint.Fp x, Unity.Mathematics.FixedPoint.Fp y); // 0x062713a0
    static Unity.Mathematics.FixedPoint.Fp Pow2(Unity.Mathematics.FixedPoint.Fp x); // 0x06271fa8
    static Unity.Mathematics.FixedPoint.Fp Log2(Unity.Mathematics.FixedPoint.Fp x); // 0x062721b4
    static Unity.Mathematics.FixedPoint.Fp Pow(Unity.Mathematics.FixedPoint.Fp b, Unity.Mathematics.FixedPoint.Fp exp); // 0x06272364
    static Unity.Mathematics.FixedPoint.Fp Sqrt(Unity.Mathematics.FixedPoint.Fp x); // 0x06272454
    static Unity.Mathematics.FixedPoint.Fp Sin(Unity.Mathematics.FixedPoint.Fp x); // 0x062724f8
    static System.Int64 ClampSinValue(System.Int64 angle, System.Boolean& flipHorizontal, System.Boolean& flipVertical); // 0x0627257c
    static Unity.Mathematics.FixedPoint.Fp Cos(Unity.Mathematics.FixedPoint.Fp x); // 0x062728bc
    static Unity.Mathematics.FixedPoint.Fp Tan(Unity.Mathematics.FixedPoint.Fp x); // 0x06272944
    static Unity.Mathematics.FixedPoint.Fp Atan2(Unity.Mathematics.FixedPoint.Fp y, Unity.Mathematics.FixedPoint.Fp x); // 0x06272c14
    System.Void .ctor(System.Int64 rawValue); // 0x06272ec4
    static Unity.Mathematics.FixedPoint.Fp RawFp(System.Int64 rawValue); // 0x06272ecc
    static Unity.Mathematics.FixedPoint.Fp Convert(System.ReadOnlySpan<System.Char> value); // 0x06272ed0
    static Unity.Mathematics.FixedPoint.Fp Convert(System.String value); // 0x0627314c
    static System.Int64 InterpolateWithSinLUT(Unity.Mathematics.FixedPoint.Fp x, System.Boolean indexFlip); // 0x062726c0
    static System.Int64 InterpolateWithTanLUT(Unity.Mathematics.FixedPoint.Fp x, System.Boolean indexFlip); // 0x06272a18
    static System.Void .cctor(); // 0x062731e4
}
