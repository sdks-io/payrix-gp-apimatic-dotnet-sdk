using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DecisionActionsScoreType>))]
public sealed record DecisionActionsScoreType : OpenStringEnum<DecisionActionsScoreType>
{
    private DecisionActionsScoreType(string value) : base(value)
    {
    }

    public static readonly DecisionActionsScoreType Low = new("low");

    public static readonly DecisionActionsScoreType High = new("high");

    public static readonly DecisionActionsScoreType None = new("none");

    public TResult Match<TResult>(Func<TResult> onLow,
        Func<TResult> onHigh,
        Func<TResult> onNone,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Low => onLow(),
            _ when this == High => onHigh(),
            _ when this == None => onNone(),
            _ => otherwise(Value)
        };

    public void Match(Action onLow, Action onHigh, Action onNone, Action<string> otherwise)
    {
        if (this == Low) onLow();
        else if (this == High) onHigh();
        else if (this == None) onNone();
        else otherwise(Value);
    }
}
