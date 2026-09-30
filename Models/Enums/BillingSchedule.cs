using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BillingSchedule>))]
public sealed record BillingSchedule : OpenStringEnum<BillingSchedule>
{
    private BillingSchedule(string value) : base(value)
    {
    }

    public static readonly BillingSchedule Days = new("days");

    public static readonly BillingSchedule Weeks = new("weeks");

    public static readonly BillingSchedule Months = new("months");

    public static readonly BillingSchedule Years = new("years");

    public TResult Match<TResult>(Func<TResult> onDays,
        Func<TResult> onWeeks,
        Func<TResult> onMonths,
        Func<TResult> onYears,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Days => onDays(),
            _ when this == Weeks => onWeeks(),
            _ when this == Months => onMonths(),
            _ when this == Years => onYears(),
            _ => otherwise(Value)
        };

    public void Match(Action onDays, Action onWeeks, Action onMonths, Action onYears, Action<string> otherwise)
    {
        if (this == Days) onDays();
        else if (this == Weeks) onWeeks();
        else if (this == Months) onMonths();
        else if (this == Years) onYears();
        else otherwise(Value);
    }
}
