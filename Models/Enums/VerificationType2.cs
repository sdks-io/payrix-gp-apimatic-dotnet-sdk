using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of check to perform on the Entity, Member or Txn.
/// &lt;details&gt;
///   &lt;summary&gt;Entity Types - Valid Values&lt;/summary&gt;
///   &lt;ul&gt;
///     &lt;li&gt;<c>advancedEntity</c> - &lt;b&gt;Advanced Entity Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>ofac</c> - &lt;b&gt;OFAC Watchlist Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>entity</c> - &lt;b&gt;Entity Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>overall</c> - &lt;b&gt;Overall Entity Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>watchlist</c> - &lt;b&gt;Watchlist Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>dataVerification</c> - &lt;b&gt;Data Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>advancedMerchant</c> - &lt;b&gt;Advanced Merchant Verification&lt;/b&gt;&lt;/li&gt;
///   &lt;/ul&gt;
/// &lt;/details&gt;
/// &lt;details&gt;
///   &lt;summary&gt;Member Types - Valid Values&lt;/summary&gt;
///   &lt;ul&gt;
///     &lt;li&gt;<c>advancedMember</c> - &lt;b&gt;Advanced Member Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>association</c> - &lt;b&gt;Association Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>member</c> - &lt;b&gt;Member Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>ofac</c> - &lt;b&gt;OFAC Watchlist Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>watchlist</c> - &lt;b&gt;Watchlist Verification&lt;/b&gt;&lt;/li&gt;
///   &lt;/ul&gt;
/// &lt;/details&gt;
/// &lt;details&gt;
///   &lt;summary&gt;Transaction Types - Valid Values&lt;/summary&gt;
///   &lt;ul&gt;
///     &lt;li&gt;<c>merchantFailureLimit</c> - &lt;b&gt;Merchant Failure Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>merchantPaymentFailureLimit</c> - &lt;b&gt;Merchant Payment Failure Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>saleTotalLimit</c> - &lt;b&gt;Sale Total Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>saleTotalMinimum</c> - &lt;b&gt;Sale Total Minimum&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>merchantCaptureWithoutAuthLimit</c> - &lt;b&gt;Merchant Capture Without Auth Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>refundTotalLimit</c> - &lt;b&gt;Refund Total Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>averageSaleCountLimit</c> - &lt;b&gt;Average Sale Count Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>merchantRefundSaleRatio</c> - &lt;b&gt;Merchant Refund Sale Ratio&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>merchantPaymentSuccessLimit</c> - &lt;b&gt;Merchant Payment Success Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>ipFailureLimit</c> - &lt;b&gt;IP Failure Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>ipFailureRatio</c> - &lt;b&gt;IP Failure Ratio&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>inactiveMerchant</c> - &lt;b&gt;Inactive Merchant&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>refundWithoutSale</c> - &lt;b&gt;Refund Without Sale&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>refundWithoutSaleLimit</c> - &lt;b&gt;Refund Without Sale Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>captureAboveAuthLimit</c> - &lt;b&gt;Capture Above Auth Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>cvv</c> - &lt;b&gt;CVV Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>avs</c> - &lt;b&gt;AVS Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>aavs</c> - &lt;b&gt;AAVS Verification&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>duplicateTxn</c> - &lt;b&gt;Duplicate Transaction&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>merchantMatch</c> - &lt;b&gt;Merchant Match&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>currencyConversion</c> - &lt;b&gt;Currency Conversion&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>settledCurrencyMismatch</c> - &lt;b&gt;Settled Currency Mismatch&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>initialTxn</c> - &lt;b&gt;Initial Transaction&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>similarTotalLimit</c> - &lt;b&gt;Similar Total Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>similarTotalRatio</c> - &lt;b&gt;Similar Total Ratio&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>limit</c> - &lt;b&gt;Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>ratio</c> - &lt;b&gt;Ratio&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>txnWatchlist</c> - &lt;b&gt;Transaction Watchlist&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>balanceRefundLimit</c> - &lt;b&gt;Balance Refund Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>saleApprovedLimit</c> - &lt;b&gt;Sale Approved Limit&lt;/b&gt;&lt;/li&gt;
///     &lt;li&gt;<c>refundApprovedLimit</c> - &lt;b&gt;Refund Approved Limit&lt;/b&gt;&lt;/li&gt;
///   &lt;/ul&gt;
/// &lt;/details&gt;
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationType2>))]
public sealed record VerificationType2 : OpenStringEnum<VerificationType2>
{
    private VerificationType2(string value) : base(value)
    {
    }

    public static readonly VerificationType2 AdvancedEntity = new("advancedEntity");

    public static readonly VerificationType2 Ofac = new("ofac");

    public static readonly VerificationType2 Entity = new("entity");

    public static readonly VerificationType2 Overall = new("overall");

    public static readonly VerificationType2 Watchlist = new("watchlist");

    public static readonly VerificationType2 DataVerification = new("dataVerification");

    public static readonly VerificationType2 AdvancedMerchant = new("advancedMerchant");

    public static readonly VerificationType2 AdvancedMember = new("advancedMember");

    public static readonly VerificationType2 Association = new("association");

    public static readonly VerificationType2 Member = new("member");

    public static readonly VerificationType2 MerchantFailureLimit = new("merchantFailureLimit");

    public static readonly VerificationType2 MerchantPaymentFailureLimit = new("merchantPaymentFailureLimit");

    public static readonly VerificationType2 SaleTotalLimit = new("saleTotalLimit");

    public static readonly VerificationType2 SaleTotalMinimum = new("saleTotalMinimum");

    public static readonly VerificationType2 MerchantCaptureWithoutAuthLimit = new("merchantCaptureWithoutAuthLimit");

    public static readonly VerificationType2 RefundTotalLimit = new("refundTotalLimit");

    public static readonly VerificationType2 AverageSaleCountLimit = new("averageSaleCountLimit");

    public static readonly VerificationType2 MerchantRefundSaleRatio = new("merchantRefundSaleRatio");

    public static readonly VerificationType2 MerchantPaymentSuccessLimit = new("merchantPaymentSuccessLimit");

    public static readonly VerificationType2 IpFailureLimit = new("ipFailureLimit");

    public static readonly VerificationType2 IpFailureRatio = new("ipFailureRatio");

    public static readonly VerificationType2 InactiveMerchant = new("inactiveMerchant");

    public static readonly VerificationType2 RefundWithoutSale = new("refundWithoutSale");

    public static readonly VerificationType2 RefundWithoutSaleLimit = new("refundWithoutSaleLimit");

    public static readonly VerificationType2 CaptureAboveAuthLimit = new("captureAboveAuthLimit");

    public static readonly VerificationType2 Cvv = new("cvv");

    public static readonly VerificationType2 Avs = new("avs");

    public static readonly VerificationType2 Aavs = new("aavs");

    public static readonly VerificationType2 DuplicateTxn = new("duplicateTxn");

    public static readonly VerificationType2 MerchantMatch = new("merchantMatch");

    public static readonly VerificationType2 CurrencyConversion = new("currencyConversion");

    public static readonly VerificationType2 SettledCurrencyMismatch = new("settledCurrencyMismatch");

    public static readonly VerificationType2 InitialTxn = new("initialTxn");

    public static readonly VerificationType2 SimilarTotalLimit = new("similarTotalLimit");

    public static readonly VerificationType2 SimilarTotalRatio = new("similarTotalRatio");

    public static readonly VerificationType2 Limit = new("limit");

    public static readonly VerificationType2 Ratio = new("ratio");

    public static readonly VerificationType2 TxnWatchlist = new("txnWatchlist");

    public static readonly VerificationType2 BalanceRefundLimit = new("balanceRefundLimit");

    public static readonly VerificationType2 SaleApprovedLimit = new("saleApprovedLimit");

    public static readonly VerificationType2 RefundApprovedLimit = new("refundApprovedLimit");

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
