using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DecisionsTarget>))]
public sealed record DecisionsTarget : OpenStringEnum<DecisionsTarget>
{
    private DecisionsTarget(string value) : base(value)
    {
    }

    public static readonly DecisionsTarget Activation = new("activation");

    public static readonly DecisionsTarget Auth = new("auth");

    public static readonly DecisionsTarget Postauth = new("postauth");

    public static readonly DecisionsTarget Capture = new("capture");

    public static readonly DecisionsTarget Refund = new("refund");

    public static readonly DecisionsTarget CreateEntity = new("createEntity");

    public static readonly DecisionsTarget Underwriting = new("underwriting");

    public static readonly DecisionsTarget Preboard = new("preboard");

    public static readonly DecisionsTarget Postboard = new("postboard");

    public static readonly DecisionsTarget Txn = new("txn");

    public static readonly DecisionsTarget TxnVolume = new("txnVolume");

    public static readonly DecisionsTarget Payout = new("payout");

    public static readonly DecisionsTarget PayoutVolume = new("payoutVolume");

    public TResult Match<TResult>(Func<TResult> onActivation,
        Func<TResult> onAuth,
        Func<TResult> onPostauth,
        Func<TResult> onCapture,
        Func<TResult> onRefund,
        Func<TResult> onCreateEntity,
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
            _ when this == Activation => onActivation(),
            _ when this == Auth => onAuth(),
            _ when this == Postauth => onPostauth(),
            _ when this == Capture => onCapture(),
            _ when this == Refund => onRefund(),
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

    public void Match(Action onActivation,
        Action onAuth,
        Action onPostauth,
        Action onCapture,
        Action onRefund,
        Action onCreateEntity,
        Action onUnderwriting,
        Action onPreboard,
        Action onPostboard,
        Action onTxn,
        Action onTxnVolume,
        Action onPayout,
        Action onPayoutVolume,
        Action<string> otherwise)
    {
        if (this == Activation) onActivation();
        else if (this == Auth) onAuth();
        else if (this == Postauth) onPostauth();
        else if (this == Capture) onCapture();
        else if (this == Refund) onRefund();
        else if (this == CreateEntity) onCreateEntity();
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
