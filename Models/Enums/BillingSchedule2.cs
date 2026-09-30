using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The schedule that determines when this Billing is triggered to start collecting data.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>days</c> - <b>Daily schedule.</b></description></item>
///   <item><description><c>weeks</c> - <b>Weekly schedule.</b></description></item>
///   <item><description><c>months</c> - <b>Monthly schedule.</b></description></item>
///   <item><description><c>years</c> - <b>Annual schedule.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BillingSchedule2>))]
public sealed record BillingSchedule2 : OpenStringEnum<BillingSchedule2>
{
    private BillingSchedule2(string value) : base(value)
    {
    }

    public static readonly BillingSchedule2 Days = new("days");

    public static readonly BillingSchedule2 Weeks = new("weeks");

    public static readonly BillingSchedule2 Months = new("months");

    public static readonly BillingSchedule2 Years = new("years");

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
