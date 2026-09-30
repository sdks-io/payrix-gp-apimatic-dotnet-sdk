using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates whether the merchant accepts pre-purchase for products that are shipped at a later date or not currently available, specifying advanced billing as either disabled (0) or enabled (1).
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>AdvancedBilling is disabled.</b></description></item>
///   <item><description><c>1</c> - <b>AdvancedBilling is enabled.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<MerchantsAdvanceBilling1>))]
public sealed record MerchantsAdvanceBilling1 : OpenIntEnum<MerchantsAdvanceBilling1>
{
    private MerchantsAdvanceBilling1(long value) : base(value)
    {
    }

    public static readonly MerchantsAdvanceBilling1 Value0 = new(0L);

    public static readonly MerchantsAdvanceBilling1 Value1 = new(1L);

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
