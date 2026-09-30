using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record ParametersResponse
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
    /// The Login that owns this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// The identifier of the Org resource that this Parameter resource is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("org")]
    public string? Org { get; init; }

    /// <summary>
    /// The identifier of the Division resource that this Parameter resource is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public string? Division { get; init; }

    /// <summary>
    /// The identifier of the Partition resource that this Parameter resource is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partition")]
    public string? Partition { get; init; }

    /// <summary>
    /// The minimum allowed Transaction total.
    /// This field is specified as an integer in cents.
    /// The default setting is to have no minimum total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minTxnTotal")]
    public long? MinTxnTotal { get; init; }

    /// <summary>
    /// The maximum allowed Transaction total.
    /// This field is specified as an integer in cents.
    /// The default setting is to have no maximum total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTxnTotal")]
    public long? MaxTxnTotal { get; init; }

    /// <summary>
    /// The maximum allowed Transaction total in any single day.
    /// This field is specified as an integer in cents.
    /// The default setting is to have no maximum total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTxnDailyTotal")]
    public long? MaxTxnDailyTotal { get; init; }

    /// <summary>
    /// The highest daily number of Sale, eCheck Sale and Capture transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTxnDailyNum")]
    public long? MaxTxnDailyNum { get; init; }

    /// <summary>
    /// The maximum allowed Transaction total in any single month.
    /// This field is specified as an integer in cents.
    /// The default setting is to have no maximum total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTxnMonthlyTotal")]
    public long? MaxTxnMonthlyTotal { get; init; }

    /// <summary>
    /// The maximum allowed number of Transactions in any single month.
    /// The default setting is to have no maximum total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTxnMonthlyNum")]
    public long? MaxTxnMonthlyNum { get; init; }

    /// <summary>
    /// The highest amount of consecutive failures for a subscription payment before it is automatically inactivated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxSubscriptionFailures")]
    public int? MaxSubscriptionFailures { get; init; }

    /// <summary>
    /// The minimum allowed Payout Credit total.
    /// This field is specified as an integer in cents.
    /// The default setting is 1 cent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minPayoutCreditTotal")]
    public long? MinPayoutCreditTotal { get; init; }

    /// <summary>
    /// The maximum allowed Payout Credit total.
    /// This field is specified as an integer in cents.
    /// The default setting is to have no maximum total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxPayoutCreditTotal")]
    public long? MaxPayoutCreditTotal { get; init; }

    /// <summary>
    /// The minimum allowed Payout Debit total.
    /// This field is specified as a negative integer in cents.
    /// The default setting is -1 cent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minPayoutDebitTotal")]
    public long? MinPayoutDebitTotal { get; init; }

    /// <summary>
    /// The maximum allowed Payout Debit total.
    /// This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxPayoutDebitTotal")]
    public long? MaxPayoutDebitTotal { get; init; }

    /// <summary>
    /// The minimum available funds that the Payout's entity needs to have to payout.
    /// This field is specified as an +/- integer in cents.
    /// The default setting is null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minAvailableFunds")]
    public long? MinAvailableFunds { get; init; }

    /// <summary>
    /// The minimum allowed number of days to delay statement debit Payouts by.
    /// The default setting is 5.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minStatementDebitPayoutDelay")]
    public long? MinStatementDebitPayoutDelay { get; init; }

    /// <summary>
    /// The minimum total debit allowed.
    /// This field is specified as an integer in cents.
    /// The default setting is 500.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minFundsPayoutTotal")]
    public long? MinFundsPayoutTotal { get; init; }

    /// <summary>
    /// The minimum allowed number of days to delay Payouts by.
    /// The default setting is 3.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minPayoutDelay")]
    public long? MinPayoutDelay { get; init; }

    /// <summary>
    /// The minimum amount of days to delay processing of a requested payout for the first payout to an entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minFirstPayoutDelay")]
    public long? MinFirstPayoutDelay { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutAdjustSubcents")]
    public ParametersPayoutAdjustSubcents2? PayoutAdjustSubcents { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutDelayIncludeOffDays")]
    public ParametersPayoutDelayIncludeOffDays2? PayoutDelayIncludeOffDays { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutIncludePending")]
    public ParametersPayoutIncludePending2? PayoutIncludePending { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amexEnabled")]
    public ParametersAmexEnabled2? AmexEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("optBlueEnabled")]
    public ParametersOptBlueEnabled2? OptBlueEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discoverEnabled")]
    public ParametersDiscoverEnabled2? DiscoverEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discoverAcquiredEnabled")]
    public ParametersDiscoverAcquiredEnabled2? DiscoverAcquiredEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mc3dsEnabled")]
    public ParametersMc3DsEnabled2? Mc3DsEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visa3dsEnabled")]
    public ParametersVisa3DsEnabled2? Visa3DsEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amex3dsEnabled")]
    public ParametersAmex3DsEnabled2? Amex3DsEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discover3dsEnabled")]
    public ParametersDiscover3DsEnabled2? Discover3DsEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eCheckEnabled")]
    public ParametersECheckEnabled2? ECheckEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingEnabled")]
    public ParametersFundingEnabled2? FundingEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debtRepaymentEnabled")]
    public ParametersDebtRepaymentEnabled2? DebtRepaymentEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verifyDisabled")]
    public ParametersVerifyDisabled2? VerifyDisabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verifyForBoardingNotRequired")]
    public ParametersVerifyForBoardingNotRequired2? VerifyForBoardingNotRequired { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verifyForPayoutNotRequired")]
    public ParametersVerifyForPayoutNotRequired2? VerifyForPayoutNotRequired { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refundReleasesReserve")]
    public RefundReleaseReserve2? RefundReleasesReserve { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendorFeesEnabled")]
    public VendorFeesEnabled2? VendorFeesEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendorFeesExternal")]
    public VendorFeesExternal2? VendorFeesExternal { get; init; }

    /// <summary>
    /// The number of days before an Auth Misuse fee should be charged on a VISA txn that has not settled.
    /// The default setting is 10.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visaMisuseSettlement")]
    public int? VisaMisuseSettlement { get; init; }

    /// <summary>
    /// The number of days before an Auth Misuse fee should be charged on a VISA txn that has not settled. Applies only to merchants with a Travel &amp; Entertainment mcc.
    /// The default setting is 20.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visaMisuseTravelAutoSettlement")]
    public int? VisaMisuseTravelAutoSettlement { get; init; }

    /// <summary>
    /// The number of hours before an Auth Misuse fee should be charged on a card present VISA txn that wasn't reversed within the timeframe.
    /// The default setting is 24.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visaMisuseCardPresentReversal")]
    public int? VisaMisuseCardPresentReversal { get; init; }

    /// <summary>
    /// The number of hours before an Auth Misuse fee should be charged on a card not present VISA txn that wasn't reversed within the timeframe.
    /// The default setting is 168.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visaMisuseCardNotPresentReversal")]
    public int? VisaMisuseCardNotPresentReversal { get; init; }

    /// <summary>
    /// The number of days before an Auth Misuse fee should be charged on a MasterCard txn that has not settled.
    /// The default setting is 120.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcMisuseSettlement")]
    public int? McMisuseSettlement { get; init; }

    /// <summary>
    /// Number of days after which to process (capture) eCheck sales. Will delay the funding and fees until the specified days from date of creation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minEcheckCaptureDelay")]
    public int? MinEcheckCaptureDelay { get; init; }

    /// <summary>
    /// Minimum number of business days before a debit is processed and made available for funding.
    /// The default setting is 5.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minDebitProcessingDelay")]
    public int? MinDebitProcessingDelay { get; init; }

    /// <summary>
    /// Minimum required total ownership of members for boarding.
    /// The default setting is '0'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minBoardingOwnership")]
    public int? MinBoardingOwnership { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("boardingExemptionsDisabled")]
    public ParametersBoardingExemptionsDisabled2? BoardingExemptionsDisabled { get; init; }

    /// <summary>
    /// The number of hours before an Auth Misuse fee should be charged on a card present MasterCard txn that wasn't reversed within the timeframe.
    /// The default setting is 24.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcMisuseCardPresentReversal")]
    public int? McMisuseCardPresentReversal { get; init; }

    /// <summary>
    /// The number of hours before an Auth Misuse fee should be charged on a card not present MasterCard txn that wasn't reversed within the timeframe.
    /// The default setting is 72.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcMisuseCardNotPresentReversal")]
    public int? McMisuseCardNotPresentReversal { get; init; }

    /// <summary>
    /// The number of hours before an Auth Misuse fee should be charged on a MasterCard txn that wasn't reversed within the timeframe. Applies only to merchants with a Travel &amp; Entertainment mcc.
    /// The default setting is 480.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcMisuseTravelAutoReversal")]
    public int? McMisuseTravelAutoReversal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("boardingDisabled")]
    public ParametersBoardingDisabled2? BoardingDisabled { get; init; }

    /// <summary>
    /// Number of days after a merchant's created date to attempt a reboard on a not yet boarded merchant. The default setting is <c>60</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoReboardDays")]
    public int? AutoReboardDays { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoTaxExemptEnabled")]
    public ParametersAutoTaxExemptEnabled2? AutoTaxExemptEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surchargeEnabled")]
    public ParametersSurchargeEnabled2? SurchargeEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcInstantPayoutsEnabled")]
    public ParametersMcInstantPayoutsEnabled2? McInstantPayoutsEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visaInstantPayoutsEnabled")]
    public ParametersVisaInstantPayoutsEnabled2? VisaInstantPayoutsEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sameDayPayoutsEnabled")]
    public ParametersSameDayPayoutsEnabled2? SameDayPayoutsEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applePayEnabled")]
    public ParametersApplePayEnabled2? ApplePayEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("googlePayEnabled")]
    public ParametersGooglePayEnabled2? GooglePayEnabled { get; init; }

    /// <summary>
    /// Maximum allowed total for same day payouts daily.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sameDayPayoutsDailyMax")]
    public long? SameDayPayoutsDailyMax { get; init; }

    /// <summary>
    /// Minimum allowed total for same day payout credit total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minSameDayPayoutCreditTotal")]
    public long? MinSameDayPayoutCreditTotal { get; init; }

    /// <summary>
    /// Maximum allowed total for same day payout credit total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxSameDayPayoutCreditTotal")]
    public long? MaxSameDayPayoutCreditTotal { get; init; }

    /// <summary>
    /// Minimum allowed total for same day payout credit total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minSameDayPayoutDebitTotal")]
    public long? MinSameDayPayoutDebitTotal { get; init; }

    /// <summary>
    /// Maximum allowed total for same day payout credit total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxSameDayPayoutDebitTotal")]
    public long? MaxSameDayPayoutDebitTotal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountUpdaterEnabled")]
    public ParametersAccountUpdaterEnabled2? AccountUpdaterEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updateAllTokensEnabled")]
    public ParametersUpdateAllTokensEnabled2? UpdateAllTokensEnabled { get; init; }

    /// <summary>
    /// The frequency for which to check for payment updates.
    /// The default setting is 30.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountUpdaterFrequency")]
    public int? AccountUpdaterFrequency { get; init; }

    /// <summary>
    /// The level to restore the funds to.
    /// The default setting is '0'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minDebitedAvailableFunds")]
    public long? MinDebitedAvailableFunds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("getParametersEnabled")]
    public ParametersGetParametersEnabled2? GetParametersEnabled { get; init; }

    /// <summary>
    /// The cutoff time for making a single payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutCutoffTime")]
    public int? PayoutCutoffTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("declineNotificationEmail")]
    public ParametersDeclineNotificationEmail2? DeclineNotificationEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decisionMicroserviceEnabled")]
    public ParametersDecisionMicroserviceEnabled2? DecisionMicroserviceEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holdMessagesDisabled")]
    public ParametersHoldMessagesDisabled2? HoldMessagesDisabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txnDecisionMicroserviceEnabled")]
    public ParametersTxnDecisionMicroserviceEnabled2? TxnDecisionMicroserviceEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("omniTokenEnabled")]
    public ParametersOmniTokenEnabled2? OmniTokenEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passTokenEnabled")]
    public ParametersPassTokenEnabled2? PassTokenEnabled { get; init; }

    /// <summary>
    /// Limit of the days a merchant can still with negative funds before we do the negative disbursement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debitGracePeriod")]
    public int? DebitGracePeriod { get; init; }

    /// <summary>
    /// Maximum amount the merchant can go negative before we do the negative disbursement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("negativeBalanceLimit")]
    public long? NegativeBalanceLimit { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("negativeBalanceEmail")]
    public ParametersNegativeBalanceEmail2? NegativeBalanceEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("positiveBalanceEmail")]
    public ParametersPositiveBalanceEmail2? PositiveBalanceEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loginAsEnabled")]
    public ParametersLoginAsEnabled2? LoginAsEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mfaEnabled")]
    public ParametersMfaEnabled2? MfaEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("portalAccessEnabled")]
    public ParametersPortalAccessEnabled2? PortalAccessEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountAddStopEmail")]
    public ParametersBankAccountAddStopEmail2? BankAccountAddStopEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountUpdateStopEmail")]
    public BankAccountUpdateStopEmail2? BankAccountUpdateStopEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
