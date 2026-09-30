using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The status of the currency conversion.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>customerAccepted</c> - <b>The customer accepted the currency conversion rate.</b></description></item>
///   <item><description><c>customerRejected</c> - <b>The customer rejected the currency conversion rate.</b></description></item>
///   <item><description><c>notEligible</c> - <b>This transaction is not eligible for currency conversion.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CurrencyConversion1>))]
public sealed record CurrencyConversion1 : OpenStringEnum<CurrencyConversion1>
{
    private CurrencyConversion1(string value) : base(value)
    {
    }

    public static readonly CurrencyConversion1 CustomerAccepted = new("customerAccepted");

    public static readonly CurrencyConversion1 CustomerRejected = new("customerRejected");

    public static readonly CurrencyConversion1 NotEligible = new("notEligible");

    public TResult Match<TResult>(Func<TResult> onCustomerAccepted,
        Func<TResult> onCustomerRejected,
        Func<TResult> onNotEligible,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CustomerAccepted => onCustomerAccepted(),
            _ when this == CustomerRejected => onCustomerRejected(),
            _ when this == NotEligible => onNotEligible(),
            _ => otherwise(Value)
        };

    public void Match(Action onCustomerAccepted,
        Action onCustomerRejected,
        Action onNotEligible,
        Action<string> otherwise)
    {
        if (this == CustomerAccepted) onCustomerAccepted();
        else if (this == CustomerRejected) onCustomerRejected();
        else if (this == NotEligible) onNotEligible();
        else otherwise(Value);
    }
}
