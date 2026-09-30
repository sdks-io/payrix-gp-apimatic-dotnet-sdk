using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AggregationSchedule>))]
public sealed record AggregationSchedule : OpenStringEnum<AggregationSchedule>
{
    private AggregationSchedule(string value) : base(value)
    {
    }

    public static readonly AggregationSchedule Hours = new("hours");

    public static readonly AggregationSchedule Days = new("days");

    public static readonly AggregationSchedule Weeks = new("weeks");

    public static readonly AggregationSchedule Months = new("months");

    public static readonly AggregationSchedule Years = new("years");

    public TResult Match<TResult>(Func<TResult> onHours,
        Func<TResult> onDays,
        Func<TResult> onWeeks,
        Func<TResult> onMonths,
        Func<TResult> onYears,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Hours => onHours(),
            _ when this == Days => onDays(),
            _ when this == Weeks => onWeeks(),
            _ when this == Months => onMonths(),
            _ when this == Years => onYears(),
            _ => otherwise(Value)
        };

    public void Match(Action onHours,
        Action onDays,
        Action onWeeks,
        Action onMonths,
        Action onYears,
        Action<string> otherwise)
    {
        if (this == Hours) onHours();
        else if (this == Days) onDays();
        else if (this == Weeks) onWeeks();
        else if (this == Months) onMonths();
        else if (this == Years) onYears();
        else otherwise(Value);
    }
}
