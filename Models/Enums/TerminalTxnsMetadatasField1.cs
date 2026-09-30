using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The discretionary field being stored.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>discretionary1</c> - <b>Custom Field 1</b></description></item>
///   <item><description><c>discretionary2</c> - <b>Custom Field 2</b></description></item>
///   <item><description><c>discretionary3</c> - <b>Custom Field 3</b></description></item>
///   <item><description><c>clinical</c> - <b>Clinical amount</b></description></item>
///   <item><description><c>copay</c> - <b>Copay amount</b></description></item>
///   <item><description><c>dental</c> - <b>Dental amount</b></description></item>
///   <item><description><c>healthCare</c> - <b>Health Care amount</b></description></item>
///   <item><description><c>rx</c> - <b>RX amount</b></description></item>
///   <item><description><c>vision</c> - <b>Vision amount</b></description></item>
///   <item><description><c>applicationId</c> - <b>Application ID (AID)</b></description></item>
///   <item><description><c>terminalTransactionCurrency</c> - <b>Terminal Transaction Currency</b></description></item>
///   <item><description><c>cardSequenceNumber</c> - <b>Card Sequence Number</b></description></item>
///   <item><description><c>applicationPreferredName</c> - <b>Application Preferred Name (APPN)</b></description></item>
///   <item><description><c>applicationLabel</c> - <b>Application Label (APPLAB)</b></description></item>
///   <item><description><c>issuerScript1</c> - <b>Issuer Script 1</b></description></item>
///   <item><description><c>issuerScript2</c> - <b>Issuer Script 2</b></description></item>
///   <item><description><c>applicationInterchangeProfile</c> - <b>Application Interchange Profile</b></description></item>
///   <item><description><c>dedicatedFileName</c> - <b>Dedicated File Name</b></description></item>
///   <item><description><c>authorizationCode</c> - <b>Authorization Code (AC)</b></description></item>
///   <item><description><c>authorizationResponseCode</c> - <b>Authorization Response Code (ARC)</b></description></item>
///   <item><description><c>cardRiskManagementDataObjectList2</c> - <b>Card Risk Management Data Object List 2 (CDOL2)</b></description></item>
///   <item><description><c>issuerAuthData</c> - <b>Issuer Authentication Data (IAUTHD)</b></description></item>
///   <item><description><c>terminalVerificationResults</c> - <b>Terminal Verification Results (TVR)</b></description></item>
///   <item><description><c>transactionStatusInformation</c> - <b>Transaction Status Information (TSI)</b></description></item>
///   <item><description><c>transactionType</c> - <b>Transaction Type</b></description></item>
///   <item><description><c>otherAmount</c> - <b>Other Amount</b></description></item>
///   <item><description><c>applicationUsageControl</c> - <b>Application Usage Control (AUC)</b></description></item>
///   <item><description><c>applicationVersionNumber</c> - <b>Application Version Number (AVN)</b></description></item>
///   <item><description><c>issuerActionCodeDefault</c> - <b>Issuer Action Code Default (IACDefault)</b></description></item>
///   <item><description><c>issuerActionCodeDenial</c> - <b>Issuer Action Code Denial (IACDenial)</b></description></item>
///   <item><description><c>issuerActionCodeOnline</c> - <b>Issuer Action Code Online (IACOnline)</b></description></item>
///   <item><description><c>issuerApplicationData</c> - <b>Issuer Application Data</b></description></item>
///   <item><description><c>applicationIdName</c> - <b>Application ID Name (AID Name)</b></description></item>
///   <item><description><c>terminalTransactionCountryCode</c> - <b>Terminal Transaction Country Code</b></description></item>
///   <item><description><c>applicationCryptogram</c> - <b>Application Cryptogram (TC)</b></description></item>
///   <item><description><c>cryptogramInformationData</c> - <b>Cryptogram Information Data</b></description></item>
///   <item><description><c>capabilityProfile</c> - <b>Capability Profile</b></description></item>
///   <item><description><c>cardHolderVerificationMethod</c> - <b>Cardholder Verification Method Results (CVM)</b></description></item>
///   <item><description><c>applicationTransactionCounter</c> - <b>App Transaction Counter</b></description></item>
///   <item><description><c>unpredictableNumber</c> - <b>Unpredictable Number</b></description></item>
///   <item><description><c>issuerScriptResults</c> - <b>Issuer Script Results</b></description></item>
///   <item><description><c>formFactorIndicator</c> - <b>Form Factor Indicator</b></description></item>
///   <item><description><c>authCharacteristcs</c> - <b>Authorization Characteristics Indicator</b></description></item>
///   <item><description><c>authNetworkId</c> - <b>Authorizing Network ID</b></description></item>
///   <item><description><c>authResponseCode</c> - <b>Authorization Response Code</b></description></item>
///   <item><description><c>authSource</c> - <b>Point Of Authorization</b></description></item>
///   <item><description><c>banknetDate</c> - <b>MasterCard Banknet Settlement Date</b></description></item>
///   <item><description><c>cardCaptureCapability</c> - <b>Card Capture Capability</b></description></item>
///   <item><description><c>cardDataInputMode</c> - <b>Amex Card Data Input Mode</b></description></item>
///   <item><description><c>cardDataOutputCapability</c> - <b>Amex Card Data Output Capability</b></description></item>
///   <item><description><c>cardholderAuthentication</c> - <b>Amex Cardholder Authentication</b></description></item>
///   <item><description><c>cardholderPresent</c> - <b>Cardholder Presence</b></description></item>
///   <item><description><c>cardInputCapability</c> - <b>Card Data Input Capability</b></description></item>
///   <item><description><c>cardLevelResult</c> - <b>Visa Card Level Products Result</b></description></item>
///   <item><description><c>cardmemberAuthentication</c> - <b>Amex Cardmember Authentication</b></description></item>
///   <item><description><c>cardmemberEntity</c> - <b>Amex Cardmember Authentication Entity</b></description></item>
///   <item><description><c>cardPresent</c> - <b>Card Presence</b></description></item>
///   <item><description><c>cvvErrorCode</c> - <b>CVV Error Code</b></description></item>
///   <item><description><c>discoverResponseCode</c> - <b>Discover Response Code</b></description></item>
///   <item><description><c>ecommerceIndicator</c> - <b>Ecommerce Indicator</b></description></item>
///   <item><description><c>entryMode</c> - <b>POS Entry Mode</b></description></item>
///   <item><description><c>entryModeChange</c> - <b>POS Entry Mode changed by the issuer</b></description></item>
///   <item><description><c>goodsSoldCode</c> - <b>Amex Goods Sold Code</b></description></item>
///   <item><description><c>marketSpecificIndicator</c> - <b>Visa Market Specific Indicator</b></description></item>
///   <item><description><c>merchantVerificationValue</c> - <b>Visa MVV/Mastercard MAID</b></description></item>
///   <item><description><c>motoIndicator</c> - <b>Mail/Telephone Order Indicator</b></description></item>
///   <item><description><c>networkResultIndicator</c> - <b>Discover Network Result Indicator</b></description></item>
///   <item><description><c>operatingEnvironment</c> - <b>Amex Operating Environment</b></description></item>
///   <item><description><c>partialApprovalIndicator</c> - <b>Discover Partial Approval Indicator</b></description></item>
///   <item><description><c>pinCaptureCapability</c> - <b>PIN Capture Capability</b></description></item>
///   <item><description><c>posAttendanceIndicator</c> - <b>POS Attendance Indicator</b></description></item>
///   <item><description><c>posAuthLifecycle</c> - <b>Discover POS Auth Lifecycle</b></description></item>
///   <item><description><c>posData</c> - <b>Network POS Data</b></description></item>
///   <item><description><c>posEcommerceIndicator</c> - <b>Discover POS Ecommerce Indicator</b></description></item>
///   <item><description><c>posLocation</c> - <b>Discover POS Location</b></description></item>
///   <item><description><c>posTransactionSecurity</c> - <b>Discover POS Transaction Security</b></description></item>
///   <item><description><c>posTransactionStatus</c> - <b>Discover POS Transaction Status</b></description></item>
///   <item><description><c>processingCode</c> - <b>Discover Processing Code</b></description></item>
///   <item><description><c>stan</c> - <b>System Trace Audit Number</b></description></item>
///   <item><description><c>statusCode</c> - <b>Network status code</b></description></item>
///   <item><description><c>terminalOutputCapability</c> - <b>Amex Terminal Output Capability</b></description></item>
///   <item><description><c>track1Indicator</c> - <b>Discover Track 1 Data Indicator</b></description></item>
///   <item><description><c>track2Indicator</c> - <b>Discover Track 2 Data Indicator</b></description></item>
///   <item><description><c>transactionEditErrorCode</c> - <b>Mastercard track data error code</b></description></item>
///   <item><description><c>transactionIntegrityClass</c> - <b>Transaction Integrity Class</b></description></item>
///   <item><description><c>transactionQualifier</c> - <b>Discover Transaction Qualifier</b></description></item>
///   <item><description><c>validationCode</c> - <b>Visa Validation Code</b></description></item>
///   <item><description><c>visaSpendIndicator</c> - <b>Visa Spend Qualified Indicator</b></description></item>
///   <item><description><c>reversals</c> - <b>Reversals</b></description></item>
///   <item><description><c>firstTxn</c> - <b>First Transaction</b></description></item>
///   <item><description><c>posTerminalID</c> - <b>POS Terminal ID</b></description></item>
///   <item><description><c>pinlessConversionFlag</c> - <b>Pinless Conversion Flag</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalTxnsMetadatasField1>))]
public sealed record TerminalTxnsMetadatasField1 : OpenStringEnum<TerminalTxnsMetadatasField1>
{
    private TerminalTxnsMetadatasField1(string value) : base(value)
    {
    }

    public static readonly TerminalTxnsMetadatasField1 Discretionary1 = new("discretionary1");

    public static readonly TerminalTxnsMetadatasField1 Discretionary2 = new("discretionary2");

    public static readonly TerminalTxnsMetadatasField1 Discretionary3 = new("discretionary3");

    public static readonly TerminalTxnsMetadatasField1 Clinical = new("clinical");

    public static readonly TerminalTxnsMetadatasField1 Copay = new("copay");

    public static readonly TerminalTxnsMetadatasField1 Dental = new("dental");

    public static readonly TerminalTxnsMetadatasField1 HealthCare = new("healthCare");

    public static readonly TerminalTxnsMetadatasField1 Rx = new("rx");

    public static readonly TerminalTxnsMetadatasField1 Vision = new("vision");

    public static readonly TerminalTxnsMetadatasField1 ApplicationId = new("applicationId");

    public static readonly TerminalTxnsMetadatasField1 TerminalTransactionCurrency = new("terminalTransactionCurrency");

    public static readonly TerminalTxnsMetadatasField1 CardSequenceNumber = new("cardSequenceNumber");

    public static readonly TerminalTxnsMetadatasField1 ApplicationPreferredName = new("applicationPreferredName");

    public static readonly TerminalTxnsMetadatasField1 ApplicationLabel = new("applicationLabel");

    public static readonly TerminalTxnsMetadatasField1 IssuerScript1 = new("issuerScript1");

    public static readonly TerminalTxnsMetadatasField1 IssuerScript2 = new("issuerScript2");

    public static readonly TerminalTxnsMetadatasField1 ApplicationInterchangeProfile = new(
        "applicationInterchangeProfile");

    public static readonly TerminalTxnsMetadatasField1 DedicatedFileName = new("dedicatedFileName");

    public static readonly TerminalTxnsMetadatasField1 AuthorizationCode = new("authorizationCode");

    public static readonly TerminalTxnsMetadatasField1 AuthorizationResponseCode = new("authorizationResponseCode");

    public static readonly TerminalTxnsMetadatasField1 CardRiskManagementDataObjectList2 = new(
        "cardRiskManagementDataObjectList2");

    public static readonly TerminalTxnsMetadatasField1 IssuerAuthData = new("issuerAuthData");

    public static readonly TerminalTxnsMetadatasField1 TerminalVerificationResults = new("terminalVerificationResults");

    public static readonly TerminalTxnsMetadatasField1 TransactionStatusInformation = new(
        "transactionStatusInformation");

    public static readonly TerminalTxnsMetadatasField1 TransactionType = new("transactionType");

    public static readonly TerminalTxnsMetadatasField1 OtherAmount = new("otherAmount");

    public static readonly TerminalTxnsMetadatasField1 ApplicationUsageControl = new("applicationUsageControl");

    public static readonly TerminalTxnsMetadatasField1 ApplicationVersionNumber = new("applicationVersionNumber");

    public static readonly TerminalTxnsMetadatasField1 IssuerActionCodeDefault = new("issuerActionCodeDefault");

    public static readonly TerminalTxnsMetadatasField1 IssuerActionCodeDenial = new("issuerActionCodeDenial");

    public static readonly TerminalTxnsMetadatasField1 IssuerActionCodeOnline = new("issuerActionCodeOnline");

    public static readonly TerminalTxnsMetadatasField1 IssuerApplicationData = new("issuerApplicationData");

    public static readonly TerminalTxnsMetadatasField1 ApplicationIdName = new("applicationIdName");

    public static readonly TerminalTxnsMetadatasField1 TerminalTransactionCountryCode = new(
        "terminalTransactionCountryCode");

    public static readonly TerminalTxnsMetadatasField1 ApplicationCryptogram = new("applicationCryptogram");

    public static readonly TerminalTxnsMetadatasField1 CryptogramInformationData = new("cryptogramInformationData");

    public static readonly TerminalTxnsMetadatasField1 CapabilityProfile = new("capabilityProfile");

    public static readonly TerminalTxnsMetadatasField1 CardHolderVerificationMethod = new(
        "cardHolderVerificationMethod");

    public static readonly TerminalTxnsMetadatasField1 ApplicationTransactionCounter = new(
        "applicationTransactionCounter");

    public static readonly TerminalTxnsMetadatasField1 UnpredictableNumber = new("unpredictableNumber");

    public static readonly TerminalTxnsMetadatasField1 IssuerScriptResults = new("issuerScriptResults");

    public static readonly TerminalTxnsMetadatasField1 FormFactorIndicator = new("formFactorIndicator");

    public static readonly TerminalTxnsMetadatasField1 AuthCharacteristcs = new("authCharacteristcs");

    public static readonly TerminalTxnsMetadatasField1 AuthNetworkId = new("authNetworkId");

    public static readonly TerminalTxnsMetadatasField1 AuthResponseCode = new("authResponseCode");

    public static readonly TerminalTxnsMetadatasField1 AuthSource = new("authSource");

    public static readonly TerminalTxnsMetadatasField1 BanknetDate = new("banknetDate");

    public static readonly TerminalTxnsMetadatasField1 CardCaptureCapability = new("cardCaptureCapability");

    public static readonly TerminalTxnsMetadatasField1 CardDataInputMode = new("cardDataInputMode");

    public static readonly TerminalTxnsMetadatasField1 CardDataOutputCapability = new("cardDataOutputCapability");

    public static readonly TerminalTxnsMetadatasField1 CardholderAuthentication = new("cardholderAuthentication");

    public static readonly TerminalTxnsMetadatasField1 CardholderPresent = new("cardholderPresent");

    public static readonly TerminalTxnsMetadatasField1 CardInputCapability = new("cardInputCapability");

    public static readonly TerminalTxnsMetadatasField1 CardLevelResult = new("cardLevelResult");

    public static readonly TerminalTxnsMetadatasField1 CardmemberAuthentication = new("cardmemberAuthentication");

    public static readonly TerminalTxnsMetadatasField1 CardmemberEntity = new("cardmemberEntity");

    public static readonly TerminalTxnsMetadatasField1 CardPresent = new("cardPresent");

    public static readonly TerminalTxnsMetadatasField1 CvvErrorCode = new("cvvErrorCode");

    public static readonly TerminalTxnsMetadatasField1 DiscoverResponseCode = new("discoverResponseCode");

    public static readonly TerminalTxnsMetadatasField1 EcommerceIndicator = new("ecommerceIndicator");

    public static readonly TerminalTxnsMetadatasField1 EntryMode = new("entryMode");

    public static readonly TerminalTxnsMetadatasField1 EntryModeChange = new("entryModeChange");

    public static readonly TerminalTxnsMetadatasField1 GoodsSoldCode = new("goodsSoldCode");

    public static readonly TerminalTxnsMetadatasField1 MarketSpecificIndicator = new("marketSpecificIndicator");

    public static readonly TerminalTxnsMetadatasField1 MerchantVerificationValue = new("merchantVerificationValue");

    public static readonly TerminalTxnsMetadatasField1 MotoIndicator = new("motoIndicator");

    public static readonly TerminalTxnsMetadatasField1 NetworkResultIndicator = new("networkResultIndicator");

    public static readonly TerminalTxnsMetadatasField1 OperatingEnvironment = new("operatingEnvironment");

    public static readonly TerminalTxnsMetadatasField1 PartialApprovalIndicator = new("partialApprovalIndicator");

    public static readonly TerminalTxnsMetadatasField1 PinCaptureCapability = new("pinCaptureCapability");

    public static readonly TerminalTxnsMetadatasField1 PosAttendanceIndicator = new("posAttendanceIndicator");

    public static readonly TerminalTxnsMetadatasField1 PosAuthLifecycle = new("posAuthLifecycle");

    public static readonly TerminalTxnsMetadatasField1 PosData = new("posData");

    public static readonly TerminalTxnsMetadatasField1 PosEcommerceIndicator = new("posEcommerceIndicator");

    public static readonly TerminalTxnsMetadatasField1 PosLocation = new("posLocation");

    public static readonly TerminalTxnsMetadatasField1 PosTransactionSecurity = new("posTransactionSecurity");

    public static readonly TerminalTxnsMetadatasField1 PosTransactionStatus = new("posTransactionStatus");

    public static readonly TerminalTxnsMetadatasField1 ProcessingCode = new("processingCode");

    public static readonly TerminalTxnsMetadatasField1 Stan = new("stan");

    public static readonly TerminalTxnsMetadatasField1 StatusCode = new("statusCode");

    public static readonly TerminalTxnsMetadatasField1 TerminalOutputCapability = new("terminalOutputCapability");

    public static readonly TerminalTxnsMetadatasField1 Track1Indicator = new("track1Indicator");

    public static readonly TerminalTxnsMetadatasField1 Track2Indicator = new("track2Indicator");

    public static readonly TerminalTxnsMetadatasField1 TransactionEditErrorCode = new("transactionEditErrorCode");

    public static readonly TerminalTxnsMetadatasField1 TransactionIntegrityClass = new("transactionIntegrityClass");

    public static readonly TerminalTxnsMetadatasField1 TransactionQualifier = new("transactionQualifier");

    public static readonly TerminalTxnsMetadatasField1 ValidationCode = new("validationCode");

    public static readonly TerminalTxnsMetadatasField1 VisaSpendIndicator = new("visaSpendIndicator");

    public static readonly TerminalTxnsMetadatasField1 Reversals = new("reversals");

    public static readonly TerminalTxnsMetadatasField1 FirstTxn = new("firstTxn");

    public static readonly TerminalTxnsMetadatasField1 PosTerminalId = new("posTerminalID");

    public static readonly TerminalTxnsMetadatasField1 PinlessConversionFlag = new("pinlessConversionFlag");

    public TResult Match<TResult>(Func<TResult> onDiscretionary1,
        Func<TResult> onDiscretionary2,
        Func<TResult> onDiscretionary3,
        Func<TResult> onClinical,
        Func<TResult> onCopay,
        Func<TResult> onDental,
        Func<TResult> onHealthCare,
        Func<TResult> onRx,
        Func<TResult> onVision,
        Func<TResult> onApplicationId,
        Func<TResult> onTerminalTransactionCurrency,
        Func<TResult> onCardSequenceNumber,
        Func<TResult> onApplicationPreferredName,
        Func<TResult> onApplicationLabel,
        Func<TResult> onIssuerScript1,
        Func<TResult> onIssuerScript2,
        Func<TResult> onApplicationInterchangeProfile,
        Func<TResult> onDedicatedFileName,
        Func<TResult> onAuthorizationCode,
        Func<TResult> onAuthorizationResponseCode,
        Func<TResult> onCardRiskManagementDataObjectList2,
        Func<TResult> onIssuerAuthData,
        Func<TResult> onTerminalVerificationResults,
        Func<TResult> onTransactionStatusInformation,
        Func<TResult> onTransactionType,
        Func<TResult> onOtherAmount,
        Func<TResult> onApplicationUsageControl,
        Func<TResult> onApplicationVersionNumber,
        Func<TResult> onIssuerActionCodeDefault,
        Func<TResult> onIssuerActionCodeDenial,
        Func<TResult> onIssuerActionCodeOnline,
        Func<TResult> onIssuerApplicationData,
        Func<TResult> onApplicationIdName,
        Func<TResult> onTerminalTransactionCountryCode,
        Func<TResult> onApplicationCryptogram,
        Func<TResult> onCryptogramInformationData,
        Func<TResult> onCapabilityProfile,
        Func<TResult> onCardHolderVerificationMethod,
        Func<TResult> onApplicationTransactionCounter,
        Func<TResult> onUnpredictableNumber,
        Func<TResult> onIssuerScriptResults,
        Func<TResult> onFormFactorIndicator,
        Func<TResult> onAuthCharacteristcs,
        Func<TResult> onAuthNetworkId,
        Func<TResult> onAuthResponseCode,
        Func<TResult> onAuthSource,
        Func<TResult> onBanknetDate,
        Func<TResult> onCardCaptureCapability,
        Func<TResult> onCardDataInputMode,
        Func<TResult> onCardDataOutputCapability,
        Func<TResult> onCardholderAuthentication,
        Func<TResult> onCardholderPresent,
        Func<TResult> onCardInputCapability,
        Func<TResult> onCardLevelResult,
        Func<TResult> onCardmemberAuthentication,
        Func<TResult> onCardmemberEntity,
        Func<TResult> onCardPresent,
        Func<TResult> onCvvErrorCode,
        Func<TResult> onDiscoverResponseCode,
        Func<TResult> onEcommerceIndicator,
        Func<TResult> onEntryMode,
        Func<TResult> onEntryModeChange,
        Func<TResult> onGoodsSoldCode,
        Func<TResult> onMarketSpecificIndicator,
        Func<TResult> onMerchantVerificationValue,
        Func<TResult> onMotoIndicator,
        Func<TResult> onNetworkResultIndicator,
        Func<TResult> onOperatingEnvironment,
        Func<TResult> onPartialApprovalIndicator,
        Func<TResult> onPinCaptureCapability,
        Func<TResult> onPosAttendanceIndicator,
        Func<TResult> onPosAuthLifecycle,
        Func<TResult> onPosData,
        Func<TResult> onPosEcommerceIndicator,
        Func<TResult> onPosLocation,
        Func<TResult> onPosTransactionSecurity,
        Func<TResult> onPosTransactionStatus,
        Func<TResult> onProcessingCode,
        Func<TResult> onStan,
        Func<TResult> onStatusCode,
        Func<TResult> onTerminalOutputCapability,
        Func<TResult> onTrack1Indicator,
        Func<TResult> onTrack2Indicator,
        Func<TResult> onTransactionEditErrorCode,
        Func<TResult> onTransactionIntegrityClass,
        Func<TResult> onTransactionQualifier,
        Func<TResult> onValidationCode,
        Func<TResult> onVisaSpendIndicator,
        Func<TResult> onReversals,
        Func<TResult> onFirstTxn,
        Func<TResult> onPosTerminalId,
        Func<TResult> onPinlessConversionFlag,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Discretionary1 => onDiscretionary1(),
            _ when this == Discretionary2 => onDiscretionary2(),
            _ when this == Discretionary3 => onDiscretionary3(),
            _ when this == Clinical => onClinical(),
            _ when this == Copay => onCopay(),
            _ when this == Dental => onDental(),
            _ when this == HealthCare => onHealthCare(),
            _ when this == Rx => onRx(),
            _ when this == Vision => onVision(),
            _ when this == ApplicationId => onApplicationId(),
            _ when this == TerminalTransactionCurrency => onTerminalTransactionCurrency(),
            _ when this == CardSequenceNumber => onCardSequenceNumber(),
            _ when this == ApplicationPreferredName => onApplicationPreferredName(),
            _ when this == ApplicationLabel => onApplicationLabel(),
            _ when this == IssuerScript1 => onIssuerScript1(),
            _ when this == IssuerScript2 => onIssuerScript2(),
            _ when this == ApplicationInterchangeProfile => onApplicationInterchangeProfile(),
            _ when this == DedicatedFileName => onDedicatedFileName(),
            _ when this == AuthorizationCode => onAuthorizationCode(),
            _ when this == AuthorizationResponseCode => onAuthorizationResponseCode(),
            _ when this == CardRiskManagementDataObjectList2 => onCardRiskManagementDataObjectList2(),
            _ when this == IssuerAuthData => onIssuerAuthData(),
            _ when this == TerminalVerificationResults => onTerminalVerificationResults(),
            _ when this == TransactionStatusInformation => onTransactionStatusInformation(),
            _ when this == TransactionType => onTransactionType(),
            _ when this == OtherAmount => onOtherAmount(),
            _ when this == ApplicationUsageControl => onApplicationUsageControl(),
            _ when this == ApplicationVersionNumber => onApplicationVersionNumber(),
            _ when this == IssuerActionCodeDefault => onIssuerActionCodeDefault(),
            _ when this == IssuerActionCodeDenial => onIssuerActionCodeDenial(),
            _ when this == IssuerActionCodeOnline => onIssuerActionCodeOnline(),
            _ when this == IssuerApplicationData => onIssuerApplicationData(),
            _ when this == ApplicationIdName => onApplicationIdName(),
            _ when this == TerminalTransactionCountryCode => onTerminalTransactionCountryCode(),
            _ when this == ApplicationCryptogram => onApplicationCryptogram(),
            _ when this == CryptogramInformationData => onCryptogramInformationData(),
            _ when this == CapabilityProfile => onCapabilityProfile(),
            _ when this == CardHolderVerificationMethod => onCardHolderVerificationMethod(),
            _ when this == ApplicationTransactionCounter => onApplicationTransactionCounter(),
            _ when this == UnpredictableNumber => onUnpredictableNumber(),
            _ when this == IssuerScriptResults => onIssuerScriptResults(),
            _ when this == FormFactorIndicator => onFormFactorIndicator(),
            _ when this == AuthCharacteristcs => onAuthCharacteristcs(),
            _ when this == AuthNetworkId => onAuthNetworkId(),
            _ when this == AuthResponseCode => onAuthResponseCode(),
            _ when this == AuthSource => onAuthSource(),
            _ when this == BanknetDate => onBanknetDate(),
            _ when this == CardCaptureCapability => onCardCaptureCapability(),
            _ when this == CardDataInputMode => onCardDataInputMode(),
            _ when this == CardDataOutputCapability => onCardDataOutputCapability(),
            _ when this == CardholderAuthentication => onCardholderAuthentication(),
            _ when this == CardholderPresent => onCardholderPresent(),
            _ when this == CardInputCapability => onCardInputCapability(),
            _ when this == CardLevelResult => onCardLevelResult(),
            _ when this == CardmemberAuthentication => onCardmemberAuthentication(),
            _ when this == CardmemberEntity => onCardmemberEntity(),
            _ when this == CardPresent => onCardPresent(),
            _ when this == CvvErrorCode => onCvvErrorCode(),
            _ when this == DiscoverResponseCode => onDiscoverResponseCode(),
            _ when this == EcommerceIndicator => onEcommerceIndicator(),
            _ when this == EntryMode => onEntryMode(),
            _ when this == EntryModeChange => onEntryModeChange(),
            _ when this == GoodsSoldCode => onGoodsSoldCode(),
            _ when this == MarketSpecificIndicator => onMarketSpecificIndicator(),
            _ when this == MerchantVerificationValue => onMerchantVerificationValue(),
            _ when this == MotoIndicator => onMotoIndicator(),
            _ when this == NetworkResultIndicator => onNetworkResultIndicator(),
            _ when this == OperatingEnvironment => onOperatingEnvironment(),
            _ when this == PartialApprovalIndicator => onPartialApprovalIndicator(),
            _ when this == PinCaptureCapability => onPinCaptureCapability(),
            _ when this == PosAttendanceIndicator => onPosAttendanceIndicator(),
            _ when this == PosAuthLifecycle => onPosAuthLifecycle(),
            _ when this == PosData => onPosData(),
            _ when this == PosEcommerceIndicator => onPosEcommerceIndicator(),
            _ when this == PosLocation => onPosLocation(),
            _ when this == PosTransactionSecurity => onPosTransactionSecurity(),
            _ when this == PosTransactionStatus => onPosTransactionStatus(),
            _ when this == ProcessingCode => onProcessingCode(),
            _ when this == Stan => onStan(),
            _ when this == StatusCode => onStatusCode(),
            _ when this == TerminalOutputCapability => onTerminalOutputCapability(),
            _ when this == Track1Indicator => onTrack1Indicator(),
            _ when this == Track2Indicator => onTrack2Indicator(),
            _ when this == TransactionEditErrorCode => onTransactionEditErrorCode(),
            _ when this == TransactionIntegrityClass => onTransactionIntegrityClass(),
            _ when this == TransactionQualifier => onTransactionQualifier(),
            _ when this == ValidationCode => onValidationCode(),
            _ when this == VisaSpendIndicator => onVisaSpendIndicator(),
            _ when this == Reversals => onReversals(),
            _ when this == FirstTxn => onFirstTxn(),
            _ when this == PosTerminalId => onPosTerminalId(),
            _ when this == PinlessConversionFlag => onPinlessConversionFlag(),
            _ => otherwise(Value)
        };

    public void Match(Action onDiscretionary1,
        Action onDiscretionary2,
        Action onDiscretionary3,
        Action onClinical,
        Action onCopay,
        Action onDental,
        Action onHealthCare,
        Action onRx,
        Action onVision,
        Action onApplicationId,
        Action onTerminalTransactionCurrency,
        Action onCardSequenceNumber,
        Action onApplicationPreferredName,
        Action onApplicationLabel,
        Action onIssuerScript1,
        Action onIssuerScript2,
        Action onApplicationInterchangeProfile,
        Action onDedicatedFileName,
        Action onAuthorizationCode,
        Action onAuthorizationResponseCode,
        Action onCardRiskManagementDataObjectList2,
        Action onIssuerAuthData,
        Action onTerminalVerificationResults,
        Action onTransactionStatusInformation,
        Action onTransactionType,
        Action onOtherAmount,
        Action onApplicationUsageControl,
        Action onApplicationVersionNumber,
        Action onIssuerActionCodeDefault,
        Action onIssuerActionCodeDenial,
        Action onIssuerActionCodeOnline,
        Action onIssuerApplicationData,
        Action onApplicationIdName,
        Action onTerminalTransactionCountryCode,
        Action onApplicationCryptogram,
        Action onCryptogramInformationData,
        Action onCapabilityProfile,
        Action onCardHolderVerificationMethod,
        Action onApplicationTransactionCounter,
        Action onUnpredictableNumber,
        Action onIssuerScriptResults,
        Action onFormFactorIndicator,
        Action onAuthCharacteristcs,
        Action onAuthNetworkId,
        Action onAuthResponseCode,
        Action onAuthSource,
        Action onBanknetDate,
        Action onCardCaptureCapability,
        Action onCardDataInputMode,
        Action onCardDataOutputCapability,
        Action onCardholderAuthentication,
        Action onCardholderPresent,
        Action onCardInputCapability,
        Action onCardLevelResult,
        Action onCardmemberAuthentication,
        Action onCardmemberEntity,
        Action onCardPresent,
        Action onCvvErrorCode,
        Action onDiscoverResponseCode,
        Action onEcommerceIndicator,
        Action onEntryMode,
        Action onEntryModeChange,
        Action onGoodsSoldCode,
        Action onMarketSpecificIndicator,
        Action onMerchantVerificationValue,
        Action onMotoIndicator,
        Action onNetworkResultIndicator,
        Action onOperatingEnvironment,
        Action onPartialApprovalIndicator,
        Action onPinCaptureCapability,
        Action onPosAttendanceIndicator,
        Action onPosAuthLifecycle,
        Action onPosData,
        Action onPosEcommerceIndicator,
        Action onPosLocation,
        Action onPosTransactionSecurity,
        Action onPosTransactionStatus,
        Action onProcessingCode,
        Action onStan,
        Action onStatusCode,
        Action onTerminalOutputCapability,
        Action onTrack1Indicator,
        Action onTrack2Indicator,
        Action onTransactionEditErrorCode,
        Action onTransactionIntegrityClass,
        Action onTransactionQualifier,
        Action onValidationCode,
        Action onVisaSpendIndicator,
        Action onReversals,
        Action onFirstTxn,
        Action onPosTerminalId,
        Action onPinlessConversionFlag,
        Action<string> otherwise)
    {
        if (this == Discretionary1) onDiscretionary1();
        else if (this == Discretionary2) onDiscretionary2();
        else if (this == Discretionary3) onDiscretionary3();
        else if (this == Clinical) onClinical();
        else if (this == Copay) onCopay();
        else if (this == Dental) onDental();
        else if (this == HealthCare) onHealthCare();
        else if (this == Rx) onRx();
        else if (this == Vision) onVision();
        else if (this == ApplicationId) onApplicationId();
        else if (this == TerminalTransactionCurrency) onTerminalTransactionCurrency();
        else if (this == CardSequenceNumber) onCardSequenceNumber();
        else if (this == ApplicationPreferredName) onApplicationPreferredName();
        else if (this == ApplicationLabel) onApplicationLabel();
        else if (this == IssuerScript1) onIssuerScript1();
        else if (this == IssuerScript2) onIssuerScript2();
        else if (this == ApplicationInterchangeProfile) onApplicationInterchangeProfile();
        else if (this == DedicatedFileName) onDedicatedFileName();
        else if (this == AuthorizationCode) onAuthorizationCode();
        else if (this == AuthorizationResponseCode) onAuthorizationResponseCode();
        else if (this == CardRiskManagementDataObjectList2) onCardRiskManagementDataObjectList2();
        else if (this == IssuerAuthData) onIssuerAuthData();
        else if (this == TerminalVerificationResults) onTerminalVerificationResults();
        else if (this == TransactionStatusInformation) onTransactionStatusInformation();
        else if (this == TransactionType) onTransactionType();
        else if (this == OtherAmount) onOtherAmount();
        else if (this == ApplicationUsageControl) onApplicationUsageControl();
        else if (this == ApplicationVersionNumber) onApplicationVersionNumber();
        else if (this == IssuerActionCodeDefault) onIssuerActionCodeDefault();
        else if (this == IssuerActionCodeDenial) onIssuerActionCodeDenial();
        else if (this == IssuerActionCodeOnline) onIssuerActionCodeOnline();
        else if (this == IssuerApplicationData) onIssuerApplicationData();
        else if (this == ApplicationIdName) onApplicationIdName();
        else if (this == TerminalTransactionCountryCode) onTerminalTransactionCountryCode();
        else if (this == ApplicationCryptogram) onApplicationCryptogram();
        else if (this == CryptogramInformationData) onCryptogramInformationData();
        else if (this == CapabilityProfile) onCapabilityProfile();
        else if (this == CardHolderVerificationMethod) onCardHolderVerificationMethod();
        else if (this == ApplicationTransactionCounter) onApplicationTransactionCounter();
        else if (this == UnpredictableNumber) onUnpredictableNumber();
        else if (this == IssuerScriptResults) onIssuerScriptResults();
        else if (this == FormFactorIndicator) onFormFactorIndicator();
        else if (this == AuthCharacteristcs) onAuthCharacteristcs();
        else if (this == AuthNetworkId) onAuthNetworkId();
        else if (this == AuthResponseCode) onAuthResponseCode();
        else if (this == AuthSource) onAuthSource();
        else if (this == BanknetDate) onBanknetDate();
        else if (this == CardCaptureCapability) onCardCaptureCapability();
        else if (this == CardDataInputMode) onCardDataInputMode();
        else if (this == CardDataOutputCapability) onCardDataOutputCapability();
        else if (this == CardholderAuthentication) onCardholderAuthentication();
        else if (this == CardholderPresent) onCardholderPresent();
        else if (this == CardInputCapability) onCardInputCapability();
        else if (this == CardLevelResult) onCardLevelResult();
        else if (this == CardmemberAuthentication) onCardmemberAuthentication();
        else if (this == CardmemberEntity) onCardmemberEntity();
        else if (this == CardPresent) onCardPresent();
        else if (this == CvvErrorCode) onCvvErrorCode();
        else if (this == DiscoverResponseCode) onDiscoverResponseCode();
        else if (this == EcommerceIndicator) onEcommerceIndicator();
        else if (this == EntryMode) onEntryMode();
        else if (this == EntryModeChange) onEntryModeChange();
        else if (this == GoodsSoldCode) onGoodsSoldCode();
        else if (this == MarketSpecificIndicator) onMarketSpecificIndicator();
        else if (this == MerchantVerificationValue) onMerchantVerificationValue();
        else if (this == MotoIndicator) onMotoIndicator();
        else if (this == NetworkResultIndicator) onNetworkResultIndicator();
        else if (this == OperatingEnvironment) onOperatingEnvironment();
        else if (this == PartialApprovalIndicator) onPartialApprovalIndicator();
        else if (this == PinCaptureCapability) onPinCaptureCapability();
        else if (this == PosAttendanceIndicator) onPosAttendanceIndicator();
        else if (this == PosAuthLifecycle) onPosAuthLifecycle();
        else if (this == PosData) onPosData();
        else if (this == PosEcommerceIndicator) onPosEcommerceIndicator();
        else if (this == PosLocation) onPosLocation();
        else if (this == PosTransactionSecurity) onPosTransactionSecurity();
        else if (this == PosTransactionStatus) onPosTransactionStatus();
        else if (this == ProcessingCode) onProcessingCode();
        else if (this == Stan) onStan();
        else if (this == StatusCode) onStatusCode();
        else if (this == TerminalOutputCapability) onTerminalOutputCapability();
        else if (this == Track1Indicator) onTrack1Indicator();
        else if (this == Track2Indicator) onTrack2Indicator();
        else if (this == TransactionEditErrorCode) onTransactionEditErrorCode();
        else if (this == TransactionIntegrityClass) onTransactionIntegrityClass();
        else if (this == TransactionQualifier) onTransactionQualifier();
        else if (this == ValidationCode) onValidationCode();
        else if (this == VisaSpendIndicator) onVisaSpendIndicator();
        else if (this == Reversals) onReversals();
        else if (this == FirstTxn) onFirstTxn();
        else if (this == PosTerminalId) onPosTerminalId();
        else if (this == PinlessConversionFlag) onPinlessConversionFlag();
        else otherwise(Value);
    }
}
