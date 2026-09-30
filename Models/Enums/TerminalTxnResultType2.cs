using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of this terminalTxnResult.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c>  -  <b>A general type of result.</b></description></item>
///   <item><description><c>2</c>  -  <b>Fraud prevention alert.</b></description></item>
///   <item><description><c>3</c>  -  <b>Processor error.</b></description></item>
///   <item><description><c>4</c>  -  <b>CVV matching alert.</b></description></item>
///   <item><description><c>5</c>  -  <b>AVS check alert.</b></description></item>
///   <item><description><c>6</c>  -  <b>AAVS check alert.</b></description></item>
///   <item><description><c>7</c>  -  <b>Network error.</b></description></item>
///   <item><description><c>8</c>  -  <b>3DS check alert.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TerminalTxnResultType2>))]
public sealed record TerminalTxnResultType2 : OpenIntEnum<TerminalTxnResultType2>
{
    private TerminalTxnResultType2(long value) : base(value)
    {
    }

    public static readonly TerminalTxnResultType2 Value1 = new(1L);

    public static readonly TerminalTxnResultType2 Value2 = new(2L);

    public static readonly TerminalTxnResultType2 Value3 = new(3L);

    public static readonly TerminalTxnResultType2 Value4 = new(4L);

    public static readonly TerminalTxnResultType2 Value5 = new(5L);

    public static readonly TerminalTxnResultType2 Value6 = new(6L);

    public static readonly TerminalTxnResultType2 Value7 = new(7L);

    public static readonly TerminalTxnResultType2 Value8 = new(8L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
        Func<TResult> onValue7,
        Func<TResult> onValue8,
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
        else otherwise(Value);
    }
}
