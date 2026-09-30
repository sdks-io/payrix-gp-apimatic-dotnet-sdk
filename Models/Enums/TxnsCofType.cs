using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TxnsCofType>))]
public sealed record TxnsCofType : OpenStringEnum<TxnsCofType>
{
    private TxnsCofType(string value) : base(value)
    {
    }

    public static readonly TxnsCofType Single = new("single");

    public static readonly TxnsCofType Scheduled = new("scheduled");

    public static readonly TxnsCofType Unscheduled = new("unscheduled");

    public static readonly TxnsCofType Installment = new("installment");

    public TResult Match<TResult>(Func<TResult> onSingle,
        Func<TResult> onScheduled,
        Func<TResult> onUnscheduled,
        Func<TResult> onInstallment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Single => onSingle(),
            _ when this == Scheduled => onScheduled(),
            _ when this == Unscheduled => onUnscheduled(),
            _ when this == Installment => onInstallment(),
            _ => otherwise(Value)
        };

    public void Match(Action onSingle,
        Action onScheduled,
        Action onUnscheduled,
        Action onInstallment,
        Action<string> otherwise)
    {
        if (this == Single) onSingle();
        else if (this == Scheduled) onScheduled();
        else if (this == Unscheduled) onUnscheduled();
        else if (this == Installment) onInstallment();
        else otherwise(Value);
    }
}
