using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConfigurationsName>))]
public sealed record ConfigurationsName : OpenStringEnum<ConfigurationsName>
{
    private ConfigurationsName(string value) : base(value)
    {
    }

    public static readonly ConfigurationsName Account = new("account");

    public static readonly ConfigurationsName BatchTxn = new("batchTxn");

    public static readonly ConfigurationsName BinReport = new("binReport");

    public static readonly ConfigurationsName Board = new("board");

    public static readonly ConfigurationsName Chargeback = new("chargeback");

    public static readonly ConfigurationsName Decision = new("decision");

    public static readonly ConfigurationsName DecisionBoard = new("decisionBoard");

    public static readonly ConfigurationsName DecisionTxn = new("decisionTxn");

    public static readonly ConfigurationsName EcheckTxn = new("echeckTxn");

    public static readonly ConfigurationsName Encryption = new("encryption");

    public static readonly ConfigurationsName Omnitoken = new("omnitoken");

    public static readonly ConfigurationsName OnlineTxn = new("onlineTxn");

    public static readonly ConfigurationsName OnlineTxnSocket = new("onlineTxnSocket");

    public static readonly ConfigurationsName PaymentUpdates = new("paymentUpdates");

    public static readonly ConfigurationsName Payout = new("payout");

    public static readonly ConfigurationsName PayoutCredit = new("payoutCredit");

    public static readonly ConfigurationsName PayoutDebit = new("payoutDebit");

    public static readonly ConfigurationsName Plaid = new("plaid");

    public static readonly ConfigurationsName Reports = new("reports");

    public static readonly ConfigurationsName Register = new("register");

    public static readonly ConfigurationsName SaferPayment = new("saferPayment");

    public static readonly ConfigurationsName Unregister = new("unregister");

    public static readonly ConfigurationsName VarsheetRetrieval = new("varsheetRetrieval");

    public static readonly ConfigurationsName Watchlist = new("watchlist");

    public TResult Match<TResult>(Func<TResult> onAccount,
        Func<TResult> onBatchTxn,
        Func<TResult> onBinReport,
        Func<TResult> onBoard,
        Func<TResult> onChargeback,
        Func<TResult> onDecision,
        Func<TResult> onDecisionBoard,
        Func<TResult> onDecisionTxn,
        Func<TResult> onEcheckTxn,
        Func<TResult> onEncryption,
        Func<TResult> onOmnitoken,
        Func<TResult> onOnlineTxn,
        Func<TResult> onOnlineTxnSocket,
        Func<TResult> onPaymentUpdates,
        Func<TResult> onPayout,
        Func<TResult> onPayoutCredit,
        Func<TResult> onPayoutDebit,
        Func<TResult> onPlaid,
        Func<TResult> onReports,
        Func<TResult> onRegister,
        Func<TResult> onSaferPayment,
        Func<TResult> onUnregister,
        Func<TResult> onVarsheetRetrieval,
        Func<TResult> onWatchlist,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Account => onAccount(),
            _ when this == BatchTxn => onBatchTxn(),
            _ when this == BinReport => onBinReport(),
            _ when this == Board => onBoard(),
            _ when this == Chargeback => onChargeback(),
            _ when this == Decision => onDecision(),
            _ when this == DecisionBoard => onDecisionBoard(),
            _ when this == DecisionTxn => onDecisionTxn(),
            _ when this == EcheckTxn => onEcheckTxn(),
            _ when this == Encryption => onEncryption(),
            _ when this == Omnitoken => onOmnitoken(),
            _ when this == OnlineTxn => onOnlineTxn(),
            _ when this == OnlineTxnSocket => onOnlineTxnSocket(),
            _ when this == PaymentUpdates => onPaymentUpdates(),
            _ when this == Payout => onPayout(),
            _ when this == PayoutCredit => onPayoutCredit(),
            _ when this == PayoutDebit => onPayoutDebit(),
            _ when this == Plaid => onPlaid(),
            _ when this == Reports => onReports(),
            _ when this == Register => onRegister(),
            _ when this == SaferPayment => onSaferPayment(),
            _ when this == Unregister => onUnregister(),
            _ when this == VarsheetRetrieval => onVarsheetRetrieval(),
            _ when this == Watchlist => onWatchlist(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccount,
        Action onBatchTxn,
        Action onBinReport,
        Action onBoard,
        Action onChargeback,
        Action onDecision,
        Action onDecisionBoard,
        Action onDecisionTxn,
        Action onEcheckTxn,
        Action onEncryption,
        Action onOmnitoken,
        Action onOnlineTxn,
        Action onOnlineTxnSocket,
        Action onPaymentUpdates,
        Action onPayout,
        Action onPayoutCredit,
        Action onPayoutDebit,
        Action onPlaid,
        Action onReports,
        Action onRegister,
        Action onSaferPayment,
        Action onUnregister,
        Action onVarsheetRetrieval,
        Action onWatchlist,
        Action<string> otherwise)
    {
        if (this == Account) onAccount();
        else if (this == BatchTxn) onBatchTxn();
        else if (this == BinReport) onBinReport();
        else if (this == Board) onBoard();
        else if (this == Chargeback) onChargeback();
        else if (this == Decision) onDecision();
        else if (this == DecisionBoard) onDecisionBoard();
        else if (this == DecisionTxn) onDecisionTxn();
        else if (this == EcheckTxn) onEcheckTxn();
        else if (this == Encryption) onEncryption();
        else if (this == Omnitoken) onOmnitoken();
        else if (this == OnlineTxn) onOnlineTxn();
        else if (this == OnlineTxnSocket) onOnlineTxnSocket();
        else if (this == PaymentUpdates) onPaymentUpdates();
        else if (this == Payout) onPayout();
        else if (this == PayoutCredit) onPayoutCredit();
        else if (this == PayoutDebit) onPayoutDebit();
        else if (this == Plaid) onPlaid();
        else if (this == Reports) onReports();
        else if (this == Register) onRegister();
        else if (this == SaferPayment) onSaferPayment();
        else if (this == Unregister) onUnregister();
        else if (this == VarsheetRetrieval) onVarsheetRetrieval();
        else if (this == Watchlist) onWatchlist();
        else otherwise(Value);
    }
}
