using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The input used for configurationStage resource. &lt;details&gt;&lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>APPLE_PAYMENTSESSION_REQUEST_JSON</c> - <b>APPLE_PAYMENTSESSION_REQUEST_JSON input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>APPLE_REGISTER_MERCHANT_REQUEST_JSON</c> - <b>APPLE_REGISTER_MERCHANT_REQUEST_JSON input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>APPLE_UNREGISTER_MERCHANT_REQUEST_JSON</c> - <b>APPLE_UNREGISTER_MERCHANT_REQUEST_JSON input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>EFT</c> - <b>EFT input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ELAVON_BATCH_FLAT</c> - <b>ELAVON_BATCH_FLAT input file. Batch file upload format and structure for the Elavon processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ELAVON_BATCH_READ_FLAT</c> - <b>ELAVON_BATCH_READ_FLAT input file. Batch file download format and structure for the Elavon processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ELAVON_BOARD_JSON</c> - <b>ELAVON_BOARD_JSON input file. Merchant boarding format and structure for the Elavon processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ELAVON_REPORTS_CSV</c> - <b>ELAVON_REPORTS_CSV input file. Settlement report format and structure for the Elavon processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ELAVON_TXN_XML</c> - <b>ELAVON_TXN_XML input file. Transaction authorization processing format and structure for the Elavon processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FEDACH_REPORT_FLAT</c> - <b>FEDACH_REPORT_FLAT input file. Fed ACH routing number file format and structure.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FIRSTDATA_BATCH_FLAT</c> - <b>FIRSTDATA_BATCH_FLAT input file. Batch file format and structure for the First Data processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FIRSTDATA_BATCH_READ_FLAT</c> - <b>FIRSTDATA_BATCH_READ_FLAT input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FIRSTDATA_BOARD_JSON</c> - <b>FIRSTDATA_BOARD_JSON input file. Merchant boarding format and structure for the First Data processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FIRSTDATA_REPORTS_FLAT</c> - <b>FIRSTDATA_REPORTS_FLAT input file. Settlement report format and structure for the First Data processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FIRSTDATA_SRS_XML</c> - <b>FIRSTDATA_SRS_XML input file. SRS registration and activation format and structure for the First Data Processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FIRSTDATA_TXN_XML</c> - <b>FIRSTDATA_TXN_XML input file. Transaction authorization processing format and structure for the First Data processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FIRSTDATA_SINGLE_BATCH_FLAT</c> - <b>FIRSTDATA_SINGLE_BATCH_FLAT input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FIRSTDATA_SINGLE_TXN_XML</c> - <b>FIRSTDATA_SINGLE_TXN_XML input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>NACHA</c> - <b>NACHA input file. Disbursement file format and structure for the NACHA funding platform.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>NEUTRINO_CSV</c> - <b>NEUTRINO_CSV input file. BIN (Bank Issuer Number) file download format and structure for the Neutrino API service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>NEUTRINO_FORM</c> - <b>NEUTRINO_FORM input file. BIN (Bank Issuer Number) file request format and structure for the Neutrino API service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>NEUTRINO_JSON</c> - <b>NEUTRINO_JSON input file. BIN (Bank Issuer Number) file format and structure for the Neutrino API service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>OFAC_XML</c> - <b>OFAC_XML input file. Entity and member watchlist file download for the OFAC SDN list.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>PAYRIX_CHARGEBACK_JSON</c> - <b>PAYRIX_CHARGEBACK_JSON input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>PAYRIX_DECISION_JSON</c> - <b>PAYRIX_DECISION_JSON input file. Risk decision integration format and structure for the Payrix integration service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>PAYRIX_ENCRYPTION_JSON</c> - <b>PAYRIX_ENCRYPTION_JSON input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>PAYRIX_GOOGLEPAY_DECRYPTION_JSON</c> - <b>PAYRIX_GOOGLEPAY_DECRYPTION_JSON Blank.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>PAYRIX_TXN_JSON</c> - <b>PAYRIX_TXN_JSON input file. Terminal activation response format and structure for the Payrix terminal app.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>PUSHY_TXN_JSON</c> - <b>PUSHY_TXN_JSON input file. Terminal activation request format and structure for the Pushy app messaging service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>SIFT_JSON</c> - <b>SIFT_JSON input file. Risk decision integration format and structure for the SIFT transaction monitoring service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>SOCURE_ALLOY_JSON</c> - <b>SOCURE_ALLOY_JSON input file. Risk decision integration format and structure for the Alloy integrator to Socure.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>SOCURE_FORM</c> - <b>SOCURE_FORM input file. Risk decision integration request format and structure for the Socure member underwriting service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>SOCURE_JSON</c> - <b>SOCURE_JSON input file. Risk decision integration response format and structure for the Socure member underwriting service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>SOUNDPAYMENTS_TXN_FORM</c> - <b>SOUNDPAYMENTS_TXN_FORM input file. Terminal activation request format and structure for the Sound Payments cloud activation service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>SOUNDPAYMENTS_TXN_XML</c> - <b>SOUNDPAYMENTS_TXN_XML input file. Terminal activation response format and structure for the Sound Payments cloud activation service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV_BATCH_XML</c> - <b>VANTIV_BATCH_XML input file. Batch file format and structure for the WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV_BOARD_XML</c> - <b>VANTIV_BOARD_XML input file. Merchant boarding format and structure for the WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV_CHARGEBACK_XML</c> - <b>VANTIV_CHARGEBACK_XML input file. Chargeback API format and structure for the WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV_PAYMENT_UPDATES_XML</c> - <b>VANTIV_PAYMENT_UPDATES_XML input file. Account Updater format and structure for the WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV_PAYOUT_CSV</c> - <b>VANTIV_PAYOUT_CSV input file. Payout reports format and structure for the WoldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV_PAYOUT_XML</c> - <b>VANTIV_PAYOUT_XML input file. Disbursement file format and structure for the WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV_PAYOUT_XML_V9</c> - <b>VANTIV_PAYOUT_XML_V9 input file. Old version 9 disbursement file format and structure for the WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV_REPORTS_CSV</c> - <b>VANTIV_REPORTS_CSV input file. Settlement report format and structure for the WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV_TXN_CSV</c> - <b>VANTIV_TXN_CSV input file. Echeck reports format and structure for the WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV_TXN_XML</c> - <b>VANTIV_TXN_XML input file. Transaction authorization processing format and structure for the WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_BATCH_FLAT</c> - <b>VCORE_BATCH_FLAT input file. Batch file upload format and structure for the WorldPay (aka Vantiv) Core processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_BATCH_READ_FLAT</c> - <b>VCORE_BATCH_READ_FLAT input file. Batch file download format and structure for the WorldPay (aka Vantiv) Core processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_BINREPORT_FLAT</c> - <b>VCORE_BINREPORT_FLAT input file. BIN (Bank Issuer Number) file download format and structure for the WorldPay (aka Vantiv) Core processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_BOARD_API</c> - <b>VCORE_BOARD_API input file. New merchant boarding API format and structure for the WorldPay (aka Vantiv) Core processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_BOARD_FLAT</c> - <b>VCORE_BOARD_FLAT input file. Old merchant boarding creation file format and structure for the WorldPay (aka Vantiv) Core processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_CHARGEBACK_FLAT</c> - <b>VCORE_CHARGEBACK_FLAT input file. Chargeback file format and structure for the WorldPay (aka Vantiv) Core processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_OMNITOKEN_JSON</c> - <b>VCORE_OMNITOKEN_JSON input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_REPORTS_FLAT</c> - <b>VCORE_REPORTS_FLAT input file. Settlement report format and structure for the WorldPay (aka Vantiv) Core processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_SAFERPAYMENT_JSON</c> - <b>VCORE_SAFERPAYMENT_JSON input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_TXN_ISO8583</c> - <b>VCORE_TXN_ISO8583 input file. Transaction authorization processing for the WorldPay (aka Vantiv) Core processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_UPDATE_FLAT</c> - <b>VCORE_UPDATE_FLAT input file. Old merchant boarding update file format and structure for the WorldPay (aka Vantiv) Core processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE_VARSHEET_JSON</c> - <b>VCORE_VARSHEET_JSON input file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WEBSHIELD_FORM</c> - <b>WEBSHIELD_FORM input file. Risk decision integration request format and structure for the Webshield entity underwriting service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WEBSHIELD_JSON</c> - <b>WEBSHIELD_JSON input file. Risk decision integration response format and structure for the Webshield entity underwriting service.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSACH_BATCH_FLAT</c> - <b>WELLSACH_BATCH_FLAT output file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSACH_PAYOUT_FLAT</c> - <b>WELLSACH_PAYOUT_FLAT output file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSACH_TXN_FLAT</c> - <b>WELLSACH_TXN_FLAT output file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSFARGO_BOARD_XML</c> - <b>WELLSFARGO_BOARD_XML output file. Merchant boarding format and structure for the Wells Fargo Merchant Services processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSFARGO_REPORT_CSV</c> - <b>WELLSFARGO_REPORT_CSV output file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSFARGO_REPORT_FLAT</c> - <b>WELLSFARGO_REPORT_FLAT output file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WFSINGLE_REPORT_FLAT</c> - <b>WFSINGLE_REPORT_FLAT output file.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WFSINGLE_BOARD_XML</c> - <b>WFSINGLE_BOARD_XML output file.</b></description></item>
/// </list>
/// <para>
///  &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConfigurationStageInput2>))]
public sealed record ConfigurationStageInput2 : OpenStringEnum<ConfigurationStageInput2>
{
    private ConfigurationStageInput2(string value) : base(value)
    {
    }

    public static readonly ConfigurationStageInput2 ApplePaymentsessionRequestJson = new(
        "APPLE_PAYMENTSESSION_REQUEST_JSON");

    public static readonly ConfigurationStageInput2 AppleRegisterMerchantRequestJson = new(
        "APPLE_REGISTER_MERCHANT_REQUEST_JSON");

    public static readonly ConfigurationStageInput2 AppleUnregisterMerchantRequestJson = new(
        "APPLE_UNREGISTER_MERCHANT_REQUEST_JSON");

    public static readonly ConfigurationStageInput2 Eft = new("EFT");

    public static readonly ConfigurationStageInput2 ElavonBatchFlat = new("ELAVON_BATCH_FLAT");

    public static readonly ConfigurationStageInput2 ElavonBatchReadFlat = new("ELAVON_BATCH_READ_FLAT");

    public static readonly ConfigurationStageInput2 ElavonBoardJson = new("ELAVON_BOARD_JSON");

    public static readonly ConfigurationStageInput2 ElavonReportsCsv = new("ELAVON_REPORTS_CSV");

    public static readonly ConfigurationStageInput2 ElavonTxnXml = new("ELAVON_TXN_XML");

    public static readonly ConfigurationStageInput2 FedachReportFlat = new("FEDACH_REPORT_FLAT");

    public static readonly ConfigurationStageInput2 FirstdataBatchFlat = new("FIRSTDATA_BATCH_FLAT");

    public static readonly ConfigurationStageInput2 FirstdataBatchReadFlat = new("FIRSTDATA_BATCH_READ_FLAT");

    public static readonly ConfigurationStageInput2 FirstdataBoardJson = new("FIRSTDATA_BOARD_JSON");

    public static readonly ConfigurationStageInput2 FirstdataReportsFlat = new("FIRSTDATA_REPORTS_FLAT");

    public static readonly ConfigurationStageInput2 FirstdataSrsXml = new("FIRSTDATA_SRS_XML");

    public static readonly ConfigurationStageInput2 FirstdataTxnXml = new("FIRSTDATA_TXN_XML");

    public static readonly ConfigurationStageInput2 FirstdataSingleBatchFlat = new("FIRSTDATA_SINGLE_BATCH_FLAT");

    public static readonly ConfigurationStageInput2 FirstdataSingleTxnXml = new("FIRSTDATA_SINGLE_TXN_XML");

    public static readonly ConfigurationStageInput2 Nacha = new("NACHA");

    public static readonly ConfigurationStageInput2 NeutrinoCsv = new("NEUTRINO_CSV");

    public static readonly ConfigurationStageInput2 NeutrinoForm = new("NEUTRINO_FORM");

    public static readonly ConfigurationStageInput2 NeutrinoJson = new("NEUTRINO_JSON");

    public static readonly ConfigurationStageInput2 OfacXml = new("OFAC_XML");

    public static readonly ConfigurationStageInput2 PayrixChargebackJson = new("PAYRIX_CHARGEBACK_JSON");

    public static readonly ConfigurationStageInput2 PayrixDecisionJson = new("PAYRIX_DECISION_JSON");

    public static readonly ConfigurationStageInput2 PayrixEncryptionJson = new("PAYRIX_ENCRYPTION_JSON");

    public static readonly ConfigurationStageInput2 PayrixGooglepayDecryptionJson = new(
        "PAYRIX_GOOGLEPAY_DECRYPTION_JSON");

    public static readonly ConfigurationStageInput2 PayrixTxnJson = new("PAYRIX_TXN_JSON");

    public static readonly ConfigurationStageInput2 PushyTxnJson = new("PUSHY_TXN_JSON");

    public static readonly ConfigurationStageInput2 SiftJson = new("SIFT_JSON");

    public static readonly ConfigurationStageInput2 SocureAlloyJson = new("SOCURE_ALLOY_JSON");

    public static readonly ConfigurationStageInput2 SocureForm = new("SOCURE_FORM");

    public static readonly ConfigurationStageInput2 SocureJson = new("SOCURE_JSON");

    public static readonly ConfigurationStageInput2 SoundpaymentsTxnForm = new("SOUNDPAYMENTS_TXN_FORM");

    public static readonly ConfigurationStageInput2 SoundpaymentsTxnXml = new("SOUNDPAYMENTS_TXN_XML");

    public static readonly ConfigurationStageInput2 VantivBatchXml = new("VANTIV_BATCH_XML");

    public static readonly ConfigurationStageInput2 VantivBoardXml = new("VANTIV_BOARD_XML");

    public static readonly ConfigurationStageInput2 VantivChargebackXml = new("VANTIV_CHARGEBACK_XML");

    public static readonly ConfigurationStageInput2 VantivPaymentUpdatesXml = new("VANTIV_PAYMENT_UPDATES_XML");

    public static readonly ConfigurationStageInput2 VantivPayoutCsv = new("VANTIV_PAYOUT_CSV");

    public static readonly ConfigurationStageInput2 VantivPayoutXml = new("VANTIV_PAYOUT_XML");

    public static readonly ConfigurationStageInput2 VantivPayoutXmlV9 = new("VANTIV_PAYOUT_XML_V9");

    public static readonly ConfigurationStageInput2 VantivReportsCsv = new("VANTIV_REPORTS_CSV");

    public static readonly ConfigurationStageInput2 VantivTxnCsv = new("VANTIV_TXN_CSV");

    public static readonly ConfigurationStageInput2 VantivTxnXml = new("VANTIV_TXN_XML");

    public static readonly ConfigurationStageInput2 VcoreBatchFlat = new("VCORE_BATCH_FLAT");

    public static readonly ConfigurationStageInput2 VcoreBatchReadFlat = new("VCORE_BATCH_READ_FLAT");

    public static readonly ConfigurationStageInput2 VcoreBinreportFlat = new("VCORE_BINREPORT_FLAT");

    public static readonly ConfigurationStageInput2 VcoreBoardApi = new("VCORE_BOARD_API");

    public static readonly ConfigurationStageInput2 VcoreBoardFlat = new("VCORE_BOARD_FLAT");

    public static readonly ConfigurationStageInput2 VcoreChargebackFlat = new("VCORE_CHARGEBACK_FLAT");

    public static readonly ConfigurationStageInput2 VcoreOmnitokenJson = new("VCORE_OMNITOKEN_JSON");

    public static readonly ConfigurationStageInput2 VcoreReportsFlat = new("VCORE_REPORTS_FLAT");

    public static readonly ConfigurationStageInput2 VcoreSaferpaymentJson = new("VCORE_SAFERPAYMENT_JSON");

    public static readonly ConfigurationStageInput2 VcoreTxnIso8583 = new("VCORE_TXN_ISO8583");

    public static readonly ConfigurationStageInput2 VcoreUpdateFlat = new("VCORE_UPDATE_FLAT");

    public static readonly ConfigurationStageInput2 VcoreVarsheetJson = new("VCORE_VARSHEET_JSON");

    public static readonly ConfigurationStageInput2 WebshieldForm = new("WEBSHIELD_FORM");

    public static readonly ConfigurationStageInput2 WebshieldJson = new("WEBSHIELD_JSON");

    public static readonly ConfigurationStageInput2 WellsachBatchFlat = new("WELLSACH_BATCH_FLAT");

    public static readonly ConfigurationStageInput2 WellsachPayoutFlat = new("WELLSACH_PAYOUT_FLAT");

    public static readonly ConfigurationStageInput2 WellsachTxnFlat = new("WELLSACH_TXN_FLAT");

    public static readonly ConfigurationStageInput2 WellsfargoBoardXml = new("WELLSFARGO_BOARD_XML");

    public static readonly ConfigurationStageInput2 WellsfargoReportCsv = new("WELLSFARGO_REPORT_CSV");

    public static readonly ConfigurationStageInput2 WellsfargoReportFlat = new("WELLSFARGO_REPORT_FLAT");

    public static readonly ConfigurationStageInput2 WfsingleReportFlat = new("WFSINGLE_REPORT_FLAT");

    public static readonly ConfigurationStageInput2 WfsingleBoardXml = new("WFSINGLE_BOARD_XML");

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
