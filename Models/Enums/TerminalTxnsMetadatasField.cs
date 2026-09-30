using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalTxnsMetadatasField>))]
public sealed record TerminalTxnsMetadatasField : OpenStringEnum<TerminalTxnsMetadatasField>
{
    private TerminalTxnsMetadatasField(string value) : base(value)
    {
    }

    public static readonly TerminalTxnsMetadatasField Discretionary1 = new("discretionary1");

    public static readonly TerminalTxnsMetadatasField Discretionary2 = new("discretionary2");

    public static readonly TerminalTxnsMetadatasField Discretionary3 = new("discretionary3");

    public static readonly TerminalTxnsMetadatasField Clinical = new("clinical");

    public static readonly TerminalTxnsMetadatasField Copay = new("copay");

    public static readonly TerminalTxnsMetadatasField Dental = new("dental");

    public static readonly TerminalTxnsMetadatasField HealthCare = new("healthCare");

    public static readonly TerminalTxnsMetadatasField Rx = new("rx");

    public static readonly TerminalTxnsMetadatasField Vision = new("vision");

    public static readonly TerminalTxnsMetadatasField ApplicationId = new("applicationId");

    public static readonly TerminalTxnsMetadatasField TerminalTransactionCurrency = new("terminalTransactionCurrency");

    public static readonly TerminalTxnsMetadatasField CardSequenceNumber = new("cardSequenceNumber");

    public static readonly TerminalTxnsMetadatasField ApplicationPreferredName = new("applicationPreferredName");

    public static readonly TerminalTxnsMetadatasField ApplicationLabel = new("applicationLabel");

    public static readonly TerminalTxnsMetadatasField IssuerScript1 = new("issuerScript1");

    public static readonly TerminalTxnsMetadatasField IssuerScript2 = new("issuerScript2");

    public static readonly TerminalTxnsMetadatasField ApplicationInterchangeProfile = new(
        "applicationInterchangeProfile");

    public static readonly TerminalTxnsMetadatasField DedicatedFileName = new("dedicatedFileName");

    public static readonly TerminalTxnsMetadatasField AuthorizationCode = new("authorizationCode");

    public static readonly TerminalTxnsMetadatasField AuthorizationResponseCode = new("authorizationResponseCode");

    public static readonly TerminalTxnsMetadatasField CardRiskManagementDataObjectList2 = new(
        "cardRiskManagementDataObjectList2");

    public static readonly TerminalTxnsMetadatasField IssuerAuthData = new("issuerAuthData");

    public static readonly TerminalTxnsMetadatasField TerminalVerificationResults = new("terminalVerificationResults");

    public static readonly TerminalTxnsMetadatasField TransactionStatusInformation = new(
        "transactionStatusInformation");

    public static readonly TerminalTxnsMetadatasField TransactionType = new("transactionType");

    public static readonly TerminalTxnsMetadatasField OtherAmount = new("otherAmount");

    public static readonly TerminalTxnsMetadatasField ApplicationUsageControl = new("applicationUsageControl");

    public static readonly TerminalTxnsMetadatasField ApplicationVersionNumber = new("applicationVersionNumber");

    public static readonly TerminalTxnsMetadatasField IssuerActionCodeDefault = new("issuerActionCodeDefault");

    public static readonly TerminalTxnsMetadatasField IssuerActionCodeDenial = new("issuerActionCodeDenial");

    public static readonly TerminalTxnsMetadatasField IssuerActionCodeOnline = new("issuerActionCodeOnline");

    public static readonly TerminalTxnsMetadatasField IssuerApplicationData = new("issuerApplicationData");

    public static readonly TerminalTxnsMetadatasField ApplicationIdName = new("applicationIdName");

    public static readonly TerminalTxnsMetadatasField TerminalTransactionCountryCode = new(
        "terminalTransactionCountryCode");

    public static readonly TerminalTxnsMetadatasField ApplicationCryptogram = new("applicationCryptogram");

    public static readonly TerminalTxnsMetadatasField CryptogramInformationData = new("cryptogramInformationData");

    public static readonly TerminalTxnsMetadatasField CapabilityProfile = new("capabilityProfile");

    public static readonly TerminalTxnsMetadatasField CardHolderVerificationMethod = new(
        "cardHolderVerificationMethod");

    public static readonly TerminalTxnsMetadatasField ApplicationTransactionCounter = new(
        "applicationTransactionCounter");

    public static readonly TerminalTxnsMetadatasField UnpredictableNumber = new("unpredictableNumber");

    public static readonly TerminalTxnsMetadatasField IssuerScriptResults = new("issuerScriptResults");

    public static readonly TerminalTxnsMetadatasField FormFactorIndicator = new("formFactorIndicator");

    public static readonly TerminalTxnsMetadatasField AuthCharacteristcs = new("authCharacteristcs");

    public static readonly TerminalTxnsMetadatasField AuthNetworkId = new("authNetworkId");

    public static readonly TerminalTxnsMetadatasField AuthResponseCode = new("authResponseCode");

    public static readonly TerminalTxnsMetadatasField AuthSource = new("authSource");

    public static readonly TerminalTxnsMetadatasField BanknetDate = new("banknetDate");

    public static readonly TerminalTxnsMetadatasField CardCaptureCapability = new("cardCaptureCapability");

    public static readonly TerminalTxnsMetadatasField CardDataInputMode = new("cardDataInputMode");

    public static readonly TerminalTxnsMetadatasField CardDataOutputCapability = new("cardDataOutputCapability");

    public static readonly TerminalTxnsMetadatasField CardholderAuthentication = new("cardholderAuthentication");

    public static readonly TerminalTxnsMetadatasField CardholderPresent = new("cardholderPresent");

    public static readonly TerminalTxnsMetadatasField CardInputCapability = new("cardInputCapability");

    public static readonly TerminalTxnsMetadatasField CardLevelResult = new("cardLevelResult");

    public static readonly TerminalTxnsMetadatasField CardmemberAuthentication = new("cardmemberAuthentication");

    public static readonly TerminalTxnsMetadatasField CardmemberEntity = new("cardmemberEntity");

    public static readonly TerminalTxnsMetadatasField CardPresent = new("cardPresent");

    public static readonly TerminalTxnsMetadatasField CvvErrorCode = new("cvvErrorCode");

    public static readonly TerminalTxnsMetadatasField DiscoverResponseCode = new("discoverResponseCode");

    public static readonly TerminalTxnsMetadatasField EcommerceIndicator = new("ecommerceIndicator");

    public static readonly TerminalTxnsMetadatasField EntryMode = new("entryMode");

    public static readonly TerminalTxnsMetadatasField EntryModeChange = new("entryModeChange");

    public static readonly TerminalTxnsMetadatasField GoodsSoldCode = new("goodsSoldCode");

    public static readonly TerminalTxnsMetadatasField MarketSpecificIndicator = new("marketSpecificIndicator");

    public static readonly TerminalTxnsMetadatasField MerchantVerificationValue = new("merchantVerificationValue");

    public static readonly TerminalTxnsMetadatasField MotoIndicator = new("motoIndicator");

    public static readonly TerminalTxnsMetadatasField NetworkResultIndicator = new("networkResultIndicator");

    public static readonly TerminalTxnsMetadatasField OperatingEnvironment = new("operatingEnvironment");

    public static readonly TerminalTxnsMetadatasField PartialApprovalIndicator = new("partialApprovalIndicator");

    public static readonly TerminalTxnsMetadatasField PinCaptureCapability = new("pinCaptureCapability");

    public static readonly TerminalTxnsMetadatasField PosAttendanceIndicator = new("posAttendanceIndicator");

    public static readonly TerminalTxnsMetadatasField PosAuthLifecycle = new("posAuthLifecycle");

    public static readonly TerminalTxnsMetadatasField PosData = new("posData");

    public static readonly TerminalTxnsMetadatasField PosEcommerceIndicator = new("posEcommerceIndicator");

    public static readonly TerminalTxnsMetadatasField PosLocation = new("posLocation");

    public static readonly TerminalTxnsMetadatasField PosTransactionSecurity = new("posTransactionSecurity");

    public static readonly TerminalTxnsMetadatasField PosTransactionStatus = new("posTransactionStatus");

    public static readonly TerminalTxnsMetadatasField ProcessingCode = new("processingCode");

    public static readonly TerminalTxnsMetadatasField Stan = new("stan");

    public static readonly TerminalTxnsMetadatasField StatusCode = new("statusCode");

    public static readonly TerminalTxnsMetadatasField TerminalOutputCapability = new("terminalOutputCapability");

    public static readonly TerminalTxnsMetadatasField Track1Indicator = new("track1Indicator");

    public static readonly TerminalTxnsMetadatasField Track2Indicator = new("track2Indicator");

    public static readonly TerminalTxnsMetadatasField TransactionEditErrorCode = new("transactionEditErrorCode");

    public static readonly TerminalTxnsMetadatasField TransactionIntegrityClass = new("transactionIntegrityClass");

    public static readonly TerminalTxnsMetadatasField TransactionQualifier = new("transactionQualifier");

    public static readonly TerminalTxnsMetadatasField ValidationCode = new("validationCode");

    public static readonly TerminalTxnsMetadatasField VisaSpendIndicator = new("visaSpendIndicator");

    public static readonly TerminalTxnsMetadatasField Reversals = new("reversals");

    public static readonly TerminalTxnsMetadatasField FirstTxn = new("firstTxn");

    public static readonly TerminalTxnsMetadatasField PosTerminalId = new("posTerminalID");

    public static readonly TerminalTxnsMetadatasField PinlessConversionFlag = new("pinlessConversionFlag");

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
