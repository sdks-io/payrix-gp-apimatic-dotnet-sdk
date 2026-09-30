using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// How is the terminal employed in the type of business using the terminal.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Retail</b></description></item>
///   <item><description><c>2</c> - <b>Retail with tips</b></description></item>
///   <item><description><c>3</c> - <b>Restaurant</b></description></item>
///   <item><description><c>4</c> - <b>Lodging</b></description></item>
///   <item><description><c>5</c> - <b>Bar</b></description></item>
///   <item><description><c>6</c> - <b>Cash Advance</b></description></item>
///   <item><description><c>7</c> - <b>Mail/Telephone Order</b></description></item>
///   <item><description><c>8</c> - <b>Pay At The Pump</b></description></item>
///   <item><description><c>9</c> - <b>Service Rest</b></description></item>
///   <item><description><c>10</c> - <b>E-commerce</b></description></item>
///   <item><description><c>11</c> - <b>Direct Marketing</b></description></item>
///   <item><description><c>12</c> - <b>Fine Dining</b></description></item>
///   <item><description><c>13</c> - <b>Gift Card Only</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TerminalEnvironment1>))]
public sealed record TerminalEnvironment1 : OpenIntEnum<TerminalEnvironment1>
{
    private TerminalEnvironment1(long value) : base(value)
    {
    }

    public static readonly TerminalEnvironment1 Value1 = new(1L);

    public static readonly TerminalEnvironment1 Value2 = new(2L);

    public static readonly TerminalEnvironment1 Value3 = new(3L);

    public static readonly TerminalEnvironment1 Value4 = new(4L);

    public static readonly TerminalEnvironment1 Value5 = new(5L);

    public static readonly TerminalEnvironment1 Value6 = new(6L);

    public static readonly TerminalEnvironment1 Value7 = new(7L);

    public static readonly TerminalEnvironment1 Value8 = new(8L);

    public static readonly TerminalEnvironment1 Value9 = new(9L);

    public static readonly TerminalEnvironment1 Value10 = new(10L);

    public static readonly TerminalEnvironment1 Value11 = new(11L);

    public static readonly TerminalEnvironment1 Value12 = new(12L);

    public static readonly TerminalEnvironment1 Value13 = new(13L);

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
        else otherwise(Value);
    }
}
