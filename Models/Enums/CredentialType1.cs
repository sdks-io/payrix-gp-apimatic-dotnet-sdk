using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of Transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Credit Card Only:</b> Sale Transaction. Processes a sale and charges the customer.</description></item>
///   <item><description><c>2</c> - <b>Credit Card Only:</b> Auth Transaction. Authorizes and holds the requested total on the credit card.</description></item>
///   <item><description><c>3</c> - <b>Credit Card Only:</b> Capture Transaction. Finalizes a prior Auth Transaction and charges the customer.</description></item>
///   <item><description><c>4</c> - <b>Credit Card Only:</b> Reverse Authorization. Reverses a prior Auth or Sale Transaction and releases the credit hold.</description></item>
///   <item><description><c>5</c> - <b>Credit Card Only:</b> Refund Transaction. Refunds a prior Capture or Sale Transaction (total may be specified for a partial refund).</description></item>
///   <item><description><c>7</c> - <b>Echeck Only:</b> Echeck Sale Transaction. Sale Transaction for ECheck payment.</description></item>
///   <item><description><c>8</c> - <b>ECheck Only:</b> ECheck Refund Transaction. Refund Transaction for prior ECheck Sale Transaction.</description></item>
///   <item><description><c>11</c> - <b>Echeck Only:</b> Echeck Redeposit Transaction. Attempt to redeposit a prior failed eCheck Sale Transaction.</description></item>
///   <item><description><c>12</c> - <b>Echeck Only:</b> Echeck Account Verification Transaction. Attempt to verify eCheck payment details.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CredentialType1>))]
public sealed record CredentialType1 : OpenStringEnum<CredentialType1>
{
    private CredentialType1(string value) : base(value)
    {
    }

    public static readonly CredentialType1 Transaction = new("transaction");

    public static readonly CredentialType1 Batch = new("batch");

    public static readonly CredentialType1 Boarding = new("boarding");

    public static readonly CredentialType1 PaymentUpdates = new("paymentUpdates");

    public static readonly CredentialType1 Payout = new("payout");

    public static readonly CredentialType1 PayoutCredit = new("payoutCredit");

    public static readonly CredentialType1 PayoutDebit = new("payoutDebit");

    public static readonly CredentialType1 Chargeback = new("chargeback");

    public static readonly CredentialType1 TxnReport = new("txnReport");

    public static readonly CredentialType1 Account = new("account");

    public static readonly CredentialType1 EntityDecision = new("entityDecision");

    public static readonly CredentialType1 TxnCheck = new("txnCheck");

    public static readonly CredentialType1 PayoutReport = new("payoutReport");

    public static readonly CredentialType1 FeeReport = new("feeReport");

    public static readonly CredentialType1 ChargebackReport = new("chargebackReport");

    public static readonly CredentialType1 BinReport = new("binReport");

    public static readonly CredentialType1 Watchlist = new("watchlist");

    public static readonly CredentialType1 Encryption = new("encryption");

    public static readonly CredentialType1 ChangeRequest = new("changeRequest");

    public TResult Match<TResult>(Func<TResult> onTransaction,
        Func<TResult> onBatch,
        Func<TResult> onBoarding,
        Func<TResult> onPaymentUpdates,
        Func<TResult> onPayout,
        Func<TResult> onPayoutCredit,
        Func<TResult> onPayoutDebit,
        Func<TResult> onChargeback,
        Func<TResult> onTxnReport,
        Func<TResult> onAccount,
        Func<TResult> onEntityDecision,
        Func<TResult> onTxnCheck,
        Func<TResult> onPayoutReport,
        Func<TResult> onFeeReport,
        Func<TResult> onChargebackReport,
        Func<TResult> onBinReport,
        Func<TResult> onWatchlist,
        Func<TResult> onEncryption,
        Func<TResult> onChangeRequest,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Transaction => onTransaction(),
            _ when this == Batch => onBatch(),
            _ when this == Boarding => onBoarding(),
            _ when this == PaymentUpdates => onPaymentUpdates(),
            _ when this == Payout => onPayout(),
            _ when this == PayoutCredit => onPayoutCredit(),
            _ when this == PayoutDebit => onPayoutDebit(),
            _ when this == Chargeback => onChargeback(),
            _ when this == TxnReport => onTxnReport(),
            _ when this == Account => onAccount(),
            _ when this == EntityDecision => onEntityDecision(),
            _ when this == TxnCheck => onTxnCheck(),
            _ when this == PayoutReport => onPayoutReport(),
            _ when this == FeeReport => onFeeReport(),
            _ when this == ChargebackReport => onChargebackReport(),
            _ when this == BinReport => onBinReport(),
            _ when this == Watchlist => onWatchlist(),
            _ when this == Encryption => onEncryption(),
            _ when this == ChangeRequest => onChangeRequest(),
            _ => otherwise(Value)
        };

    public void Match(Action onTransaction,
        Action onBatch,
        Action onBoarding,
        Action onPaymentUpdates,
        Action onPayout,
        Action onPayoutCredit,
        Action onPayoutDebit,
        Action onChargeback,
        Action onTxnReport,
        Action onAccount,
        Action onEntityDecision,
        Action onTxnCheck,
        Action onPayoutReport,
        Action onFeeReport,
        Action onChargebackReport,
        Action onBinReport,
        Action onWatchlist,
        Action onEncryption,
        Action onChangeRequest,
        Action<string> otherwise)
    {
        if (this == Transaction) onTransaction();
        else if (this == Batch) onBatch();
        else if (this == Boarding) onBoarding();
        else if (this == PaymentUpdates) onPaymentUpdates();
        else if (this == Payout) onPayout();
        else if (this == PayoutCredit) onPayoutCredit();
        else if (this == PayoutDebit) onPayoutDebit();
        else if (this == Chargeback) onChargeback();
        else if (this == TxnReport) onTxnReport();
        else if (this == Account) onAccount();
        else if (this == EntityDecision) onEntityDecision();
        else if (this == TxnCheck) onTxnCheck();
        else if (this == PayoutReport) onPayoutReport();
        else if (this == FeeReport) onFeeReport();
        else if (this == ChargebackReport) onChargebackReport();
        else if (this == BinReport) onBinReport();
        else if (this == Watchlist) onWatchlist();
        else if (this == Encryption) onEncryption();
        else if (this == ChangeRequest) onChangeRequest();
        else otherwise(Value);
    }
}
