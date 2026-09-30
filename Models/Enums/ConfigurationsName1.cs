using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The name of this configuration resource.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>account</c> - <b>Account. The specified configuration will be used for bank accounts integrations.</b></description></item>
///   <item><description><c>batchTxn</c> - <b>BatchTxn. The specified configuration will be used for processing transaction batches.</b></description></item>
///   <item><description><c>binReport</c> - <b>BinReport. The specified configuration will be used for bin reports integrations.</b></description></item>
///   <item><description><c>board</c> - <b>Board. The specified configuration will be used for boarding merchants.</b></description></item>
///   <item><description><c>chargeback</c> - <b>Chargeback. The specified configuration will be used for everything related to chargebacks.</b></description></item>
///   <item><description><c>decision</c> - <b>Decision. The specified configuration will be used for everything related to decisions.</b></description></item>
///   <item><description><c>decisionBoard</c> - <b>This holds configuration for running boarding decision policy on entity through Risk MS.</b></description></item>
///   <item><description><c>decisionTxn</c> - <b>DecisionTxn is used for running transaction decision policy through the Risk MS.</b></description></item>
///   <item><description><c>echeckTxn</c> - <b>EcheckTxn. The specified configuration will be used to get reports of echeck transactions as well as getting additional information about those transactions.</b></description></item>
///   <item><description><c>encryption</c> - <b>Holds the configuration for running Google and Apple Pay encryption/decryption through the Payrix Encryption Service.</b></description></item>
///   <item><description><c>omnitoken</c> - <b>Holds the configuration parameters for omnitoken services.</b></description></item>
///   <item><description><c>onlineTxn</c> - <b>OnlineTxn. The specified configuration will be used to process transactions online without a batch.</b></description></item>
///   <item><description><c>onlineTxnSocket</c> - <b>OnlineTxnSocket.</b></description></item>
///   <item><description><c>paymentUpdates</c> - <b>PaymentUpdates.</b></description></item>
///   <item><description><c>payout</c> - <b>Payout. The specified configuration will be used for everything related to payouts.</b></description></item>
///   <item><description><c>payoutCredit</c> - <b>Holds the configuration for processing payout credit through the integration service.</b></description></item>
///   <item><description><c>payoutDebit</c> - <b>Holds the configuration for processing payouts debit through the integration service.</b></description></item>
///   <item><description><c>plaid</c> - <b>Holds the configuration parameters for Plaid services (connecting accounts, getting identity, etc.).</b></description></item>
///   <item><description><c>reports</c> - <b>Reports. The specified configuration will be used to import processed transactions.</b></description></item>
///   <item><description><c>register</c> - <b>Register.</b></description></item>
///   <item><description><c>saferPayment</c> - <b>Holds the configuration parameters for safer payment VAS.</b></description></item>
///   <item><description><c>unregister</c> - <b>Unregister.</b></description></item>
///   <item><description><c>varsheetRetrieval</c> - <b>Holds the configuration parameters for varsheet retrieval.</b></description></item>
///   <item><description><c>watchlist</c> - <b>Watchlist. The specified configuration will be used to receive a watch list by the OFAC.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConfigurationsName1>))]
public sealed record ConfigurationsName1 : OpenStringEnum<ConfigurationsName1>
{
    private ConfigurationsName1(string value) : base(value)
    {
    }

    public static readonly ConfigurationsName1 Account = new("account");

    public static readonly ConfigurationsName1 BatchTxn = new("batchTxn");

    public static readonly ConfigurationsName1 BinReport = new("binReport");

    public static readonly ConfigurationsName1 Board = new("board");

    public static readonly ConfigurationsName1 Chargeback = new("chargeback");

    public static readonly ConfigurationsName1 Decision = new("decision");

    public static readonly ConfigurationsName1 DecisionBoard = new("decisionBoard");

    public static readonly ConfigurationsName1 DecisionTxn = new("decisionTxn");

    public static readonly ConfigurationsName1 EcheckTxn = new("echeckTxn");

    public static readonly ConfigurationsName1 Encryption = new("encryption");

    public static readonly ConfigurationsName1 Omnitoken = new("omnitoken");

    public static readonly ConfigurationsName1 OnlineTxn = new("onlineTxn");

    public static readonly ConfigurationsName1 OnlineTxnSocket = new("onlineTxnSocket");

    public static readonly ConfigurationsName1 PaymentUpdates = new("paymentUpdates");

    public static readonly ConfigurationsName1 Payout = new("payout");

    public static readonly ConfigurationsName1 PayoutCredit = new("payoutCredit");

    public static readonly ConfigurationsName1 PayoutDebit = new("payoutDebit");

    public static readonly ConfigurationsName1 Plaid = new("plaid");

    public static readonly ConfigurationsName1 Reports = new("reports");

    public static readonly ConfigurationsName1 Register = new("register");

    public static readonly ConfigurationsName1 SaferPayment = new("saferPayment");

    public static readonly ConfigurationsName1 Unregister = new("unregister");

    public static readonly ConfigurationsName1 VarsheetRetrieval = new("varsheetRetrieval");

    public static readonly ConfigurationsName1 Watchlist = new("watchlist");

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
