using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The name of this configurationStage resource.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>blank</c> - <b>Blank. Used for a stage with no name.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>acceptedCards</c> - <b>Set card types accepted by the merchant.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ack</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>activateSrs</c> - <b>First Data merchant SRS activation.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>alert</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>acceptedCards</c> - <b>'This holds the parameter to pull the accepted cards for a merchant, this is specific to VCORE'</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>amexUpdate</c> - <b>Update merchant card enablement for American Express.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>applepay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>balance</c> - <b>Bank account balance request for decisions and verifications processes.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>batch</c> - <b>Send batch command to terminal.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>chargeback</c> - <b>Chargeback. The standard name used for chargeback related stages.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>chargebackList</c> - <b>ChargebackList. The specific name to get chargeback reports.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>confirmDisbursement</c> - <b>Disbursement confirmation report retrieval.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>contactUpdate</c> - <b>Update merchant contacts.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>createMerchant</c> - <b>Send merchant details for merchant boarding.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>credit</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>decrypt</c> - <b>Set card types accepted by the merchant.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>debit</c> - <b>Set card types accepted by the merchant.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>debitPinEnable</c> - <b>Set merchant Pin Debit enablement.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>debitPinlessEnable</c> - <b>Set merchant Pinless Debit enablement.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>discoverUrl</c> - <b>Retrieve merchant transaction processing url.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>discoverUpdate</c> - <b>Update merchant card enablement for Discover.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>document</c> - <b>Document. The standard name for chargeback related documentation such as uploading a document or updating a document.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>documentList</c> - <b>DocumentList. Used for receiving documents related to a chargeback.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>interchange</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>encrypt</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>entity</c> - <b>Entity. The standard name used when it comes to entity related stages such as retrieving an entity or updating.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>entityAddressUpdate</c> - <b>Update merchant legal entity address.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>entityRetrieval</c> - <b>EntityRetrieval. Used when entity stage name is already being used in that crud configuration.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>entityUpdate</c> - <b>EntityUpdate. Used when entity stage name is already being used in that crud configuration.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>expressSubAccountUpdate</c> - <b>'This holds the parameter for updating express subaccount'</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>return</c> - <b>Return. Used for return stage name.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>feeList</c> - <b>FeeList. The specific name to get fees reports.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>googlepay</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>memberCreate</c> - <b>MemberCreate. Stage name used to indicate creating a merchant member.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>memberDelete</c> - <b>MemberDelete. Stage name used to indicate deleting a merchant member.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>members</c> - <b>Members. Stage name used for creating several members for the merchant.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>memberUpdate</c> - <b>Update merchant member.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>merchant</c> - <b>Merchant. The standard name used for merchant related stages such retrieving a merchant or updating a merchant.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>merchantCardPresent</c> - <b>'This holds the parameter for creating merchants with card present options, this is specific for WF and WFSingle platform'</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>merchantCardNotPresent</c> - <b>'This holds the parameter for creating merchants with card not present options, this is specific for WF and WFSingle platform'</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>merchantUpdate</c> - <b>Update merchant details.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>merchantRetrieval</c> - <b>MerchantRetrieval. Used when merchant stage name is already being used in that crud configuration.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>noc</c> - <b>Noc. Stage name used for notification of change for disbursement related integrations.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>nocReturns</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>omniTokenEnable</c> - <b>'This holds the parameters for omni token enablement'</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>passTokenEnable</c> - <b>'This holds the parameters for pass token enablement'</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>payment</c> - <b>Send payment details for Account Updater request.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paymentConfirmation</c> - <b>Retrieve Account Updater request echo confirmation.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>paymentUpdate</c> - <b>Retrieve Account Updater updates.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>payout</c> - <b>Payout. Stage name used for payouts.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>primaryMemberUpdate</c> - <b>Update merchant primary member.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>registerSrs</c> - <b>First Data merchant SRS registration.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>returnCredit</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>returnDebit</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>returns</c> - <b>''</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>saferPaymentEnable</c> - <b>'This holds the parameters for safer payment enablement'</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>terminalCreate</c> - <b>Send terminal details for terminal boarding.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>terminalList</c> - <b>Retrieve list of terminals for a merchant.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>terminalsSupported</c> - <b>Retrieve list of supported terminals for a merchant.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>txn</c> - <b>Txn. The standard name used for transaction related stages.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>txnList</c> - <b>TxnList. The specific name to get transaction reports.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>varsheet</c> - <b>'This hold the parameter for accessing the terminal VARSHEET retrieval'</b></description></item>
/// </list>
/// <para>
///  &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConfigurationStageName2>))]
public sealed record ConfigurationStageName2 : OpenStringEnum<ConfigurationStageName2>
{
    private ConfigurationStageName2(string value) : base(value)
    {
    }

    public static readonly ConfigurationStageName2 Blank = new("blank");

    public static readonly ConfigurationStageName2 AcceptedCards = new("acceptedCards");

    public static readonly ConfigurationStageName2 Ack = new("ack");

    public static readonly ConfigurationStageName2 ActivateSrs = new("activateSrs");

    public static readonly ConfigurationStageName2 Alert = new("alert");

    public static readonly ConfigurationStageName2 AmexUpdate = new("amexUpdate");

    public static readonly ConfigurationStageName2 Applepay = new("applepay");

    public static readonly ConfigurationStageName2 Balance = new("balance");

    public static readonly ConfigurationStageName2 Batch = new("batch");

    public static readonly ConfigurationStageName2 Chargeback = new("chargeback");

    public static readonly ConfigurationStageName2 ChargebackList = new("chargebackList");

    public static readonly ConfigurationStageName2 ConfirmDisbursement = new("confirmDisbursement");

    public static readonly ConfigurationStageName2 ContactUpdate = new("contactUpdate");

    public static readonly ConfigurationStageName2 CreateMerchant = new("createMerchant");

    public static readonly ConfigurationStageName2 Credit = new("credit");

    public static readonly ConfigurationStageName2 Decrypt = new("decrypt");

    public static readonly ConfigurationStageName2 Debit = new("debit");

    public static readonly ConfigurationStageName2 DebitPinEnable = new("debitPinEnable");

    public static readonly ConfigurationStageName2 DebitPinlessEnable = new("debitPinlessEnable");

    public static readonly ConfigurationStageName2 DiscoverUrl = new("discoverUrl");

    public static readonly ConfigurationStageName2 DiscoverUpdate = new("discoverUpdate");

    public static readonly ConfigurationStageName2 Document = new("document");

    public static readonly ConfigurationStageName2 DocumentList = new("documentList");

    public static readonly ConfigurationStageName2 Interchange = new("interchange");

    public static readonly ConfigurationStageName2 Encrypt = new("encrypt");

    public static readonly ConfigurationStageName2 Entity = new("entity");

    public static readonly ConfigurationStageName2 EntityAddressUpdate = new("entityAddressUpdate");

    public static readonly ConfigurationStageName2 EntityRetrieval = new("entityRetrieval");

    public static readonly ConfigurationStageName2 EntityUpdate = new("entityUpdate");

    public static readonly ConfigurationStageName2 ExpressSubAccountUpdate = new("expressSubAccountUpdate");

    public static readonly ConfigurationStageName2 Return = new("return");

    public static readonly ConfigurationStageName2 FeeList = new("feeList");

    public static readonly ConfigurationStageName2 Googlepay = new("googlepay");

    public static readonly ConfigurationStageName2 MemberCreate = new("memberCreate");

    public static readonly ConfigurationStageName2 MemberDelete = new("memberDelete");

    public static readonly ConfigurationStageName2 Members = new("members");

    public static readonly ConfigurationStageName2 MemberUpdate = new("memberUpdate");

    public static readonly ConfigurationStageName2 Merchant = new("merchant");

    public static readonly ConfigurationStageName2 MerchantCardPresent = new("merchantCardPresent");

    public static readonly ConfigurationStageName2 MerchantCardNotPresent = new("merchantCardNotPresent");

    public static readonly ConfigurationStageName2 MerchantUpdate = new("merchantUpdate");

    public static readonly ConfigurationStageName2 MerchantRetrieval = new("merchantRetrieval");

    public static readonly ConfigurationStageName2 Noc = new("noc");

    public static readonly ConfigurationStageName2 NocReturns = new("nocReturns");

    public static readonly ConfigurationStageName2 OmniTokenEnable = new("omniTokenEnable");

    public static readonly ConfigurationStageName2 PassTokenEnable = new("passTokenEnable");

    public static readonly ConfigurationStageName2 Payment = new("payment");

    public static readonly ConfigurationStageName2 PaymentConfirmation = new("paymentConfirmation");

    public static readonly ConfigurationStageName2 PaymentUpdate = new("paymentUpdate");

    public static readonly ConfigurationStageName2 Payout = new("payout");

    public static readonly ConfigurationStageName2 PrimaryMemberUpdate = new("primaryMemberUpdate");

    public static readonly ConfigurationStageName2 RegisterSrs = new("registerSrs");

    public static readonly ConfigurationStageName2 ReturnCredit = new("returnCredit");

    public static readonly ConfigurationStageName2 ReturnDebit = new("returnDebit");

    public static readonly ConfigurationStageName2 Returns = new("returns");

    public static readonly ConfigurationStageName2 SaferPaymentEnable = new("saferPaymentEnable");

    public static readonly ConfigurationStageName2 TerminalCreate = new("terminalCreate");

    public static readonly ConfigurationStageName2 TerminalList = new("terminalList");

    public static readonly ConfigurationStageName2 TerminalsSupported = new("terminalsSupported");

    public static readonly ConfigurationStageName2 Txn = new("txn");

    public static readonly ConfigurationStageName2 TxnList = new("txnList");

    public static readonly ConfigurationStageName2 Varsheet = new("varsheet");

    public TResult Match<TResult>(Func<TResult> onBlank,
        Func<TResult> onAcceptedCards,
        Func<TResult> onAck,
        Func<TResult> onActivateSrs,
        Func<TResult> onAlert,
        Func<TResult> onAmexUpdate,
        Func<TResult> onApplepay,
        Func<TResult> onBalance,
        Func<TResult> onBatch,
        Func<TResult> onChargeback,
        Func<TResult> onChargebackList,
        Func<TResult> onConfirmDisbursement,
        Func<TResult> onContactUpdate,
        Func<TResult> onCreateMerchant,
        Func<TResult> onCredit,
        Func<TResult> onDecrypt,
        Func<TResult> onDebit,
        Func<TResult> onDebitPinEnable,
        Func<TResult> onDebitPinlessEnable,
        Func<TResult> onDiscoverUrl,
        Func<TResult> onDiscoverUpdate,
        Func<TResult> onDocument,
        Func<TResult> onDocumentList,
        Func<TResult> onInterchange,
        Func<TResult> onEncrypt,
        Func<TResult> onEntity,
        Func<TResult> onEntityAddressUpdate,
        Func<TResult> onEntityRetrieval,
        Func<TResult> onEntityUpdate,
        Func<TResult> onExpressSubAccountUpdate,
        Func<TResult> onReturn,
        Func<TResult> onFeeList,
        Func<TResult> onGooglepay,
        Func<TResult> onMemberCreate,
        Func<TResult> onMemberDelete,
        Func<TResult> onMembers,
        Func<TResult> onMemberUpdate,
        Func<TResult> onMerchant,
        Func<TResult> onMerchantCardPresent,
        Func<TResult> onMerchantCardNotPresent,
        Func<TResult> onMerchantUpdate,
        Func<TResult> onMerchantRetrieval,
        Func<TResult> onNoc,
        Func<TResult> onNocReturns,
        Func<TResult> onOmniTokenEnable,
        Func<TResult> onPassTokenEnable,
        Func<TResult> onPayment,
        Func<TResult> onPaymentConfirmation,
        Func<TResult> onPaymentUpdate,
        Func<TResult> onPayout,
        Func<TResult> onPrimaryMemberUpdate,
        Func<TResult> onRegisterSrs,
        Func<TResult> onReturnCredit,
        Func<TResult> onReturnDebit,
        Func<TResult> onReturns,
        Func<TResult> onSaferPaymentEnable,
        Func<TResult> onTerminalCreate,
        Func<TResult> onTerminalList,
        Func<TResult> onTerminalsSupported,
        Func<TResult> onTxn,
        Func<TResult> onTxnList,
        Func<TResult> onVarsheet,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Blank => onBlank(),
            _ when this == AcceptedCards => onAcceptedCards(),
            _ when this == Ack => onAck(),
            _ when this == ActivateSrs => onActivateSrs(),
            _ when this == Alert => onAlert(),
            _ when this == AmexUpdate => onAmexUpdate(),
            _ when this == Applepay => onApplepay(),
            _ when this == Balance => onBalance(),
            _ when this == Batch => onBatch(),
            _ when this == Chargeback => onChargeback(),
            _ when this == ChargebackList => onChargebackList(),
            _ when this == ConfirmDisbursement => onConfirmDisbursement(),
            _ when this == ContactUpdate => onContactUpdate(),
            _ when this == CreateMerchant => onCreateMerchant(),
            _ when this == Credit => onCredit(),
            _ when this == Decrypt => onDecrypt(),
            _ when this == Debit => onDebit(),
            _ when this == DebitPinEnable => onDebitPinEnable(),
            _ when this == DebitPinlessEnable => onDebitPinlessEnable(),
            _ when this == DiscoverUrl => onDiscoverUrl(),
            _ when this == DiscoverUpdate => onDiscoverUpdate(),
            _ when this == Document => onDocument(),
            _ when this == DocumentList => onDocumentList(),
            _ when this == Interchange => onInterchange(),
            _ when this == Encrypt => onEncrypt(),
            _ when this == Entity => onEntity(),
            _ when this == EntityAddressUpdate => onEntityAddressUpdate(),
            _ when this == EntityRetrieval => onEntityRetrieval(),
            _ when this == EntityUpdate => onEntityUpdate(),
            _ when this == ExpressSubAccountUpdate => onExpressSubAccountUpdate(),
            _ when this == Return => onReturn(),
            _ when this == FeeList => onFeeList(),
            _ when this == Googlepay => onGooglepay(),
            _ when this == MemberCreate => onMemberCreate(),
            _ when this == MemberDelete => onMemberDelete(),
            _ when this == Members => onMembers(),
            _ when this == MemberUpdate => onMemberUpdate(),
            _ when this == Merchant => onMerchant(),
            _ when this == MerchantCardPresent => onMerchantCardPresent(),
            _ when this == MerchantCardNotPresent => onMerchantCardNotPresent(),
            _ when this == MerchantUpdate => onMerchantUpdate(),
            _ when this == MerchantRetrieval => onMerchantRetrieval(),
            _ when this == Noc => onNoc(),
            _ when this == NocReturns => onNocReturns(),
            _ when this == OmniTokenEnable => onOmniTokenEnable(),
            _ when this == PassTokenEnable => onPassTokenEnable(),
            _ when this == Payment => onPayment(),
            _ when this == PaymentConfirmation => onPaymentConfirmation(),
            _ when this == PaymentUpdate => onPaymentUpdate(),
            _ when this == Payout => onPayout(),
            _ when this == PrimaryMemberUpdate => onPrimaryMemberUpdate(),
            _ when this == RegisterSrs => onRegisterSrs(),
            _ when this == ReturnCredit => onReturnCredit(),
            _ when this == ReturnDebit => onReturnDebit(),
            _ when this == Returns => onReturns(),
            _ when this == SaferPaymentEnable => onSaferPaymentEnable(),
            _ when this == TerminalCreate => onTerminalCreate(),
            _ when this == TerminalList => onTerminalList(),
            _ when this == TerminalsSupported => onTerminalsSupported(),
            _ when this == Txn => onTxn(),
            _ when this == TxnList => onTxnList(),
            _ when this == Varsheet => onVarsheet(),
            _ => otherwise(Value)
        };

    public void Match(Action onBlank,
        Action onAcceptedCards,
        Action onAck,
        Action onActivateSrs,
        Action onAlert,
        Action onAmexUpdate,
        Action onApplepay,
        Action onBalance,
        Action onBatch,
        Action onChargeback,
        Action onChargebackList,
        Action onConfirmDisbursement,
        Action onContactUpdate,
        Action onCreateMerchant,
        Action onCredit,
        Action onDecrypt,
        Action onDebit,
        Action onDebitPinEnable,
        Action onDebitPinlessEnable,
        Action onDiscoverUrl,
        Action onDiscoverUpdate,
        Action onDocument,
        Action onDocumentList,
        Action onInterchange,
        Action onEncrypt,
        Action onEntity,
        Action onEntityAddressUpdate,
        Action onEntityRetrieval,
        Action onEntityUpdate,
        Action onExpressSubAccountUpdate,
        Action onReturn,
        Action onFeeList,
        Action onGooglepay,
        Action onMemberCreate,
        Action onMemberDelete,
        Action onMembers,
        Action onMemberUpdate,
        Action onMerchant,
        Action onMerchantCardPresent,
        Action onMerchantCardNotPresent,
        Action onMerchantUpdate,
        Action onMerchantRetrieval,
        Action onNoc,
        Action onNocReturns,
        Action onOmniTokenEnable,
        Action onPassTokenEnable,
        Action onPayment,
        Action onPaymentConfirmation,
        Action onPaymentUpdate,
        Action onPayout,
        Action onPrimaryMemberUpdate,
        Action onRegisterSrs,
        Action onReturnCredit,
        Action onReturnDebit,
        Action onReturns,
        Action onSaferPaymentEnable,
        Action onTerminalCreate,
        Action onTerminalList,
        Action onTerminalsSupported,
        Action onTxn,
        Action onTxnList,
        Action onVarsheet,
        Action<string> otherwise)
    {
        if (this == Blank) onBlank();
        else if (this == AcceptedCards) onAcceptedCards();
        else if (this == Ack) onAck();
        else if (this == ActivateSrs) onActivateSrs();
        else if (this == Alert) onAlert();
        else if (this == AmexUpdate) onAmexUpdate();
        else if (this == Applepay) onApplepay();
        else if (this == Balance) onBalance();
        else if (this == Batch) onBatch();
        else if (this == Chargeback) onChargeback();
        else if (this == ChargebackList) onChargebackList();
        else if (this == ConfirmDisbursement) onConfirmDisbursement();
        else if (this == ContactUpdate) onContactUpdate();
        else if (this == CreateMerchant) onCreateMerchant();
        else if (this == Credit) onCredit();
        else if (this == Decrypt) onDecrypt();
        else if (this == Debit) onDebit();
        else if (this == DebitPinEnable) onDebitPinEnable();
        else if (this == DebitPinlessEnable) onDebitPinlessEnable();
        else if (this == DiscoverUrl) onDiscoverUrl();
        else if (this == DiscoverUpdate) onDiscoverUpdate();
        else if (this == Document) onDocument();
        else if (this == DocumentList) onDocumentList();
        else if (this == Interchange) onInterchange();
        else if (this == Encrypt) onEncrypt();
        else if (this == Entity) onEntity();
        else if (this == EntityAddressUpdate) onEntityAddressUpdate();
        else if (this == EntityRetrieval) onEntityRetrieval();
        else if (this == EntityUpdate) onEntityUpdate();
        else if (this == ExpressSubAccountUpdate) onExpressSubAccountUpdate();
        else if (this == Return) onReturn();
        else if (this == FeeList) onFeeList();
        else if (this == Googlepay) onGooglepay();
        else if (this == MemberCreate) onMemberCreate();
        else if (this == MemberDelete) onMemberDelete();
        else if (this == Members) onMembers();
        else if (this == MemberUpdate) onMemberUpdate();
        else if (this == Merchant) onMerchant();
        else if (this == MerchantCardPresent) onMerchantCardPresent();
        else if (this == MerchantCardNotPresent) onMerchantCardNotPresent();
        else if (this == MerchantUpdate) onMerchantUpdate();
        else if (this == MerchantRetrieval) onMerchantRetrieval();
        else if (this == Noc) onNoc();
        else if (this == NocReturns) onNocReturns();
        else if (this == OmniTokenEnable) onOmniTokenEnable();
        else if (this == PassTokenEnable) onPassTokenEnable();
        else if (this == Payment) onPayment();
        else if (this == PaymentConfirmation) onPaymentConfirmation();
        else if (this == PaymentUpdate) onPaymentUpdate();
        else if (this == Payout) onPayout();
        else if (this == PrimaryMemberUpdate) onPrimaryMemberUpdate();
        else if (this == RegisterSrs) onRegisterSrs();
        else if (this == ReturnCredit) onReturnCredit();
        else if (this == ReturnDebit) onReturnDebit();
        else if (this == Returns) onReturns();
        else if (this == SaferPaymentEnable) onSaferPaymentEnable();
        else if (this == TerminalCreate) onTerminalCreate();
        else if (this == TerminalList) onTerminalList();
        else if (this == TerminalsSupported) onTerminalsSupported();
        else if (this == Txn) onTxn();
        else if (this == TxnList) onTxnList();
        else if (this == Varsheet) onVarsheet();
        else otherwise(Value);
    }
}
