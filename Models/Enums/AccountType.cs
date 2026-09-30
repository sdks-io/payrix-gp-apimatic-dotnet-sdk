using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountType>))]
public sealed record AccountType : OpenStringEnum<AccountType>
{
    private AccountType(string value) : base(value)
    {
    }

    public static readonly AccountType All = new("all");

    public static readonly AccountType Credit = new("credit");

    public static readonly AccountType Debit = new("debit");

    public TResult Match<TResult>(Func<TResult> onAll,
        Func<TResult> onCredit,
        Func<TResult> onDebit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == All => onAll(),
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ => otherwise(Value)
        };

    public void Match(Action onAll, Action onCredit, Action onDebit, Action<string> otherwise)
    {
        if (this == All) onAll();
        else if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else otherwise(Value);
    }
}
