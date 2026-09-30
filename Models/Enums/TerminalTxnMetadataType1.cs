using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of metadata associated with the Terminal transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>amounts</c> - <b>Transaction Amounts</b></description></item>
///   <item><description><c>emv</c> - <b>EuroPay, Mastercard, Visa Transactions</b></description></item>
///   <item><description><c>network</c> - <b>Network Transactions</b></description></item>
///   <item><description><c>timeout</c> - <b>Transaction Timeouts</b></description></item>
///   <item><description><c>firstTxn</c> - <b>First Transaction</b></description></item>
///   <item><description><c>discretionary</c> - <b>Custom Transaction Field Value</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalTxnMetadataType1>))]
public sealed record TerminalTxnMetadataType1 : OpenStringEnum<TerminalTxnMetadataType1>
{
    private TerminalTxnMetadataType1(string value) : base(value)
    {
    }

    public static readonly TerminalTxnMetadataType1 Amounts = new("amounts");

    public static readonly TerminalTxnMetadataType1 Emv = new("emv");

    public static readonly TerminalTxnMetadataType1 Network = new("network");

    public static readonly TerminalTxnMetadataType1 Timeout = new("timeout");

    public static readonly TerminalTxnMetadataType1 FirstTxn = new("firstTxn");

    public static readonly TerminalTxnMetadataType1 Discretionary = new("discretionary");

    public TResult Match<TResult>(Func<TResult> onAmounts,
        Func<TResult> onEmv,
        Func<TResult> onNetwork,
        Func<TResult> onTimeout,
        Func<TResult> onFirstTxn,
        Func<TResult> onDiscretionary,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Amounts => onAmounts(),
            _ when this == Emv => onEmv(),
            _ when this == Network => onNetwork(),
            _ when this == Timeout => onTimeout(),
            _ when this == FirstTxn => onFirstTxn(),
            _ when this == Discretionary => onDiscretionary(),
            _ => otherwise(Value)
        };

    public void Match(Action onAmounts,
        Action onEmv,
        Action onNetwork,
        Action onTimeout,
        Action onFirstTxn,
        Action onDiscretionary,
        Action<string> otherwise)
    {
        if (this == Amounts) onAmounts();
        else if (this == Emv) onEmv();
        else if (this == Network) onNetwork();
        else if (this == Timeout) onTimeout();
        else if (this == FirstTxn) onFirstTxn();
        else if (this == Discretionary) onDiscretionary();
        else otherwise(Value);
    }
}
