using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DecisionType>))]
public sealed record DecisionType : OpenStringEnum<DecisionType>
{
    private DecisionType(string value) : base(value)
    {
    }

    public static readonly DecisionType MerchantFailureLimit = new("merchantFailureLimit");

    public static readonly DecisionType MerchantFailureRatio = new("merchantFailureRatio");

    public static readonly DecisionType SaleTotalLimit = new("saleTotalLimit");

    public static readonly DecisionType RefundTotalLimit = new("refundTotalLimit");

    public static readonly DecisionType AverageSaleCountLimit = new("averageSaleCountLimit");

    public static readonly DecisionType MerchantRefundSaleRatio = new("merchantRefundSaleRatio");

    public static readonly DecisionType MerchantPaymentSuccessLimit = new("merchantPaymentSuccessLimit");

    public static readonly DecisionType IpFailureLimit = new("ipFailureLimit");

    public static readonly DecisionType IpFailureRatio = new("ipFailureRatio");

    public static readonly DecisionType InactiveMerchant = new("inactiveMerchant");

    public static readonly DecisionType MerchantPaymentFailureLimit = new("merchantPaymentFailureLimit");

    public static readonly DecisionType MerchantCaptureWithoutAuthLimit = new("merchantCaptureWithoutAuthLimit");

    public static readonly DecisionType RefundWithoutSale = new("refundWithoutSale");

    public static readonly DecisionType RefundWithoutSaleLimit = new("refundWithoutSaleLimit");

    public static readonly DecisionType CaptureAboveAuthLimit = new("captureAboveAuthLimit");

    public static readonly DecisionType FraudScore = new("fraudScore");

    public static readonly DecisionType Cvv = new("cvv");

    public static readonly DecisionType Avs = new("avs");

    public static readonly DecisionType Aavs = new("aavs");

    public static readonly DecisionType DuplicateTxn = new("duplicateTxn");

    public static readonly DecisionType MerchantMatch = new("merchantMatch");

    public static readonly DecisionType CurrencyConversion = new("currencyConversion");

    public static readonly DecisionType SettledCurrencyMismatch = new("settledCurrencyMismatch");

    public static readonly DecisionType InitialTxn = new("initialTxn");

    public static readonly DecisionType SimilarTotalLimit = new("similarTotalLimit");

    public static readonly DecisionType SimilarTotalRatio = new("similarTotalRatio");

    public static readonly DecisionType SaleTotalMinimum = new("saleTotalMinimum");

    public static readonly DecisionType Limit = new("limit");

    public static readonly DecisionType Ratio = new("ratio");

    public static readonly DecisionType TxnWatchlist = new("txnWatchlist");

    public static readonly DecisionType BalanceRefundLimit = new("balanceRefundLimit");

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
