using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DisbursementsFundingStatus>))]
public sealed record DisbursementsFundingStatus : OpenStringEnum<DisbursementsFundingStatus>
{
    private DisbursementsFundingStatus(string value) : base(value)
    {
    }

    public static readonly DisbursementsFundingStatus Pending = new("pending");

    public static readonly DisbursementsFundingStatus Processed = new("processed");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onProcessed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Processed => onProcessed(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onProcessed, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Processed) onProcessed();
        else otherwise(Value);
    }
}
