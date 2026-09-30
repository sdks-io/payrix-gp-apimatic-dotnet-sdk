using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The schedule that determines when the funds in this Reserve should be released, which can have valid values such as never, days, weeks, months, or years.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>never</c> - <b>Never.</b></description></item>
///   <item><description><c>days</c> - <b>Daily. The funds are released every day.</b></description></item>
///   <item><description><c>weeks</c> - <b>Weekly. The funds are released every week.</b></description></item>
///   <item><description><c>months</c> - <b>Monthly. The funds are released every month.</b></description></item>
///   <item><description><c>years</c> - <b>Annually. The funds are released every year.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReservesRelease2>))]
public sealed record ReservesRelease2 : OpenStringEnum<ReservesRelease2>
{
    private ReservesRelease2(string value) : base(value)
    {
    }

    public static readonly ReservesRelease2 Never = new("never");

    public static readonly ReservesRelease2 Days = new("days");

    public static readonly ReservesRelease2 Weeks = new("weeks");

    public static readonly ReservesRelease2 Months = new("months");

    public static readonly ReservesRelease2 Years = new("years");

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
