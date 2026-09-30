using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PlanType>))]
public sealed record PlanType : OpenStringEnum<PlanType>
{
    private PlanType(string value) : base(value)
    {
    }

    public static readonly PlanType Recurring = new("recurring");

    public static readonly PlanType Installment = new("installment");

    public TResult Match<TResult>(Func<TResult> onRecurring,
        Func<TResult> onInstallment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Recurring => onRecurring(),
            _ when this == Installment => onInstallment(),
            _ => otherwise(Value)
        };

    public void Match(Action onRecurring, Action onInstallment, Action<string> otherwise)
    {
        if (this == Recurring) onRecurring();
        else if (this == Installment) onInstallment();
        else otherwise(Value);
    }
}
