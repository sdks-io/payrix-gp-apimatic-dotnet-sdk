using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The unit of measure for the amount on the plan.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>actual</c> - <b>An actual amount to charge, in cents.</b></description></item>
///   <item><description><c>percent</c> - <b>A percentage of another amount, in basis points.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlanUm1>))]
public sealed record PlanUm1 : OpenStringEnum<PlanUm1>
{
    private PlanUm1(string value) : base(value)
    {
    }

    public static readonly PlanUm1 Actual = new("actual");

    public static readonly PlanUm1 Percent = new("percent");

    public TResult Match<TResult>(Func<TResult> onActual, Func<TResult> onPercent, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Actual => onActual(),
            _ when this == Percent => onPercent(),
            _ => otherwise(Value)
        };

    public void Match(Action onActual, Action onPercent, Action<string> otherwise)
    {
        if (this == Actual) onActual();
        else if (this == Percent) onPercent();
        else otherwise(Value);
    }
}
