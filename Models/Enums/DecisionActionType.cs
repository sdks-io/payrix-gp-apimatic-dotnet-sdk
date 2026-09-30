using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DecisionActionType>))]
public sealed record DecisionActionType : OpenStringEnum<DecisionActionType>
{
    private DecisionActionType(string value) : base(value)
    {
    }

    public static readonly DecisionActionType Equal = new("equal");

    public static readonly DecisionActionType NotEqual = new("notEqual");

    public static readonly DecisionActionType Contains = new("contains");

    public static readonly DecisionActionType Greater = new("greater");

    public static readonly DecisionActionType Less = new("less");

    public TResult Match<TResult>(Func<TResult> onEqual,
        Func<TResult> onNotEqual,
        Func<TResult> onContains,
        Func<TResult> onGreater,
        Func<TResult> onLess,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Equal => onEqual(),
            _ when this == NotEqual => onNotEqual(),
            _ when this == Contains => onContains(),
            _ when this == Greater => onGreater(),
            _ when this == Less => onLess(),
            _ => otherwise(Value)
        };

    public void Match(Action onEqual,
        Action onNotEqual,
        Action onContains,
        Action onGreater,
        Action onLess,
        Action<string> otherwise)
    {
        if (this == Equal) onEqual();
        else if (this == NotEqual) onNotEqual();
        else if (this == Contains) onContains();
        else if (this == Greater) onGreater();
        else if (this == Less) onLess();
        else otherwise(Value);
    }
}
