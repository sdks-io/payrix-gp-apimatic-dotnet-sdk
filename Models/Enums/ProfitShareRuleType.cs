using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProfitShareRuleType>))]
public sealed record ProfitShareRuleType : OpenStringEnum<ProfitShareRuleType>
{
    private ProfitShareRuleType(string value) : base(value)
    {
    }

    public static readonly ProfitShareRuleType Less = new("less");

    public static readonly ProfitShareRuleType Equal = new("equal");

    public static readonly ProfitShareRuleType NotEqual = new("notEqual");

    public static readonly ProfitShareRuleType Greater = new("greater");

    public static readonly ProfitShareRuleType Event = new("event");

    public static readonly ProfitShareRuleType NotEvent = new("notEvent");

    public static readonly ProfitShareRuleType Fee = new("fee");

    public static readonly ProfitShareRuleType NotFee = new("notFee");

    public static readonly ProfitShareRuleType Fromentity = new("fromentity");

    public static readonly ProfitShareRuleType NotFromentity = new("notFromentity");

    public TResult Match<TResult>(Func<TResult> onLess,
        Func<TResult> onEqual,
        Func<TResult> onNotEqual,
        Func<TResult> onGreater,
        Func<TResult> onEvent,
        Func<TResult> onNotEvent,
        Func<TResult> onFee,
        Func<TResult> onNotFee,
        Func<TResult> onFromentity,
        Func<TResult> onNotFromentity,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Less => onLess(),
            _ when this == Equal => onEqual(),
            _ when this == NotEqual => onNotEqual(),
            _ when this == Greater => onGreater(),
            _ when this == Event => onEvent(),
            _ when this == NotEvent => onNotEvent(),
            _ when this == Fee => onFee(),
            _ when this == NotFee => onNotFee(),
            _ when this == Fromentity => onFromentity(),
            _ when this == NotFromentity => onNotFromentity(),
            _ => otherwise(Value)
        };

    public void Match(Action onLess,
        Action onEqual,
        Action onNotEqual,
        Action onGreater,
        Action onEvent,
        Action onNotEvent,
        Action onFee,
        Action onNotFee,
        Action onFromentity,
        Action onNotFromentity,
        Action<string> otherwise)
    {
        if (this == Less) onLess();
        else if (this == Equal) onEqual();
        else if (this == NotEqual) onNotEqual();
        else if (this == Greater) onGreater();
        else if (this == Event) onEvent();
        else if (this == NotEvent) onNotEvent();
        else if (this == Fee) onFee();
        else if (this == NotFee) onNotFee();
        else if (this == Fromentity) onFromentity();
        else if (this == NotFromentity) onNotFromentity();
        else otherwise(Value);
    }
}
