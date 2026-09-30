using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates if entries were processed for this Disbursement. &lt;details&gt;&lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>pending</c> - <b>Pending entry creation and processing.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>processed</c> - <b>Entry created and processed.</b></description></item>
/// </list>
/// <para>
///   &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisbursementsFundingStatus1>))]
public sealed record DisbursementsFundingStatus1 : OpenStringEnum<DisbursementsFundingStatus1>
{
    private DisbursementsFundingStatus1(string value) : base(value)
    {
    }

    public static readonly DisbursementsFundingStatus1 Pending = new("pending");

    public static readonly DisbursementsFundingStatus1 Processed = new("processed");

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
