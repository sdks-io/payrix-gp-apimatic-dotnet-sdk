using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DecisionsPeriod>))]
public sealed record DecisionsPeriod : OpenStringEnum<DecisionsPeriod>
{
    private DecisionsPeriod(string value) : base(value)
    {
    }

    public static readonly DecisionsPeriod Days = new("days");

    public static readonly DecisionsPeriod Weeks = new("weeks");

    public static readonly DecisionsPeriod Months = new("months");

    public static readonly DecisionsPeriod Years = new("years");

    public static readonly DecisionsPeriod Seconds = new("seconds");

    public static readonly DecisionsPeriod Minutes = new("minutes");

    public static readonly DecisionsPeriod Hours = new("hours");

    public TResult Match<TResult>(Func<TResult> onDays,
        Func<TResult> onWeeks,
        Func<TResult> onMonths,
        Func<TResult> onYears,
        Func<TResult> onSeconds,
        Func<TResult> onMinutes,
        Func<TResult> onHours,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Days => onDays(),
            _ when this == Weeks => onWeeks(),
            _ when this == Months => onMonths(),
            _ when this == Years => onYears(),
            _ when this == Seconds => onSeconds(),
            _ when this == Minutes => onMinutes(),
            _ when this == Hours => onHours(),
            _ => otherwise(Value)
        };

    public void Match(Action onDays,
        Action onWeeks,
        Action onMonths,
        Action onYears,
        Action onSeconds,
        Action onMinutes,
        Action onHours,
        Action<string> otherwise)
    {
        if (this == Days) onDays();
        else if (this == Weeks) onWeeks();
        else if (this == Months) onMonths();
        else if (this == Years) onYears();
        else if (this == Seconds) onSeconds();
        else if (this == Minutes) onMinutes();
        else if (this == Hours) onHours();
        else otherwise(Value);
    }
}
