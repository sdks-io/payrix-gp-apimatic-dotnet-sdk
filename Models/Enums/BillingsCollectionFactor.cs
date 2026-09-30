using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BillingsCollectionFactor>))]
public sealed record BillingsCollectionFactor : OpenStringEnum<BillingsCollectionFactor>
{
    private BillingsCollectionFactor(string value) : base(value)
    {
    }

    public static readonly BillingsCollectionFactor Days = new("days");

    public static readonly BillingsCollectionFactor Weeks = new("weeks");

    public static readonly BillingsCollectionFactor Months = new("months");

    public static readonly BillingsCollectionFactor Years = new("years");

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
