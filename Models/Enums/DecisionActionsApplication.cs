using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DecisionActionsApplication>))]
public sealed record DecisionActionsApplication : OpenStringEnum<DecisionActionsApplication>
{
    private DecisionActionsApplication(string value) : base(value)
    {
    }

    public static readonly DecisionActionsApplication Account = new("account");

    public static readonly DecisionActionsApplication Txn = new("txn");

    public static readonly DecisionActionsApplication Entity = new("entity");

    public TResult Match<TResult>(Func<TResult> onAccount,
        Func<TResult> onTxn,
        Func<TResult> onEntity,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Account => onAccount(),
            _ when this == Txn => onTxn(),
            _ when this == Entity => onEntity(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccount, Action onTxn, Action onEntity, Action<string> otherwise)
    {
        if (this == Account) onAccount();
        else if (this == Txn) onTxn();
        else if (this == Entity) onEntity();
        else otherwise(Value);
    }
}
