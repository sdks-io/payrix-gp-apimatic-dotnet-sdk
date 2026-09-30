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
///   <item><description><c>1</c> - <b>Credit Card Only: Sale Transaction.</b> Processes a sale and charges the customer.</description></item>
///   <item><description><c>2</c> - <b>Credit Card Only: Auth Transaction.</b> Authorizes and holds the requested total on the credit card.</description></item>
///   <item><description><c>3</c> - <b>Credit Card Only: Capture Transaction.</b> Finalizes a prior Auth Transaction and charges the customer.</description></item>
///   <item><description><c>4</c> - <b>Credit Card Only: Reverse Authorization.</b> Reverses a prior Auth or Sale Transaction and releases the credit hold.</description></item>
///   <item><description><c>5</c> - <b>Credit Card Only: Refund Transaction.</b> Refunds a prior Capture or Sale Transaction (total may be specified for a partial refund).</description></item>
///   <item><description><c>7</c> - <b>Echeck Only: Echeck Sale Transaction.</b> Sale Transaction for ECheck payment.</description></item>
///   <item><description><c>8</c> - <b>Echeck Only: Echeck Refund Transaction.</b> Refund Transaction for prior ECheck Sale Transaction.</description></item>
///   <item><description><c>11</c> - <b>Echeck Only: Echeck Redeposit Transaction.</b> Attempt to redeposit a prior failed eCheck Sale Transaction.</description></item>
///   <item><description><c>12</c> - <b>Echeck Only: Echeck Account Verification Transaction.</b> Attempt to verify eCheck payment details.</description></item>
///   <item><description><c>14</c> - <b>Incremental Authorization.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TxnType1>))]
public sealed record TxnType1 : OpenIntEnum<TxnType1>
{
    private TxnType1(long value) : base(value)
    {
    }

    public static readonly TxnType1 Value1 = new(1L);

    public static readonly TxnType1 Value2 = new(2L);

    public static readonly TxnType1 Value3 = new(3L);

    public static readonly TxnType1 Value4 = new(4L);

    public static readonly TxnType1 Value5 = new(5L);

    public static readonly TxnType1 Value7 = new(7L);

    public static readonly TxnType1 Value8 = new(8L);

    public static readonly TxnType1 Value11 = new(11L);

    public static readonly TxnType1 Value12 = new(12L);

    public static readonly TxnType1 Value14 = new(14L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue7,
        Func<TResult> onValue8,
        Func<TResult> onValue11,
        Func<TResult> onValue12,
        Func<TResult> onValue14,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value7 => onValue7(),
            _ when this == Value8 => onValue8(),
            _ when this == Value11 => onValue11(),
            _ when this == Value12 => onValue12(),
            _ when this == Value14 => onValue14(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue7,
        Action onValue8,
        Action onValue11,
        Action onValue12,
        Action onValue14,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value7) onValue7();
        else if (this == Value8) onValue8();
        else if (this == Value11) onValue11();
        else if (this == Value12) onValue12();
        else if (this == Value14) onValue14();
        else otherwise(Value);
    }
}
