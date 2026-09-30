using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The desired type to take on the referenced Note.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>note</c> - <b>Just add a note to the hold.</b></description></item>
///   <item><description><c>release</c> - <b>Release the hold for this Hold.</b></description></item>
///   <item><description><c>review</c> - <b>Mark the hold as having been reviewed.</b></description></item>
///   <item><description><c>reReview</c> - <b>If the hold was marked as reviewed, this will allow resetting the review.</b></description></item>
///   <item><description><c>amexSales</c> - <b>If the entity does sales with amex.</b></description></item>
///   <item><description><c>businessSales</c> - <b>If the entity does business direct sales.</b></description></item>
///   <item><description><c>consumerSales</c> - <b>If the entity does consumer direct sales.</b></description></item>
///   <item><description><c>deliverySchedule</c> - <b>The delivery schedule of the entity.</b></description></item>
///   <item><description><c>immediateDeliveryPercent</c> - <b>The amount of immediate deliveries with 0 day after the transaction.</b></description></item>
///   <item><description><c>sevenDayDeliveryPercent</c> - <b>The amount of deliveries between 1-7 days after the transaction.</b></description></item>
///   <item><description><c>fourteenDayDeliveryPercent</c> - <b>The amount of deliveries between 8-14 days after the transaction.</b></description></item>
///   <item><description><c>thirtyDayDeliveryPercent</c> - <b>The amount of deliveries between 15-30 days after the transaction.</b></description></item>
///   <item><description><c>cardPresentSales</c> - <b>If the entity does sales with card present.</b></description></item>
///   <item><description><c>motoSales</c> - <b>If the entity does sales over the phone or mail.</b></description></item>
///   <item><description><c>ecommerceSales</c> - <b>If the entity does ecommerce sales.</b></description></item>
///   <item><description><c>siteVisit</c> - <b>If the entity had the site visit.</b></description></item>
///   <item><description><c>goodsSold</c> - <b>The type of goods the entity sales.</b></description></item>
///   <item><description><c>authorizationFlatFee</c> - <b>The flat fee agreement for each authorization.</b></description></item>
///   <item><description><c>capturePercentFee</c> - <b>The percentage fee agreement for each capture.</b></description></item>
///   <item><description><c>captureFlatFee</c> - <b>The flat fee agreement for each capture.</b></description></item>
///   <item><description><c>riskApproved</c> - <b>The entity was approved.</b></description></item>
///   <item><description><c>riskPending</c> - <b>The entity is in pending status.</b></description></item>
///   <item><description><c>riskCancelled</c> - <b>The entity has a cancelled status.</b></description></item>
///   <item><description><c>riskDenied</c> - <b>The entity has a denied status.</b></description></item>
///   <item><description><c>riskClosed</c> - <b>The entity has a closed status.</b></description></item>
///   <item><description><c>riskInvestigation</c> - <b>The entity is in investigation status.</b></description></item>
///   <item><description><c>riskPendingData</c> - <b>Pending Docs/Info for The entity.</b></description></item>
///   <item><description><c>riskFundsReleased</c> - <b>Funds released for The entity.</b></description></item>
///   <item><description><c>riskActivityApproved</c> - <b>Activity approved for the entity.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NoteType1>))]
public sealed record NoteType1 : OpenStringEnum<NoteType1>
{
    private NoteType1(string value) : base(value)
    {
    }

    public static readonly NoteType1 Note = new("note");

    public static readonly NoteType1 Release = new("release");

    public static readonly NoteType1 Review = new("review");

    public static readonly NoteType1 ReReview = new("reReview");

    public static readonly NoteType1 AmexSales = new("amexSales");

    public static readonly NoteType1 BusinessSales = new("businessSales");

    public static readonly NoteType1 ConsumerSales = new("consumerSales");

    public static readonly NoteType1 DeliverySchedule = new("deliverySchedule");

    public static readonly NoteType1 ImmediateDeliveryPercent = new("immediateDeliveryPercent");

    public static readonly NoteType1 SevenDayDeliveryPercent = new("sevenDayDeliveryPercent");

    public static readonly NoteType1 FourteenDayDeliveryPercent = new("fourteenDayDeliveryPercent");

    public static readonly NoteType1 ThirtyDayDeliveryPercent = new("thirtyDayDeliveryPercent");

    public static readonly NoteType1 CardPresentSales = new("cardPresentSales");

    public static readonly NoteType1 MotoSales = new("motoSales");

    public static readonly NoteType1 EcommerceSales = new("ecommerceSales");

    public static readonly NoteType1 SiteVisit = new("siteVisit");

    public static readonly NoteType1 GoodsSold = new("goodsSold");

    public static readonly NoteType1 AuthorizationFlatFee = new("authorizationFlatFee");

    public static readonly NoteType1 CapturePercentFee = new("capturePercentFee");

    public static readonly NoteType1 CaptureFlatFee = new("captureFlatFee");

    public static readonly NoteType1 RiskApproved = new("riskApproved");

    public static readonly NoteType1 RiskPending = new("riskPending");

    public static readonly NoteType1 RiskCancelled = new("riskCancelled");

    public static readonly NoteType1 RiskDenied = new("riskDenied");

    public static readonly NoteType1 RiskClosed = new("riskClosed");

    public static readonly NoteType1 RiskInvestigation = new("riskInvestigation");

    public static readonly NoteType1 RiskPendingData = new("riskPendingData");

    public static readonly NoteType1 RiskFundsReleased = new("riskFundsReleased");

    public static readonly NoteType1 RiskActivityApproved = new("riskActivityApproved");

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
