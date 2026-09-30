using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntityReturnCode>))]
public sealed record EntityReturnCode : OpenStringEnum<EntityReturnCode>
{
    private EntityReturnCode(string value) : base(value)
    {
    }

    public static readonly EntityReturnCode R01 = new("R01");

    public static readonly EntityReturnCode R02 = new("R02");

    public static readonly EntityReturnCode R03 = new("R03");

    public static readonly EntityReturnCode R04 = new("R04");

    public static readonly EntityReturnCode R05 = new("R05");

    public static readonly EntityReturnCode R06 = new("R06");

    public static readonly EntityReturnCode R07 = new("R07");

    public static readonly EntityReturnCode R08 = new("R08");

    public static readonly EntityReturnCode R09 = new("R09");

    public static readonly EntityReturnCode R10 = new("R10");

    public static readonly EntityReturnCode R11 = new("R11");

    public static readonly EntityReturnCode R12 = new("R12");

    public static readonly EntityReturnCode R13 = new("R13");

    public static readonly EntityReturnCode R14 = new("R14");

    public static readonly EntityReturnCode R15 = new("R15");

    public static readonly EntityReturnCode R16 = new("R16");

    public static readonly EntityReturnCode R17 = new("R17");

    public static readonly EntityReturnCode R18 = new("R18");

    public static readonly EntityReturnCode R19 = new("R19");

    public static readonly EntityReturnCode R20 = new("R20");

    public static readonly EntityReturnCode R21 = new("R21");

    public static readonly EntityReturnCode R22 = new("R22");

    public static readonly EntityReturnCode R23 = new("R23");

    public static readonly EntityReturnCode R24 = new("R24");

    public static readonly EntityReturnCode R25 = new("R25");

    public static readonly EntityReturnCode R26 = new("R26");

    public static readonly EntityReturnCode R27 = new("R27");

    public static readonly EntityReturnCode R28 = new("R28");

    public static readonly EntityReturnCode R29 = new("R29");

    public static readonly EntityReturnCode R30 = new("R30");

    public static readonly EntityReturnCode R31 = new("R31");

    public static readonly EntityReturnCode R32 = new("R32");

    public static readonly EntityReturnCode R33 = new("R33");

    public static readonly EntityReturnCode R34 = new("R34");

    public static readonly EntityReturnCode R35 = new("R35");

    public static readonly EntityReturnCode R36 = new("R36");

    public static readonly EntityReturnCode R37 = new("R37");

    public static readonly EntityReturnCode R38 = new("R38");

    public static readonly EntityReturnCode R39 = new("R39");

    public static readonly EntityReturnCode R40 = new("R40");

    public static readonly EntityReturnCode R41 = new("R41");

    public static readonly EntityReturnCode R42 = new("R42");

    public static readonly EntityReturnCode R43 = new("R43");

    public static readonly EntityReturnCode R44 = new("R44");

    public static readonly EntityReturnCode R45 = new("R45");

    public static readonly EntityReturnCode R46 = new("R46");

    public static readonly EntityReturnCode R47 = new("R47");

    public static readonly EntityReturnCode R50 = new("R50");

    public static readonly EntityReturnCode R51 = new("R51");

    public static readonly EntityReturnCode R52 = new("R52");

    public static readonly EntityReturnCode R53 = new("R53");

    public static readonly EntityReturnCode R61 = new("R61");

    public static readonly EntityReturnCode R62 = new("R62");

    public static readonly EntityReturnCode R63 = new("R63");

    public static readonly EntityReturnCode R64 = new("R64");

    public static readonly EntityReturnCode R65 = new("R65");

    public static readonly EntityReturnCode R66 = new("R66");

    public static readonly EntityReturnCode R67 = new("R67");

    public static readonly EntityReturnCode R68 = new("R68");

    public static readonly EntityReturnCode R69 = new("R69");

    public static readonly EntityReturnCode R70 = new("R70");

    public static readonly EntityReturnCode R71 = new("R71");

    public static readonly EntityReturnCode R72 = new("R72");

    public static readonly EntityReturnCode R73 = new("R73");

    public static readonly EntityReturnCode R74 = new("R74");

    public static readonly EntityReturnCode R75 = new("R75");

    public static readonly EntityReturnCode R76 = new("R76");

    public static readonly EntityReturnCode R80 = new("R80");

    public static readonly EntityReturnCode R81 = new("R81");

    public static readonly EntityReturnCode R82 = new("R82");

    public static readonly EntityReturnCode R83 = new("R83");

    public static readonly EntityReturnCode R84 = new("R84");

    public static readonly EntityReturnCode R94 = new("R94");

    public static readonly EntityReturnCode R95 = new("R95");

    public static readonly EntityReturnCode R97 = new("R97");

    public static readonly EntityReturnCode R98 = new("R98");

    public static readonly EntityReturnCode R99 = new("R99");

    public static readonly EntityReturnCode C01 = new("C01");

    public static readonly EntityReturnCode C02 = new("C02");

    public static readonly EntityReturnCode C03 = new("C03");

    public static readonly EntityReturnCode C04 = new("C04");

    public static readonly EntityReturnCode C05 = new("C05");

    public static readonly EntityReturnCode C06 = new("C06");

    public static readonly EntityReturnCode C07 = new("C07");

    public static readonly EntityReturnCode C08 = new("C08");

    public static readonly EntityReturnCode C09 = new("C09");

    public static readonly EntityReturnCode C10 = new("C10");

    public static readonly EntityReturnCode C11 = new("C11");

    public static readonly EntityReturnCode C12 = new("C12");

    public static readonly EntityReturnCode C13 = new("C13");

    public static readonly EntityReturnCode C61 = new("C61");

    public static readonly EntityReturnCode C62 = new("C62");

    public static readonly EntityReturnCode C63 = new("C63");

    public static readonly EntityReturnCode C64 = new("C64");

    public static readonly EntityReturnCode C65 = new("C65");

    public static readonly EntityReturnCode C66 = new("C66");

    public static readonly EntityReturnCode C67 = new("C67");

    public static readonly EntityReturnCode C68 = new("C68");

    public static readonly EntityReturnCode C69 = new("C69");

    public static readonly EntityReturnCode R90007 = new("R900-07");

    public static readonly EntityReturnCode R90008 = new("R900-08");

    public static readonly EntityReturnCode R90016 = new("R900-16");

    public static readonly EntityReturnCode R90017 = new("R900-17");

    public static readonly EntityReturnCode R900D2 = new("R900-D2");

    public static readonly EntityReturnCode R900E1 = new("R900-E1");

    public static readonly EntityReturnCode R900L2 = new("R900-L2");

    public static readonly EntityReturnCode R900L3 = new("R900-L3");

    public static readonly EntityReturnCode R900M1 = new("R900-M1");

    public static readonly EntityReturnCode R901 = new("R901");

    public static readonly EntityReturnCode R902 = new("R902");

    public static readonly EntityReturnCode R903 = new("R903");

    public static readonly EntityReturnCode R904 = new("R904");

    public static readonly EntityReturnCode R905 = new("R905");

    public static readonly EntityReturnCode R907 = new("R907");

    public static readonly EntityReturnCode R908 = new("R908");

    public static readonly EntityReturnCode R909 = new("R909");

    public static readonly EntityReturnCode R910 = new("R910");

    public static readonly EntityReturnCode R911 = new("R911");

    public static readonly EntityReturnCode R912 = new("R912");

    public static readonly EntityReturnCode R914 = new("R914");

    public static readonly EntityReturnCode R915 = new("R915");

    public static readonly EntityReturnCode R916 = new("R916");

    public static readonly EntityReturnCode R917 = new("R917");

    public static readonly EntityReturnCode R918 = new("R918");

    public static readonly EntityReturnCode R919 = new("R919");

    public static readonly EntityReturnCode R920 = new("R920");

    public static readonly EntityReturnCode R921 = new("R921");

    public static readonly EntityReturnCode R922 = new("R922");

    public static readonly EntityReturnCode R990 = new("R990");

    public TResult Match<TResult>(Func<TResult> onR01,
        Func<TResult> onR02,
        Func<TResult> onR03,
        Func<TResult> onR04,
        Func<TResult> onR05,
        Func<TResult> onR06,
        Func<TResult> onR07,
        Func<TResult> onR08,
        Func<TResult> onR09,
        Func<TResult> onR10,
        Func<TResult> onR11,
        Func<TResult> onR12,
        Func<TResult> onR13,
        Func<TResult> onR14,
        Func<TResult> onR15,
        Func<TResult> onR16,
        Func<TResult> onR17,
        Func<TResult> onR18,
        Func<TResult> onR19,
        Func<TResult> onR20,
        Func<TResult> onR21,
        Func<TResult> onR22,
        Func<TResult> onR23,
        Func<TResult> onR24,
        Func<TResult> onR25,
        Func<TResult> onR26,
        Func<TResult> onR27,
        Func<TResult> onR28,
        Func<TResult> onR29,
        Func<TResult> onR30,
        Func<TResult> onR31,
        Func<TResult> onR32,
        Func<TResult> onR33,
        Func<TResult> onR34,
        Func<TResult> onR35,
        Func<TResult> onR36,
        Func<TResult> onR37,
        Func<TResult> onR38,
        Func<TResult> onR39,
        Func<TResult> onR40,
        Func<TResult> onR41,
        Func<TResult> onR42,
        Func<TResult> onR43,
        Func<TResult> onR44,
        Func<TResult> onR45,
        Func<TResult> onR46,
        Func<TResult> onR47,
        Func<TResult> onR50,
        Func<TResult> onR51,
        Func<TResult> onR52,
        Func<TResult> onR53,
        Func<TResult> onR61,
        Func<TResult> onR62,
        Func<TResult> onR63,
        Func<TResult> onR64,
        Func<TResult> onR65,
        Func<TResult> onR66,
        Func<TResult> onR67,
        Func<TResult> onR68,
        Func<TResult> onR69,
        Func<TResult> onR70,
        Func<TResult> onR71,
        Func<TResult> onR72,
        Func<TResult> onR73,
        Func<TResult> onR74,
        Func<TResult> onR75,
        Func<TResult> onR76,
        Func<TResult> onR80,
        Func<TResult> onR81,
        Func<TResult> onR82,
        Func<TResult> onR83,
        Func<TResult> onR84,
        Func<TResult> onR94,
        Func<TResult> onR95,
        Func<TResult> onR97,
        Func<TResult> onR98,
        Func<TResult> onR99,
        Func<TResult> onC01,
        Func<TResult> onC02,
        Func<TResult> onC03,
        Func<TResult> onC04,
        Func<TResult> onC05,
        Func<TResult> onC06,
        Func<TResult> onC07,
        Func<TResult> onC08,
        Func<TResult> onC09,
        Func<TResult> onC10,
        Func<TResult> onC11,
        Func<TResult> onC12,
        Func<TResult> onC13,
        Func<TResult> onC61,
        Func<TResult> onC62,
        Func<TResult> onC63,
        Func<TResult> onC64,
        Func<TResult> onC65,
        Func<TResult> onC66,
        Func<TResult> onC67,
        Func<TResult> onC68,
        Func<TResult> onC69,
        Func<TResult> onR90007,
        Func<TResult> onR90008,
        Func<TResult> onR90016,
        Func<TResult> onR90017,
        Func<TResult> onR900D2,
        Func<TResult> onR900E1,
        Func<TResult> onR900L2,
        Func<TResult> onR900L3,
        Func<TResult> onR900M1,
        Func<TResult> onR901,
        Func<TResult> onR902,
        Func<TResult> onR903,
        Func<TResult> onR904,
        Func<TResult> onR905,
        Func<TResult> onR907,
        Func<TResult> onR908,
        Func<TResult> onR909,
        Func<TResult> onR910,
        Func<TResult> onR911,
        Func<TResult> onR912,
        Func<TResult> onR914,
        Func<TResult> onR915,
        Func<TResult> onR916,
        Func<TResult> onR917,
        Func<TResult> onR918,
        Func<TResult> onR919,
        Func<TResult> onR920,
        Func<TResult> onR921,
        Func<TResult> onR922,
        Func<TResult> onR990,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == R01 => onR01(),
            _ when this == R02 => onR02(),
            _ when this == R03 => onR03(),
            _ when this == R04 => onR04(),
            _ when this == R05 => onR05(),
            _ when this == R06 => onR06(),
            _ when this == R07 => onR07(),
            _ when this == R08 => onR08(),
            _ when this == R09 => onR09(),
            _ when this == R10 => onR10(),
            _ when this == R11 => onR11(),
            _ when this == R12 => onR12(),
            _ when this == R13 => onR13(),
            _ when this == R14 => onR14(),
            _ when this == R15 => onR15(),
            _ when this == R16 => onR16(),
            _ when this == R17 => onR17(),
            _ when this == R18 => onR18(),
            _ when this == R19 => onR19(),
            _ when this == R20 => onR20(),
            _ when this == R21 => onR21(),
            _ when this == R22 => onR22(),
            _ when this == R23 => onR23(),
            _ when this == R24 => onR24(),
            _ when this == R25 => onR25(),
            _ when this == R26 => onR26(),
            _ when this == R27 => onR27(),
            _ when this == R28 => onR28(),
            _ when this == R29 => onR29(),
            _ when this == R30 => onR30(),
            _ when this == R31 => onR31(),
            _ when this == R32 => onR32(),
            _ when this == R33 => onR33(),
            _ when this == R34 => onR34(),
            _ when this == R35 => onR35(),
            _ when this == R36 => onR36(),
            _ when this == R37 => onR37(),
            _ when this == R38 => onR38(),
            _ when this == R39 => onR39(),
            _ when this == R40 => onR40(),
            _ when this == R41 => onR41(),
            _ when this == R42 => onR42(),
            _ when this == R43 => onR43(),
            _ when this == R44 => onR44(),
            _ when this == R45 => onR45(),
            _ when this == R46 => onR46(),
            _ when this == R47 => onR47(),
            _ when this == R50 => onR50(),
            _ when this == R51 => onR51(),
            _ when this == R52 => onR52(),
            _ when this == R53 => onR53(),
            _ when this == R61 => onR61(),
            _ when this == R62 => onR62(),
            _ when this == R63 => onR63(),
            _ when this == R64 => onR64(),
            _ when this == R65 => onR65(),
            _ when this == R66 => onR66(),
            _ when this == R67 => onR67(),
            _ when this == R68 => onR68(),
            _ when this == R69 => onR69(),
            _ when this == R70 => onR70(),
            _ when this == R71 => onR71(),
            _ when this == R72 => onR72(),
            _ when this == R73 => onR73(),
            _ when this == R74 => onR74(),
            _ when this == R75 => onR75(),
            _ when this == R76 => onR76(),
            _ when this == R80 => onR80(),
            _ when this == R81 => onR81(),
            _ when this == R82 => onR82(),
            _ when this == R83 => onR83(),
            _ when this == R84 => onR84(),
            _ when this == R94 => onR94(),
            _ when this == R95 => onR95(),
            _ when this == R97 => onR97(),
            _ when this == R98 => onR98(),
            _ when this == R99 => onR99(),
            _ when this == C01 => onC01(),
            _ when this == C02 => onC02(),
            _ when this == C03 => onC03(),
            _ when this == C04 => onC04(),
            _ when this == C05 => onC05(),
            _ when this == C06 => onC06(),
            _ when this == C07 => onC07(),
            _ when this == C08 => onC08(),
            _ when this == C09 => onC09(),
            _ when this == C10 => onC10(),
            _ when this == C11 => onC11(),
            _ when this == C12 => onC12(),
            _ when this == C13 => onC13(),
            _ when this == C61 => onC61(),
            _ when this == C62 => onC62(),
            _ when this == C63 => onC63(),
            _ when this == C64 => onC64(),
            _ when this == C65 => onC65(),
            _ when this == C66 => onC66(),
            _ when this == C67 => onC67(),
            _ when this == C68 => onC68(),
            _ when this == C69 => onC69(),
            _ when this == R90007 => onR90007(),
            _ when this == R90008 => onR90008(),
            _ when this == R90016 => onR90016(),
            _ when this == R90017 => onR90017(),
            _ when this == R900D2 => onR900D2(),
            _ when this == R900E1 => onR900E1(),
            _ when this == R900L2 => onR900L2(),
            _ when this == R900L3 => onR900L3(),
            _ when this == R900M1 => onR900M1(),
            _ when this == R901 => onR901(),
            _ when this == R902 => onR902(),
            _ when this == R903 => onR903(),
            _ when this == R904 => onR904(),
            _ when this == R905 => onR905(),
            _ when this == R907 => onR907(),
            _ when this == R908 => onR908(),
            _ when this == R909 => onR909(),
            _ when this == R910 => onR910(),
            _ when this == R911 => onR911(),
            _ when this == R912 => onR912(),
            _ when this == R914 => onR914(),
            _ when this == R915 => onR915(),
            _ when this == R916 => onR916(),
            _ when this == R917 => onR917(),
            _ when this == R918 => onR918(),
            _ when this == R919 => onR919(),
            _ when this == R920 => onR920(),
            _ when this == R921 => onR921(),
            _ when this == R922 => onR922(),
            _ when this == R990 => onR990(),
            _ => otherwise(Value)
        };

    public void Match(Action onR01,
        Action onR02,
        Action onR03,
        Action onR04,
        Action onR05,
        Action onR06,
        Action onR07,
        Action onR08,
        Action onR09,
        Action onR10,
        Action onR11,
        Action onR12,
        Action onR13,
        Action onR14,
        Action onR15,
        Action onR16,
        Action onR17,
        Action onR18,
        Action onR19,
        Action onR20,
        Action onR21,
        Action onR22,
        Action onR23,
        Action onR24,
        Action onR25,
        Action onR26,
        Action onR27,
        Action onR28,
        Action onR29,
        Action onR30,
        Action onR31,
        Action onR32,
        Action onR33,
        Action onR34,
        Action onR35,
        Action onR36,
        Action onR37,
        Action onR38,
        Action onR39,
        Action onR40,
        Action onR41,
        Action onR42,
        Action onR43,
        Action onR44,
        Action onR45,
        Action onR46,
        Action onR47,
        Action onR50,
        Action onR51,
        Action onR52,
        Action onR53,
        Action onR61,
        Action onR62,
        Action onR63,
        Action onR64,
        Action onR65,
        Action onR66,
        Action onR67,
        Action onR68,
        Action onR69,
        Action onR70,
        Action onR71,
        Action onR72,
        Action onR73,
        Action onR74,
        Action onR75,
        Action onR76,
        Action onR80,
        Action onR81,
        Action onR82,
        Action onR83,
        Action onR84,
        Action onR94,
        Action onR95,
        Action onR97,
        Action onR98,
        Action onR99,
        Action onC01,
        Action onC02,
        Action onC03,
        Action onC04,
        Action onC05,
        Action onC06,
        Action onC07,
        Action onC08,
        Action onC09,
        Action onC10,
        Action onC11,
        Action onC12,
        Action onC13,
        Action onC61,
        Action onC62,
        Action onC63,
        Action onC64,
        Action onC65,
        Action onC66,
        Action onC67,
        Action onC68,
        Action onC69,
        Action onR90007,
        Action onR90008,
        Action onR90016,
        Action onR90017,
        Action onR900D2,
        Action onR900E1,
        Action onR900L2,
        Action onR900L3,
        Action onR900M1,
        Action onR901,
        Action onR902,
        Action onR903,
        Action onR904,
        Action onR905,
        Action onR907,
        Action onR908,
        Action onR909,
        Action onR910,
        Action onR911,
        Action onR912,
        Action onR914,
        Action onR915,
        Action onR916,
        Action onR917,
        Action onR918,
        Action onR919,
        Action onR920,
        Action onR921,
        Action onR922,
        Action onR990,
        Action<string> otherwise)
    {
        if (this == R01) onR01();
        else if (this == R02) onR02();
        else if (this == R03) onR03();
        else if (this == R04) onR04();
        else if (this == R05) onR05();
        else if (this == R06) onR06();
        else if (this == R07) onR07();
        else if (this == R08) onR08();
        else if (this == R09) onR09();
        else if (this == R10) onR10();
        else if (this == R11) onR11();
        else if (this == R12) onR12();
        else if (this == R13) onR13();
        else if (this == R14) onR14();
        else if (this == R15) onR15();
        else if (this == R16) onR16();
        else if (this == R17) onR17();
        else if (this == R18) onR18();
        else if (this == R19) onR19();
        else if (this == R20) onR20();
        else if (this == R21) onR21();
        else if (this == R22) onR22();
        else if (this == R23) onR23();
        else if (this == R24) onR24();
        else if (this == R25) onR25();
        else if (this == R26) onR26();
        else if (this == R27) onR27();
        else if (this == R28) onR28();
        else if (this == R29) onR29();
        else if (this == R30) onR30();
        else if (this == R31) onR31();
        else if (this == R32) onR32();
        else if (this == R33) onR33();
        else if (this == R34) onR34();
        else if (this == R35) onR35();
        else if (this == R36) onR36();
        else if (this == R37) onR37();
        else if (this == R38) onR38();
        else if (this == R39) onR39();
        else if (this == R40) onR40();
        else if (this == R41) onR41();
        else if (this == R42) onR42();
        else if (this == R43) onR43();
        else if (this == R44) onR44();
        else if (this == R45) onR45();
        else if (this == R46) onR46();
        else if (this == R47) onR47();
        else if (this == R50) onR50();
        else if (this == R51) onR51();
        else if (this == R52) onR52();
        else if (this == R53) onR53();
        else if (this == R61) onR61();
        else if (this == R62) onR62();
        else if (this == R63) onR63();
        else if (this == R64) onR64();
        else if (this == R65) onR65();
        else if (this == R66) onR66();
        else if (this == R67) onR67();
        else if (this == R68) onR68();
        else if (this == R69) onR69();
        else if (this == R70) onR70();
        else if (this == R71) onR71();
        else if (this == R72) onR72();
        else if (this == R73) onR73();
        else if (this == R74) onR74();
        else if (this == R75) onR75();
        else if (this == R76) onR76();
        else if (this == R80) onR80();
        else if (this == R81) onR81();
        else if (this == R82) onR82();
        else if (this == R83) onR83();
        else if (this == R84) onR84();
        else if (this == R94) onR94();
        else if (this == R95) onR95();
        else if (this == R97) onR97();
        else if (this == R98) onR98();
        else if (this == R99) onR99();
        else if (this == C01) onC01();
        else if (this == C02) onC02();
        else if (this == C03) onC03();
        else if (this == C04) onC04();
        else if (this == C05) onC05();
        else if (this == C06) onC06();
        else if (this == C07) onC07();
        else if (this == C08) onC08();
        else if (this == C09) onC09();
        else if (this == C10) onC10();
        else if (this == C11) onC11();
        else if (this == C12) onC12();
        else if (this == C13) onC13();
        else if (this == C61) onC61();
        else if (this == C62) onC62();
        else if (this == C63) onC63();
        else if (this == C64) onC64();
        else if (this == C65) onC65();
        else if (this == C66) onC66();
        else if (this == C67) onC67();
        else if (this == C68) onC68();
        else if (this == C69) onC69();
        else if (this == R90007) onR90007();
        else if (this == R90008) onR90008();
        else if (this == R90016) onR90016();
        else if (this == R90017) onR90017();
        else if (this == R900D2) onR900D2();
        else if (this == R900E1) onR900E1();
        else if (this == R900L2) onR900L2();
        else if (this == R900L3) onR900L3();
        else if (this == R900M1) onR900M1();
        else if (this == R901) onR901();
        else if (this == R902) onR902();
        else if (this == R903) onR903();
        else if (this == R904) onR904();
        else if (this == R905) onR905();
        else if (this == R907) onR907();
        else if (this == R908) onR908();
        else if (this == R909) onR909();
        else if (this == R910) onR910();
        else if (this == R911) onR911();
        else if (this == R912) onR912();
        else if (this == R914) onR914();
        else if (this == R915) onR915();
        else if (this == R916) onR916();
        else if (this == R917) onR917();
        else if (this == R918) onR918();
        else if (this == R919) onR919();
        else if (this == R920) onR920();
        else if (this == R921) onR921();
        else if (this == R922) onR922();
        else if (this == R990) onR990();
        else otherwise(Value);
    }
}
