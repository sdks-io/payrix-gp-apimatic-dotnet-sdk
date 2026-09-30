using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConfigurationStageName>))]
public sealed record ConfigurationStageName : OpenStringEnum<ConfigurationStageName>
{
    private ConfigurationStageName(string value) : base(value)
    {
    }

    public static readonly ConfigurationStageName Blank = new("blank");

    public static readonly ConfigurationStageName AcceptedCards = new("acceptedCards");

    public static readonly ConfigurationStageName Ack = new("ack");

    public static readonly ConfigurationStageName ActivateSrs = new("activateSrs");

    public static readonly ConfigurationStageName Alert = new("alert");

    public static readonly ConfigurationStageName AmexUpdate = new("amexUpdate");

    public static readonly ConfigurationStageName Applepay = new("applepay");

    public static readonly ConfigurationStageName Balance = new("balance");

    public static readonly ConfigurationStageName Batch = new("batch");

    public static readonly ConfigurationStageName Chargeback = new("chargeback");

    public static readonly ConfigurationStageName ChargebackList = new("chargebackList");

    public static readonly ConfigurationStageName ConfirmDisbursement = new("confirmDisbursement");

    public static readonly ConfigurationStageName ContactUpdate = new("contactUpdate");

    public static readonly ConfigurationStageName CreateMerchant = new("createMerchant");

    public static readonly ConfigurationStageName Credit = new("credit");

    public static readonly ConfigurationStageName Decrypt = new("decrypt");

    public static readonly ConfigurationStageName Debit = new("debit");

    public static readonly ConfigurationStageName DebitPinEnable = new("debitPinEnable");

    public static readonly ConfigurationStageName DebitPinlessEnable = new("debitPinlessEnable");

    public static readonly ConfigurationStageName DiscoverUrl = new("discoverUrl");

    public static readonly ConfigurationStageName DiscoverUpdate = new("discoverUpdate");

    public static readonly ConfigurationStageName Document = new("document");

    public static readonly ConfigurationStageName DocumentList = new("documentList");

    public static readonly ConfigurationStageName Interchange = new("interchange");

    public static readonly ConfigurationStageName Encrypt = new("encrypt");

    public static readonly ConfigurationStageName Entity = new("entity");

    public static readonly ConfigurationStageName EntityAddressUpdate = new("entityAddressUpdate");

    public static readonly ConfigurationStageName EntityRetrieval = new("entityRetrieval");

    public static readonly ConfigurationStageName EntityUpdate = new("entityUpdate");

    public static readonly ConfigurationStageName ExpressSubAccountUpdate = new("expressSubAccountUpdate");

    public static readonly ConfigurationStageName Return = new("return");

    public static readonly ConfigurationStageName FeeList = new("feeList");

    public static readonly ConfigurationStageName Googlepay = new("googlepay");

    public static readonly ConfigurationStageName MemberCreate = new("memberCreate");

    public static readonly ConfigurationStageName MemberDelete = new("memberDelete");

    public static readonly ConfigurationStageName Members = new("members");

    public static readonly ConfigurationStageName MemberUpdate = new("memberUpdate");

    public static readonly ConfigurationStageName Merchant = new("merchant");

    public static readonly ConfigurationStageName MerchantCardPresent = new("merchantCardPresent");

    public static readonly ConfigurationStageName MerchantCardNotPresent = new("merchantCardNotPresent");

    public static readonly ConfigurationStageName MerchantUpdate = new("merchantUpdate");

    public static readonly ConfigurationStageName MerchantRetrieval = new("merchantRetrieval");

    public static readonly ConfigurationStageName Noc = new("noc");

    public static readonly ConfigurationStageName NocReturns = new("nocReturns");

    public static readonly ConfigurationStageName OmniTokenEnable = new("omniTokenEnable");

    public static readonly ConfigurationStageName PassTokenEnable = new("passTokenEnable");

    public static readonly ConfigurationStageName Payment = new("payment");

    public static readonly ConfigurationStageName PaymentConfirmation = new("paymentConfirmation");

    public static readonly ConfigurationStageName PaymentUpdate = new("paymentUpdate");

    public static readonly ConfigurationStageName Payout = new("payout");

    public static readonly ConfigurationStageName PrimaryMemberUpdate = new("primaryMemberUpdate");

    public static readonly ConfigurationStageName RegisterSrs = new("registerSrs");

    public static readonly ConfigurationStageName ReturnCredit = new("returnCredit");

    public static readonly ConfigurationStageName ReturnDebit = new("returnDebit");

    public static readonly ConfigurationStageName Returns = new("returns");

    public static readonly ConfigurationStageName SaferPaymentEnable = new("saferPaymentEnable");

    public static readonly ConfigurationStageName TerminalCreate = new("terminalCreate");

    public static readonly ConfigurationStageName TerminalList = new("terminalList");

    public static readonly ConfigurationStageName TerminalsSupported = new("terminalsSupported");

    public static readonly ConfigurationStageName Txn = new("txn");

    public static readonly ConfigurationStageName TxnList = new("txnList");

    public static readonly ConfigurationStageName Varsheet = new("varsheet");

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
