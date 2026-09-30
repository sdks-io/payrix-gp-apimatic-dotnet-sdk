using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<AlertTriggerResource>))]
public sealed record AlertTriggerResource : OpenIntEnum<AlertTriggerResource>
{
    private AlertTriggerResource(long value) : base(value)
    {
    }

    public static readonly AlertTriggerResource Value1 = new(1L);

    public static readonly AlertTriggerResource Value2 = new(2L);

    public static readonly AlertTriggerResource Value3 = new(3L);

    public static readonly AlertTriggerResource Value4 = new(4L);

    public static readonly AlertTriggerResource Value5 = new(5L);

    public static readonly AlertTriggerResource Value6 = new(6L);

    public static readonly AlertTriggerResource Value7 = new(7L);

    public static readonly AlertTriggerResource Value8 = new(8L);

    public static readonly AlertTriggerResource Value9 = new(9L);

    public static readonly AlertTriggerResource Value10 = new(10L);

    public static readonly AlertTriggerResource Value12 = new(12L);

    public static readonly AlertTriggerResource Value13 = new(13L);

    public static readonly AlertTriggerResource Value14 = new(14L);

    public static readonly AlertTriggerResource Value15 = new(15L);

    public static readonly AlertTriggerResource Value16 = new(16L);

    public static readonly AlertTriggerResource Value17 = new(17L);

    public static readonly AlertTriggerResource Value18 = new(18L);

    public static readonly AlertTriggerResource Value19 = new(19L);

    public static readonly AlertTriggerResource Value20 = new(20L);

    public static readonly AlertTriggerResource Value21 = new(21L);

    public static readonly AlertTriggerResource Value22 = new(22L);

    public static readonly AlertTriggerResource Value23 = new(23L);

    public static readonly AlertTriggerResource Value24 = new(24L);

    public static readonly AlertTriggerResource Value25 = new(25L);

    public static readonly AlertTriggerResource Value26 = new(26L);

    public static readonly AlertTriggerResource Value28 = new(28L);

    public static readonly AlertTriggerResource Value29 = new(29L);

    public static readonly AlertTriggerResource Value30 = new(30L);

    public static readonly AlertTriggerResource Value31 = new(31L);

    public static readonly AlertTriggerResource Value32 = new(32L);

    public static readonly AlertTriggerResource Value33 = new(33L);

    public static readonly AlertTriggerResource Value34 = new(34L);

    public static readonly AlertTriggerResource Value35 = new(35L);

    public static readonly AlertTriggerResource Value36 = new(36L);

    public static readonly AlertTriggerResource Value37 = new(37L);

    public static readonly AlertTriggerResource Value38 = new(38L);

    public static readonly AlertTriggerResource Value39 = new(39L);

    public static readonly AlertTriggerResource Value40 = new(40L);

    public static readonly AlertTriggerResource Value41 = new(41L);

    public static readonly AlertTriggerResource Value42 = new(42L);

    public static readonly AlertTriggerResource Value43 = new(43L);

    public static readonly AlertTriggerResource Value44 = new(44L);

    public static readonly AlertTriggerResource Value45 = new(45L);

    public static readonly AlertTriggerResource Value46 = new(46L);

    public static readonly AlertTriggerResource Value47 = new(47L);

    public static readonly AlertTriggerResource Value48 = new(48L);

    public static readonly AlertTriggerResource Value49 = new(49L);

    public static readonly AlertTriggerResource Value50 = new(50L);

    public static readonly AlertTriggerResource Value53 = new(53L);

    public static readonly AlertTriggerResource Value54 = new(54L);

    public static readonly AlertTriggerResource Value55 = new(55L);

    public static readonly AlertTriggerResource Value56 = new(56L);

    public static readonly AlertTriggerResource Value59 = new(59L);

    public static readonly AlertTriggerResource Value60 = new(60L);

    public static readonly AlertTriggerResource Value61 = new(61L);

    public static readonly AlertTriggerResource Value62 = new(62L);

    public static readonly AlertTriggerResource Value63 = new(63L);

    public static readonly AlertTriggerResource Value64 = new(64L);

    public static readonly AlertTriggerResource Value65 = new(65L);

    public static readonly AlertTriggerResource Value66 = new(66L);

    public static readonly AlertTriggerResource Value67 = new(67L);

    public static readonly AlertTriggerResource Value68 = new(68L);

    public static readonly AlertTriggerResource Value69 = new(69L);

    public static readonly AlertTriggerResource Value70 = new(70L);

    public static readonly AlertTriggerResource Value71 = new(71L);

    public static readonly AlertTriggerResource Value72 = new(72L);

    public static readonly AlertTriggerResource Value74 = new(74L);

    public static readonly AlertTriggerResource Value75 = new(75L);

    public static readonly AlertTriggerResource Value76 = new(76L);

    public static readonly AlertTriggerResource Value77 = new(77L);

    public static readonly AlertTriggerResource Value78 = new(78L);

    public static readonly AlertTriggerResource Value79 = new(79L);

    public static readonly AlertTriggerResource Value80 = new(80L);

    public static readonly AlertTriggerResource Value81 = new(81L);

    public static readonly AlertTriggerResource Value82 = new(82L);

    public static readonly AlertTriggerResource Value83 = new(83L);

    public static readonly AlertTriggerResource Value84 = new(84L);

    public static readonly AlertTriggerResource Value85 = new(85L);

    public static readonly AlertTriggerResource Value86 = new(86L);

    public static readonly AlertTriggerResource Value87 = new(87L);

    public static readonly AlertTriggerResource Value88 = new(88L);

    public static readonly AlertTriggerResource Value89 = new(89L);

    public static readonly AlertTriggerResource Value90 = new(90L);

    public static readonly AlertTriggerResource Value91 = new(91L);

    public static readonly AlertTriggerResource Value92 = new(92L);

    public static readonly AlertTriggerResource Value93 = new(93L);

    public static readonly AlertTriggerResource Value94 = new(94L);

    public static readonly AlertTriggerResource Value95 = new(95L);

    public static readonly AlertTriggerResource Value96 = new(96L);

    public static readonly AlertTriggerResource Value97 = new(97L);

    public static readonly AlertTriggerResource Value98 = new(98L);

    public static readonly AlertTriggerResource Value99 = new(99L);

    public static readonly AlertTriggerResource Value100 = new(100L);

    public static readonly AlertTriggerResource Value101 = new(101L);

    public static readonly AlertTriggerResource Value102 = new(102L);

    public static readonly AlertTriggerResource Value103 = new(103L);

    public static readonly AlertTriggerResource Value104 = new(104L);

    public static readonly AlertTriggerResource Value105 = new(105L);

    public static readonly AlertTriggerResource Value106 = new(106L);

    public static readonly AlertTriggerResource Value107 = new(107L);

    public static readonly AlertTriggerResource Value108 = new(108L);

    public static readonly AlertTriggerResource Value109 = new(109L);

    public static readonly AlertTriggerResource Value110 = new(110L);

    public static readonly AlertTriggerResource Value111 = new(111L);

    public static readonly AlertTriggerResource Value112 = new(112L);

    public static readonly AlertTriggerResource Value113 = new(113L);

    public static readonly AlertTriggerResource Value114 = new(114L);

    public static readonly AlertTriggerResource Value115 = new(115L);

    public static readonly AlertTriggerResource Value117 = new(117L);

    public static readonly AlertTriggerResource Value118 = new(118L);

    public static readonly AlertTriggerResource Value119 = new(119L);

    public static readonly AlertTriggerResource Value120 = new(120L);

    public static readonly AlertTriggerResource Value121 = new(121L);

    public static readonly AlertTriggerResource Value122 = new(122L);

    public static readonly AlertTriggerResource Value123 = new(123L);

    public static readonly AlertTriggerResource Value124 = new(124L);

    public static readonly AlertTriggerResource Value125 = new(125L);

    public static readonly AlertTriggerResource Value127 = new(127L);

    public static readonly AlertTriggerResource Value128 = new(128L);

    public static readonly AlertTriggerResource Value129 = new(129L);

    public static readonly AlertTriggerResource Value130 = new(130L);

    public static readonly AlertTriggerResource Value131 = new(131L);

    public static readonly AlertTriggerResource Value132 = new(132L);

    public static readonly AlertTriggerResource Value133 = new(133L);

    public static readonly AlertTriggerResource Value134 = new(134L);

    public static readonly AlertTriggerResource Value135 = new(135L);

    public static readonly AlertTriggerResource Value136 = new(136L);

    public static readonly AlertTriggerResource Value137 = new(137L);

    public static readonly AlertTriggerResource Value138 = new(138L);

    public static readonly AlertTriggerResource Value139 = new(139L);

    public static readonly AlertTriggerResource Value140 = new(140L);

    public static readonly AlertTriggerResource Value141 = new(141L);

    public static readonly AlertTriggerResource Value142 = new(142L);

    public static readonly AlertTriggerResource Value143 = new(143L);

    public static readonly AlertTriggerResource Value144 = new(144L);

    public static readonly AlertTriggerResource Value145 = new(145L);

    public static readonly AlertTriggerResource Value146 = new(146L);

    public static readonly AlertTriggerResource Value147 = new(147L);

    public static readonly AlertTriggerResource Value148 = new(148L);

    public static readonly AlertTriggerResource Value149 = new(149L);

    public static readonly AlertTriggerResource Value150 = new(150L);

    public static readonly AlertTriggerResource Value151 = new(151L);

    public static readonly AlertTriggerResource Value152 = new(152L);

    public static readonly AlertTriggerResource Value153 = new(153L);

    public static readonly AlertTriggerResource Value154 = new(154L);

    public static readonly AlertTriggerResource Value155 = new(155L);

    public static readonly AlertTriggerResource Value156 = new(156L);

    public static readonly AlertTriggerResource Value157 = new(157L);

    public static readonly AlertTriggerResource Value158 = new(158L);

    public static readonly AlertTriggerResource Value159 = new(159L);

    public static readonly AlertTriggerResource Value160 = new(160L);

    public static readonly AlertTriggerResource Value161 = new(161L);

    public static readonly AlertTriggerResource Value162 = new(162L);

    public static readonly AlertTriggerResource Value163 = new(163L);

    public static readonly AlertTriggerResource Value165 = new(165L);

    public static readonly AlertTriggerResource Value166 = new(166L);

    public static readonly AlertTriggerResource Value167 = new(167L);

    public static readonly AlertTriggerResource Value168 = new(168L);

    public static readonly AlertTriggerResource Value169 = new(169L);

    public static readonly AlertTriggerResource Value170 = new(170L);

    public static readonly AlertTriggerResource Value171 = new(171L);

    public static readonly AlertTriggerResource Value172 = new(172L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
        Func<TResult> onValue7,
        Func<TResult> onValue8,
        Func<TResult> onValue9,
        Func<TResult> onValue10,
        Func<TResult> onValue12,
        Func<TResult> onValue13,
        Func<TResult> onValue14,
        Func<TResult> onValue15,
        Func<TResult> onValue16,
        Func<TResult> onValue17,
        Func<TResult> onValue18,
        Func<TResult> onValue19,
        Func<TResult> onValue20,
        Func<TResult> onValue21,
        Func<TResult> onValue22,
        Func<TResult> onValue23,
        Func<TResult> onValue24,
        Func<TResult> onValue25,
        Func<TResult> onValue26,
        Func<TResult> onValue28,
        Func<TResult> onValue29,
        Func<TResult> onValue30,
        Func<TResult> onValue31,
        Func<TResult> onValue32,
        Func<TResult> onValue33,
        Func<TResult> onValue34,
        Func<TResult> onValue35,
        Func<TResult> onValue36,
        Func<TResult> onValue37,
        Func<TResult> onValue38,
        Func<TResult> onValue39,
        Func<TResult> onValue40,
        Func<TResult> onValue41,
        Func<TResult> onValue42,
        Func<TResult> onValue43,
        Func<TResult> onValue44,
        Func<TResult> onValue45,
        Func<TResult> onValue46,
        Func<TResult> onValue47,
        Func<TResult> onValue48,
        Func<TResult> onValue49,
        Func<TResult> onValue50,
        Func<TResult> onValue53,
        Func<TResult> onValue54,
        Func<TResult> onValue55,
        Func<TResult> onValue56,
        Func<TResult> onValue59,
        Func<TResult> onValue60,
        Func<TResult> onValue61,
        Func<TResult> onValue62,
        Func<TResult> onValue63,
        Func<TResult> onValue64,
        Func<TResult> onValue65,
        Func<TResult> onValue66,
        Func<TResult> onValue67,
        Func<TResult> onValue68,
        Func<TResult> onValue69,
        Func<TResult> onValue70,
        Func<TResult> onValue71,
        Func<TResult> onValue72,
        Func<TResult> onValue74,
        Func<TResult> onValue75,
        Func<TResult> onValue76,
        Func<TResult> onValue77,
        Func<TResult> onValue78,
        Func<TResult> onValue79,
        Func<TResult> onValue80,
        Func<TResult> onValue81,
        Func<TResult> onValue82,
        Func<TResult> onValue83,
        Func<TResult> onValue84,
        Func<TResult> onValue85,
        Func<TResult> onValue86,
        Func<TResult> onValue87,
        Func<TResult> onValue88,
        Func<TResult> onValue89,
        Func<TResult> onValue90,
        Func<TResult> onValue91,
        Func<TResult> onValue92,
        Func<TResult> onValue93,
        Func<TResult> onValue94,
        Func<TResult> onValue95,
        Func<TResult> onValue96,
        Func<TResult> onValue97,
        Func<TResult> onValue98,
        Func<TResult> onValue99,
        Func<TResult> onValue100,
        Func<TResult> onValue101,
        Func<TResult> onValue102,
        Func<TResult> onValue103,
        Func<TResult> onValue104,
        Func<TResult> onValue105,
        Func<TResult> onValue106,
        Func<TResult> onValue107,
        Func<TResult> onValue108,
        Func<TResult> onValue109,
        Func<TResult> onValue110,
        Func<TResult> onValue111,
        Func<TResult> onValue112,
        Func<TResult> onValue113,
        Func<TResult> onValue114,
        Func<TResult> onValue115,
        Func<TResult> onValue117,
        Func<TResult> onValue118,
        Func<TResult> onValue119,
        Func<TResult> onValue120,
        Func<TResult> onValue121,
        Func<TResult> onValue122,
        Func<TResult> onValue123,
        Func<TResult> onValue124,
        Func<TResult> onValue125,
        Func<TResult> onValue127,
        Func<TResult> onValue128,
        Func<TResult> onValue129,
        Func<TResult> onValue130,
        Func<TResult> onValue131,
        Func<TResult> onValue132,
        Func<TResult> onValue133,
        Func<TResult> onValue134,
        Func<TResult> onValue135,
        Func<TResult> onValue136,
        Func<TResult> onValue137,
        Func<TResult> onValue138,
        Func<TResult> onValue139,
        Func<TResult> onValue140,
        Func<TResult> onValue141,
        Func<TResult> onValue142,
        Func<TResult> onValue143,
        Func<TResult> onValue144,
        Func<TResult> onValue145,
        Func<TResult> onValue146,
        Func<TResult> onValue147,
        Func<TResult> onValue148,
        Func<TResult> onValue149,
        Func<TResult> onValue150,
        Func<TResult> onValue151,
        Func<TResult> onValue152,
        Func<TResult> onValue153,
        Func<TResult> onValue154,
        Func<TResult> onValue155,
        Func<TResult> onValue156,
        Func<TResult> onValue157,
        Func<TResult> onValue158,
        Func<TResult> onValue159,
        Func<TResult> onValue160,
        Func<TResult> onValue161,
        Func<TResult> onValue162,
        Func<TResult> onValue163,
        Func<TResult> onValue165,
        Func<TResult> onValue166,
        Func<TResult> onValue167,
        Func<TResult> onValue168,
        Func<TResult> onValue169,
        Func<TResult> onValue170,
        Func<TResult> onValue171,
        Func<TResult> onValue172,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value6 => onValue6(),
            _ when this == Value7 => onValue7(),
            _ when this == Value8 => onValue8(),
            _ when this == Value9 => onValue9(),
            _ when this == Value10 => onValue10(),
            _ when this == Value12 => onValue12(),
            _ when this == Value13 => onValue13(),
            _ when this == Value14 => onValue14(),
            _ when this == Value15 => onValue15(),
            _ when this == Value16 => onValue16(),
            _ when this == Value17 => onValue17(),
            _ when this == Value18 => onValue18(),
            _ when this == Value19 => onValue19(),
            _ when this == Value20 => onValue20(),
            _ when this == Value21 => onValue21(),
            _ when this == Value22 => onValue22(),
            _ when this == Value23 => onValue23(),
            _ when this == Value24 => onValue24(),
            _ when this == Value25 => onValue25(),
            _ when this == Value26 => onValue26(),
            _ when this == Value28 => onValue28(),
            _ when this == Value29 => onValue29(),
            _ when this == Value30 => onValue30(),
            _ when this == Value31 => onValue31(),
            _ when this == Value32 => onValue32(),
            _ when this == Value33 => onValue33(),
            _ when this == Value34 => onValue34(),
            _ when this == Value35 => onValue35(),
            _ when this == Value36 => onValue36(),
            _ when this == Value37 => onValue37(),
            _ when this == Value38 => onValue38(),
            _ when this == Value39 => onValue39(),
            _ when this == Value40 => onValue40(),
            _ when this == Value41 => onValue41(),
            _ when this == Value42 => onValue42(),
            _ when this == Value43 => onValue43(),
            _ when this == Value44 => onValue44(),
            _ when this == Value45 => onValue45(),
            _ when this == Value46 => onValue46(),
            _ when this == Value47 => onValue47(),
            _ when this == Value48 => onValue48(),
            _ when this == Value49 => onValue49(),
            _ when this == Value50 => onValue50(),
            _ when this == Value53 => onValue53(),
            _ when this == Value54 => onValue54(),
            _ when this == Value55 => onValue55(),
            _ when this == Value56 => onValue56(),
            _ when this == Value59 => onValue59(),
            _ when this == Value60 => onValue60(),
            _ when this == Value61 => onValue61(),
            _ when this == Value62 => onValue62(),
            _ when this == Value63 => onValue63(),
            _ when this == Value64 => onValue64(),
            _ when this == Value65 => onValue65(),
            _ when this == Value66 => onValue66(),
            _ when this == Value67 => onValue67(),
            _ when this == Value68 => onValue68(),
            _ when this == Value69 => onValue69(),
            _ when this == Value70 => onValue70(),
            _ when this == Value71 => onValue71(),
            _ when this == Value72 => onValue72(),
            _ when this == Value74 => onValue74(),
            _ when this == Value75 => onValue75(),
            _ when this == Value76 => onValue76(),
            _ when this == Value77 => onValue77(),
            _ when this == Value78 => onValue78(),
            _ when this == Value79 => onValue79(),
            _ when this == Value80 => onValue80(),
            _ when this == Value81 => onValue81(),
            _ when this == Value82 => onValue82(),
            _ when this == Value83 => onValue83(),
            _ when this == Value84 => onValue84(),
            _ when this == Value85 => onValue85(),
            _ when this == Value86 => onValue86(),
            _ when this == Value87 => onValue87(),
            _ when this == Value88 => onValue88(),
            _ when this == Value89 => onValue89(),
            _ when this == Value90 => onValue90(),
            _ when this == Value91 => onValue91(),
            _ when this == Value92 => onValue92(),
            _ when this == Value93 => onValue93(),
            _ when this == Value94 => onValue94(),
            _ when this == Value95 => onValue95(),
            _ when this == Value96 => onValue96(),
            _ when this == Value97 => onValue97(),
            _ when this == Value98 => onValue98(),
            _ when this == Value99 => onValue99(),
            _ when this == Value100 => onValue100(),
            _ when this == Value101 => onValue101(),
            _ when this == Value102 => onValue102(),
            _ when this == Value103 => onValue103(),
            _ when this == Value104 => onValue104(),
            _ when this == Value105 => onValue105(),
            _ when this == Value106 => onValue106(),
            _ when this == Value107 => onValue107(),
            _ when this == Value108 => onValue108(),
            _ when this == Value109 => onValue109(),
            _ when this == Value110 => onValue110(),
            _ when this == Value111 => onValue111(),
            _ when this == Value112 => onValue112(),
            _ when this == Value113 => onValue113(),
            _ when this == Value114 => onValue114(),
            _ when this == Value115 => onValue115(),
            _ when this == Value117 => onValue117(),
            _ when this == Value118 => onValue118(),
            _ when this == Value119 => onValue119(),
            _ when this == Value120 => onValue120(),
            _ when this == Value121 => onValue121(),
            _ when this == Value122 => onValue122(),
            _ when this == Value123 => onValue123(),
            _ when this == Value124 => onValue124(),
            _ when this == Value125 => onValue125(),
            _ when this == Value127 => onValue127(),
            _ when this == Value128 => onValue128(),
            _ when this == Value129 => onValue129(),
            _ when this == Value130 => onValue130(),
            _ when this == Value131 => onValue131(),
            _ when this == Value132 => onValue132(),
            _ when this == Value133 => onValue133(),
            _ when this == Value134 => onValue134(),
            _ when this == Value135 => onValue135(),
            _ when this == Value136 => onValue136(),
            _ when this == Value137 => onValue137(),
            _ when this == Value138 => onValue138(),
            _ when this == Value139 => onValue139(),
            _ when this == Value140 => onValue140(),
            _ when this == Value141 => onValue141(),
            _ when this == Value142 => onValue142(),
            _ when this == Value143 => onValue143(),
            _ when this == Value144 => onValue144(),
            _ when this == Value145 => onValue145(),
            _ when this == Value146 => onValue146(),
            _ when this == Value147 => onValue147(),
            _ when this == Value148 => onValue148(),
            _ when this == Value149 => onValue149(),
            _ when this == Value150 => onValue150(),
            _ when this == Value151 => onValue151(),
            _ when this == Value152 => onValue152(),
            _ when this == Value153 => onValue153(),
            _ when this == Value154 => onValue154(),
            _ when this == Value155 => onValue155(),
            _ when this == Value156 => onValue156(),
            _ when this == Value157 => onValue157(),
            _ when this == Value158 => onValue158(),
            _ when this == Value159 => onValue159(),
            _ when this == Value160 => onValue160(),
            _ when this == Value161 => onValue161(),
            _ when this == Value162 => onValue162(),
            _ when this == Value163 => onValue163(),
            _ when this == Value165 => onValue165(),
            _ when this == Value166 => onValue166(),
            _ when this == Value167 => onValue167(),
            _ when this == Value168 => onValue168(),
            _ when this == Value169 => onValue169(),
            _ when this == Value170 => onValue170(),
            _ when this == Value171 => onValue171(),
            _ when this == Value172 => onValue172(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue6,
        Action onValue7,
        Action onValue8,
        Action onValue9,
        Action onValue10,
        Action onValue12,
        Action onValue13,
        Action onValue14,
        Action onValue15,
        Action onValue16,
        Action onValue17,
        Action onValue18,
        Action onValue19,
        Action onValue20,
        Action onValue21,
        Action onValue22,
        Action onValue23,
        Action onValue24,
        Action onValue25,
        Action onValue26,
        Action onValue28,
        Action onValue29,
        Action onValue30,
        Action onValue31,
        Action onValue32,
        Action onValue33,
        Action onValue34,
        Action onValue35,
        Action onValue36,
        Action onValue37,
        Action onValue38,
        Action onValue39,
        Action onValue40,
        Action onValue41,
        Action onValue42,
        Action onValue43,
        Action onValue44,
        Action onValue45,
        Action onValue46,
        Action onValue47,
        Action onValue48,
        Action onValue49,
        Action onValue50,
        Action onValue53,
        Action onValue54,
        Action onValue55,
        Action onValue56,
        Action onValue59,
        Action onValue60,
        Action onValue61,
        Action onValue62,
        Action onValue63,
        Action onValue64,
        Action onValue65,
        Action onValue66,
        Action onValue67,
        Action onValue68,
        Action onValue69,
        Action onValue70,
        Action onValue71,
        Action onValue72,
        Action onValue74,
        Action onValue75,
        Action onValue76,
        Action onValue77,
        Action onValue78,
        Action onValue79,
        Action onValue80,
        Action onValue81,
        Action onValue82,
        Action onValue83,
        Action onValue84,
        Action onValue85,
        Action onValue86,
        Action onValue87,
        Action onValue88,
        Action onValue89,
        Action onValue90,
        Action onValue91,
        Action onValue92,
        Action onValue93,
        Action onValue94,
        Action onValue95,
        Action onValue96,
        Action onValue97,
        Action onValue98,
        Action onValue99,
        Action onValue100,
        Action onValue101,
        Action onValue102,
        Action onValue103,
        Action onValue104,
        Action onValue105,
        Action onValue106,
        Action onValue107,
        Action onValue108,
        Action onValue109,
        Action onValue110,
        Action onValue111,
        Action onValue112,
        Action onValue113,
        Action onValue114,
        Action onValue115,
        Action onValue117,
        Action onValue118,
        Action onValue119,
        Action onValue120,
        Action onValue121,
        Action onValue122,
        Action onValue123,
        Action onValue124,
        Action onValue125,
        Action onValue127,
        Action onValue128,
        Action onValue129,
        Action onValue130,
        Action onValue131,
        Action onValue132,
        Action onValue133,
        Action onValue134,
        Action onValue135,
        Action onValue136,
        Action onValue137,
        Action onValue138,
        Action onValue139,
        Action onValue140,
        Action onValue141,
        Action onValue142,
        Action onValue143,
        Action onValue144,
        Action onValue145,
        Action onValue146,
        Action onValue147,
        Action onValue148,
        Action onValue149,
        Action onValue150,
        Action onValue151,
        Action onValue152,
        Action onValue153,
        Action onValue154,
        Action onValue155,
        Action onValue156,
        Action onValue157,
        Action onValue158,
        Action onValue159,
        Action onValue160,
        Action onValue161,
        Action onValue162,
        Action onValue163,
        Action onValue165,
        Action onValue166,
        Action onValue167,
        Action onValue168,
        Action onValue169,
        Action onValue170,
        Action onValue171,
        Action onValue172,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value6) onValue6();
        else if (this == Value7) onValue7();
        else if (this == Value8) onValue8();
        else if (this == Value9) onValue9();
        else if (this == Value10) onValue10();
        else if (this == Value12) onValue12();
        else if (this == Value13) onValue13();
        else if (this == Value14) onValue14();
        else if (this == Value15) onValue15();
        else if (this == Value16) onValue16();
        else if (this == Value17) onValue17();
        else if (this == Value18) onValue18();
        else if (this == Value19) onValue19();
        else if (this == Value20) onValue20();
        else if (this == Value21) onValue21();
        else if (this == Value22) onValue22();
        else if (this == Value23) onValue23();
        else if (this == Value24) onValue24();
        else if (this == Value25) onValue25();
        else if (this == Value26) onValue26();
        else if (this == Value28) onValue28();
        else if (this == Value29) onValue29();
        else if (this == Value30) onValue30();
        else if (this == Value31) onValue31();
        else if (this == Value32) onValue32();
        else if (this == Value33) onValue33();
        else if (this == Value34) onValue34();
        else if (this == Value35) onValue35();
        else if (this == Value36) onValue36();
        else if (this == Value37) onValue37();
        else if (this == Value38) onValue38();
        else if (this == Value39) onValue39();
        else if (this == Value40) onValue40();
        else if (this == Value41) onValue41();
        else if (this == Value42) onValue42();
        else if (this == Value43) onValue43();
        else if (this == Value44) onValue44();
        else if (this == Value45) onValue45();
        else if (this == Value46) onValue46();
        else if (this == Value47) onValue47();
        else if (this == Value48) onValue48();
        else if (this == Value49) onValue49();
        else if (this == Value50) onValue50();
        else if (this == Value53) onValue53();
        else if (this == Value54) onValue54();
        else if (this == Value55) onValue55();
        else if (this == Value56) onValue56();
        else if (this == Value59) onValue59();
        else if (this == Value60) onValue60();
        else if (this == Value61) onValue61();
        else if (this == Value62) onValue62();
        else if (this == Value63) onValue63();
        else if (this == Value64) onValue64();
        else if (this == Value65) onValue65();
        else if (this == Value66) onValue66();
        else if (this == Value67) onValue67();
        else if (this == Value68) onValue68();
        else if (this == Value69) onValue69();
        else if (this == Value70) onValue70();
        else if (this == Value71) onValue71();
        else if (this == Value72) onValue72();
        else if (this == Value74) onValue74();
        else if (this == Value75) onValue75();
        else if (this == Value76) onValue76();
        else if (this == Value77) onValue77();
        else if (this == Value78) onValue78();
        else if (this == Value79) onValue79();
        else if (this == Value80) onValue80();
        else if (this == Value81) onValue81();
        else if (this == Value82) onValue82();
        else if (this == Value83) onValue83();
        else if (this == Value84) onValue84();
        else if (this == Value85) onValue85();
        else if (this == Value86) onValue86();
        else if (this == Value87) onValue87();
        else if (this == Value88) onValue88();
        else if (this == Value89) onValue89();
        else if (this == Value90) onValue90();
        else if (this == Value91) onValue91();
        else if (this == Value92) onValue92();
        else if (this == Value93) onValue93();
        else if (this == Value94) onValue94();
        else if (this == Value95) onValue95();
        else if (this == Value96) onValue96();
        else if (this == Value97) onValue97();
        else if (this == Value98) onValue98();
        else if (this == Value99) onValue99();
        else if (this == Value100) onValue100();
        else if (this == Value101) onValue101();
        else if (this == Value102) onValue102();
        else if (this == Value103) onValue103();
        else if (this == Value104) onValue104();
        else if (this == Value105) onValue105();
        else if (this == Value106) onValue106();
        else if (this == Value107) onValue107();
        else if (this == Value108) onValue108();
        else if (this == Value109) onValue109();
        else if (this == Value110) onValue110();
        else if (this == Value111) onValue111();
        else if (this == Value112) onValue112();
        else if (this == Value113) onValue113();
        else if (this == Value114) onValue114();
        else if (this == Value115) onValue115();
        else if (this == Value117) onValue117();
        else if (this == Value118) onValue118();
        else if (this == Value119) onValue119();
        else if (this == Value120) onValue120();
        else if (this == Value121) onValue121();
        else if (this == Value122) onValue122();
        else if (this == Value123) onValue123();
        else if (this == Value124) onValue124();
        else if (this == Value125) onValue125();
        else if (this == Value127) onValue127();
        else if (this == Value128) onValue128();
        else if (this == Value129) onValue129();
        else if (this == Value130) onValue130();
        else if (this == Value131) onValue131();
        else if (this == Value132) onValue132();
        else if (this == Value133) onValue133();
        else if (this == Value134) onValue134();
        else if (this == Value135) onValue135();
        else if (this == Value136) onValue136();
        else if (this == Value137) onValue137();
        else if (this == Value138) onValue138();
        else if (this == Value139) onValue139();
        else if (this == Value140) onValue140();
        else if (this == Value141) onValue141();
        else if (this == Value142) onValue142();
        else if (this == Value143) onValue143();
        else if (this == Value144) onValue144();
        else if (this == Value145) onValue145();
        else if (this == Value146) onValue146();
        else if (this == Value147) onValue147();
        else if (this == Value148) onValue148();
        else if (this == Value149) onValue149();
        else if (this == Value150) onValue150();
        else if (this == Value151) onValue151();
        else if (this == Value152) onValue152();
        else if (this == Value153) onValue153();
        else if (this == Value154) onValue154();
        else if (this == Value155) onValue155();
        else if (this == Value156) onValue156();
        else if (this == Value157) onValue157();
        else if (this == Value158) onValue158();
        else if (this == Value159) onValue159();
        else if (this == Value160) onValue160();
        else if (this == Value161) onValue161();
        else if (this == Value162) onValue162();
        else if (this == Value163) onValue163();
        else if (this == Value165) onValue165();
        else if (this == Value166) onValue166();
        else if (this == Value167) onValue167();
        else if (this == Value168) onValue168();
        else if (this == Value169) onValue169();
        else if (this == Value170) onValue170();
        else if (this == Value171) onValue171();
        else if (this == Value172) onValue172();
        else otherwise(Value);
    }
}
