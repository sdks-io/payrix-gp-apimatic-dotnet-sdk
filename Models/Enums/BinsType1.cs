using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of the card used in the Transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>credit</c> - <b>Credit Card</b></description></item>
///   <item><description><c>debit</c> - <b>Debit Card</b></description></item>
///   <item><description><c>debitCredit</c> - <b>Debit or Credit Card</b></description></item>
///   <item><description><c>charge</c> - <b>Charge Card</b></description></item>
///   <item><description><c>prepaid</c> - <b>Prepaid Debit Card</b></description></item>
///   <item><description><c>bankAccount</c> - <b>Bank Account Card</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BinsType1>))]
public sealed record BinsType1 : OpenStringEnum<BinsType1>
{
    private BinsType1(string value) : base(value)
    {
    }

    public static readonly BinsType1 Credit = new("credit");

    public static readonly BinsType1 Debit = new("debit");

    public static readonly BinsType1 DebitCredit = new("debitCredit");

    public static readonly BinsType1 Charge = new("charge");

    public static readonly BinsType1 Prepaid = new("prepaid");

    public static readonly BinsType1 BankAccount = new("bankAccount");

    public TResult Match<TResult>(Func<TResult> onCredit,
        Func<TResult> onDebit,
        Func<TResult> onDebitCredit,
        Func<TResult> onCharge,
        Func<TResult> onPrepaid,
        Func<TResult> onBankAccount,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ when this == DebitCredit => onDebitCredit(),
            _ when this == Charge => onCharge(),
            _ when this == Prepaid => onPrepaid(),
            _ when this == BankAccount => onBankAccount(),
            _ => otherwise(Value)
        };

    public void Match(Action onCredit,
        Action onDebit,
        Action onDebitCredit,
        Action onCharge,
        Action onPrepaid,
        Action onBankAccount,
        Action<string> otherwise)
    {
        if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else if (this == DebitCredit) onDebitCredit();
        else if (this == Charge) onCharge();
        else if (this == Prepaid) onPrepaid();
        else if (this == BankAccount) onBankAccount();
        else otherwise(Value);
    }
}
