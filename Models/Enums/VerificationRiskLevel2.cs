using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>Low</c> - <b>Risk level for Low.</b></description></item>
///   <item><description><c>High</c> - <b>Risk level for High.</b></description></item>
///   <item><description><c>Medium</c> - <b>Risk level for Medium.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationRiskLevel2>))]
public sealed record VerificationRiskLevel2 : OpenStringEnum<VerificationRiskLevel2>
{
    private VerificationRiskLevel2(string value) : base(value)
    {
    }

    public static readonly VerificationRiskLevel2 Low = new("Low");

    public static readonly VerificationRiskLevel2 High = new("High");

    public static readonly VerificationRiskLevel2 Medium = new("Medium");

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
