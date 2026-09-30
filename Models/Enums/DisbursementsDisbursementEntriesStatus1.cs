using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of disbursementEntries creation.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>pending</c> - <b>Pending entry creation and processing.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>processing</c> - <b>Entry is still processing.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>processed</c> - <b>Entry created and processed.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisbursementsDisbursementEntriesStatus1>))]
public sealed record DisbursementsDisbursementEntriesStatus1 : OpenStringEnum<DisbursementsDisbursementEntriesStatus1>
{
    private DisbursementsDisbursementEntriesStatus1(string value) : base(value)
    {
    }

    public static readonly DisbursementsDisbursementEntriesStatus1 Pending = new("pending");

    public static readonly DisbursementsDisbursementEntriesStatus1 Processing = new("processing");

    public static readonly DisbursementsDisbursementEntriesStatus1 Processed = new("processed");

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
