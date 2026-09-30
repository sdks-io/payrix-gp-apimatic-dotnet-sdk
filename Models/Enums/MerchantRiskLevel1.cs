using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The risk level which the Merchant is in, if applicable.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>restricted</c> - <b>Restricted from processing transactions.</b></description></item>
///   <item><description><c>prohibited</c> - <b>Prohibited business use category.</b></description></item>
///   <item><description><c>high</c> - <b>High merchant risk score.</b></description></item>
///   <item><description><c>medium</c> - <b>Medium merchant risk score.</b></description></item>
///   <item><description><c>low</c> - <b>Low merchant risk score.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantRiskLevel1>))]
public sealed record MerchantRiskLevel1 : OpenStringEnum<MerchantRiskLevel1>
{
    private MerchantRiskLevel1(string value) : base(value)
    {
    }

    public static readonly MerchantRiskLevel1 Restricted = new("restricted");

    public static readonly MerchantRiskLevel1 Prohibited = new("prohibited");

    public static readonly MerchantRiskLevel1 High = new("high");

    public static readonly MerchantRiskLevel1 Medium = new("medium");

    public static readonly MerchantRiskLevel1 Low = new("low");

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
