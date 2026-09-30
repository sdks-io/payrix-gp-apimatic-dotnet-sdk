using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// A date indicator that determines how far back in time time-based checks should be checked. This field works in conjunction with the 'periodFactor' field, which multiplies this basic period.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>days</c> - <b>Days. The basic value for the date range is set in days.</b></description></item>
///   <item><description><c>weeks</c> - <b>Weeks. The basic value for the date range is set in weeks.</b></description></item>
///   <item><description><c>months</c> - <b>Months. The basic value for the date range is set in months.</b></description></item>
///   <item><description><c>years</c> - <b>Years. The basic value for the date range is set in years.</b></description></item>
///   <item><description><c>seconds</c> - <b>Seconds. The basic value for the date range is set in seconds.</b></description></item>
///   <item><description><c>minutes</c> - <b>Minutes. The basic value for the date range is set in minutes.</b></description></item>
///   <item><description><c>hours</c> - <b>Hours. The basic value for the date range is set in hours.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DecisionsPeriod1>))]
public sealed record DecisionsPeriod1 : OpenStringEnum<DecisionsPeriod1>
{
    private DecisionsPeriod1(string value) : base(value)
    {
    }

    public static readonly DecisionsPeriod1 Days = new("days");

    public static readonly DecisionsPeriod1 Weeks = new("weeks");

    public static readonly DecisionsPeriod1 Months = new("months");

    public static readonly DecisionsPeriod1 Years = new("years");

    public static readonly DecisionsPeriod1 Seconds = new("seconds");

    public static readonly DecisionsPeriod1 Minutes = new("minutes");

    public static readonly DecisionsPeriod1 Hours = new("hours");

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
