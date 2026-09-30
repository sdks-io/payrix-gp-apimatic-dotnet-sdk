using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<OrgFlowTrigger>))]
public sealed record OrgFlowTrigger : OpenStringEnum<OrgFlowTrigger>
{
    private OrgFlowTrigger(string value) : base(value)
    {
    }

    public static readonly OrgFlowTrigger Create = new("create");

    public static readonly OrgFlowTrigger Low = new("low");

    public static readonly OrgFlowTrigger High = new("high");

    public static readonly OrgFlowTrigger Board = new("board");

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
