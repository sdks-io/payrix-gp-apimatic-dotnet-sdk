using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PayoutFlowUm>))]
public sealed record PayoutFlowUm : OpenStringEnum<PayoutFlowUm>
{
    private PayoutFlowUm(string value) : base(value)
    {
    }

    public static readonly PayoutFlowUm Percent = new("percent");

    public static readonly PayoutFlowUm Actual = new("actual");

    public static readonly PayoutFlowUm Percentneg = new("percentneg");

    public TResult Match<TResult>(Func<TResult> onPercent,
        Func<TResult> onActual,
        Func<TResult> onPercentneg,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Percent => onPercent(),
            _ when this == Actual => onActual(),
            _ when this == Percentneg => onPercentneg(),
            _ => otherwise(Value)
        };

    public void Match(Action onPercent, Action onActual, Action onPercentneg, Action<string> otherwise)
    {
        if (this == Percent) onPercent();
        else if (this == Actual) onActual();
        else if (this == Percentneg) onPercentneg();
        else otherwise(Value);
    }
}
