using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PayoutFlowSchedule>))]
public sealed record PayoutFlowSchedule : OpenStringEnum<PayoutFlowSchedule>
{
    private PayoutFlowSchedule(string value) : base(value)
    {
    }

    public static readonly PayoutFlowSchedule Days = new("days");

    public static readonly PayoutFlowSchedule Weeks = new("weeks");

    public static readonly PayoutFlowSchedule Months = new("months");

    public static readonly PayoutFlowSchedule Years = new("years");

    public static readonly PayoutFlowSchedule Single = new("single");

    public TResult Match<TResult>(Func<TResult> onDays,
        Func<TResult> onWeeks,
        Func<TResult> onMonths,
        Func<TResult> onYears,
        Func<TResult> onSingle,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Days => onDays(),
            _ when this == Weeks => onWeeks(),
            _ when this == Months => onMonths(),
            _ when this == Years => onYears(),
            _ when this == Single => onSingle(),
            _ => otherwise(Value)
        };

    public void Match(Action onDays,
        Action onWeeks,
        Action onMonths,
        Action onYears,
        Action onSingle,
        Action<string> otherwise)
    {
        if (this == Days) onDays();
        else if (this == Weeks) onWeeks();
        else if (this == Months) onMonths();
        else if (this == Years) onYears();
        else if (this == Single) onSingle();
        else otherwise(Value);
    }
}
