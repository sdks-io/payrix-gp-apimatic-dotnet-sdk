using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The unit of measure for this Fee.
/// <para>
/// Notes:
///   * Percentage and Surcharge units will only apply to Fee schedules set to trigger from monetary events, such as an authorization, capture, or refund.
/// </para>
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Percentage.</b> The Fee is a percentage of the related event amount, specified in the 'amount' field in basis points.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>2</c> - <b>Fixed Amount.</b> The Fee is a fixed amount, specified in the 'amount' field as an integer in cents.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>3</c> - <b>Surcharge.</b> The Fee is a percentage of the related event amount as a surcharge (the calculated amount will be based on the assumption that the related event amount already contains the fee amount in it), specified in the 'amount' field in basis points.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<FeeUm1>))]
public sealed record FeeUm1 : OpenIntEnum<FeeUm1>
{
    private FeeUm1(long value) : base(value)
    {
    }

    public static readonly FeeUm1 Value1 = new(1L);

    public static readonly FeeUm1 Value2 = new(2L);

    public static readonly FeeUm1 Value3 = new(3L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action onValue2, Action onValue3, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else otherwise(Value);
    }
}
