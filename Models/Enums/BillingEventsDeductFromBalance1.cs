using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether to deduct the billing amount from the entity's account balance.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Do not deduct from balance.</b></description></item>
///   <item><description><c>1</c> - <b>Deduct from balance.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<BillingEventsDeductFromBalance1>))]
public sealed record BillingEventsDeductFromBalance1 : OpenIntEnum<BillingEventsDeductFromBalance1>
{
    private BillingEventsDeductFromBalance1(long value) : base(value)
    {
    }

    public static readonly BillingEventsDeductFromBalance1 Value0 = new(0L);

    public static readonly BillingEventsDeductFromBalance1 Value1 = new(1L);

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
