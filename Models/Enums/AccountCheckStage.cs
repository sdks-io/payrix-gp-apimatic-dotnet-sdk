using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountCheckStage>))]
public sealed record AccountCheckStage : OpenStringEnum<AccountCheckStage>
{
    private AccountCheckStage(string value) : base(value)
    {
    }

    public static readonly AccountCheckStage CreateAccount = new("createAccount");

    public TResult Match<TResult>(Func<TResult> onCreateAccount, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CreateAccount => onCreateAccount(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreateAccount, Action<string> otherwise)
    {
        if (this == CreateAccount) onCreateAccount();
        else otherwise(Value);
    }
}
