using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountVerificationType>))]
public sealed record AccountVerificationType : OpenStringEnum<AccountVerificationType>
{
    private AccountVerificationType(string value) : base(value)
    {
    }

    public static readonly AccountVerificationType Debit = new("debit");

    public static readonly AccountVerificationType Credentials = new("credentials");

    public TResult Match<TResult>(Func<TResult> onDebit,
        Func<TResult> onCredentials,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Debit => onDebit(),
            _ when this == Credentials => onCredentials(),
            _ => otherwise(Value)
        };

    public void Match(Action onDebit, Action onCredentials, Action<string> otherwise)
    {
        if (this == Debit) onDebit();
        else if (this == Credentials) onCredentials();
        else otherwise(Value);
    }
}
