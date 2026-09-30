using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The last stage completed for risk underwriting review.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>createEntity</c> - <b>Merchant created.</b> No Signup Form submitted.</description></item>
///   <item><description><c>underwriting</c> - <b>Risk/Underwriting Review.</b> Merchant Signup Form submitted.</description></item>
///   <item><description><c>preboard</c> - <b>Preboard.</b> Check the Merchant before they are boarded.</description></item>
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
[JsonConverter(typeof(StringEnumConverter<EntityCheckStage2>))]
public sealed record EntityCheckStage2 : OpenStringEnum<EntityCheckStage2>
{
    private EntityCheckStage2(string value) : base(value)
    {
    }

    public static readonly EntityCheckStage2 CreateEntity = new("createEntity");

    public static readonly EntityCheckStage2 Underwriting = new("underwriting");

    public static readonly EntityCheckStage2 Preboard = new("preboard");

    public static readonly EntityCheckStage2 Postboard = new("postboard");

    public static readonly EntityCheckStage2 Txn = new("txn");

    public static readonly EntityCheckStage2 TxnVolume = new("txnVolume");

    public static readonly EntityCheckStage2 Payout = new("payout");

    public static readonly EntityCheckStage2 PayoutVolume = new("payoutVolume");

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
