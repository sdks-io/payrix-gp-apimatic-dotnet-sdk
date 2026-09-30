using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PlanUm>))]
public sealed record PlanUm : OpenStringEnum<PlanUm>
{
    private PlanUm(string value) : base(value)
    {
    }

    public static readonly PlanUm Actual = new("actual");

    public static readonly PlanUm Percent = new("percent");

    public TResult Match<TResult>(Func<TResult> onActual, Func<TResult> onPercent, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Actual => onActual(),
            _ when this == Percent => onPercent(),
            _ => otherwise(Value)
        };

    public void Match(Action onActual, Action onPercent, Action<string> otherwise)
    {
        if (this == Actual) onActual();
        else if (this == Percent) onPercent();
        else otherwise(Value);
    }
}
