using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<FeeSchedule>))]
public sealed record FeeSchedule : OpenIntEnum<FeeSchedule>
{
    private FeeSchedule(long value) : base(value)
    {
    }

    public static readonly FeeSchedule Value1 = new(1L);

    public static readonly FeeSchedule Value2 = new(2L);

    public static readonly FeeSchedule Value3 = new(3L);

    public static readonly FeeSchedule Value4 = new(4L);

    public static readonly FeeSchedule Value5 = new(5L);

    public static readonly FeeSchedule Value6 = new(6L);

    public static readonly FeeSchedule Value7 = new(7L);

    public static readonly FeeSchedule Value8 = new(8L);

    public static readonly FeeSchedule Value9 = new(9L);

    public static readonly FeeSchedule Value10 = new(10L);

    public static readonly FeeSchedule Value11 = new(11L);

    public static readonly FeeSchedule Value12 = new(12L);

    public static readonly FeeSchedule Value13 = new(13L);

    public static readonly FeeSchedule Value14 = new(14L);

    public static readonly FeeSchedule Value15 = new(15L);

    public static readonly FeeSchedule Value16 = new(16L);

    public static readonly FeeSchedule Value17 = new(17L);

    public static readonly FeeSchedule Value18 = new(18L);

    public static readonly FeeSchedule Value19 = new(19L);

    public static readonly FeeSchedule Value20 = new(20L);

    public static readonly FeeSchedule Value21 = new(21L);

    public static readonly FeeSchedule Value22 = new(22L);

    public static readonly FeeSchedule Value23 = new(23L);

    public static readonly FeeSchedule Value24 = new(24L);

    public static readonly FeeSchedule Value25 = new(25L);

    public static readonly FeeSchedule Value26 = new(26L);

    public static readonly FeeSchedule Value27 = new(27L);

    public static readonly FeeSchedule Value28 = new(28L);

    public static readonly FeeSchedule Value29 = new(29L);

    public static readonly FeeSchedule Value30 = new(30L);

    public static readonly FeeSchedule Value31 = new(31L);

    public static readonly FeeSchedule Value32 = new(32L);

    public static readonly FeeSchedule Value33 = new(33L);

    public static readonly FeeSchedule Value34 = new(34L);

    public static readonly FeeSchedule Value35 = new(35L);

    public static readonly FeeSchedule Value43 = new(43L);

    public static readonly FeeSchedule Value44 = new(44L);

    public static readonly FeeSchedule Value45 = new(45L);

    public static readonly FeeSchedule Value46 = new(46L);

    public static readonly FeeSchedule Value47 = new(47L);

    public static readonly FeeSchedule Value51 = new(51L);

    public static readonly FeeSchedule Value52 = new(52L);

    public static readonly FeeSchedule Value53 = new(53L);

    public static readonly FeeSchedule Value54 = new(54L);

    public static readonly FeeSchedule Value55 = new(55L);

    public static readonly FeeSchedule Value56 = new(56L);

    public static readonly FeeSchedule Value57 = new(57L);

    public static readonly FeeSchedule Value58 = new(58L);

    public static readonly FeeSchedule Value59 = new(59L);

    public static readonly FeeSchedule Value60 = new(60L);

    public static readonly FeeSchedule Value61 = new(61L);

    public static readonly FeeSchedule Value62 = new(62L);

    public static readonly FeeSchedule Value63 = new(63L);

    public static readonly FeeSchedule Value64 = new(64L);

    public static readonly FeeSchedule Value65 = new(65L);

    public static readonly FeeSchedule Value66 = new(66L);

    public static readonly FeeSchedule Value67 = new(67L);

    public static readonly FeeSchedule Value68 = new(68L);

    public static readonly FeeSchedule Value69 = new(69L);

    public static readonly FeeSchedule Value70 = new(70L);

    public static readonly FeeSchedule Value71 = new(71L);

    public static readonly FeeSchedule Value72 = new(72L);

    public static readonly FeeSchedule Value73 = new(73L);

    public static readonly FeeSchedule Value74 = new(74L);

    public static readonly FeeSchedule Value75 = new(75L);

    public static readonly FeeSchedule Value76 = new(76L);

    public static readonly FeeSchedule Value77 = new(77L);

    public static readonly FeeSchedule Value78 = new(78L);

    public static readonly FeeSchedule Value79 = new(79L);

    public static readonly FeeSchedule Value80 = new(80L);

    public static readonly FeeSchedule Value81 = new(81L);

    public static readonly FeeSchedule Value82 = new(82L);

    public static readonly FeeSchedule Value83 = new(83L);

    public static readonly FeeSchedule Value84 = new(84L);

    public static readonly FeeSchedule Value85 = new(85L);

    public static readonly FeeSchedule Value86 = new(86L);

    public static readonly FeeSchedule Value88 = new(88L);

    public static readonly FeeSchedule Value89 = new(89L);

    public static readonly FeeSchedule Value90 = new(90L);

    public static readonly FeeSchedule Value91 = new(91L);

    public static readonly FeeSchedule Value92 = new(92L);

    public static readonly FeeSchedule Value93 = new(93L);

    public static readonly FeeSchedule Value96 = new(96L);

    public static readonly FeeSchedule Value200 = new(200L);

    public static readonly FeeSchedule Value201 = new(201L);

    public static readonly FeeSchedule Value202 = new(202L);

    public static readonly FeeSchedule Value203 = new(203L);

    public static readonly FeeSchedule Value204 = new(204L);

    public static readonly FeeSchedule Value205 = new(205L);

    public static readonly FeeSchedule Value206 = new(206L);

    public static readonly FeeSchedule Value207 = new(207L);

    public static readonly FeeSchedule Value208 = new(208L);

    public static readonly FeeSchedule Value209 = new(209L);

    public static readonly FeeSchedule Value210 = new(210L);

    public static readonly FeeSchedule Value211 = new(211L);

    public static readonly FeeSchedule Value212 = new(212L);

    public static readonly FeeSchedule Value213 = new(213L);

    public static readonly FeeSchedule Value214 = new(214L);

    public static readonly FeeSchedule Value215 = new(215L);

    public static readonly FeeSchedule Value216 = new(216L);

    public static readonly FeeSchedule Value217 = new(217L);

    public static readonly FeeSchedule Value218 = new(218L);

    public static readonly FeeSchedule Value230 = new(230L);

    public static readonly FeeSchedule Value231 = new(231L);

    public static readonly FeeSchedule Value232 = new(232L);

    public static readonly FeeSchedule Value233 = new(233L);

    public static readonly FeeSchedule Value234 = new(234L);

    public static readonly FeeSchedule Value235 = new(235L);

    public static readonly FeeSchedule Value236 = new(236L);

    public static readonly FeeSchedule Value237 = new(237L);

    public static readonly FeeSchedule Value238 = new(238L);

    public static readonly FeeSchedule Value239 = new(239L);

    public static readonly FeeSchedule Value240 = new(240L);

    public static readonly FeeSchedule Value241 = new(241L);

    public static readonly FeeSchedule Value242 = new(242L);

    public static readonly FeeSchedule Value243 = new(243L);

    public static readonly FeeSchedule Value244 = new(244L);

    public static readonly FeeSchedule Value245 = new(245L);

    public static readonly FeeSchedule Value246 = new(246L);

    public static readonly FeeSchedule Value247 = new(247L);

    public static readonly FeeSchedule Value248 = new(248L);

    public static readonly FeeSchedule Value249 = new(249L);

    public static readonly FeeSchedule Value250 = new(250L);

    public static readonly FeeSchedule Value251 = new(251L);

    public static readonly FeeSchedule Value252 = new(252L);

    public static readonly FeeSchedule Value253 = new(253L);

    public static readonly FeeSchedule Value254 = new(254L);

    public static readonly FeeSchedule Value255 = new(255L);

    public static readonly FeeSchedule Value256 = new(256L);

    public static readonly FeeSchedule Value257 = new(257L);

    public static readonly FeeSchedule Value258 = new(258L);

    public static readonly FeeSchedule Value259 = new(259L);

    public static readonly FeeSchedule Value260 = new(260L);

    public static readonly FeeSchedule Value261 = new(261L);

    public static readonly FeeSchedule Value262 = new(262L);

    public static readonly FeeSchedule Value263 = new(263L);

    public static readonly FeeSchedule Value264 = new(264L);

    public static readonly FeeSchedule Value265 = new(265L);

    public static readonly FeeSchedule Value266 = new(266L);

    public static readonly FeeSchedule Value267 = new(267L);

    public static readonly FeeSchedule Value268 = new(268L);

    public static readonly FeeSchedule Value269 = new(269L);

    public static readonly FeeSchedule Value270 = new(270L);

    public static readonly FeeSchedule Value271 = new(271L);

    public static readonly FeeSchedule Value272 = new(272L);

    public static readonly FeeSchedule Value273 = new(273L);

    public static readonly FeeSchedule Value274 = new(274L);

    public static readonly FeeSchedule Value275 = new(275L);

    public static readonly FeeSchedule Value276 = new(276L);

    public static readonly FeeSchedule Value277 = new(277L);

    public static readonly FeeSchedule Value278 = new(278L);

    public static readonly FeeSchedule Value279 = new(279L);

    public static readonly FeeSchedule Value280 = new(280L);

    public static readonly FeeSchedule Value281 = new(281L);

    public static readonly FeeSchedule Value282 = new(282L);

    public static readonly FeeSchedule Value283 = new(283L);

    public static readonly FeeSchedule Value284 = new(284L);

    public static readonly FeeSchedule Value400 = new(400L);

    public static readonly FeeSchedule Value401 = new(401L);

    public static readonly FeeSchedule Value402 = new(402L);

    public static readonly FeeSchedule Value403 = new(403L);

    public static readonly FeeSchedule Value404 = new(404L);

    public static readonly FeeSchedule Value405 = new(405L);

    public static readonly FeeSchedule Value406 = new(406L);

    public static readonly FeeSchedule Value407 = new(407L);

    public static readonly FeeSchedule Value408 = new(408L);

    public static readonly FeeSchedule Value409 = new(409L);

    public static readonly FeeSchedule Value410 = new(410L);

    public static readonly FeeSchedule Value601 = new(601L);

    public static readonly FeeSchedule Value602 = new(602L);

    public static readonly FeeSchedule Value603 = new(603L);

    public static readonly FeeSchedule Value604 = new(604L);

    public static readonly FeeSchedule Value605 = new(605L);

    public static readonly FeeSchedule Value606 = new(606L);

    public static readonly FeeSchedule Value607 = new(607L);

    public static readonly FeeSchedule Value608 = new(608L);

    public static readonly FeeSchedule Value701 = new(701L);

    public static readonly FeeSchedule Value702 = new(702L);

    public static readonly FeeSchedule Value703 = new(703L);

    public static readonly FeeSchedule Value704 = new(704L);

    public static readonly FeeSchedule Value705 = new(705L);

    public static readonly FeeSchedule Value801 = new(801L);

    public static readonly FeeSchedule Value802 = new(802L);

    public static readonly FeeSchedule Value803 = new(803L);

    public static readonly FeeSchedule Value804 = new(804L);

    public static readonly FeeSchedule Value805 = new(805L);

    public static readonly FeeSchedule Value806 = new(806L);

    public static readonly FeeSchedule Value807 = new(807L);

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
        Func<TResult> onValue11,
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
        Func<TResult> onValue27,
        Func<TResult> onValue28,
        Func<TResult> onValue29,
        Func<TResult> onValue30,
        Func<TResult> onValue31,
        Func<TResult> onValue32,
        Func<TResult> onValue33,
        Func<TResult> onValue34,
        Func<TResult> onValue35,
        Func<TResult> onValue43,
        Func<TResult> onValue44,
        Func<TResult> onValue45,
        Func<TResult> onValue46,
        Func<TResult> onValue47,
        Func<TResult> onValue51,
        Func<TResult> onValue52,
        Func<TResult> onValue53,
        Func<TResult> onValue54,
        Func<TResult> onValue55,
        Func<TResult> onValue56,
        Func<TResult> onValue57,
        Func<TResult> onValue58,
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
        Func<TResult> onValue73,
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
        Func<TResult> onValue88,
        Func<TResult> onValue89,
        Func<TResult> onValue90,
        Func<TResult> onValue91,
        Func<TResult> onValue92,
        Func<TResult> onValue93,
        Func<TResult> onValue96,
        Func<TResult> onValue200,
        Func<TResult> onValue201,
        Func<TResult> onValue202,
        Func<TResult> onValue203,
        Func<TResult> onValue204,
        Func<TResult> onValue205,
        Func<TResult> onValue206,
        Func<TResult> onValue207,
        Func<TResult> onValue208,
        Func<TResult> onValue209,
        Func<TResult> onValue210,
        Func<TResult> onValue211,
        Func<TResult> onValue212,
        Func<TResult> onValue213,
        Func<TResult> onValue214,
        Func<TResult> onValue215,
        Func<TResult> onValue216,
        Func<TResult> onValue217,
        Func<TResult> onValue218,
        Func<TResult> onValue230,
        Func<TResult> onValue231,
        Func<TResult> onValue232,
        Func<TResult> onValue233,
        Func<TResult> onValue234,
        Func<TResult> onValue235,
        Func<TResult> onValue236,
        Func<TResult> onValue237,
        Func<TResult> onValue238,
        Func<TResult> onValue239,
        Func<TResult> onValue240,
        Func<TResult> onValue241,
        Func<TResult> onValue242,
        Func<TResult> onValue243,
        Func<TResult> onValue244,
        Func<TResult> onValue245,
        Func<TResult> onValue246,
        Func<TResult> onValue247,
        Func<TResult> onValue248,
        Func<TResult> onValue249,
        Func<TResult> onValue250,
        Func<TResult> onValue251,
        Func<TResult> onValue252,
        Func<TResult> onValue253,
        Func<TResult> onValue254,
        Func<TResult> onValue255,
        Func<TResult> onValue256,
        Func<TResult> onValue257,
        Func<TResult> onValue258,
        Func<TResult> onValue259,
        Func<TResult> onValue260,
        Func<TResult> onValue261,
        Func<TResult> onValue262,
        Func<TResult> onValue263,
        Func<TResult> onValue264,
        Func<TResult> onValue265,
        Func<TResult> onValue266,
        Func<TResult> onValue267,
        Func<TResult> onValue268,
        Func<TResult> onValue269,
        Func<TResult> onValue270,
        Func<TResult> onValue271,
        Func<TResult> onValue272,
        Func<TResult> onValue273,
        Func<TResult> onValue274,
        Func<TResult> onValue275,
        Func<TResult> onValue276,
        Func<TResult> onValue277,
        Func<TResult> onValue278,
        Func<TResult> onValue279,
        Func<TResult> onValue280,
        Func<TResult> onValue281,
        Func<TResult> onValue282,
        Func<TResult> onValue283,
        Func<TResult> onValue284,
        Func<TResult> onValue400,
        Func<TResult> onValue401,
        Func<TResult> onValue402,
        Func<TResult> onValue403,
        Func<TResult> onValue404,
        Func<TResult> onValue405,
        Func<TResult> onValue406,
        Func<TResult> onValue407,
        Func<TResult> onValue408,
        Func<TResult> onValue409,
        Func<TResult> onValue410,
        Func<TResult> onValue601,
        Func<TResult> onValue602,
        Func<TResult> onValue603,
        Func<TResult> onValue604,
        Func<TResult> onValue605,
        Func<TResult> onValue606,
        Func<TResult> onValue607,
        Func<TResult> onValue608,
        Func<TResult> onValue701,
        Func<TResult> onValue702,
        Func<TResult> onValue703,
        Func<TResult> onValue704,
        Func<TResult> onValue705,
        Func<TResult> onValue801,
        Func<TResult> onValue802,
        Func<TResult> onValue803,
        Func<TResult> onValue804,
        Func<TResult> onValue805,
        Func<TResult> onValue806,
        Func<TResult> onValue807,
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
            _ when this == Value11 => onValue11(),
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
            _ when this == Value27 => onValue27(),
            _ when this == Value28 => onValue28(),
            _ when this == Value29 => onValue29(),
            _ when this == Value30 => onValue30(),
            _ when this == Value31 => onValue31(),
            _ when this == Value32 => onValue32(),
            _ when this == Value33 => onValue33(),
            _ when this == Value34 => onValue34(),
            _ when this == Value35 => onValue35(),
            _ when this == Value43 => onValue43(),
            _ when this == Value44 => onValue44(),
            _ when this == Value45 => onValue45(),
            _ when this == Value46 => onValue46(),
            _ when this == Value47 => onValue47(),
            _ when this == Value51 => onValue51(),
            _ when this == Value52 => onValue52(),
            _ when this == Value53 => onValue53(),
            _ when this == Value54 => onValue54(),
            _ when this == Value55 => onValue55(),
            _ when this == Value56 => onValue56(),
            _ when this == Value57 => onValue57(),
            _ when this == Value58 => onValue58(),
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
            _ when this == Value73 => onValue73(),
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
            _ when this == Value88 => onValue88(),
            _ when this == Value89 => onValue89(),
            _ when this == Value90 => onValue90(),
            _ when this == Value91 => onValue91(),
            _ when this == Value92 => onValue92(),
            _ when this == Value93 => onValue93(),
            _ when this == Value96 => onValue96(),
            _ when this == Value200 => onValue200(),
            _ when this == Value201 => onValue201(),
            _ when this == Value202 => onValue202(),
            _ when this == Value203 => onValue203(),
            _ when this == Value204 => onValue204(),
            _ when this == Value205 => onValue205(),
            _ when this == Value206 => onValue206(),
            _ when this == Value207 => onValue207(),
            _ when this == Value208 => onValue208(),
            _ when this == Value209 => onValue209(),
            _ when this == Value210 => onValue210(),
            _ when this == Value211 => onValue211(),
            _ when this == Value212 => onValue212(),
            _ when this == Value213 => onValue213(),
            _ when this == Value214 => onValue214(),
            _ when this == Value215 => onValue215(),
            _ when this == Value216 => onValue216(),
            _ when this == Value217 => onValue217(),
            _ when this == Value218 => onValue218(),
            _ when this == Value230 => onValue230(),
            _ when this == Value231 => onValue231(),
            _ when this == Value232 => onValue232(),
            _ when this == Value233 => onValue233(),
            _ when this == Value234 => onValue234(),
            _ when this == Value235 => onValue235(),
            _ when this == Value236 => onValue236(),
            _ when this == Value237 => onValue237(),
            _ when this == Value238 => onValue238(),
            _ when this == Value239 => onValue239(),
            _ when this == Value240 => onValue240(),
            _ when this == Value241 => onValue241(),
            _ when this == Value242 => onValue242(),
            _ when this == Value243 => onValue243(),
            _ when this == Value244 => onValue244(),
            _ when this == Value245 => onValue245(),
            _ when this == Value246 => onValue246(),
            _ when this == Value247 => onValue247(),
            _ when this == Value248 => onValue248(),
            _ when this == Value249 => onValue249(),
            _ when this == Value250 => onValue250(),
            _ when this == Value251 => onValue251(),
            _ when this == Value252 => onValue252(),
            _ when this == Value253 => onValue253(),
            _ when this == Value254 => onValue254(),
            _ when this == Value255 => onValue255(),
            _ when this == Value256 => onValue256(),
            _ when this == Value257 => onValue257(),
            _ when this == Value258 => onValue258(),
            _ when this == Value259 => onValue259(),
            _ when this == Value260 => onValue260(),
            _ when this == Value261 => onValue261(),
            _ when this == Value262 => onValue262(),
            _ when this == Value263 => onValue263(),
            _ when this == Value264 => onValue264(),
            _ when this == Value265 => onValue265(),
            _ when this == Value266 => onValue266(),
            _ when this == Value267 => onValue267(),
            _ when this == Value268 => onValue268(),
            _ when this == Value269 => onValue269(),
            _ when this == Value270 => onValue270(),
            _ when this == Value271 => onValue271(),
            _ when this == Value272 => onValue272(),
            _ when this == Value273 => onValue273(),
            _ when this == Value274 => onValue274(),
            _ when this == Value275 => onValue275(),
            _ when this == Value276 => onValue276(),
            _ when this == Value277 => onValue277(),
            _ when this == Value278 => onValue278(),
            _ when this == Value279 => onValue279(),
            _ when this == Value280 => onValue280(),
            _ when this == Value281 => onValue281(),
            _ when this == Value282 => onValue282(),
            _ when this == Value283 => onValue283(),
            _ when this == Value284 => onValue284(),
            _ when this == Value400 => onValue400(),
            _ when this == Value401 => onValue401(),
            _ when this == Value402 => onValue402(),
            _ when this == Value403 => onValue403(),
            _ when this == Value404 => onValue404(),
            _ when this == Value405 => onValue405(),
            _ when this == Value406 => onValue406(),
            _ when this == Value407 => onValue407(),
            _ when this == Value408 => onValue408(),
            _ when this == Value409 => onValue409(),
            _ when this == Value410 => onValue410(),
            _ when this == Value601 => onValue601(),
            _ when this == Value602 => onValue602(),
            _ when this == Value603 => onValue603(),
            _ when this == Value604 => onValue604(),
            _ when this == Value605 => onValue605(),
            _ when this == Value606 => onValue606(),
            _ when this == Value607 => onValue607(),
            _ when this == Value608 => onValue608(),
            _ when this == Value701 => onValue701(),
            _ when this == Value702 => onValue702(),
            _ when this == Value703 => onValue703(),
            _ when this == Value704 => onValue704(),
            _ when this == Value705 => onValue705(),
            _ when this == Value801 => onValue801(),
            _ when this == Value802 => onValue802(),
            _ when this == Value803 => onValue803(),
            _ when this == Value804 => onValue804(),
            _ when this == Value805 => onValue805(),
            _ when this == Value806 => onValue806(),
            _ when this == Value807 => onValue807(),
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
        Action onValue11,
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
        Action onValue27,
        Action onValue28,
        Action onValue29,
        Action onValue30,
        Action onValue31,
        Action onValue32,
        Action onValue33,
        Action onValue34,
        Action onValue35,
        Action onValue43,
        Action onValue44,
        Action onValue45,
        Action onValue46,
        Action onValue47,
        Action onValue51,
        Action onValue52,
        Action onValue53,
        Action onValue54,
        Action onValue55,
        Action onValue56,
        Action onValue57,
        Action onValue58,
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
        Action onValue73,
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
        Action onValue88,
        Action onValue89,
        Action onValue90,
        Action onValue91,
        Action onValue92,
        Action onValue93,
        Action onValue96,
        Action onValue200,
        Action onValue201,
        Action onValue202,
        Action onValue203,
        Action onValue204,
        Action onValue205,
        Action onValue206,
        Action onValue207,
        Action onValue208,
        Action onValue209,
        Action onValue210,
        Action onValue211,
        Action onValue212,
        Action onValue213,
        Action onValue214,
        Action onValue215,
        Action onValue216,
        Action onValue217,
        Action onValue218,
        Action onValue230,
        Action onValue231,
        Action onValue232,
        Action onValue233,
        Action onValue234,
        Action onValue235,
        Action onValue236,
        Action onValue237,
        Action onValue238,
        Action onValue239,
        Action onValue240,
        Action onValue241,
        Action onValue242,
        Action onValue243,
        Action onValue244,
        Action onValue245,
        Action onValue246,
        Action onValue247,
        Action onValue248,
        Action onValue249,
        Action onValue250,
        Action onValue251,
        Action onValue252,
        Action onValue253,
        Action onValue254,
        Action onValue255,
        Action onValue256,
        Action onValue257,
        Action onValue258,
        Action onValue259,
        Action onValue260,
        Action onValue261,
        Action onValue262,
        Action onValue263,
        Action onValue264,
        Action onValue265,
        Action onValue266,
        Action onValue267,
        Action onValue268,
        Action onValue269,
        Action onValue270,
        Action onValue271,
        Action onValue272,
        Action onValue273,
        Action onValue274,
        Action onValue275,
        Action onValue276,
        Action onValue277,
        Action onValue278,
        Action onValue279,
        Action onValue280,
        Action onValue281,
        Action onValue282,
        Action onValue283,
        Action onValue284,
        Action onValue400,
        Action onValue401,
        Action onValue402,
        Action onValue403,
        Action onValue404,
        Action onValue405,
        Action onValue406,
        Action onValue407,
        Action onValue408,
        Action onValue409,
        Action onValue410,
        Action onValue601,
        Action onValue602,
        Action onValue603,
        Action onValue604,
        Action onValue605,
        Action onValue606,
        Action onValue607,
        Action onValue608,
        Action onValue701,
        Action onValue702,
        Action onValue703,
        Action onValue704,
        Action onValue705,
        Action onValue801,
        Action onValue802,
        Action onValue803,
        Action onValue804,
        Action onValue805,
        Action onValue806,
        Action onValue807,
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
        else if (this == Value11) onValue11();
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
        else if (this == Value27) onValue27();
        else if (this == Value28) onValue28();
        else if (this == Value29) onValue29();
        else if (this == Value30) onValue30();
        else if (this == Value31) onValue31();
        else if (this == Value32) onValue32();
        else if (this == Value33) onValue33();
        else if (this == Value34) onValue34();
        else if (this == Value35) onValue35();
        else if (this == Value43) onValue43();
        else if (this == Value44) onValue44();
        else if (this == Value45) onValue45();
        else if (this == Value46) onValue46();
        else if (this == Value47) onValue47();
        else if (this == Value51) onValue51();
        else if (this == Value52) onValue52();
        else if (this == Value53) onValue53();
        else if (this == Value54) onValue54();
        else if (this == Value55) onValue55();
        else if (this == Value56) onValue56();
        else if (this == Value57) onValue57();
        else if (this == Value58) onValue58();
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
        else if (this == Value73) onValue73();
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
        else if (this == Value88) onValue88();
        else if (this == Value89) onValue89();
        else if (this == Value90) onValue90();
        else if (this == Value91) onValue91();
        else if (this == Value92) onValue92();
        else if (this == Value93) onValue93();
        else if (this == Value96) onValue96();
        else if (this == Value200) onValue200();
        else if (this == Value201) onValue201();
        else if (this == Value202) onValue202();
        else if (this == Value203) onValue203();
        else if (this == Value204) onValue204();
        else if (this == Value205) onValue205();
        else if (this == Value206) onValue206();
        else if (this == Value207) onValue207();
        else if (this == Value208) onValue208();
        else if (this == Value209) onValue209();
        else if (this == Value210) onValue210();
        else if (this == Value211) onValue211();
        else if (this == Value212) onValue212();
        else if (this == Value213) onValue213();
        else if (this == Value214) onValue214();
        else if (this == Value215) onValue215();
        else if (this == Value216) onValue216();
        else if (this == Value217) onValue217();
        else if (this == Value218) onValue218();
        else if (this == Value230) onValue230();
        else if (this == Value231) onValue231();
        else if (this == Value232) onValue232();
        else if (this == Value233) onValue233();
        else if (this == Value234) onValue234();
        else if (this == Value235) onValue235();
        else if (this == Value236) onValue236();
        else if (this == Value237) onValue237();
        else if (this == Value238) onValue238();
        else if (this == Value239) onValue239();
        else if (this == Value240) onValue240();
        else if (this == Value241) onValue241();
        else if (this == Value242) onValue242();
        else if (this == Value243) onValue243();
        else if (this == Value244) onValue244();
        else if (this == Value245) onValue245();
        else if (this == Value246) onValue246();
        else if (this == Value247) onValue247();
        else if (this == Value248) onValue248();
        else if (this == Value249) onValue249();
        else if (this == Value250) onValue250();
        else if (this == Value251) onValue251();
        else if (this == Value252) onValue252();
        else if (this == Value253) onValue253();
        else if (this == Value254) onValue254();
        else if (this == Value255) onValue255();
        else if (this == Value256) onValue256();
        else if (this == Value257) onValue257();
        else if (this == Value258) onValue258();
        else if (this == Value259) onValue259();
        else if (this == Value260) onValue260();
        else if (this == Value261) onValue261();
        else if (this == Value262) onValue262();
        else if (this == Value263) onValue263();
        else if (this == Value264) onValue264();
        else if (this == Value265) onValue265();
        else if (this == Value266) onValue266();
        else if (this == Value267) onValue267();
        else if (this == Value268) onValue268();
        else if (this == Value269) onValue269();
        else if (this == Value270) onValue270();
        else if (this == Value271) onValue271();
        else if (this == Value272) onValue272();
        else if (this == Value273) onValue273();
        else if (this == Value274) onValue274();
        else if (this == Value275) onValue275();
        else if (this == Value276) onValue276();
        else if (this == Value277) onValue277();
        else if (this == Value278) onValue278();
        else if (this == Value279) onValue279();
        else if (this == Value280) onValue280();
        else if (this == Value281) onValue281();
        else if (this == Value282) onValue282();
        else if (this == Value283) onValue283();
        else if (this == Value284) onValue284();
        else if (this == Value400) onValue400();
        else if (this == Value401) onValue401();
        else if (this == Value402) onValue402();
        else if (this == Value403) onValue403();
        else if (this == Value404) onValue404();
        else if (this == Value405) onValue405();
        else if (this == Value406) onValue406();
        else if (this == Value407) onValue407();
        else if (this == Value408) onValue408();
        else if (this == Value409) onValue409();
        else if (this == Value410) onValue410();
        else if (this == Value601) onValue601();
        else if (this == Value602) onValue602();
        else if (this == Value603) onValue603();
        else if (this == Value604) onValue604();
        else if (this == Value605) onValue605();
        else if (this == Value606) onValue606();
        else if (this == Value607) onValue607();
        else if (this == Value608) onValue608();
        else if (this == Value701) onValue701();
        else if (this == Value702) onValue702();
        else if (this == Value703) onValue703();
        else if (this == Value704) onValue704();
        else if (this == Value705) onValue705();
        else if (this == Value801) onValue801();
        else if (this == Value802) onValue802();
        else if (this == Value803) onValue803();
        else if (this == Value804) onValue804();
        else if (this == Value805) onValue805();
        else if (this == Value806) onValue806();
        else if (this == Value807) onValue807();
        else otherwise(Value);
    }
}
