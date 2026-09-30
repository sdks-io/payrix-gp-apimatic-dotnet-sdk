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
///   <item><description><c>1</c> - <b>Daily.</b> The Payout is paid every day.</description></item>
///   <item><description><c>2</c> - <b>Weekly.</b> The Payout is paid every week.</description></item>
///   <item><description><c>3</c> - <b>Monthly.</b> The Payout is paid every month.</description></item>
///   <item><description><c>4</c> - <b>Annually.</b> The Payout is paid every year.</description></item>
///   <item><description><c>5</c> - <b>Single.</b> The Payout is a one-off payment.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<PayoutSchedule1>))]
public sealed record PayoutSchedule1 : OpenIntEnum<PayoutSchedule1>
{
    private PayoutSchedule1(long value) : base(value)
    {
    }

    public static readonly PayoutSchedule1 Value1 = new(1L);

    public static readonly PayoutSchedule1 Value2 = new(2L);

    public static readonly PayoutSchedule1 Value3 = new(3L);

    public static readonly PayoutSchedule1 Value4 = new(4L);

    public static readonly PayoutSchedule1 Value5 = new(5L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else otherwise(Value);
    }
}
