using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The final action taken on the hold while it's been released.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Holds released because the hold resource was approved.</b></description></item>
///   <item><description><c>2</c> - <b>Holds released because the hold resource was cancelled.</b></description></item>
///   <item><description><c>3</c> - <b>Holds released because the hold resource was refunded.</b></description></item>
///   <item><description><c>4</c> - <b>Holds released because the hold resource was failed.</b></description></item>
///   <item><description><c>5</c> - <b>Expired.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<HoldsReleaseAction1>))]
public sealed record HoldsReleaseAction1 : OpenIntEnum<HoldsReleaseAction1>
{
    private HoldsReleaseAction1(long value) : base(value)
    {
    }

    public static readonly HoldsReleaseAction1 Value1 = new(1L);

    public static readonly HoldsReleaseAction1 Value2 = new(2L);

    public static readonly HoldsReleaseAction1 Value3 = new(3L);

    public static readonly HoldsReleaseAction1 Value4 = new(4L);

    public static readonly HoldsReleaseAction1 Value5 = new(5L);

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
