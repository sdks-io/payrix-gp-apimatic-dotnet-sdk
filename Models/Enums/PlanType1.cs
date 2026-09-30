using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of plan.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>recurring</c> - <b>A recurring payment plan (subcription).</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>installment</c>  - <b>A deferred payment installment plan.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlanType1>))]
public sealed record PlanType1 : OpenStringEnum<PlanType1>
{
    private PlanType1(string value) : base(value)
    {
    }

    public static readonly PlanType1 Recurring = new("recurring");

    public static readonly PlanType1 Installment = new("installment");

    public TResult Match<TResult>(Func<TResult> onRecurring,
        Func<TResult> onInstallment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Recurring => onRecurring(),
            _ when this == Installment => onInstallment(),
            _ => otherwise(Value)
        };

    public void Match(Action onRecurring, Action onInstallment, Action<string> otherwise)
    {
        if (this == Recurring) onRecurring();
        else if (this == Installment) onInstallment();
        else otherwise(Value);
    }
}
