using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The credential used for configurationStage resource.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>transaction</c> - <b>Credential used for transaction processing.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>batch</c> - <b>Credential used for transaction batches.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>boarding</c> - <b>Credential used merchant boarding.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paymentUpdates</c> - <b>Account updater (the process through which old/expired credit cards are automatically updated).</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>payout</c> - <b>Credential used for payouts.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>payoutCredit</c> - <b>Credential used for transaction batches.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>payoutDebit</c> - <b>Credential used for transaction batches.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>chargeback</c> - <b>Credential used for chargeback processing and updating.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>txnReport</c> - <b>Credential used for transaction reports.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>account</c> - <b>Credential used for account integrations.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>entityDecision</c> - <b>Credential used for entity decisions.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>txnCheck</c> - <b>Credential used for transaction verifications.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>payoutReport</c> - <b>Credential used for payout reports.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>feeReport</c> - <b>Credential used for fee reports.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>chargebackReport</c> - <b>Credential used for chargeback reports.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>binReport</c> - <b>Credential used for binReports.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>watchlist</c> - <b>Third party watchlist download .</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>encryption</c> - <b>Credential used for encryption.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>changeRequest</c> - <b>Credential used for changeRequest.</b></description></item>
/// </list>
/// <para>
///  &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConfigurationStageCredentials2>))]
public sealed record ConfigurationStageCredentials2 : OpenStringEnum<ConfigurationStageCredentials2>
{
    private ConfigurationStageCredentials2(string value) : base(value)
    {
    }

    public static readonly ConfigurationStageCredentials2 Transaction = new("transaction");

    public static readonly ConfigurationStageCredentials2 Batch = new("batch");

    public static readonly ConfigurationStageCredentials2 Boarding = new("boarding");

    public static readonly ConfigurationStageCredentials2 PaymentUpdates = new("paymentUpdates");

    public static readonly ConfigurationStageCredentials2 Payout = new("payout");

    public static readonly ConfigurationStageCredentials2 PayoutCredit = new("payoutCredit");

    public static readonly ConfigurationStageCredentials2 PayoutDebit = new("payoutDebit");

    public static readonly ConfigurationStageCredentials2 Chargeback = new("chargeback");

    public static readonly ConfigurationStageCredentials2 TxnReport = new("txnReport");

    public static readonly ConfigurationStageCredentials2 Account = new("account");

    public static readonly ConfigurationStageCredentials2 EntityDecision = new("entityDecision");

    public static readonly ConfigurationStageCredentials2 TxnCheck = new("txnCheck");

    public static readonly ConfigurationStageCredentials2 PayoutReport = new("payoutReport");

    public static readonly ConfigurationStageCredentials2 FeeReport = new("feeReport");

    public static readonly ConfigurationStageCredentials2 ChargebackReport = new("chargebackReport");

    public static readonly ConfigurationStageCredentials2 BinReport = new("binReport");

    public static readonly ConfigurationStageCredentials2 Watchlist = new("watchlist");

    public static readonly ConfigurationStageCredentials2 Encryption = new("encryption");

    public static readonly ConfigurationStageCredentials2 ChangeRequest = new("changeRequest");

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
