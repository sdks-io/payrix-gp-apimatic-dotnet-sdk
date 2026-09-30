using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The unit of measure for this Payout is the percentage of funds.
/// If the Entity has a negative balance of $10 and the amount is set to 10000 (100%),
/// then $10 will be drawn from their account to fully replenish the balance to $0.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Percentage unit measurement.</b> (Percentage of Funds).</description></item>
///   <item><description><c>2</c> - <b>Actual unit measurement.</b> (Exact Currency Amount).</description></item>
///   <item><description><c>3</c> - <b>Negative Percentage unit measurement.</b> (Replenish account by percent negative back to $0).</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<PayoutUm1>))]
public sealed record PayoutUm1 : OpenIntEnum<PayoutUm1>
{
    private PayoutUm1(long value) : base(value)
    {
    }

    public static readonly PayoutUm1 Value1 = new(1L);

    public static readonly PayoutUm1 Value2 = new(2L);

    public static readonly PayoutUm1 Value3 = new(3L);

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
