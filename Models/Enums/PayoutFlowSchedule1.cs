using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The schedule that determines when the Payout resource that is created should be triggered to be paid.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>days</c> - <b>Daily.</b> The Payout is paid every day.</description></item>
///   <item><description><c>weeks</c> - <b>Weekly.</b> The Payout is paid every week.</description></item>
///   <item><description><c>months</c> - <b>Monthly.</b> The Payout is paid every month.</description></item>
///   <item><description><c>years</c> - <b>Annually.</b> The Payout is paid every year.</description></item>
///   <item><description><c>single</c> - <b>Single.</b> The Payout is a one-off payment.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutFlowSchedule1>))]
public sealed record PayoutFlowSchedule1 : OpenStringEnum<PayoutFlowSchedule1>
{
    private PayoutFlowSchedule1(string value) : base(value)
    {
    }

    public static readonly PayoutFlowSchedule1 Days = new("days");

    public static readonly PayoutFlowSchedule1 Weeks = new("weeks");

    public static readonly PayoutFlowSchedule1 Months = new("months");

    public static readonly PayoutFlowSchedule1 Years = new("years");

    public static readonly PayoutFlowSchedule1 Single = new("single");

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
