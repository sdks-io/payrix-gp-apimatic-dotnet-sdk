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
///   &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TxnStatus1>))]
public sealed record TxnStatus1 : OpenIntEnum<TxnStatus1>
{
    private TxnStatus1(long value) : base(value)
    {
    }

    public static readonly TxnStatus1 Value0 = new(0L);

    public static readonly TxnStatus1 Value1 = new(1L);

    public static readonly TxnStatus1 Value2 = new(2L);

    public static readonly TxnStatus1 Value3 = new(3L);

    public static readonly TxnStatus1 Value4 = new(4L);

    public static readonly TxnStatus1 Value5 = new(5L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0,
        Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else otherwise(Value);
    }
}
