using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConfigurationStageInput>))]
public sealed record ConfigurationStageInput : OpenStringEnum<ConfigurationStageInput>
{
    private ConfigurationStageInput(string value) : base(value)
    {
    }

    public static readonly ConfigurationStageInput ApplePaymentsessionRequestJson = new(
        "APPLE_PAYMENTSESSION_REQUEST_JSON");

    public static readonly ConfigurationStageInput AppleRegisterMerchantRequestJson = new(
        "APPLE_REGISTER_MERCHANT_REQUEST_JSON");

    public static readonly ConfigurationStageInput AppleUnregisterMerchantRequestJson = new(
        "APPLE_UNREGISTER_MERCHANT_REQUEST_JSON");

    public static readonly ConfigurationStageInput Eft = new("EFT");

    public static readonly ConfigurationStageInput ElavonBatchFlat = new("ELAVON_BATCH_FLAT");

    public static readonly ConfigurationStageInput ElavonBatchReadFlat = new("ELAVON_BATCH_READ_FLAT");

    public static readonly ConfigurationStageInput ElavonBoardJson = new("ELAVON_BOARD_JSON");

    public static readonly ConfigurationStageInput ElavonReportsCsv = new("ELAVON_REPORTS_CSV");

    public static readonly ConfigurationStageInput ElavonTxnXml = new("ELAVON_TXN_XML");

    public static readonly ConfigurationStageInput FedachReportFlat = new("FEDACH_REPORT_FLAT");

    public static readonly ConfigurationStageInput FirstdataBatchFlat = new("FIRSTDATA_BATCH_FLAT");

    public static readonly ConfigurationStageInput FirstdataBatchReadFlat = new("FIRSTDATA_BATCH_READ_FLAT");

    public static readonly ConfigurationStageInput FirstdataBoardJson = new("FIRSTDATA_BOARD_JSON");

    public static readonly ConfigurationStageInput FirstdataReportsFlat = new("FIRSTDATA_REPORTS_FLAT");

    public static readonly ConfigurationStageInput FirstdataSrsXml = new("FIRSTDATA_SRS_XML");

    public static readonly ConfigurationStageInput FirstdataTxnXml = new("FIRSTDATA_TXN_XML");

    public static readonly ConfigurationStageInput FirstdataSingleBatchFlat = new("FIRSTDATA_SINGLE_BATCH_FLAT");

    public static readonly ConfigurationStageInput FirstdataSingleTxnXml = new("FIRSTDATA_SINGLE_TXN_XML");

    public static readonly ConfigurationStageInput Nacha = new("NACHA");

    public static readonly ConfigurationStageInput NeutrinoCsv = new("NEUTRINO_CSV");

    public static readonly ConfigurationStageInput NeutrinoForm = new("NEUTRINO_FORM");

    public static readonly ConfigurationStageInput NeutrinoJson = new("NEUTRINO_JSON");

    public static readonly ConfigurationStageInput OfacXml = new("OFAC_XML");

    public static readonly ConfigurationStageInput PayrixChargebackJson = new("PAYRIX_CHARGEBACK_JSON");

    public static readonly ConfigurationStageInput PayrixDecisionJson = new("PAYRIX_DECISION_JSON");

    public static readonly ConfigurationStageInput PayrixEncryptionJson = new("PAYRIX_ENCRYPTION_JSON");

    public static readonly ConfigurationStageInput PayrixGooglepayDecryptionJson = new(
        "PAYRIX_GOOGLEPAY_DECRYPTION_JSON");

    public static readonly ConfigurationStageInput PayrixTxnJson = new("PAYRIX_TXN_JSON");

    public static readonly ConfigurationStageInput PushyTxnJson = new("PUSHY_TXN_JSON");

    public static readonly ConfigurationStageInput SiftJson = new("SIFT_JSON");

    public static readonly ConfigurationStageInput SocureAlloyJson = new("SOCURE_ALLOY_JSON");

    public static readonly ConfigurationStageInput SocureForm = new("SOCURE_FORM");

    public static readonly ConfigurationStageInput SocureJson = new("SOCURE_JSON");

    public static readonly ConfigurationStageInput SoundpaymentsTxnForm = new("SOUNDPAYMENTS_TXN_FORM");

    public static readonly ConfigurationStageInput SoundpaymentsTxnXml = new("SOUNDPAYMENTS_TXN_XML");

    public static readonly ConfigurationStageInput VantivBatchXml = new("VANTIV_BATCH_XML");

    public static readonly ConfigurationStageInput VantivBoardXml = new("VANTIV_BOARD_XML");

    public static readonly ConfigurationStageInput VantivChargebackXml = new("VANTIV_CHARGEBACK_XML");

    public static readonly ConfigurationStageInput VantivPaymentUpdatesXml = new("VANTIV_PAYMENT_UPDATES_XML");

    public static readonly ConfigurationStageInput VantivPayoutCsv = new("VANTIV_PAYOUT_CSV");

    public static readonly ConfigurationStageInput VantivPayoutXml = new("VANTIV_PAYOUT_XML");

    public static readonly ConfigurationStageInput VantivPayoutXmlV9 = new("VANTIV_PAYOUT_XML_V9");

    public static readonly ConfigurationStageInput VantivReportsCsv = new("VANTIV_REPORTS_CSV");

    public static readonly ConfigurationStageInput VantivTxnCsv = new("VANTIV_TXN_CSV");

    public static readonly ConfigurationStageInput VantivTxnXml = new("VANTIV_TXN_XML");

    public static readonly ConfigurationStageInput VcoreBatchFlat = new("VCORE_BATCH_FLAT");

    public static readonly ConfigurationStageInput VcoreBatchReadFlat = new("VCORE_BATCH_READ_FLAT");

    public static readonly ConfigurationStageInput VcoreBinreportFlat = new("VCORE_BINREPORT_FLAT");

    public static readonly ConfigurationStageInput VcoreBoardApi = new("VCORE_BOARD_API");

    public static readonly ConfigurationStageInput VcoreBoardFlat = new("VCORE_BOARD_FLAT");

    public static readonly ConfigurationStageInput VcoreChargebackFlat = new("VCORE_CHARGEBACK_FLAT");

    public static readonly ConfigurationStageInput VcoreOmnitokenJson = new("VCORE_OMNITOKEN_JSON");

    public static readonly ConfigurationStageInput VcoreReportsFlat = new("VCORE_REPORTS_FLAT");

    public static readonly ConfigurationStageInput VcoreSaferpaymentJson = new("VCORE_SAFERPAYMENT_JSON");

    public static readonly ConfigurationStageInput VcoreTxnIso8583 = new("VCORE_TXN_ISO8583");

    public static readonly ConfigurationStageInput VcoreUpdateFlat = new("VCORE_UPDATE_FLAT");

    public static readonly ConfigurationStageInput VcoreVarsheetJson = new("VCORE_VARSHEET_JSON");

    public static readonly ConfigurationStageInput WebshieldForm = new("WEBSHIELD_FORM");

    public static readonly ConfigurationStageInput WebshieldJson = new("WEBSHIELD_JSON");

    public static readonly ConfigurationStageInput WellsachBatchFlat = new("WELLSACH_BATCH_FLAT");

    public static readonly ConfigurationStageInput WellsachPayoutFlat = new("WELLSACH_PAYOUT_FLAT");

    public static readonly ConfigurationStageInput WellsachTxnFlat = new("WELLSACH_TXN_FLAT");

    public static readonly ConfigurationStageInput WellsfargoBoardXml = new("WELLSFARGO_BOARD_XML");

    public static readonly ConfigurationStageInput WellsfargoReportCsv = new("WELLSFARGO_REPORT_CSV");

    public static readonly ConfigurationStageInput WellsfargoReportFlat = new("WELLSFARGO_REPORT_FLAT");

    public static readonly ConfigurationStageInput WfsingleReportFlat = new("WFSINGLE_REPORT_FLAT");

    public static readonly ConfigurationStageInput WfsingleBoardXml = new("WFSINGLE_BOARD_XML");

    public TResult Match<TResult>(Func<TResult> onApplePaymentsessionRequestJson,
        Func<TResult> onAppleRegisterMerchantRequestJson,
        Func<TResult> onAppleUnregisterMerchantRequestJson,
        Func<TResult> onEft,
        Func<TResult> onElavonBatchFlat,
        Func<TResult> onElavonBatchReadFlat,
        Func<TResult> onElavonBoardJson,
        Func<TResult> onElavonReportsCsv,
        Func<TResult> onElavonTxnXml,
        Func<TResult> onFedachReportFlat,
        Func<TResult> onFirstdataBatchFlat,
        Func<TResult> onFirstdataBatchReadFlat,
        Func<TResult> onFirstdataBoardJson,
        Func<TResult> onFirstdataReportsFlat,
        Func<TResult> onFirstdataSrsXml,
        Func<TResult> onFirstdataTxnXml,
        Func<TResult> onFirstdataSingleBatchFlat,
        Func<TResult> onFirstdataSingleTxnXml,
        Func<TResult> onNacha,
        Func<TResult> onNeutrinoCsv,
        Func<TResult> onNeutrinoForm,
        Func<TResult> onNeutrinoJson,
        Func<TResult> onOfacXml,
        Func<TResult> onPayrixChargebackJson,
        Func<TResult> onPayrixDecisionJson,
        Func<TResult> onPayrixEncryptionJson,
        Func<TResult> onPayrixGooglepayDecryptionJson,
        Func<TResult> onPayrixTxnJson,
        Func<TResult> onPushyTxnJson,
        Func<TResult> onSiftJson,
        Func<TResult> onSocureAlloyJson,
        Func<TResult> onSocureForm,
        Func<TResult> onSocureJson,
        Func<TResult> onSoundpaymentsTxnForm,
        Func<TResult> onSoundpaymentsTxnXml,
        Func<TResult> onVantivBatchXml,
        Func<TResult> onVantivBoardXml,
        Func<TResult> onVantivChargebackXml,
        Func<TResult> onVantivPaymentUpdatesXml,
        Func<TResult> onVantivPayoutCsv,
        Func<TResult> onVantivPayoutXml,
        Func<TResult> onVantivPayoutXmlV9,
        Func<TResult> onVantivReportsCsv,
        Func<TResult> onVantivTxnCsv,
        Func<TResult> onVantivTxnXml,
        Func<TResult> onVcoreBatchFlat,
        Func<TResult> onVcoreBatchReadFlat,
        Func<TResult> onVcoreBinreportFlat,
        Func<TResult> onVcoreBoardApi,
        Func<TResult> onVcoreBoardFlat,
        Func<TResult> onVcoreChargebackFlat,
        Func<TResult> onVcoreOmnitokenJson,
        Func<TResult> onVcoreReportsFlat,
        Func<TResult> onVcoreSaferpaymentJson,
        Func<TResult> onVcoreTxnIso8583,
        Func<TResult> onVcoreUpdateFlat,
        Func<TResult> onVcoreVarsheetJson,
        Func<TResult> onWebshieldForm,
        Func<TResult> onWebshieldJson,
        Func<TResult> onWellsachBatchFlat,
        Func<TResult> onWellsachPayoutFlat,
        Func<TResult> onWellsachTxnFlat,
        Func<TResult> onWellsfargoBoardXml,
        Func<TResult> onWellsfargoReportCsv,
        Func<TResult> onWellsfargoReportFlat,
        Func<TResult> onWfsingleReportFlat,
        Func<TResult> onWfsingleBoardXml,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ApplePaymentsessionRequestJson => onApplePaymentsessionRequestJson(),
            _ when this == AppleRegisterMerchantRequestJson => onAppleRegisterMerchantRequestJson(),
            _ when this == AppleUnregisterMerchantRequestJson => onAppleUnregisterMerchantRequestJson(),
            _ when this == Eft => onEft(),
            _ when this == ElavonBatchFlat => onElavonBatchFlat(),
            _ when this == ElavonBatchReadFlat => onElavonBatchReadFlat(),
            _ when this == ElavonBoardJson => onElavonBoardJson(),
            _ when this == ElavonReportsCsv => onElavonReportsCsv(),
            _ when this == ElavonTxnXml => onElavonTxnXml(),
            _ when this == FedachReportFlat => onFedachReportFlat(),
            _ when this == FirstdataBatchFlat => onFirstdataBatchFlat(),
            _ when this == FirstdataBatchReadFlat => onFirstdataBatchReadFlat(),
            _ when this == FirstdataBoardJson => onFirstdataBoardJson(),
            _ when this == FirstdataReportsFlat => onFirstdataReportsFlat(),
            _ when this == FirstdataSrsXml => onFirstdataSrsXml(),
            _ when this == FirstdataTxnXml => onFirstdataTxnXml(),
            _ when this == FirstdataSingleBatchFlat => onFirstdataSingleBatchFlat(),
            _ when this == FirstdataSingleTxnXml => onFirstdataSingleTxnXml(),
            _ when this == Nacha => onNacha(),
            _ when this == NeutrinoCsv => onNeutrinoCsv(),
            _ when this == NeutrinoForm => onNeutrinoForm(),
            _ when this == NeutrinoJson => onNeutrinoJson(),
            _ when this == OfacXml => onOfacXml(),
            _ when this == PayrixChargebackJson => onPayrixChargebackJson(),
            _ when this == PayrixDecisionJson => onPayrixDecisionJson(),
            _ when this == PayrixEncryptionJson => onPayrixEncryptionJson(),
            _ when this == PayrixGooglepayDecryptionJson => onPayrixGooglepayDecryptionJson(),
            _ when this == PayrixTxnJson => onPayrixTxnJson(),
            _ when this == PushyTxnJson => onPushyTxnJson(),
            _ when this == SiftJson => onSiftJson(),
            _ when this == SocureAlloyJson => onSocureAlloyJson(),
            _ when this == SocureForm => onSocureForm(),
            _ when this == SocureJson => onSocureJson(),
            _ when this == SoundpaymentsTxnForm => onSoundpaymentsTxnForm(),
            _ when this == SoundpaymentsTxnXml => onSoundpaymentsTxnXml(),
            _ when this == VantivBatchXml => onVantivBatchXml(),
            _ when this == VantivBoardXml => onVantivBoardXml(),
            _ when this == VantivChargebackXml => onVantivChargebackXml(),
            _ when this == VantivPaymentUpdatesXml => onVantivPaymentUpdatesXml(),
            _ when this == VantivPayoutCsv => onVantivPayoutCsv(),
            _ when this == VantivPayoutXml => onVantivPayoutXml(),
            _ when this == VantivPayoutXmlV9 => onVantivPayoutXmlV9(),
            _ when this == VantivReportsCsv => onVantivReportsCsv(),
            _ when this == VantivTxnCsv => onVantivTxnCsv(),
            _ when this == VantivTxnXml => onVantivTxnXml(),
            _ when this == VcoreBatchFlat => onVcoreBatchFlat(),
            _ when this == VcoreBatchReadFlat => onVcoreBatchReadFlat(),
            _ when this == VcoreBinreportFlat => onVcoreBinreportFlat(),
            _ when this == VcoreBoardApi => onVcoreBoardApi(),
            _ when this == VcoreBoardFlat => onVcoreBoardFlat(),
            _ when this == VcoreChargebackFlat => onVcoreChargebackFlat(),
            _ when this == VcoreOmnitokenJson => onVcoreOmnitokenJson(),
            _ when this == VcoreReportsFlat => onVcoreReportsFlat(),
            _ when this == VcoreSaferpaymentJson => onVcoreSaferpaymentJson(),
            _ when this == VcoreTxnIso8583 => onVcoreTxnIso8583(),
            _ when this == VcoreUpdateFlat => onVcoreUpdateFlat(),
            _ when this == VcoreVarsheetJson => onVcoreVarsheetJson(),
            _ when this == WebshieldForm => onWebshieldForm(),
            _ when this == WebshieldJson => onWebshieldJson(),
            _ when this == WellsachBatchFlat => onWellsachBatchFlat(),
            _ when this == WellsachPayoutFlat => onWellsachPayoutFlat(),
            _ when this == WellsachTxnFlat => onWellsachTxnFlat(),
            _ when this == WellsfargoBoardXml => onWellsfargoBoardXml(),
            _ when this == WellsfargoReportCsv => onWellsfargoReportCsv(),
            _ when this == WellsfargoReportFlat => onWellsfargoReportFlat(),
            _ when this == WfsingleReportFlat => onWfsingleReportFlat(),
            _ when this == WfsingleBoardXml => onWfsingleBoardXml(),
            _ => otherwise(Value)
        };

    public void Match(Action onApplePaymentsessionRequestJson,
        Action onAppleRegisterMerchantRequestJson,
        Action onAppleUnregisterMerchantRequestJson,
        Action onEft,
        Action onElavonBatchFlat,
        Action onElavonBatchReadFlat,
        Action onElavonBoardJson,
        Action onElavonReportsCsv,
        Action onElavonTxnXml,
        Action onFedachReportFlat,
        Action onFirstdataBatchFlat,
        Action onFirstdataBatchReadFlat,
        Action onFirstdataBoardJson,
        Action onFirstdataReportsFlat,
        Action onFirstdataSrsXml,
        Action onFirstdataTxnXml,
        Action onFirstdataSingleBatchFlat,
        Action onFirstdataSingleTxnXml,
        Action onNacha,
        Action onNeutrinoCsv,
        Action onNeutrinoForm,
        Action onNeutrinoJson,
        Action onOfacXml,
        Action onPayrixChargebackJson,
        Action onPayrixDecisionJson,
        Action onPayrixEncryptionJson,
        Action onPayrixGooglepayDecryptionJson,
        Action onPayrixTxnJson,
        Action onPushyTxnJson,
        Action onSiftJson,
        Action onSocureAlloyJson,
        Action onSocureForm,
        Action onSocureJson,
        Action onSoundpaymentsTxnForm,
        Action onSoundpaymentsTxnXml,
        Action onVantivBatchXml,
        Action onVantivBoardXml,
        Action onVantivChargebackXml,
        Action onVantivPaymentUpdatesXml,
        Action onVantivPayoutCsv,
        Action onVantivPayoutXml,
        Action onVantivPayoutXmlV9,
        Action onVantivReportsCsv,
        Action onVantivTxnCsv,
        Action onVantivTxnXml,
        Action onVcoreBatchFlat,
        Action onVcoreBatchReadFlat,
        Action onVcoreBinreportFlat,
        Action onVcoreBoardApi,
        Action onVcoreBoardFlat,
        Action onVcoreChargebackFlat,
        Action onVcoreOmnitokenJson,
        Action onVcoreReportsFlat,
        Action onVcoreSaferpaymentJson,
        Action onVcoreTxnIso8583,
        Action onVcoreUpdateFlat,
        Action onVcoreVarsheetJson,
        Action onWebshieldForm,
        Action onWebshieldJson,
        Action onWellsachBatchFlat,
        Action onWellsachPayoutFlat,
        Action onWellsachTxnFlat,
        Action onWellsfargoBoardXml,
        Action onWellsfargoReportCsv,
        Action onWellsfargoReportFlat,
        Action onWfsingleReportFlat,
        Action onWfsingleBoardXml,
        Action<string> otherwise)
    {
        if (this == ApplePaymentsessionRequestJson) onApplePaymentsessionRequestJson();
        else if (this == AppleRegisterMerchantRequestJson) onAppleRegisterMerchantRequestJson();
        else if (this == AppleUnregisterMerchantRequestJson) onAppleUnregisterMerchantRequestJson();
        else if (this == Eft) onEft();
        else if (this == ElavonBatchFlat) onElavonBatchFlat();
        else if (this == ElavonBatchReadFlat) onElavonBatchReadFlat();
        else if (this == ElavonBoardJson) onElavonBoardJson();
        else if (this == ElavonReportsCsv) onElavonReportsCsv();
        else if (this == ElavonTxnXml) onElavonTxnXml();
        else if (this == FedachReportFlat) onFedachReportFlat();
        else if (this == FirstdataBatchFlat) onFirstdataBatchFlat();
        else if (this == FirstdataBatchReadFlat) onFirstdataBatchReadFlat();
        else if (this == FirstdataBoardJson) onFirstdataBoardJson();
        else if (this == FirstdataReportsFlat) onFirstdataReportsFlat();
        else if (this == FirstdataSrsXml) onFirstdataSrsXml();
        else if (this == FirstdataTxnXml) onFirstdataTxnXml();
        else if (this == FirstdataSingleBatchFlat) onFirstdataSingleBatchFlat();
        else if (this == FirstdataSingleTxnXml) onFirstdataSingleTxnXml();
        else if (this == Nacha) onNacha();
        else if (this == NeutrinoCsv) onNeutrinoCsv();
        else if (this == NeutrinoForm) onNeutrinoForm();
        else if (this == NeutrinoJson) onNeutrinoJson();
        else if (this == OfacXml) onOfacXml();
        else if (this == PayrixChargebackJson) onPayrixChargebackJson();
        else if (this == PayrixDecisionJson) onPayrixDecisionJson();
        else if (this == PayrixEncryptionJson) onPayrixEncryptionJson();
        else if (this == PayrixGooglepayDecryptionJson) onPayrixGooglepayDecryptionJson();
        else if (this == PayrixTxnJson) onPayrixTxnJson();
        else if (this == PushyTxnJson) onPushyTxnJson();
        else if (this == SiftJson) onSiftJson();
        else if (this == SocureAlloyJson) onSocureAlloyJson();
        else if (this == SocureForm) onSocureForm();
        else if (this == SocureJson) onSocureJson();
        else if (this == SoundpaymentsTxnForm) onSoundpaymentsTxnForm();
        else if (this == SoundpaymentsTxnXml) onSoundpaymentsTxnXml();
        else if (this == VantivBatchXml) onVantivBatchXml();
        else if (this == VantivBoardXml) onVantivBoardXml();
        else if (this == VantivChargebackXml) onVantivChargebackXml();
        else if (this == VantivPaymentUpdatesXml) onVantivPaymentUpdatesXml();
        else if (this == VantivPayoutCsv) onVantivPayoutCsv();
        else if (this == VantivPayoutXml) onVantivPayoutXml();
        else if (this == VantivPayoutXmlV9) onVantivPayoutXmlV9();
        else if (this == VantivReportsCsv) onVantivReportsCsv();
        else if (this == VantivTxnCsv) onVantivTxnCsv();
        else if (this == VantivTxnXml) onVantivTxnXml();
        else if (this == VcoreBatchFlat) onVcoreBatchFlat();
        else if (this == VcoreBatchReadFlat) onVcoreBatchReadFlat();
        else if (this == VcoreBinreportFlat) onVcoreBinreportFlat();
        else if (this == VcoreBoardApi) onVcoreBoardApi();
        else if (this == VcoreBoardFlat) onVcoreBoardFlat();
        else if (this == VcoreChargebackFlat) onVcoreChargebackFlat();
        else if (this == VcoreOmnitokenJson) onVcoreOmnitokenJson();
        else if (this == VcoreReportsFlat) onVcoreReportsFlat();
        else if (this == VcoreSaferpaymentJson) onVcoreSaferpaymentJson();
        else if (this == VcoreTxnIso8583) onVcoreTxnIso8583();
        else if (this == VcoreUpdateFlat) onVcoreUpdateFlat();
        else if (this == VcoreVarsheetJson) onVcoreVarsheetJson();
        else if (this == WebshieldForm) onWebshieldForm();
        else if (this == WebshieldJson) onWebshieldJson();
        else if (this == WellsachBatchFlat) onWellsachBatchFlat();
        else if (this == WellsachPayoutFlat) onWellsachPayoutFlat();
        else if (this == WellsachTxnFlat) onWellsachTxnFlat();
        else if (this == WellsfargoBoardXml) onWellsfargoBoardXml();
        else if (this == WellsfargoReportCsv) onWellsfargoReportCsv();
        else if (this == WellsfargoReportFlat) onWellsfargoReportFlat();
        else if (this == WfsingleReportFlat) onWfsingleReportFlat();
        else if (this == WfsingleBoardXml) onWfsingleBoardXml();
        else otherwise(Value);
    }
}
