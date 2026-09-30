using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether the terminal should print a receipt or not.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>noReceipt</c> - <b>No Receipt.</b></description></item>
///   <item><description><c>merchant</c> - <b>Merchant copy only.</b></description></item>
///   <item><description><c>customer</c> - <b>Customer copy only.</b></description></item>
///   <item><description><c>both</c> - <b>Merchant and Customer copy.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalTxnsReceipt1>))]
public sealed record TerminalTxnsReceipt1 : OpenStringEnum<TerminalTxnsReceipt1>
{
    private TerminalTxnsReceipt1(string value) : base(value)
    {
    }

    public static readonly TerminalTxnsReceipt1 NoReceipt = new("noReceipt");

    public static readonly TerminalTxnsReceipt1 Merchant = new("merchant");

    public static readonly TerminalTxnsReceipt1 Customer = new("customer");

    public static readonly TerminalTxnsReceipt1 Both = new("both");

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
