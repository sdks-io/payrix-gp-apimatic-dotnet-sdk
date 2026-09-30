using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntityCheckStage>))]
public sealed record EntityCheckStage : OpenStringEnum<EntityCheckStage>
{
    private EntityCheckStage(string value) : base(value)
    {
    }

    public static readonly EntityCheckStage CreateEntity = new("createEntity");

    public static readonly EntityCheckStage Underwriting = new("underwriting");

    public static readonly EntityCheckStage Preboard = new("preboard");

    public static readonly EntityCheckStage Postboard = new("postboard");

    public static readonly EntityCheckStage Txn = new("txn");

    public static readonly EntityCheckStage TxnVolume = new("txnVolume");

    public static readonly EntityCheckStage Payout = new("payout");

    public static readonly EntityCheckStage PayoutVolume = new("payoutVolume");

    public TResult Match<TResult>(Func<TResult> onCreateEntity,
        Func<TResult> onUnderwriting,
        Func<TResult> onPreboard,
        Func<TResult> onPostboard,
        Func<TResult> onTxn,
        Func<TResult> onTxnVolume,
        Func<TResult> onPayout,
        Func<TResult> onPayoutVolume,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CreateEntity => onCreateEntity(),
            _ when this == Underwriting => onUnderwriting(),
            _ when this == Preboard => onPreboard(),
            _ when this == Postboard => onPostboard(),
            _ when this == Txn => onTxn(),
            _ when this == TxnVolume => onTxnVolume(),
            _ when this == Payout => onPayout(),
            _ when this == PayoutVolume => onPayoutVolume(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreateEntity,
        Action onUnderwriting,
        Action onPreboard,
        Action onPostboard,
        Action onTxn,
        Action onTxnVolume,
        Action onPayout,
        Action onPayoutVolume,
        Action<string> otherwise)
    {
        if (this == CreateEntity) onCreateEntity();
        else if (this == Underwriting) onUnderwriting();
        else if (this == Preboard) onPreboard();
        else if (this == Postboard) onPostboard();
        else if (this == Txn) onTxn();
        else if (this == TxnVolume) onTxnVolume();
        else if (this == Payout) onPayout();
        else if (this == PayoutVolume) onPayoutVolume();
        else otherwise(Value);
    }
}
