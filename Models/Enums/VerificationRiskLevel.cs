using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<VerificationRiskLevel>))]
public sealed record VerificationRiskLevel : OpenStringEnum<VerificationRiskLevel>
{
    private VerificationRiskLevel(string value) : base(value)
    {
    }

    public static readonly VerificationRiskLevel Low = new("Low");

    public static readonly VerificationRiskLevel High = new("High");

    public static readonly VerificationRiskLevel Medium = new("Medium");

    public TResult Match<TResult>(Func<TResult> onLow,
        Func<TResult> onHigh,
        Func<TResult> onMedium,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Low => onLow(),
            _ when this == High => onHigh(),
            _ when this == Medium => onMedium(),
            _ => otherwise(Value)
        };

    public void Match(Action onLow, Action onHigh, Action onMedium, Action<string> otherwise)
    {
        if (this == Low) onLow();
        else if (this == High) onHigh();
        else if (this == Medium) onMedium();
        else otherwise(Value);
    }
}
