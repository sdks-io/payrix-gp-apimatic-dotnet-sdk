using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<MerchantLocationType>))]
public sealed record MerchantLocationType : OpenIntEnum<MerchantLocationType>
{
    private MerchantLocationType(long value) : base(value)
    {
    }

    public static readonly MerchantLocationType Value77 = new(77L);

    public static readonly MerchantLocationType Value78 = new(78L);

    public static readonly MerchantLocationType Value79 = new(79L);

    public static readonly MerchantLocationType Value80 = new(80L);

    public static readonly MerchantLocationType Value81 = new(81L);

    public TResult Match<TResult>(Func<TResult> onValue77,
        Func<TResult> onValue78,
        Func<TResult> onValue79,
        Func<TResult> onValue80,
        Func<TResult> onValue81,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value77 => onValue77(),
            _ when this == Value78 => onValue78(),
            _ when this == Value79 => onValue79(),
            _ when this == Value80 => onValue80(),
            _ when this == Value81 => onValue81(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue77,
        Action onValue78,
        Action onValue79,
        Action onValue80,
        Action onValue81,
        Action<long> otherwise)
    {
        if (this == Value77) onValue77();
        else if (this == Value78) onValue78();
        else if (this == Value79) onValue79();
        else if (this == Value80) onValue80();
        else if (this == Value81) onValue81();
        else otherwise(Value);
    }
}
