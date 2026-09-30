using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AggregationStatus>))]
public sealed record AggregationStatus : OpenStringEnum<AggregationStatus>
{
    private AggregationStatus(string value) : base(value)
    {
    }

    public static readonly AggregationStatus NotReady = new("notReady");

    public static readonly AggregationStatus Ready = new("ready");

    public static readonly AggregationStatus Processing = new("processing");

    public static readonly AggregationStatus Processed = new("processed");

    public TResult Match<TResult>(Func<TResult> onNotReady,
        Func<TResult> onReady,
        Func<TResult> onProcessing,
        Func<TResult> onProcessed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotReady => onNotReady(),
            _ when this == Ready => onReady(),
            _ when this == Processing => onProcessing(),
            _ when this == Processed => onProcessed(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotReady,
        Action onReady,
        Action onProcessing,
        Action onProcessed,
        Action<string> otherwise)
    {
        if (this == NotReady) onNotReady();
        else if (this == Ready) onReady();
        else if (this == Processing) onProcessing();
        else if (this == Processed) onProcessed();
        else otherwise(Value);
    }
}
