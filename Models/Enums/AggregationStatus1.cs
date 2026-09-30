using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of the aggregation process.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>notReady</c> - <b>Aggregation is not ready.</b></description></item>
///   <item><description><c>ready</c> - <b>Aggregation is ready.</b></description></item>
///   <item><description><c>processing</c> - <b>Aggregation is processing.</b></description></item>
///   <item><description><c>processed</c> - <b>Aggregation has been processed.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AggregationStatus1>))]
public sealed record AggregationStatus1 : OpenStringEnum<AggregationStatus1>
{
    private AggregationStatus1(string value) : base(value)
    {
    }

    public static readonly AggregationStatus1 NotReady = new("notReady");

    public static readonly AggregationStatus1 Ready = new("ready");

    public static readonly AggregationStatus1 Processing = new("processing");

    public static readonly AggregationStatus1 Processed = new("processed");

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
