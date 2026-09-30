using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DisbursementsDisbursementEntriesStatus>))]
public sealed record DisbursementsDisbursementEntriesStatus : OpenStringEnum<DisbursementsDisbursementEntriesStatus>
{
    private DisbursementsDisbursementEntriesStatus(string value) : base(value)
    {
    }

    public static readonly DisbursementsDisbursementEntriesStatus Pending = new("pending");

    public static readonly DisbursementsDisbursementEntriesStatus Processing = new("processing");

    public static readonly DisbursementsDisbursementEntriesStatus Processed = new("processed");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onProcessing,
        Func<TResult> onProcessed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Processing => onProcessing(),
            _ when this == Processed => onProcessed(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onProcessing, Action onProcessed, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Processing) onProcessing();
        else if (this == Processed) onProcessed();
        else otherwise(Value);
    }
}
