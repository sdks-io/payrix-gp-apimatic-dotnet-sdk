using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// How payment information has been entered, including manually keyed entries, card swipes with track 1 or 2 data received, card dips with EMV chip data received, contactless card reads with track or EMV data received, and ApplePay read with cryptogram data received.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Manually keyed entry.</b></description></item>
///   <item><description><c>2</c> - <b>Card swiped. Track 1 received.</b></description></item>
///   <item><description><c>3</c> - <b>Card swiped. Track 2 received.</b></description></item>
///   <item><description><c>4</c> - <b>Card swiped. Track 1 &amp; 2 received.</b></description></item>
///   <item><description><c>5</c> - <b>Card dipped. EMV chip received.</b></description></item>
///   <item><description><c>6</c> - <b>Contactless card read. Track or EMV data received.</b></description></item>
///   <item><description><c>7</c> - <b>Track Data from Card Swipe after EMV chip failure.</b></description></item>
///   <item><description><c>8</c> - <b>Track Data from Manually keyed entry after EMV chip failure.</b></description></item>
///   <item><description><c>9</c> - <b>ApplePay</b></description></item>
///   <item><description><c>10</c> - <b>Google Pay.</b></description></item>
///   <item><description><c>11</c> - <b>Merchant created transaction.</b></description></item>
///   <item><description><c>12</c> - <b>Invoice payment.</b></description></item>
///   <item><description><c>13</c> - <b>Merchant created transaction in payrix portal.</b></description></item>
///   <item><description><c>14</c> - <b>Invoice payment from payrix portal.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<EntryMode1>))]
public sealed record EntryMode1 : OpenIntEnum<EntryMode1>
{
    private EntryMode1(long value) : base(value)
    {
    }

    public static readonly EntryMode1 Value1 = new(1L);

    public static readonly EntryMode1 Value2 = new(2L);

    public static readonly EntryMode1 Value3 = new(3L);

    public static readonly EntryMode1 Value4 = new(4L);

    public static readonly EntryMode1 Value5 = new(5L);

    public static readonly EntryMode1 Value6 = new(6L);

    public static readonly EntryMode1 Value7 = new(7L);

    public static readonly EntryMode1 Value8 = new(8L);

    public static readonly EntryMode1 Value9 = new(9L);

    public static readonly EntryMode1 Value10 = new(10L);

    public static readonly EntryMode1 Value11 = new(11L);

    public static readonly EntryMode1 Value12 = new(12L);

    public static readonly EntryMode1 Value13 = new(13L);

    public static readonly EntryMode1 Value14 = new(14L);

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
        else otherwise(Value);
    }
}
