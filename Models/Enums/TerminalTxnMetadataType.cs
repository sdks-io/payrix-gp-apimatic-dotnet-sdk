using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalTxnMetadataType>))]
public sealed record TerminalTxnMetadataType : OpenStringEnum<TerminalTxnMetadataType>
{
    private TerminalTxnMetadataType(string value) : base(value)
    {
    }

    public static readonly TerminalTxnMetadataType Amounts = new("amounts");

    public static readonly TerminalTxnMetadataType Emv = new("emv");

    public static readonly TerminalTxnMetadataType Network = new("network");

    public static readonly TerminalTxnMetadataType Timeout = new("timeout");

    public static readonly TerminalTxnMetadataType FirstTxn = new("firstTxn");

    public static readonly TerminalTxnMetadataType Discretionary = new("discretionary");

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
