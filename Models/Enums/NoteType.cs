using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<NoteType>))]
public sealed record NoteType : OpenStringEnum<NoteType>
{
    private NoteType(string value) : base(value)
    {
    }

    public static readonly NoteType Note = new("note");

    public static readonly NoteType Release = new("release");

    public static readonly NoteType Review = new("review");

    public static readonly NoteType ReReview = new("reReview");

    public static readonly NoteType AmexSales = new("amexSales");

    public static readonly NoteType BusinessSales = new("businessSales");

    public static readonly NoteType ConsumerSales = new("consumerSales");

    public static readonly NoteType DeliverySchedule = new("deliverySchedule");

    public static readonly NoteType ImmediateDeliveryPercent = new("immediateDeliveryPercent");

    public static readonly NoteType SevenDayDeliveryPercent = new("sevenDayDeliveryPercent");

    public static readonly NoteType FourteenDayDeliveryPercent = new("fourteenDayDeliveryPercent");

    public static readonly NoteType ThirtyDayDeliveryPercent = new("thirtyDayDeliveryPercent");

    public static readonly NoteType CardPresentSales = new("cardPresentSales");

    public static readonly NoteType MotoSales = new("motoSales");

    public static readonly NoteType EcommerceSales = new("ecommerceSales");

    public static readonly NoteType SiteVisit = new("siteVisit");

    public static readonly NoteType GoodsSold = new("goodsSold");

    public static readonly NoteType AuthorizationFlatFee = new("authorizationFlatFee");

    public static readonly NoteType CapturePercentFee = new("capturePercentFee");

    public static readonly NoteType CaptureFlatFee = new("captureFlatFee");

    public static readonly NoteType RiskApproved = new("riskApproved");

    public static readonly NoteType RiskPending = new("riskPending");

    public static readonly NoteType RiskCancelled = new("riskCancelled");

    public static readonly NoteType RiskDenied = new("riskDenied");

    public static readonly NoteType RiskClosed = new("riskClosed");

    public static readonly NoteType RiskInvestigation = new("riskInvestigation");

    public static readonly NoteType RiskPendingData = new("riskPendingData");

    public static readonly NoteType RiskFundsReleased = new("riskFundsReleased");

    public static readonly NoteType RiskActivityApproved = new("riskActivityApproved");

    public TResult Match<TResult>(Func<TResult> onNote,
        Func<TResult> onRelease,
        Func<TResult> onReview,
        Func<TResult> onReReview,
        Func<TResult> onAmexSales,
        Func<TResult> onBusinessSales,
        Func<TResult> onConsumerSales,
        Func<TResult> onDeliverySchedule,
        Func<TResult> onImmediateDeliveryPercent,
        Func<TResult> onSevenDayDeliveryPercent,
        Func<TResult> onFourteenDayDeliveryPercent,
        Func<TResult> onThirtyDayDeliveryPercent,
        Func<TResult> onCardPresentSales,
        Func<TResult> onMotoSales,
        Func<TResult> onEcommerceSales,
        Func<TResult> onSiteVisit,
        Func<TResult> onGoodsSold,
        Func<TResult> onAuthorizationFlatFee,
        Func<TResult> onCapturePercentFee,
        Func<TResult> onCaptureFlatFee,
        Func<TResult> onRiskApproved,
        Func<TResult> onRiskPending,
        Func<TResult> onRiskCancelled,
        Func<TResult> onRiskDenied,
        Func<TResult> onRiskClosed,
        Func<TResult> onRiskInvestigation,
        Func<TResult> onRiskPendingData,
        Func<TResult> onRiskFundsReleased,
        Func<TResult> onRiskActivityApproved,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Note => onNote(),
            _ when this == Release => onRelease(),
            _ when this == Review => onReview(),
            _ when this == ReReview => onReReview(),
            _ when this == AmexSales => onAmexSales(),
            _ when this == BusinessSales => onBusinessSales(),
            _ when this == ConsumerSales => onConsumerSales(),
            _ when this == DeliverySchedule => onDeliverySchedule(),
            _ when this == ImmediateDeliveryPercent => onImmediateDeliveryPercent(),
            _ when this == SevenDayDeliveryPercent => onSevenDayDeliveryPercent(),
            _ when this == FourteenDayDeliveryPercent => onFourteenDayDeliveryPercent(),
            _ when this == ThirtyDayDeliveryPercent => onThirtyDayDeliveryPercent(),
            _ when this == CardPresentSales => onCardPresentSales(),
            _ when this == MotoSales => onMotoSales(),
            _ when this == EcommerceSales => onEcommerceSales(),
            _ when this == SiteVisit => onSiteVisit(),
            _ when this == GoodsSold => onGoodsSold(),
            _ when this == AuthorizationFlatFee => onAuthorizationFlatFee(),
            _ when this == CapturePercentFee => onCapturePercentFee(),
            _ when this == CaptureFlatFee => onCaptureFlatFee(),
            _ when this == RiskApproved => onRiskApproved(),
            _ when this == RiskPending => onRiskPending(),
            _ when this == RiskCancelled => onRiskCancelled(),
            _ when this == RiskDenied => onRiskDenied(),
            _ when this == RiskClosed => onRiskClosed(),
            _ when this == RiskInvestigation => onRiskInvestigation(),
            _ when this == RiskPendingData => onRiskPendingData(),
            _ when this == RiskFundsReleased => onRiskFundsReleased(),
            _ when this == RiskActivityApproved => onRiskActivityApproved(),
            _ => otherwise(Value)
        };

    public void Match(Action onNote,
        Action onRelease,
        Action onReview,
        Action onReReview,
        Action onAmexSales,
        Action onBusinessSales,
        Action onConsumerSales,
        Action onDeliverySchedule,
        Action onImmediateDeliveryPercent,
        Action onSevenDayDeliveryPercent,
        Action onFourteenDayDeliveryPercent,
        Action onThirtyDayDeliveryPercent,
        Action onCardPresentSales,
        Action onMotoSales,
        Action onEcommerceSales,
        Action onSiteVisit,
        Action onGoodsSold,
        Action onAuthorizationFlatFee,
        Action onCapturePercentFee,
        Action onCaptureFlatFee,
        Action onRiskApproved,
        Action onRiskPending,
        Action onRiskCancelled,
        Action onRiskDenied,
        Action onRiskClosed,
        Action onRiskInvestigation,
        Action onRiskPendingData,
        Action onRiskFundsReleased,
        Action onRiskActivityApproved,
        Action<string> otherwise)
    {
        if (this == Note) onNote();
        else if (this == Release) onRelease();
        else if (this == Review) onReview();
        else if (this == ReReview) onReReview();
        else if (this == AmexSales) onAmexSales();
        else if (this == BusinessSales) onBusinessSales();
        else if (this == ConsumerSales) onConsumerSales();
        else if (this == DeliverySchedule) onDeliverySchedule();
        else if (this == ImmediateDeliveryPercent) onImmediateDeliveryPercent();
        else if (this == SevenDayDeliveryPercent) onSevenDayDeliveryPercent();
        else if (this == FourteenDayDeliveryPercent) onFourteenDayDeliveryPercent();
        else if (this == ThirtyDayDeliveryPercent) onThirtyDayDeliveryPercent();
        else if (this == CardPresentSales) onCardPresentSales();
        else if (this == MotoSales) onMotoSales();
        else if (this == EcommerceSales) onEcommerceSales();
        else if (this == SiteVisit) onSiteVisit();
        else if (this == GoodsSold) onGoodsSold();
        else if (this == AuthorizationFlatFee) onAuthorizationFlatFee();
        else if (this == CapturePercentFee) onCapturePercentFee();
        else if (this == CaptureFlatFee) onCaptureFlatFee();
        else if (this == RiskApproved) onRiskApproved();
        else if (this == RiskPending) onRiskPending();
        else if (this == RiskCancelled) onRiskCancelled();
        else if (this == RiskDenied) onRiskDenied();
        else if (this == RiskClosed) onRiskClosed();
        else if (this == RiskInvestigation) onRiskInvestigation();
        else if (this == RiskPendingData) onRiskPendingData();
        else if (this == RiskFundsReleased) onRiskFundsReleased();
        else if (this == RiskActivityApproved) onRiskActivityApproved();
        else otherwise(Value);
    }
}
