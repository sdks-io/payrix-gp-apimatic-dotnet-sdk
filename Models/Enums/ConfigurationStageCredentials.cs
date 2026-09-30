using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConfigurationStageCredentials>))]
public sealed record ConfigurationStageCredentials : OpenStringEnum<ConfigurationStageCredentials>
{
    private ConfigurationStageCredentials(string value) : base(value)
    {
    }

    public static readonly ConfigurationStageCredentials Transaction = new("transaction");

    public static readonly ConfigurationStageCredentials Batch = new("batch");

    public static readonly ConfigurationStageCredentials Boarding = new("boarding");

    public static readonly ConfigurationStageCredentials PaymentUpdates = new("paymentUpdates");

    public static readonly ConfigurationStageCredentials Payout = new("payout");

    public static readonly ConfigurationStageCredentials PayoutCredit = new("payoutCredit");

    public static readonly ConfigurationStageCredentials PayoutDebit = new("payoutDebit");

    public static readonly ConfigurationStageCredentials Chargeback = new("chargeback");

    public static readonly ConfigurationStageCredentials TxnReport = new("txnReport");

    public static readonly ConfigurationStageCredentials Account = new("account");

    public static readonly ConfigurationStageCredentials EntityDecision = new("entityDecision");

    public static readonly ConfigurationStageCredentials TxnCheck = new("txnCheck");

    public static readonly ConfigurationStageCredentials PayoutReport = new("payoutReport");

    public static readonly ConfigurationStageCredentials FeeReport = new("feeReport");

    public static readonly ConfigurationStageCredentials ChargebackReport = new("chargebackReport");

    public static readonly ConfigurationStageCredentials BinReport = new("binReport");

    public static readonly ConfigurationStageCredentials Watchlist = new("watchlist");

    public static readonly ConfigurationStageCredentials Encryption = new("encryption");

    public static readonly ConfigurationStageCredentials ChangeRequest = new("changeRequest");

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
