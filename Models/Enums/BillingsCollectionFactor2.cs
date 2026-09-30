using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// A multiplier that you can use to adjust the set of data to be used in the collection calculation.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>days</c> - <b>Days.</b> Multiplier based on days.</description></item>
///   <item><description><c>weeks</c> - <b>Weeks.</b> Multiplier based on weeks.</description></item>
///   <item><description><c>months</c> - <b>Months.</b> Multiplier based on months.</description></item>
///   <item><description><c>years</c> - <b>Years.</b> Multiplier based on years.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BillingsCollectionFactor2>))]
public sealed record BillingsCollectionFactor2 : OpenStringEnum<BillingsCollectionFactor2>
{
    private BillingsCollectionFactor2(string value) : base(value)
    {
    }

    public static readonly BillingsCollectionFactor2 Days = new("days");

    public static readonly BillingsCollectionFactor2 Weeks = new("weeks");

    public static readonly BillingsCollectionFactor2 Months = new("months");

    public static readonly BillingsCollectionFactor2 Years = new("years");

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
