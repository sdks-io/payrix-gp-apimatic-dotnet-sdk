using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of the settlement.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>cancelled</c> - <b>Cancelled.</b></description></item>
///   <item><description><c>failed</c> - <b>Failed.</b></description></item>
///   <item><description><c>pending</c> - <b>Pending.</b></description></item>
///   <item><description><c>processed</c> - <b>Processed.</b></description></item>
///   <item><description><c>processing</c> - <b>Processing.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SettlementStatus1>))]
public sealed record SettlementStatus1 : OpenStringEnum<SettlementStatus1>
{
    private SettlementStatus1(string value) : base(value)
    {
    }

    public static readonly SettlementStatus1 Cancelled = new("cancelled");

    public static readonly SettlementStatus1 Failed = new("failed");

    public static readonly SettlementStatus1 Pending = new("pending");

    public static readonly SettlementStatus1 Processed = new("processed");

    public static readonly SettlementStatus1 Processing = new("processing");

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
