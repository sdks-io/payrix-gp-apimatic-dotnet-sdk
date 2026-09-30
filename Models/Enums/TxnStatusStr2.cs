using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The status of the Transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Pending.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Approved.</b> Payments can be voided or cancelled.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>2</c> - <b>Failed</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>3</c> - <b>Captured.</b> Payments can be refunded.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>4</c> - <b>Settled.</b> Payments can be refunded.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>5</c> - <b>Returned.</b> Payments has been successfully refunded.</description></item>
/// </list>
/// <para>
///  &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TxnStatusStr2>))]
public sealed record TxnStatusStr2 : OpenStringEnum<TxnStatusStr2>
{
    private TxnStatusStr2(string value) : base(value)
    {
    }

    public static readonly TxnStatusStr2 _0 = new("0");

    public static readonly TxnStatusStr2 _1 = new("1");

    public static readonly TxnStatusStr2 _2 = new("2");

    public static readonly TxnStatusStr2 _3 = new("3");

    public static readonly TxnStatusStr2 _4 = new("4");

    public static readonly TxnStatusStr2 _5 = new("5");

    public TResult Match<TResult>(Func<TResult> on_0,
        Func<TResult> on_1,
        Func<TResult> on_2,
        Func<TResult> on_3,
        Func<TResult> on_4,
        Func<TResult> on_5,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _0 => on_0(),
            _ when this == _1 => on_1(),
            _ when this == _2 => on_2(),
            _ when this == _3 => on_3(),
            _ when this == _4 => on_4(),
            _ when this == _5 => on_5(),
            _ => otherwise(Value)
        };

    public void Match(Action on_0,
        Action on_1,
        Action on_2,
        Action on_3,
        Action on_4,
        Action on_5,
        Action<string> otherwise)
    {
        if (this == _0) on_0();
        else if (this == _1) on_1();
        else if (this == _2) on_2();
        else if (this == _3) on_3();
        else if (this == _4) on_4();
        else if (this == _5) on_5();
        else otherwise(Value);
    }
}
