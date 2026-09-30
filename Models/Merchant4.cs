using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record Merchant4
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
    /// The date and time on which this Merchant last processed a Transaction. The format should be YYYY-MM-DD HH:MM:SS.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastActivity")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}")]
    public string? LastActivity { get; init; }

    /// <summary>
    /// Show the total approved amount to this merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalApprovedSales")]
    public long? TotalApprovedSales { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public Entity4? Entity { get; init; }

    /// <summary>
    /// The name under which the Merchant is doing business, if applicable. This field is stored as a text string and must be between 0 and 50 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dba")]
    public string? Dba { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new")]
    public MerchantsNew1? New { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("incrementalAuthSupported")]
    public MerchantsIncrementalAuthSupported1? IncrementalAuthSupported { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seasonal")]
    public MerchantsSeasonal1? Seasonal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("advancedBilling")]
    public MerchantsAdvanceBilling1? AdvancedBilling { get; init; }

    /// <summary>
    /// The date on which the Merchant was established. The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016.
    /// <para>
    /// <b>Note:</b> Include the <c>established</c> date value to ensure successful underwriting and new Merchant onboarding to the VCore platform.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("established")]
    public int? Established { get; init; }

    /// <summary>
    /// The value of the annual credit card sales of this Merchant.
    /// This field is specified as an integer in cents. For example, $25.30 is expressed as '2530'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annualCCSales")]
    public long? AnnualCcSales { get; init; }

    /// <summary>
    /// The value of the annual credit card sale volume of this Merchant.
    /// This field is specified as an integer in cents. For example, $25.30 is expressed as '2530'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annualCCSaleVolume")]
    public long? AnnualCcSaleVolume { get; init; }

    /// <summary>
    /// The value of the annual direct deposit sale volume of this Merchant.
    /// This field is specified as an integer in cents. For example, $25.30 is expressed as '2530'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annualACHSaleVolume")]
    public long? AnnualAchSaleVolume { get; init; }

    /// <summary>
    /// Indicates the Annual AMEX Sales Volume for the outlet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amexVolume")]
    public long? AmexVolume { get; init; }

    /// <summary>
    /// The value of the average credit card sales of this Merchant.
    /// This field is specified as an integer in cents. For example, $25.30 is expressed as '2530'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avgTicket")]
    public long? AvgTicket { get; init; }

    /// <summary>
    /// The American Express merchant identifier for this Merchant, if applicable.
    /// This field is stored as a text string and must be between 1 and 15 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amex")]
    public string? Amex { get; init; }

    /// <summary>
    /// The Discover merchant identifier for this Merchant, if applicable.
    /// This field is stored as a text string and must be between 1 and 15 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discover")]
    public string? Discover { get; init; }

    /// <summary>
    /// The Merchant Category Code (MCC) for this Merchant. This code is not required to create a Merchant, but it is required to successfully board a Merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcc")]
    public string? Mcc { get; init; }

    /// <summary>
    /// Merchant Verification Value. A value assigned by Visa to identify participation in select merchant programs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visaMvv")]
    public string? VisaMvv { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visaDisclosure")]
    public MerchantsVisaDisclosureIp1? VisaDisclosure { get; init; }

    /// <summary>
    /// The IP address where the Merchant platform disclosure is hosted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disclosureIP")]
    public string? DisclosureIp { get; init; }

    /// <summary>
    /// The date the Merchant platform disclosure is reviewed by the Merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disclosureDate")]
    public int? DisclosureDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("environment")]
    public MerchantEnvironment1? Environment { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public MerchantStatus1? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoBoarded")]
    public MerchantAutoBoarded1? AutoBoarded { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusReason")]
    public MerchantStatusReason1? StatusReason { get; init; }

    /// <summary>
    /// The denial or account closure reason code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountClosureReasonCode")]
    public string? AccountClosureReasonCode { get; init; }

    /// <summary>
    /// The date the account closure reason code was provided. It should be in YYYYMMDD format
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountClosureReasonDate")]
    public int? AccountClosureReasonDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskLevel")]
    public MerchantRiskLevel1? RiskLevel { get; init; }

    /// <summary>
    /// The credit ratio to use while calculating risk factors for credit, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creditRatio")]
    public int? CreditRatio { get; init; }

    /// <summary>
    /// The credit timeliness for the Merchant, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creditTimeliness")]
    public int? CreditTimeliness { get; init; }

    /// <summary>
    /// Chargeback Ratio.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chargebackRatio")]
    public int? ChargebackRatio { get; init; }

    /// <summary>
    /// The ndx (Non Delivery Exposure) days which the Merchant is in, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ndxDays")]
    public int? NdxDays { get; init; }

    /// <summary>
    /// The ndx (Non Delivery Exposure) percentage to be used for the merchant, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ndxPercentage")]
    public int? NdxPercentage { get; init; }

    /// <summary>
    /// The date and time on which this Merchant was successfully boarded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("boarded")]
    public int? Boarded { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("saqType")]
    public MerchantsSaqType1? SaqType { get; init; }

    /// <summary>
    /// The date of the PCI SAQ assessment. The format should be YYYYMMDD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("saqDate")]
    public int? SaqDate { get; init; }

    /// <summary>
    /// Qualified Security Assessor (QSA) companies are independent security organizations that have been qualified by the PCI Security Standards Council to validate an entity's adherence to PCI DSS. This is a free-text field for inputting the QSA's business name.
    ///  The name of the Qualified Security Assessor (QSA) used by the Merchant to assess, verify and prove their PCI DSS compliance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qsa")]
    public string? Qsa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("letterStatus")]
    public MerchantsLetterStatus1? LetterStatus { get; init; }

    /// <summary>
    /// The date associated with the letter status. The format should be YYYYMMDD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("letterDate")]
    public int? LetterDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tcAttestation")]
    public MerchantsTcAttestation1? TcAttestation { get; init; }

    /// <summary>
    /// Transaction Session Id.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tmxSessionId")]
    public string? TmxSessionId { get; init; }

    /// <summary>
    /// Notification Email for chargebacks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chargebackNotificationEmail")]
    public string? ChargebackNotificationEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locationType")]
    public MerchantLocationType1? LocationType { get; init; }

    /// <summary>
    /// The merchant percentage of transactions that are Card Not Present (Includes MOTO and eCommerce).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentKeyed")]
    public int? PercentKeyed { get; init; }

    /// <summary>
    /// The expected total volume for all credit card and ACH payments that the merchant will process for the current year.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalVolume")]
    public long? TotalVolume { get; init; }

    /// <summary>
    /// This field indicates what percentage are internet originated transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentEcomm")]
    public int? PercentEcomm { get; init; }

    /// <summary>
    /// This field indicates what percentage of the transactions are Business to Business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentBusiness")]
    public int? PercentBusiness { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applePayActive")]
    public MerchantsApplePayActive1? ApplePayActive { get; init; }

    /// <summary>
    /// The status of Apple Pay for this merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applePayStatus")]
    public string? ApplePayStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("googlePayActive")]
    public MerchantsGooglePayActive1? GooglePayActive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("naics")]
    public MerchantsNaics1? Naics { get; init; }

    /// <summary>
    /// The NAICS sector description matching the above NAICS sector code. If "Other", industry description is prefixed with "Other: ".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("naicsDescription")]
    public string? NaicsDescription { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expressBatchCloseMethod")]
    public MerchantsExpressBatchCloseMethod1? ExpressBatchCloseMethod { get; init; }

    /// <summary>
    /// This field indicates the batch close time for this merchant applicable to Express platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expressBatchCloseTime")]
    public string? ExpressBatchCloseTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passTokenEnabled")]
    public MerchantsPassTokenEnabled1? PassTokenEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assessments")]
    public IReadOnlyList<AssessmentsResponse>? Assessments { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appleDomains")]
    public IReadOnlyList<AppleDomainsResponse>? AppleDomains { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batches")]
    public IReadOnlyList<BatchesResponse>? Batches { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chargebacks")]
    public IReadOnlyList<ChargebacksResponse>? Chargebacks { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customers")]
    public IReadOnlyList<CustomersResponse>? Customers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoices")]
    public IReadOnlyList<InvoicesResponse>? Invoices { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("members")]
    public IReadOnlyList<MembersResponse>? Members { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantPlatformStatuses")]
    public IReadOnlyList<MerchantPlatformStatusesResponse>? MerchantPlatformStatuses { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantResults")]
    public IReadOnlyList<MerchantResultsResponse>? MerchantResults { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plans")]
    public IReadOnlyList<PlansResponse>? Plans { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminals")]
    public IReadOnlyList<TerminalsResponse>? Terminals { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
