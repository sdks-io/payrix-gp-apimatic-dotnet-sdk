using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MerchantRiskLevel>))]
public sealed record MerchantRiskLevel : OpenStringEnum<MerchantRiskLevel>
{
    private MerchantRiskLevel(string value) : base(value)
    {
    }

    public static readonly MerchantRiskLevel Restricted = new("restricted");

    public static readonly MerchantRiskLevel Prohibited = new("prohibited");

    public static readonly MerchantRiskLevel High = new("high");

    public static readonly MerchantRiskLevel Medium = new("medium");

    public static readonly MerchantRiskLevel Low = new("low");

    public TResult Match<TResult>(Func<TResult> onRestricted,
        Func<TResult> onProhibited,
        Func<TResult> onHigh,
        Func<TResult> onMedium,
        Func<TResult> onLow,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Restricted => onRestricted(),
            _ when this == Prohibited => onProhibited(),
            _ when this == High => onHigh(),
            _ when this == Medium => onMedium(),
            _ when this == Low => onLow(),
            _ => otherwise(Value)
        };

    public void Match(Action onRestricted,
        Action onProhibited,
        Action onHigh,
        Action onMedium,
        Action onLow,
        Action<string> otherwise)
    {
        if (this == Restricted) onRestricted();
        else if (this == Prohibited) onProhibited();
        else if (this == High) onHigh();
        else if (this == Medium) onMedium();
        else if (this == Low) onLow();
        else otherwise(Value);
    }
}
