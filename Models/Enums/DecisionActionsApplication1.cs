using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Where the action defined by this DecisionAction should apply.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>account</c> - <b>Account type Decision.</b></description></item>
///   <item><description><c>txn</c> - <b>Txn type Decision.</b></description></item>
///   <item><description><c>entity</c> - <b>Entity type Decision.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DecisionActionsApplication1>))]
public sealed record DecisionActionsApplication1 : OpenStringEnum<DecisionActionsApplication1>
{
    private DecisionActionsApplication1(string value) : base(value)
    {
    }

    public static readonly DecisionActionsApplication1 Account = new("account");

    public static readonly DecisionActionsApplication1 Txn = new("txn");

    public static readonly DecisionActionsApplication1 Entity = new("entity");

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
