using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PaymentUpdateStatus>))]
public sealed record PaymentUpdateStatus : OpenStringEnum<PaymentUpdateStatus>
{
    private PaymentUpdateStatus(string value) : base(value)
    {
    }

    public static readonly PaymentUpdateStatus Pending = new("pending");

    public static readonly PaymentUpdateStatus Processing = new("processing");

    public static readonly PaymentUpdateStatus Failed = new("failed");

    public static readonly PaymentUpdateStatus Processed = new("processed");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onProcessing,
        Func<TResult> onFailed,
        Func<TResult> onProcessed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Processing => onProcessing(),
            _ when this == Failed => onFailed(),
            _ when this == Processed => onProcessed(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onProcessing,
        Action onFailed,
        Action onProcessed,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Processing) onProcessing();
        else if (this == Failed) onFailed();
        else if (this == Processed) onProcessed();
        else otherwise(Value);
    }
}
