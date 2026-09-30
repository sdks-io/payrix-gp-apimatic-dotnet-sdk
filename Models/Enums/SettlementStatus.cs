using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SettlementStatus>))]
public sealed record SettlementStatus : OpenStringEnum<SettlementStatus>
{
    private SettlementStatus(string value) : base(value)
    {
    }

    public static readonly SettlementStatus Cancelled = new("cancelled");

    public static readonly SettlementStatus Failed = new("failed");

    public static readonly SettlementStatus Pending = new("pending");

    public static readonly SettlementStatus Processed = new("processed");

    public static readonly SettlementStatus Processing = new("processing");

    public TResult Match<TResult>(Func<TResult> onCancelled,
        Func<TResult> onFailed,
        Func<TResult> onPending,
        Func<TResult> onProcessed,
        Func<TResult> onProcessing,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Cancelled => onCancelled(),
            _ when this == Failed => onFailed(),
            _ when this == Pending => onPending(),
            _ when this == Processed => onProcessed(),
            _ when this == Processing => onProcessing(),
            _ => otherwise(Value)
        };

    public void Match(Action onCancelled,
        Action onFailed,
        Action onPending,
        Action onProcessed,
        Action onProcessing,
        Action<string> otherwise)
    {
        if (this == Cancelled) onCancelled();
        else if (this == Failed) onFailed();
        else if (this == Pending) onPending();
        else if (this == Processed) onProcessed();
        else if (this == Processing) onProcessing();
        else otherwise(Value);
    }
}
