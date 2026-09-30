using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CurrencyConversion>))]
public sealed record CurrencyConversion : OpenStringEnum<CurrencyConversion>
{
    private CurrencyConversion(string value) : base(value)
    {
    }

    public static readonly CurrencyConversion CustomerAccepted = new("customerAccepted");

    public static readonly CurrencyConversion CustomerRejected = new("customerRejected");

    public static readonly CurrencyConversion NotEligible = new("notEligible");

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
