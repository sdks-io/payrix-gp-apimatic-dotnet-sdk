using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChargebackDocumentStatus>))]
public sealed record ChargebackDocumentStatus : OpenStringEnum<ChargebackDocumentStatus>
{
    private ChargebackDocumentStatus(string value) : base(value)
    {
    }

    public static readonly ChargebackDocumentStatus Created = new("created");

    public static readonly ChargebackDocumentStatus Processed = new("processed");

    public static readonly ChargebackDocumentStatus Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onCreated,
        Func<TResult> onProcessed,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Created => onCreated(),
            _ when this == Processed => onProcessed(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreated, Action onProcessed, Action onFailed, Action<string> otherwise)
    {
        if (this == Created) onCreated();
        else if (this == Processed) onProcessed();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
