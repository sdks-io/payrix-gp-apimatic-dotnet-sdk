using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicator to extract fee from txn supplied fee. When set, amount will correspond to the fee amount in the txn and only that amount will be extractable, anything over that amount will not be extracted. &lt;details&gt;&lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Disabled.</b> Fee will be calculated normally.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Enabled.</b> Fee will be calculated based on transaction fee.</description></item>
/// </list>
/// <para>
///
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<FeesTxnFee1>))]
public sealed record FeesTxnFee1 : OpenIntEnum<FeesTxnFee1>
{
    private FeesTxnFee1(long value) : base(value)
    {
    }

    public static readonly FeesTxnFee1 Value0 = new(0L);

    public static readonly FeesTxnFee1 Value1 = new(1L);

    public TResult Match<TResult>(Func<TResult> onValue0, Func<TResult> onValue1, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0, Action onValue1, Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else otherwise(Value);
    }
}
