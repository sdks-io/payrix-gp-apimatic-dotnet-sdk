using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BinsType>))]
public sealed record BinsType : OpenStringEnum<BinsType>
{
    private BinsType(string value) : base(value)
    {
    }

    public static readonly BinsType Credit = new("credit");

    public static readonly BinsType Debit = new("debit");

    public static readonly BinsType DebitCredit = new("debitCredit");

    public static readonly BinsType Charge = new("charge");

    public static readonly BinsType Prepaid = new("prepaid");

    public static readonly BinsType BankAccount = new("bankAccount");

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
