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
///   <item><description><c>percent</c> - <b>Percentage unit measurement.</b> (Percentage of Funds).</description></item>
///   <item><description><c>actual</c> - <b>Actual unit measurement.</b> (Exact Currency Amount).</description></item>
///   <item><description><c>percentneg</c> - <b>Negative Percentage unit measurement.</b> (Replenish account by percent negative back to $0).</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutFlowUm1>))]
public sealed record PayoutFlowUm1 : OpenStringEnum<PayoutFlowUm1>
{
    private PayoutFlowUm1(string value) : base(value)
    {
    }

    public static readonly PayoutFlowUm1 Percent = new("percent");

    public static readonly PayoutFlowUm1 Actual = new("actual");

    public static readonly PayoutFlowUm1 Percentneg = new("percentneg");

    public TResult Match<TResult>(Func<TResult> onPercent,
        Func<TResult> onActual,
        Func<TResult> onPercentneg,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Percent => onPercent(),
            _ when this == Actual => onActual(),
            _ when this == Percentneg => onPercentneg(),
            _ => otherwise(Value)
        };

    public void Match(Action onPercent, Action onActual, Action onPercentneg, Action<string> otherwise)
    {
        if (this == Percent) onPercent();
        else if (this == Actual) onActual();
        else if (this == Percentneg) onPercentneg();
        else otherwise(Value);
    }
}
