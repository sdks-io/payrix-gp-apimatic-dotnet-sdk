using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalTxnsBinType>))]
public sealed record TerminalTxnsBinType : OpenStringEnum<TerminalTxnsBinType>
{
    private TerminalTxnsBinType(string value) : base(value)
    {
    }

    public static readonly TerminalTxnsBinType Credit = new("CREDIT");

    public static readonly TerminalTxnsBinType Debit = new("DEBIT");

    public static readonly TerminalTxnsBinType Prepaid = new("PREPAID");

    public TResult Match<TResult>(Func<TResult> onCredit,
        Func<TResult> onDebit,
        Func<TResult> onPrepaid,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ when this == Prepaid => onPrepaid(),
            _ => otherwise(Value)
        };

    public void Match(Action onCredit, Action onDebit, Action onPrepaid, Action<string> otherwise)
    {
        if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else if (this == Prepaid) onPrepaid();
        else otherwise(Value);
    }
}
