using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The target that this decision should apply at.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>activation</c> - <b>Terminal activation.</b></description></item>
///   <item><description><c>auth</c> - <b>Apply this decision during transaction authorization.</b></description></item>
///   <item><description><c>postauth</c> - <b>Immediately after authorization.</b></description></item>
///   <item><description><c>capture</c> - <b>Apply this decision during transaction capture.</b></description></item>
///   <item><description><c>refund</c> - <b>Apply this decision when processing a refund.</b></description></item>
///   <item><description><c>createEntity</c> - <b>createEntity. Process decisions during entity creation.</b></description></item>
///   <item><description><c>underwriting</c> - <b>Underwriting. Check the members before they are boarded.</b></description></item>
///   <item><description><c>preboard</c> - <b>Preboard. Check the Merchant before they are boarded.</b></description></item>
///   <item><description><c>postboard</c> - <b>Check the Merchant after they are boarded.</b></description></item>
///   <item><description><c>txn</c> - <b>Check the Merchant when they process a Transaction.</b></description></item>
///   <item><description><c>txnVolume</c> - <b>Check the Merchant when their transaction volume hits a certain amount.</b></description></item>
///   <item><description><c>payout</c> - <b>Check the Merchant when a Payout occurs.</b></description></item>
///   <item><description><c>payoutVolume</c> - <b>Check the Merchant when the volume of Payouts to the Merchant hits a certain amount.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DecisionsTarget1>))]
public sealed record DecisionsTarget1 : OpenStringEnum<DecisionsTarget1>
{
    private DecisionsTarget1(string value) : base(value)
    {
    }

    public static readonly DecisionsTarget1 Activation = new("activation");

    public static readonly DecisionsTarget1 Auth = new("auth");

    public static readonly DecisionsTarget1 Postauth = new("postauth");

    public static readonly DecisionsTarget1 Capture = new("capture");

    public static readonly DecisionsTarget1 Refund = new("refund");

    public static readonly DecisionsTarget1 CreateEntity = new("createEntity");

    public static readonly DecisionsTarget1 Underwriting = new("underwriting");

    public static readonly DecisionsTarget1 Preboard = new("preboard");

    public static readonly DecisionsTarget1 Postboard = new("postboard");

    public static readonly DecisionsTarget1 Txn = new("txn");

    public static readonly DecisionsTarget1 TxnVolume = new("txnVolume");

    public static readonly DecisionsTarget1 Payout = new("payout");

    public static readonly DecisionsTarget1 PayoutVolume = new("payoutVolume");

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
