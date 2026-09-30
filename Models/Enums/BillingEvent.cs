using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BillingEvent>))]
public sealed record BillingEvent : OpenStringEnum<BillingEvent>
{
    private BillingEvent(string value) : base(value)
    {
    }

    public static readonly BillingEvent Fees = new("fees");

    public static readonly BillingEvent Chargebacks = new("chargebacks");

    public static readonly BillingEvent Returns = new("returns");

    public static readonly BillingEvent ProfitShares = new("profitShares");

    public static readonly BillingEvent RevShares = new("revShares");

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
