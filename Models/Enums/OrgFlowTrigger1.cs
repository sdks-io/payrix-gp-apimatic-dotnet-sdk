using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// This field sets the trigger that determines when this orgFlow runs.
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// - <c>create</c> - <b>Entity creation.</b>
/// - <c>low</c> - <b>Entity verification through decisions hits a configured low score.</b>
/// - <c>high</c> - <b>Entity verification through decisions hits a configured high score.</b>
/// - <c>board</c> - <b>Merchant boarding.</b>
/// &lt;/details&gt;
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrgFlowTrigger1>))]
public sealed record OrgFlowTrigger1 : OpenStringEnum<OrgFlowTrigger1>
{
    private OrgFlowTrigger1(string value) : base(value)
    {
    }

    public static readonly OrgFlowTrigger1 Create = new("create");

    public static readonly OrgFlowTrigger1 Low = new("low");

    public static readonly OrgFlowTrigger1 High = new("high");

    public static readonly OrgFlowTrigger1 Board = new("board");

    public TResult Match<TResult>(Func<TResult> onCreate,
        Func<TResult> onLow,
        Func<TResult> onHigh,
        Func<TResult> onBoard,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Create => onCreate(),
            _ when this == Low => onLow(),
            _ when this == High => onHigh(),
            _ when this == Board => onBoard(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreate, Action onLow, Action onHigh, Action onBoard, Action<string> otherwise)
    {
        if (this == Create) onCreate();
        else if (this == Low) onLow();
        else if (this == High) onHigh();
        else if (this == Board) onBoard();
        else otherwise(Value);
    }
}
