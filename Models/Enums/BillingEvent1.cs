using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of event that triggers billing.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>fees</c> - <b>Fee.</b> Fee events trigger the billing configuration.</description></item>
///   <item><description><c>chargebacks</c> - <b>Chargebacks.</b> Chargeback events trigger the billing configuration.</description></item>
///   <item><description><c>returns</c> - <b>Returns.</b> Return events trigger the billing configuration.</description></item>
///   <item><description><c>profitShares</c> - <b>Profit Shares.</b> Profit Sharing events trigger the billing configuration.</description></item>
///   <item><description><c>revShares</c> - <b>RevShares.</b> Rev Sharing events trigger the billing configuration.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BillingEvent1>))]
public sealed record BillingEvent1 : OpenStringEnum<BillingEvent1>
{
    private BillingEvent1(string value) : base(value)
    {
    }

    public static readonly BillingEvent1 Fees = new("fees");

    public static readonly BillingEvent1 Chargebacks = new("chargebacks");

    public static readonly BillingEvent1 Returns = new("returns");

    public static readonly BillingEvent1 ProfitShares = new("profitShares");

    public static readonly BillingEvent1 RevShares = new("revShares");

    public TResult Match<TResult>(Func<TResult> onFees,
        Func<TResult> onChargebacks,
        Func<TResult> onReturns,
        Func<TResult> onProfitShares,
        Func<TResult> onRevShares,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Fees => onFees(),
            _ when this == Chargebacks => onChargebacks(),
            _ when this == Returns => onReturns(),
            _ when this == ProfitShares => onProfitShares(),
            _ when this == RevShares => onRevShares(),
            _ => otherwise(Value)
        };

    public void Match(Action onFees,
        Action onChargebacks,
        Action onReturns,
        Action onProfitShares,
        Action onRevShares,
        Action<string> otherwise)
    {
        if (this == Fees) onFees();
        else if (this == Chargebacks) onChargebacks();
        else if (this == Returns) onReturns();
        else if (this == ProfitShares) onProfitShares();
        else if (this == RevShares) onRevShares();
        else otherwise(Value);
    }
}
