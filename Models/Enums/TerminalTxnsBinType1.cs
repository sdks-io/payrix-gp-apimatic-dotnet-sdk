using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of bank issuer number (BIN) that allows for resulting transactions.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>CREDIT</c> - <b>Credit BIN Type.</b></description></item>
///   <item><description><c>DEBIT</c> - <b>Debit BIN Type.</b></description></item>
///   <item><description><c>PREPAID</c> - <b>Prepaid BIN Type.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalTxnsBinType1>))]
public sealed record TerminalTxnsBinType1 : OpenStringEnum<TerminalTxnsBinType1>
{
    private TerminalTxnsBinType1(string value) : base(value)
    {
    }

    public static readonly TerminalTxnsBinType1 Credit = new("CREDIT");

    public static readonly TerminalTxnsBinType1 Debit = new("DEBIT");

    public static readonly TerminalTxnsBinType1 Prepaid = new("PREPAID");

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
