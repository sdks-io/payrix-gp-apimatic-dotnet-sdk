using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<VerificationType>))]
public sealed record VerificationType : OpenStringEnum<VerificationType>
{
    private VerificationType(string value) : base(value)
    {
    }

    public static readonly VerificationType AdvancedEntity = new("advancedEntity");

    public static readonly VerificationType Ofac = new("ofac");

    public static readonly VerificationType Entity = new("entity");

    public static readonly VerificationType Overall = new("overall");

    public static readonly VerificationType Watchlist = new("watchlist");

    public static readonly VerificationType DataVerification = new("dataVerification");

    public static readonly VerificationType AdvancedMerchant = new("advancedMerchant");

    public static readonly VerificationType AdvancedMember = new("advancedMember");

    public static readonly VerificationType Association = new("association");

    public static readonly VerificationType Member = new("member");

    public static readonly VerificationType MerchantFailureLimit = new("merchantFailureLimit");

    public static readonly VerificationType MerchantPaymentFailureLimit = new("merchantPaymentFailureLimit");

    public static readonly VerificationType SaleTotalLimit = new("saleTotalLimit");

    public static readonly VerificationType SaleTotalMinimum = new("saleTotalMinimum");

    public static readonly VerificationType MerchantCaptureWithoutAuthLimit = new("merchantCaptureWithoutAuthLimit");

    public static readonly VerificationType RefundTotalLimit = new("refundTotalLimit");

    public static readonly VerificationType AverageSaleCountLimit = new("averageSaleCountLimit");

    public static readonly VerificationType MerchantRefundSaleRatio = new("merchantRefundSaleRatio");

    public static readonly VerificationType MerchantPaymentSuccessLimit = new("merchantPaymentSuccessLimit");

    public static readonly VerificationType IpFailureLimit = new("ipFailureLimit");

    public static readonly VerificationType IpFailureRatio = new("ipFailureRatio");

    public static readonly VerificationType InactiveMerchant = new("inactiveMerchant");

    public static readonly VerificationType RefundWithoutSale = new("refundWithoutSale");

    public static readonly VerificationType RefundWithoutSaleLimit = new("refundWithoutSaleLimit");

    public static readonly VerificationType CaptureAboveAuthLimit = new("captureAboveAuthLimit");

    public static readonly VerificationType Cvv = new("cvv");

    public static readonly VerificationType Avs = new("avs");

    public static readonly VerificationType Aavs = new("aavs");

    public static readonly VerificationType DuplicateTxn = new("duplicateTxn");

    public static readonly VerificationType MerchantMatch = new("merchantMatch");

    public static readonly VerificationType CurrencyConversion = new("currencyConversion");

    public static readonly VerificationType SettledCurrencyMismatch = new("settledCurrencyMismatch");

    public static readonly VerificationType InitialTxn = new("initialTxn");

    public static readonly VerificationType SimilarTotalLimit = new("similarTotalLimit");

    public static readonly VerificationType SimilarTotalRatio = new("similarTotalRatio");

    public static readonly VerificationType Limit = new("limit");

    public static readonly VerificationType Ratio = new("ratio");

    public static readonly VerificationType TxnWatchlist = new("txnWatchlist");

    public static readonly VerificationType BalanceRefundLimit = new("balanceRefundLimit");

    public static readonly VerificationType SaleApprovedLimit = new("saleApprovedLimit");

    public static readonly VerificationType RefundApprovedLimit = new("refundApprovedLimit");

    public TResult Match<TResult>(Func<TResult> onAdvancedEntity,
        Func<TResult> onOfac,
        Func<TResult> onEntity,
        Func<TResult> onOverall,
        Func<TResult> onWatchlist,
        Func<TResult> onDataVerification,
        Func<TResult> onAdvancedMerchant,
        Func<TResult> onAdvancedMember,
        Func<TResult> onAssociation,
        Func<TResult> onMember,
        Func<TResult> onMerchantFailureLimit,
        Func<TResult> onMerchantPaymentFailureLimit,
        Func<TResult> onSaleTotalLimit,
        Func<TResult> onSaleTotalMinimum,
        Func<TResult> onMerchantCaptureWithoutAuthLimit,
        Func<TResult> onRefundTotalLimit,
        Func<TResult> onAverageSaleCountLimit,
        Func<TResult> onMerchantRefundSaleRatio,
        Func<TResult> onMerchantPaymentSuccessLimit,
        Func<TResult> onIpFailureLimit,
        Func<TResult> onIpFailureRatio,
        Func<TResult> onInactiveMerchant,
        Func<TResult> onRefundWithoutSale,
        Func<TResult> onRefundWithoutSaleLimit,
        Func<TResult> onCaptureAboveAuthLimit,
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
        Func<TResult> onLimit,
        Func<TResult> onRatio,
        Func<TResult> onTxnWatchlist,
        Func<TResult> onBalanceRefundLimit,
        Func<TResult> onSaleApprovedLimit,
        Func<TResult> onRefundApprovedLimit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AdvancedEntity => onAdvancedEntity(),
            _ when this == Ofac => onOfac(),
            _ when this == Entity => onEntity(),
            _ when this == Overall => onOverall(),
            _ when this == Watchlist => onWatchlist(),
            _ when this == DataVerification => onDataVerification(),
            _ when this == AdvancedMerchant => onAdvancedMerchant(),
            _ when this == AdvancedMember => onAdvancedMember(),
            _ when this == Association => onAssociation(),
            _ when this == Member => onMember(),
            _ when this == MerchantFailureLimit => onMerchantFailureLimit(),
            _ when this == MerchantPaymentFailureLimit => onMerchantPaymentFailureLimit(),
            _ when this == SaleTotalLimit => onSaleTotalLimit(),
            _ when this == SaleTotalMinimum => onSaleTotalMinimum(),
            _ when this == MerchantCaptureWithoutAuthLimit => onMerchantCaptureWithoutAuthLimit(),
            _ when this == RefundTotalLimit => onRefundTotalLimit(),
            _ when this == AverageSaleCountLimit => onAverageSaleCountLimit(),
            _ when this == MerchantRefundSaleRatio => onMerchantRefundSaleRatio(),
            _ when this == MerchantPaymentSuccessLimit => onMerchantPaymentSuccessLimit(),
            _ when this == IpFailureLimit => onIpFailureLimit(),
            _ when this == IpFailureRatio => onIpFailureRatio(),
            _ when this == InactiveMerchant => onInactiveMerchant(),
            _ when this == RefundWithoutSale => onRefundWithoutSale(),
            _ when this == RefundWithoutSaleLimit => onRefundWithoutSaleLimit(),
            _ when this == CaptureAboveAuthLimit => onCaptureAboveAuthLimit(),
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
            _ when this == Limit => onLimit(),
            _ when this == Ratio => onRatio(),
            _ when this == TxnWatchlist => onTxnWatchlist(),
            _ when this == BalanceRefundLimit => onBalanceRefundLimit(),
            _ when this == SaleApprovedLimit => onSaleApprovedLimit(),
            _ when this == RefundApprovedLimit => onRefundApprovedLimit(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdvancedEntity,
        Action onOfac,
        Action onEntity,
        Action onOverall,
        Action onWatchlist,
        Action onDataVerification,
        Action onAdvancedMerchant,
        Action onAdvancedMember,
        Action onAssociation,
        Action onMember,
        Action onMerchantFailureLimit,
        Action onMerchantPaymentFailureLimit,
        Action onSaleTotalLimit,
        Action onSaleTotalMinimum,
        Action onMerchantCaptureWithoutAuthLimit,
        Action onRefundTotalLimit,
        Action onAverageSaleCountLimit,
        Action onMerchantRefundSaleRatio,
        Action onMerchantPaymentSuccessLimit,
        Action onIpFailureLimit,
        Action onIpFailureRatio,
        Action onInactiveMerchant,
        Action onRefundWithoutSale,
        Action onRefundWithoutSaleLimit,
        Action onCaptureAboveAuthLimit,
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
        Action onLimit,
        Action onRatio,
        Action onTxnWatchlist,
        Action onBalanceRefundLimit,
        Action onSaleApprovedLimit,
        Action onRefundApprovedLimit,
        Action<string> otherwise)
    {
        if (this == AdvancedEntity) onAdvancedEntity();
        else if (this == Ofac) onOfac();
        else if (this == Entity) onEntity();
        else if (this == Overall) onOverall();
        else if (this == Watchlist) onWatchlist();
        else if (this == DataVerification) onDataVerification();
        else if (this == AdvancedMerchant) onAdvancedMerchant();
        else if (this == AdvancedMember) onAdvancedMember();
        else if (this == Association) onAssociation();
        else if (this == Member) onMember();
        else if (this == MerchantFailureLimit) onMerchantFailureLimit();
        else if (this == MerchantPaymentFailureLimit) onMerchantPaymentFailureLimit();
        else if (this == SaleTotalLimit) onSaleTotalLimit();
        else if (this == SaleTotalMinimum) onSaleTotalMinimum();
        else if (this == MerchantCaptureWithoutAuthLimit) onMerchantCaptureWithoutAuthLimit();
        else if (this == RefundTotalLimit) onRefundTotalLimit();
        else if (this == AverageSaleCountLimit) onAverageSaleCountLimit();
        else if (this == MerchantRefundSaleRatio) onMerchantRefundSaleRatio();
        else if (this == MerchantPaymentSuccessLimit) onMerchantPaymentSuccessLimit();
        else if (this == IpFailureLimit) onIpFailureLimit();
        else if (this == IpFailureRatio) onIpFailureRatio();
        else if (this == InactiveMerchant) onInactiveMerchant();
        else if (this == RefundWithoutSale) onRefundWithoutSale();
        else if (this == RefundWithoutSaleLimit) onRefundWithoutSaleLimit();
        else if (this == CaptureAboveAuthLimit) onCaptureAboveAuthLimit();
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
        else if (this == Limit) onLimit();
        else if (this == Ratio) onRatio();
        else if (this == TxnWatchlist) onTxnWatchlist();
        else if (this == BalanceRefundLimit) onBalanceRefundLimit();
        else if (this == SaleApprovedLimit) onSaleApprovedLimit();
        else if (this == RefundApprovedLimit) onRefundApprovedLimit();
        else otherwise(Value);
    }
}
