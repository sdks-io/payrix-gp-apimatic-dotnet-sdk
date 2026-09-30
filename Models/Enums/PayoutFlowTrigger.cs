using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PayoutFlowTrigger>))]
public sealed record PayoutFlowTrigger : OpenStringEnum<PayoutFlowTrigger>
{
    private PayoutFlowTrigger(string value) : base(value)
    {
    }

    public static readonly PayoutFlowTrigger AccountCreate = new("accountCreate");

    public static readonly PayoutFlowTrigger Board = new("board");

    public TResult Match<TResult>(Func<TResult> onAccountCreate,
        Func<TResult> onBoard,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountCreate => onAccountCreate(),
            _ when this == Board => onBoard(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountCreate, Action onBoard, Action<string> otherwise)
    {
        if (this == AccountCreate) onAccountCreate();
        else if (this == Board) onBoard();
        else otherwise(Value);
    }
}
