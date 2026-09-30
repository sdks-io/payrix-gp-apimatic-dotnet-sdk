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
[JsonConverter(typeof(StringEnumConverter<TxnTypeStr2>))]
public sealed record TxnTypeStr2 : OpenStringEnum<TxnTypeStr2>
{
    private TxnTypeStr2(string value) : base(value)
    {
    }

    public static readonly TxnTypeStr2 _1 = new("1");

    public static readonly TxnTypeStr2 _2 = new("2");

    public static readonly TxnTypeStr2 _3 = new("3");

    public static readonly TxnTypeStr2 _4 = new("4");

    public static readonly TxnTypeStr2 _5 = new("5");

    public static readonly TxnTypeStr2 _7 = new("7");

    public static readonly TxnTypeStr2 _8 = new("8");

    public static readonly TxnTypeStr2 _11 = new("11");

    public static readonly TxnTypeStr2 _12 = new("12");

    public static readonly TxnTypeStr2 _14 = new("14");

    public TResult Match<TResult>(Func<TResult> on_1,
        Func<TResult> on_2,
        Func<TResult> on_3,
        Func<TResult> on_4,
        Func<TResult> on_5,
        Func<TResult> on_7,
        Func<TResult> on_8,
        Func<TResult> on_11,
        Func<TResult> on_12,
        Func<TResult> on_14,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _1 => on_1(),
            _ when this == _2 => on_2(),
            _ when this == _3 => on_3(),
            _ when this == _4 => on_4(),
            _ when this == _5 => on_5(),
            _ when this == _7 => on_7(),
            _ when this == _8 => on_8(),
            _ when this == _11 => on_11(),
            _ when this == _12 => on_12(),
            _ when this == _14 => on_14(),
            _ => otherwise(Value)
        };

    public void Match(Action on_1,
        Action on_2,
        Action on_3,
        Action on_4,
        Action on_5,
        Action on_7,
        Action on_8,
        Action on_11,
        Action on_12,
        Action on_14,
        Action<string> otherwise)
    {
        if (this == _1) on_1();
        else if (this == _2) on_2();
        else if (this == _3) on_3();
        else if (this == _4) on_4();
        else if (this == _5) on_5();
        else if (this == _7) on_7();
        else if (this == _8) on_8();
        else if (this == _11) on_11();
        else if (this == _12) on_12();
        else if (this == _14) on_14();
        else otherwise(Value);
    }
}
