using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DisbursementRefStage>))]
public sealed record DisbursementRefStage : OpenStringEnum<DisbursementRefStage>
{
    private DisbursementRefStage(string value) : base(value)
    {
    }

    public static readonly DisbursementRefStage Create = new("create");

    public static readonly DisbursementRefStage Approve = new("approve");

    public static readonly DisbursementRefStage Split = new("split");

    public static readonly DisbursementRefStage Failed = new("failed");

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
