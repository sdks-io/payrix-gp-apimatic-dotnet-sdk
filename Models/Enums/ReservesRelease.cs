using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReservesRelease>))]
public sealed record ReservesRelease : OpenStringEnum<ReservesRelease>
{
    private ReservesRelease(string value) : base(value)
    {
    }

    public static readonly ReservesRelease Never = new("never");

    public static readonly ReservesRelease Days = new("days");

    public static readonly ReservesRelease Weeks = new("weeks");

    public static readonly ReservesRelease Months = new("months");

    public static readonly ReservesRelease Years = new("years");

    public TResult Match<TResult>(Func<TResult> onNever,
        Func<TResult> onDays,
        Func<TResult> onWeeks,
        Func<TResult> onMonths,
        Func<TResult> onYears,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Never => onNever(),
            _ when this == Days => onDays(),
            _ when this == Weeks => onWeeks(),
            _ when this == Months => onMonths(),
            _ when this == Years => onYears(),
            _ => otherwise(Value)
        };

    public void Match(Action onNever,
        Action onDays,
        Action onWeeks,
        Action onMonths,
        Action onYears,
        Action<string> otherwise)
    {
        if (this == Never) onNever();
        else if (this == Days) onDays();
        else if (this == Weeks) onWeeks();
        else if (this == Months) onMonths();
        else if (this == Years) onYears();
        else otherwise(Value);
    }
}
