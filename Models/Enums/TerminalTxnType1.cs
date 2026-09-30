using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of Transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Credit Card Only: Sale Transaction.</b> This is the most common type of Transaction, it processes a sale and charges the customer.</description></item>
///   <item><description><c>2</c> - <b>Credit Card Only: Auth Transaction.</b> Authorizes and holds the requested total on the credit card.</description></item>
///   <item><description><c>4</c> - <b>Credit Card Only: Reverse Authorization.</b> Reverses a prior Auth or Sale Transaction and releases the credit hold.</description></item>
///   <item><description><c>5</c> - <b>Credit Card Only: Refund Transaction.</b> Refunds a prior Capture or Sale Transaction (total may be specified for a partial refund).</description></item>
///   <item><description><c>13</c> - <b>Batch out terminal.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TerminalTxnType1>))]
public sealed record TerminalTxnType1 : OpenIntEnum<TerminalTxnType1>
{
    private TerminalTxnType1(long value) : base(value)
    {
    }

    public static readonly TerminalTxnType1 Value1 = new(1L);

    public static readonly TerminalTxnType1 Value2 = new(2L);

    public static readonly TerminalTxnType1 Value4 = new(4L);

    public static readonly TerminalTxnType1 Value5 = new(5L);

    public static readonly TerminalTxnType1 Value13 = new(13L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue13,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value13 => onValue13(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue2,
        Action onValue4,
        Action onValue5,
        Action onValue13,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value13) onValue13();
        else otherwise(Value);
    }
}
