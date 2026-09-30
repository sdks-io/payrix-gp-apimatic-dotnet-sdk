using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// An indicator that specifies whether the Merchant is new to credit card processing, where merchants are considered to be new by default and can have a valid value of either '0' (Not new) or '1' (New).
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Not new</b></description></item>
///   <item><description><c>1</c> - <b>New</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<MerchantsNew1>))]
public sealed record MerchantsNew1 : OpenIntEnum<MerchantsNew1>
{
    private MerchantsNew1(long value) : base(value)
    {
    }

    public static readonly MerchantsNew1 Value0 = new(0L);

    public static readonly MerchantsNew1 Value1 = new(1L);

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
