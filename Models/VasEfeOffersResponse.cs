using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record VasEfeOffersResponse
{
    /// <summary>
    /// The ID of this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The date and time at which this resource was created. The format should be YYYY-MM-DD HH:MM:SS.SSSS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? Created { get; init; }

    /// <summary>
    /// The date and time at which this resource was modified. The format should be YYYY-MM-DD HH:MM:SS.SSSS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modified")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? Modified { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creator")]
    public Creator18? Creator { get; init; }

    /// <summary>
    /// The identifier of the Login that last modified this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier")]
    public string? Modifier { get; init; }

    /// <summary>
    /// Id of the offer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offerId")]
    public string? OfferId { get; init; }

    /// <summary>
    /// Expire date of offer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiry")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}")]
    public string? Expiry { get; init; }

    /// <summary>
    /// EntityId for merchant
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    /// <summary>
    /// MID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mid")]
    public string? Mid { get; init; }

    /// <summary>
    /// Primary point of contacts email
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryContactEmail")]
    public string? PrimaryContactEmail { get; init; }

    /// <summary>
    /// This refers to the partner product association
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantLenderId")]
    public string? MerchantLenderId { get; init; }

    /// <summary>
    /// Vendor associated with the product
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendorName")]
    public string? VendorName { get; init; }

    /// <summary>
    /// Date of provided offer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offerDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? OfferDate { get; init; }

    /// <summary>
    /// Amount approved for
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalApprovedAmount")]
    public string? TotalApprovedAmount { get; init; }

    /// <summary>
    /// Fee amount charged
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeAmount")]
    public string? FeeAmount { get; init; }

    /// <summary>
    /// Refers to fee charged by a lender to process a new loan application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originationFee")]
    public string? OriginationFee { get; init; }

    /// <summary>
    /// Url of corresponding offer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offerUrl")]
    public string? OfferUrl { get; init; }

    /// <summary>
    /// Name associated with the product
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productName")]
    public string? ProductName { get; init; }

    /// <summary>
    /// Long description of the product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productLongDescription")]
    public string? ProductLongDescription { get; init; }

    /// <summary>
    /// To identify whether a partner belongs to Core or VAP platforms.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquirePlatform")]
    public string? AcquirePlatform { get; init; }

    /// <summary>
    /// The date when preliminary information is submitted for vendor assessment to determine merchant eligibility to receive the cash advance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prequalificationSentDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? PrequalificationSentDate { get; init; }

    /// <summary>
    /// Date when the vendor provides the preQualification status of a given sub-merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prequalificationReceivedDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? PrequalificationReceivedDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isMerchantPrequalified")]
    public VasEfeOffersIsMerchantPrequalified2? IsMerchantPrequalified { get; init; }

    /// <summary>
    /// Date when merchant submitted an application to receive cash advance from a vendor. Date should be past or present in the format YYYY-MM-DD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appliedDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? AppliedDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offerStatus")]
    public VasEfeOffersOfferStatus2? OfferStatus { get; init; }

    /// <summary>
    /// Type of product which partner has enrolled into.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productCode")]
    public string? ProductCode { get; init; }

    /// <summary>
    /// Date when sub merchant started re-paying cash advance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? StartDate { get; init; }

    /// <summary>
    /// Date when sub merchant is expected to complete the repayment of cash advance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? EndDate { get; init; }

    /// <summary>
    /// Maximum amount to be repaid by sub merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitFundingCap")]
    public string? SplitFundingCap { get; init; }

    /// <summary>
    /// Repayment percentage as defined by lender.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitFundingRate")]
    public string? SplitFundingRate { get; init; }

    /// <summary>
    /// Maximum daily repayment limit as defined by lender.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dailyFundingMaxLimit")]
    public string? DailyFundingMaxLimit { get; init; }

    /// <summary>
    /// Split Funding Amount refers to the cash advance provided to the merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitFundingAmount")]
    public string? SplitFundingAmount { get; init; }

    /// <summary>
    /// The date when the merchant has opted in.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("optInDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? OptInDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitSettlementEnabled")]
    public VasEfeOffersSplitSettlementEnabled2? SplitSettlementEnabled { get; init; }

    /// <summary>
    /// The unique identifier for the Embedded Finance Partner (EFP) offer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("efpOfferId")]
    public string? EfpOfferId { get; init; }

    /// <summary>
    /// The approved amount for the product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productApprovedAmount")]
    public string? ProductApprovedAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
