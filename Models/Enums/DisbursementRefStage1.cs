using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The stage of the Disbursement reference.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>create</c>  - Funding is sent to the processor (based on prior split setup).</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>approve</c>  - Funding approved by the processor.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>split</c> - Disbursement amount is split for processing.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>failed</c> - Funding failed.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisbursementRefStage1>))]
public sealed record DisbursementRefStage1 : OpenStringEnum<DisbursementRefStage1>
{
    private DisbursementRefStage1(string value) : base(value)
    {
    }

    public static readonly DisbursementRefStage1 Create = new("create");

    public static readonly DisbursementRefStage1 Approve = new("approve");

    public static readonly DisbursementRefStage1 Split = new("split");

    public static readonly DisbursementRefStage1 Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onCreate,
        Func<TResult> onApprove,
        Func<TResult> onSplit,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Create => onCreate(),
            _ when this == Approve => onApprove(),
            _ when this == Split => onSplit(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreate, Action onApprove, Action onSplit, Action onFailed, Action<string> otherwise)
    {
        if (this == Create) onCreate();
        else if (this == Approve) onApprove();
        else if (this == Split) onSplit();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
