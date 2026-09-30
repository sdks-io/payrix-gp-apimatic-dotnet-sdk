using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<StatementStatus>))]
public sealed record StatementStatus : OpenStringEnum<StatementStatus>
{
    private StatementStatus(string value) : base(value)
    {
    }

    public static readonly StatementStatus Pending = new("pending");

    public static readonly StatementStatus Processing = new("processing");

    public static readonly StatementStatus PartiallyPaid = new("partiallyPaid");

    public static readonly StatementStatus Paid = new("paid");

    public static readonly StatementStatus PartiallyCancelled = new("partiallyCancelled");

    public static readonly StatementStatus Cancelled = new("cancelled");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onProcessing,
        Func<TResult> onPartiallyPaid,
        Func<TResult> onPaid,
        Func<TResult> onPartiallyCancelled,
        Func<TResult> onCancelled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Processing => onProcessing(),
            _ when this == PartiallyPaid => onPartiallyPaid(),
            _ when this == Paid => onPaid(),
            _ when this == PartiallyCancelled => onPartiallyCancelled(),
            _ when this == Cancelled => onCancelled(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onProcessing,
        Action onPartiallyPaid,
        Action onPaid,
        Action onPartiallyCancelled,
        Action onCancelled,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Processing) onProcessing();
        else if (this == PartiallyPaid) onPartiallyPaid();
        else if (this == Paid) onPaid();
        else if (this == PartiallyCancelled) onPartiallyCancelled();
        else if (this == Cancelled) onCancelled();
        else otherwise(Value);
    }
}
