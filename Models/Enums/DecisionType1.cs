using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of check to perform.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>merchantFailureLimit</c> - <b>Exceeded the maximum number of allowed failed authorizations.</b></description></item>
///   <item><description><c>merchantFailureRatio</c> - <b>Exceeded the maximum ratio of allowed failed authorizations.</b></description></item>
///   <item><description><c>saleTotalLimit</c> - <b>Exceeded the maximum allowed sale total value.</b></description></item>
///   <item><description><c>refundTotalLimit</c> - <b>Exceeded the maximum allowed refund total value.</b></description></item>
///   <item><description><c>averageSaleCountLimit</c> - <b>Exceeded the allowed maximum payment size (individual transaction amount).</b></description></item>
///   <item><description><c>merchantRefundSaleRatio</c> - <b>Exceeded the maximum allowed ratio of refunds to sales.</b></description></item>
///   <item><description><c>merchantPaymentSuccessLimit</c> - <b>This is used to check if the merchant has charged the same payment more than X times on a given period of time.</b></description></item>
///   <item><description><c>ipFailureLimit</c> - <b>Exceeded the maximum allowed number of failed authorizations for a particular IP address.</b></description></item>
///   <item><description><c>ipFailureRatio</c> - <b>Exceeded the maximum allowed ratio of failed authorizations for a particular IP address.</b></description></item>
///   <item><description><c>inactiveMerchant</c> - <b>The Merchant is not active.</b></description></item>
///   <item><description><c>merchantPaymentFailureLimit</c> - <b>Exceeded the maximum allowed number of failed transactions.</b></description></item>
///   <item><description><c>merchantCaptureWithoutAuthLimit</c> - <b>Exceeded the maximum allowed number of transactions without authorizations.</b></description></item>
///   <item><description><c>refundWithoutSale</c> - <b>Refund transaction does not have an associated sale transaction.</b></description></item>
///   <item><description><c>refundWithoutSaleLimit</c> - <b>Exceeded the maximum number of refund transactions that do not have associated sale transactions.</b></description></item>
///   <item><description><c>captureAboveAuthLimit</c> - <b>Exceeded the maximum authorized value for transactions with failed authorizations.</b></description></item>
///   <item><description><c>fraudScore</c> - <b>Transaction fraud score.</b></description></item>
///   <item><description><c>cvv</c> - <b>CVV.</b></description></item>
///   <item><description><c>avs</c> - <b>AVS.</b></description></item>
///   <item><description><c>aavs</c> - <b>AAVS.</b></description></item>
///   <item><description><c>duplicateTxn</c> - <b>Duplicate transaction.</b></description></item>
///   <item><description><c>merchantMatch</c> - <b>Transaction matches merchant details.</b></description></item>
///   <item><description><c>currencyConversion</c> - <b>Transaction triggers currency conversion.</b></description></item>
///   <item><description><c>settledCurrencyMismatch</c> - <b>Transaction settled currency mismatch.</b></description></item>
///   <item><description><c>initialTxn</c> - <b>Initial transaction of this type.</b></description></item>
///   <item><description><c>similarTotalLimit</c> - <b>Exceeded the limit of transactions with equal totals.</b></description></item>
///   <item><description><c>similarTotalRatio</c> - <b>Exceeded the ratio of transactions with equal totals.</b></description></item>
///   <item><description><c>saleTotalMinimum</c> - <b>Minimum transaction amount.</b></description></item>
///   <item><description><c>limit</c> - <b>Exceeded the maximum allowed number of authorizations.</b></description></item>
///   <item><description><c>ratio</c> - <b>This is used to check if similar transactions have reached the ratio of auth transactions in a given period of time.</b></description></item>
///   <item><description><c>txnWatchlist</c> - <b>Check the transaction data against a custom watchlist.</b></description></item>
///   <item><description><c>balanceRefundLimit</c> - <b>This is used to check if a merchant has enough balance to process a REFUND transaction and it is within the scope of the threshold.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DecisionType1>))]
public sealed record DecisionType1 : OpenStringEnum<DecisionType1>
{
    private DecisionType1(string value) : base(value)
    {
    }

    public static readonly DecisionType1 MerchantFailureLimit = new("merchantFailureLimit");

    public static readonly DecisionType1 MerchantFailureRatio = new("merchantFailureRatio");

    public static readonly DecisionType1 SaleTotalLimit = new("saleTotalLimit");

    public static readonly DecisionType1 RefundTotalLimit = new("refundTotalLimit");

    public static readonly DecisionType1 AverageSaleCountLimit = new("averageSaleCountLimit");

    public static readonly DecisionType1 MerchantRefundSaleRatio = new("merchantRefundSaleRatio");

    public static readonly DecisionType1 MerchantPaymentSuccessLimit = new("merchantPaymentSuccessLimit");

    public static readonly DecisionType1 IpFailureLimit = new("ipFailureLimit");

    public static readonly DecisionType1 IpFailureRatio = new("ipFailureRatio");

    public static readonly DecisionType1 InactiveMerchant = new("inactiveMerchant");

    public static readonly DecisionType1 MerchantPaymentFailureLimit = new("merchantPaymentFailureLimit");

    public static readonly DecisionType1 MerchantCaptureWithoutAuthLimit = new("merchantCaptureWithoutAuthLimit");

    public static readonly DecisionType1 RefundWithoutSale = new("refundWithoutSale");

    public static readonly DecisionType1 RefundWithoutSaleLimit = new("refundWithoutSaleLimit");

    public static readonly DecisionType1 CaptureAboveAuthLimit = new("captureAboveAuthLimit");

    public static readonly DecisionType1 FraudScore = new("fraudScore");

    public static readonly DecisionType1 Cvv = new("cvv");

    public static readonly DecisionType1 Avs = new("avs");

    public static readonly DecisionType1 Aavs = new("aavs");

    public static readonly DecisionType1 DuplicateTxn = new("duplicateTxn");

    public static readonly DecisionType1 MerchantMatch = new("merchantMatch");

    public static readonly DecisionType1 CurrencyConversion = new("currencyConversion");

    public static readonly DecisionType1 SettledCurrencyMismatch = new("settledCurrencyMismatch");

    public static readonly DecisionType1 InitialTxn = new("initialTxn");

    public static readonly DecisionType1 SimilarTotalLimit = new("similarTotalLimit");

    public static readonly DecisionType1 SimilarTotalRatio = new("similarTotalRatio");

    public static readonly DecisionType1 SaleTotalMinimum = new("saleTotalMinimum");

    public static readonly DecisionType1 Limit = new("limit");

    public static readonly DecisionType1 Ratio = new("ratio");

    public static readonly DecisionType1 TxnWatchlist = new("txnWatchlist");

    public static readonly DecisionType1 BalanceRefundLimit = new("balanceRefundLimit");

    public TResult Match<TResult>(Func<TResult> onMerchantFailureLimit,
        Func<TResult> onMerchantFailureRatio,
        Func<TResult> onSaleTotalLimit,
        Func<TResult> onRefundTotalLimit,
        Func<TResult> onAverageSaleCountLimit,
        Func<TResult> onMerchantRefundSaleRatio,
        Func<TResult> onMerchantPaymentSuccessLimit,
        Func<TResult> onIpFailureLimit,
        Func<TResult> onIpFailureRatio,
        Func<TResult> onInactiveMerchant,
        Func<TResult> onMerchantPaymentFailureLimit,
        Func<TResult> onMerchantCaptureWithoutAuthLimit,
        Func<TResult> onRefundWithoutSale,
        Func<TResult> onRefundWithoutSaleLimit,
        Func<TResult> onCaptureAboveAuthLimit,
        Func<TResult> onFraudScore,
        Func<TResult> onCvv,
        Func<TResult> onAvs,
        Func<TResult> onAavs,
        Func<TResult> onDuplicateTxn,
        Func<TResult> onMerchantMatch,
        Func<TResult> onCurrencyConversion,
        Func<TResult> onSettledCurrencyMismatch,
        Func<TResult> onInitialTxn,
        Func<TResult> onSimilarTotalLimit,
        Func<TResult> onSimilarTotalRatio,
        Func<TResult> onSaleTotalMinimum,
        Func<TResult> onLimit,
        Func<TResult> onRatio,
        Func<TResult> onTxnWatchlist,
        Func<TResult> onBalanceRefundLimit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MerchantFailureLimit => onMerchantFailureLimit(),
            _ when this == MerchantFailureRatio => onMerchantFailureRatio(),
            _ when this == SaleTotalLimit => onSaleTotalLimit(),
            _ when this == RefundTotalLimit => onRefundTotalLimit(),
            _ when this == AverageSaleCountLimit => onAverageSaleCountLimit(),
            _ when this == MerchantRefundSaleRatio => onMerchantRefundSaleRatio(),
            _ when this == MerchantPaymentSuccessLimit => onMerchantPaymentSuccessLimit(),
            _ when this == IpFailureLimit => onIpFailureLimit(),
            _ when this == IpFailureRatio => onIpFailureRatio(),
            _ when this == InactiveMerchant => onInactiveMerchant(),
            _ when this == MerchantPaymentFailureLimit => onMerchantPaymentFailureLimit(),
            _ when this == MerchantCaptureWithoutAuthLimit => onMerchantCaptureWithoutAuthLimit(),
            _ when this == RefundWithoutSale => onRefundWithoutSale(),
            _ when this == RefundWithoutSaleLimit => onRefundWithoutSaleLimit(),
            _ when this == CaptureAboveAuthLimit => onCaptureAboveAuthLimit(),
            _ when this == FraudScore => onFraudScore(),
            _ when this == Cvv => onCvv(),
            _ when this == Avs => onAvs(),
            _ when this == Aavs => onAavs(),
            _ when this == DuplicateTxn => onDuplicateTxn(),
            _ when this == MerchantMatch => onMerchantMatch(),
            _ when this == CurrencyConversion => onCurrencyConversion(),
            _ when this == SettledCurrencyMismatch => onSettledCurrencyMismatch(),
            _ when this == InitialTxn => onInitialTxn(),
            _ when this == SimilarTotalLimit => onSimilarTotalLimit(),
            _ when this == SimilarTotalRatio => onSimilarTotalRatio(),
            _ when this == SaleTotalMinimum => onSaleTotalMinimum(),
            _ when this == Limit => onLimit(),
            _ when this == Ratio => onRatio(),
            _ when this == TxnWatchlist => onTxnWatchlist(),
            _ when this == BalanceRefundLimit => onBalanceRefundLimit(),
            _ => otherwise(Value)
        };

    public void Match(Action onMerchantFailureLimit,
        Action onMerchantFailureRatio,
        Action onSaleTotalLimit,
        Action onRefundTotalLimit,
        Action onAverageSaleCountLimit,
        Action onMerchantRefundSaleRatio,
        Action onMerchantPaymentSuccessLimit,
        Action onIpFailureLimit,
        Action onIpFailureRatio,
        Action onInactiveMerchant,
        Action onMerchantPaymentFailureLimit,
        Action onMerchantCaptureWithoutAuthLimit,
        Action onRefundWithoutSale,
        Action onRefundWithoutSaleLimit,
        Action onCaptureAboveAuthLimit,
        Action onFraudScore,
        Action onCvv,
        Action onAvs,
        Action onAavs,
        Action onDuplicateTxn,
        Action onMerchantMatch,
        Action onCurrencyConversion,
        Action onSettledCurrencyMismatch,
        Action onInitialTxn,
        Action onSimilarTotalLimit,
        Action onSimilarTotalRatio,
        Action onSaleTotalMinimum,
        Action onLimit,
        Action onRatio,
        Action onTxnWatchlist,
        Action onBalanceRefundLimit,
        Action<string> otherwise)
    {
        if (this == MerchantFailureLimit) onMerchantFailureLimit();
        else if (this == MerchantFailureRatio) onMerchantFailureRatio();
        else if (this == SaleTotalLimit) onSaleTotalLimit();
        else if (this == RefundTotalLimit) onRefundTotalLimit();
        else if (this == AverageSaleCountLimit) onAverageSaleCountLimit();
        else if (this == MerchantRefundSaleRatio) onMerchantRefundSaleRatio();
        else if (this == MerchantPaymentSuccessLimit) onMerchantPaymentSuccessLimit();
        else if (this == IpFailureLimit) onIpFailureLimit();
        else if (this == IpFailureRatio) onIpFailureRatio();
        else if (this == InactiveMerchant) onInactiveMerchant();
        else if (this == MerchantPaymentFailureLimit) onMerchantPaymentFailureLimit();
        else if (this == MerchantCaptureWithoutAuthLimit) onMerchantCaptureWithoutAuthLimit();
        else if (this == RefundWithoutSale) onRefundWithoutSale();
        else if (this == RefundWithoutSaleLimit) onRefundWithoutSaleLimit();
        else if (this == CaptureAboveAuthLimit) onCaptureAboveAuthLimit();
        else if (this == FraudScore) onFraudScore();
        else if (this == Cvv) onCvv();
        else if (this == Avs) onAvs();
        else if (this == Aavs) onAavs();
        else if (this == DuplicateTxn) onDuplicateTxn();
        else if (this == MerchantMatch) onMerchantMatch();
        else if (this == CurrencyConversion) onCurrencyConversion();
        else if (this == SettledCurrencyMismatch) onSettledCurrencyMismatch();
        else if (this == InitialTxn) onInitialTxn();
        else if (this == SimilarTotalLimit) onSimilarTotalLimit();
        else if (this == SimilarTotalRatio) onSimilarTotalRatio();
        else if (this == SaleTotalMinimum) onSaleTotalMinimum();
        else if (this == Limit) onLimit();
        else if (this == Ratio) onRatio();
        else if (this == TxnWatchlist) onTxnWatchlist();
        else if (this == BalanceRefundLimit) onBalanceRefundLimit();
        else otherwise(Value);
    }
}
