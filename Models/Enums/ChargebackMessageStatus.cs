using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChargebackMessageStatus>))]
public sealed record ChargebackMessageStatus : OpenStringEnum<ChargebackMessageStatus>
{
    private ChargebackMessageStatus(string value) : base(value)
    {
    }

    public static readonly ChargebackMessageStatus Requested = new("requested");

    public static readonly ChargebackMessageStatus Processing = new("processing");

    public static readonly ChargebackMessageStatus Failed = new("failed");

    public static readonly ChargebackMessageStatus Denied = new("denied");

    public static readonly ChargebackMessageStatus Processed = new("processed");

    public TResult Match<TResult>(Func<TResult> onRequested,
        Func<TResult> onProcessing,
        Func<TResult> onFailed,
        Func<TResult> onDenied,
        Func<TResult> onProcessed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Requested => onRequested(),
            _ when this == Processing => onProcessing(),
            _ when this == Failed => onFailed(),
            _ when this == Denied => onDenied(),
            _ when this == Processed => onProcessed(),
            _ => otherwise(Value)
        };

    public void Match(Action onRequested,
        Action onProcessing,
        Action onFailed,
        Action onDenied,
        Action onProcessed,
        Action<string> otherwise)
    {
        if (this == Requested) onRequested();
        else if (this == Processing) onProcessing();
        else if (this == Failed) onFailed();
        else if (this == Denied) onDenied();
        else if (this == Processed) onProcessed();
        else otherwise(Value);
    }
}
