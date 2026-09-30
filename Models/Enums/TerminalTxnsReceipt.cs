using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalTxnsReceipt>))]
public sealed record TerminalTxnsReceipt : OpenStringEnum<TerminalTxnsReceipt>
{
    private TerminalTxnsReceipt(string value) : base(value)
    {
    }

    public static readonly TerminalTxnsReceipt NoReceipt = new("noReceipt");

    public static readonly TerminalTxnsReceipt Merchant = new("merchant");

    public static readonly TerminalTxnsReceipt Customer = new("customer");

    public static readonly TerminalTxnsReceipt Both = new("both");

    public TResult Match<TResult>(Func<TResult> onNoReceipt,
        Func<TResult> onMerchant,
        Func<TResult> onCustomer,
        Func<TResult> onBoth,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoReceipt => onNoReceipt(),
            _ when this == Merchant => onMerchant(),
            _ when this == Customer => onCustomer(),
            _ when this == Both => onBoth(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoReceipt, Action onMerchant, Action onCustomer, Action onBoth, Action<string> otherwise)
    {
        if (this == NoReceipt) onNoReceipt();
        else if (this == Merchant) onMerchant();
        else if (this == Customer) onCustomer();
        else if (this == Both) onBoth();
        else otherwise(Value);
    }
}
