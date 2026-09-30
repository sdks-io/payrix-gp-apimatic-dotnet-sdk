using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The event type that triggers the associated Alert.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>create</c> - <b>Triggers when the associated resource is created.</b></description></item>
///   <item><description><c>update</c> - <b>Triggers when the associated resource is updated.</b></description></item>
///   <item><description><c>delete</c> - <b>Triggers when the associated resource is deleted.</b></description></item>
///   <item><description><c>ownership</c> - <b>Triggers when the ownership of the associated resource changes.</b></description></item>
///   <item><description><c>batch</c> - <b>Triggers when Transactions are captured in a batch.</b></description></item>
///   <item><description><c>account</c> - <b>Triggers when the Account associated with a Merchant is updated.</b></description></item>
///   <item><description><c>account.created</c> - <b>Triggers when the Account is created.</b></description></item>
///   <item><description><c>account.updated</c> - <b>Triggers when the Account is updated.</b></description></item>
///   <item><description><c>payout</c> - <b>Triggers when a Payout occurs.</b></description></item>
///   <item><description><c>fee</c> - <b>Triggers when an Entity is charged a Fee.</b></description></item>
///   <item><description><c>changerequest.declined</c> - <b>Triggers when change request declined.</b></description></item>
///   <item><description><c>changerequest.created</c> - <b>Triggers when change request created.</b></description></item>
///   <item><description><c>changerequest.approved</c> - <b>Triggers when change request approved.</b></description></item>
///   <item><description><c>changerequest.manualReview</c> - <b>Triggers when change request reviewed manually.</b></description></item>
///   <item><description><c>chargeback</c> - <b>Triggers alert when Chargeback Reports are created.</b></description></item>
///   <item><description><c>chargeback.opened</c> - <b>Triggers alert when Chargeback opened.</b></description></item>
///   <item><description><c>chargeback.closed</c> - <b>Triggers alert when Chargeback closed.</b></description></item>
///   <item><description><c>chargeback.created</c> - <b>Triggers alert when a Chargeback is created.</b></description></item>
///   <item><description><c>chargeback.lost</c> - <b>Triggers alert when a Chargeback dispute was lost.</b></description></item>
///   <item><description><c>chargeback.won</c> - <b>Triggers alert when a Chargeback dispute was won.</b></description></item>
///   <item><description><c>chargebackdocument.uploaded</c> - <b>Triggers alert when Chargeback document uploaded.</b></description></item>
///   <item><description><c>debit.disbursement.recovery</c> - <b>Triggers when the entity recovers from a negative balance and now has a positive balance again and the debtorEntity record is deleted.</b></description></item>
///   <item><description><c>disbursement.requested</c> - <b>Triggers alert when a Disbursement is requested.</b></description></item>
///   <item><description><c>disbursement.processing</c> - <b>Triggers alert when a Disbursement is processing.</b></description></item>
///   <item><description><c>disbursement.processed</c> - <b>Triggers alert when a Disbursement has been processed.</b></description></item>
///   <item><description><c>disbursement.failed</c> - <b>Triggers alert when a Disbursement has failed.</b></description></item>
///   <item><description><c>disbursement.denied</c> - <b>Triggers alert when a Disbursement has been denied.</b></description></item>
///   <item><description><c>disbursement.report</c> - <b>Triggers alert when Disbursements are processed.</b></description></item>
///   <item><description><c>disbursement.returned</c> - <b>Triggers alert when Disbursement has returned.</b></description></item>
///   <item><description><c>disbursementEntries.processed</c> - <b>Triggers alert when Disbursement Entries have been processed.</b></description></item>
///   <item><description><c>invoice.created</c> - <b>Triggers alert when an invoice has been created.</b></description></item>
///   <item><description><c>invoice.cancelled</c> - <b>Triggers alert when an invoice has been cancelled.</b></description></item>
///   <item><description><c>invoice.emailed</c> - <b>Triggers alert when an invoice has been emailed.</b></description></item>
///   <item><description><c>invoice.expired</c> - <b>Triggers alert when an invoice has expired.</b></description></item>
///   <item><description><c>invoice.paid</c> - <b>Triggers alert when an invoice has been paid.</b></description></item>
///   <item><description><c>invoice.refunded</c> - <b>Triggers alert when an invoice has been refunded.</b></description></item>
///   <item><description><c>invoice.viewed</c> - <b>Triggers alert when an invoice has been viewed.</b></description></item>
///   <item><description><c>invoiceResult.failure</c> - <b>Triggers alert when an invoice result has failed.</b></description></item>
///   <item><description><c>merchant.created</c> - <b>Triggers alert when a Merchant has been created.</b></description></item>
///   <item><description><c>merchant.boarding</c> - <b>Triggers alert when a Merchant is boarding.</b></description></item>
///   <item><description><c>merchant.boarded</c> - <b>Triggers alert when a Merchant has been boarded.</b></description></item>
///   <item><description><c>merchant.closed</c> - <b>Triggers alert when a Merchant is closed.</b></description></item>
///   <item><description><c>merchant.conditionally.approved</c> - <b>Triggers alert when a Merchant is conditionally approved.</b></description></item>
///   <item><description><c>merchant.fully.boarded</c> - <b>Triggers alert when a Merchant is fully boarded after being conditionally approved.</b></description></item>
///   <item><description><c>merchant.pending</c> - <b>Triggers alert when a Merchant is pending.</b></description></item>
///   <item><description><c>merchant.reserved</c> - <b>Triggers alert when a Merchant is reserved after being conditionally approved.</b></description></item>
///   <item><description><c>merchant.incomplete</c> - <b>Triggers alert when a Merchant is incomplete.</b></description></item>
///   <item><description><c>merchant.failed</c> - <b>Triggers alert when Merchant boarding has failed.</b></description></item>
///   <item><description><c>merchant.held</c> - <b>Triggers alert when a Merchant boarding requires manual review.</b></description></item>
///   <item><description><c>message.created</c> - <b>Triggers alert when a Message was created.</b></description></item>
///   <item><description><c>paymentupdate.report</c> - <b>Triggers when a report for a paymentUpdate is generated.</b></description></item>
///   <item><description><c>resource.created</c> - <b>Triggers alert when a Resource was created.</b></description></item>
///   <item><description><c>resource.updated</c> - <b>Triggers alert when a Resource was updated.</b></description></item>
///   <item><description><c>subscription.created</c> - <b>Triggers alert when a Subscription was created.</b></description></item>
///   <item><description><c>subscription.approved</c> - <b>Triggers alert when a Subscription was approved.</b></description></item>
///   <item><description><c>subscription.failed</c> - <b>Triggers alert when a Subscription has failed.</b></description></item>
///   <item><description><c>terminalTxn.created</c> - <b>Triggers alert when Terminal Transaction has been created.</b></description></item>
///   <item><description><c>terminalTxn.approved</c> - <b>Triggers alert when Terminal Transaction has been approved.</b></description></item>
///   <item><description><c>terminalTxn.failed</c> - <b>Triggers alert when Terminal Transaction has failed.</b></description></item>
///   <item><description><c>txn.created</c> - <b>Triggers alert when a Transaction is created.</b></description></item>
///   <item><description><c>txn.approved</c> - <b>Triggers alert when a Transaction has been approved.</b></description></item>
///   <item><description><c>txn.failed</c> - <b>Triggers alert when a Transaction has failed.</b></description></item>
///   <item><description><c>txn.captured</c> - <b>Triggers alert when a Transaction has been captured.</b></description></item>
///   <item><description><c>txn.settled</c> - <b>Triggers alert when a Transaction has been settled.</b></description></item>
///   <item><description><c>txn.returned</c> - <b>Triggers alert when a Transaction has been returned.</b></description></item>
///   <item><description><c>txn.echeck.funded</c> - <b>Triggers alert when a Transaction has been eCheck funded.</b></description></item>
///   <item><description><c>txn.delayed.funding</c> - <b>Triggers alert when a Transaction delayed funding.</b></description></item>
///   <item><description><c>upcoming.debit.disbursement</c> - <b>Triggers alert for upcoming debit disbursement.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AlertTriggerEvent1>))]
public sealed record AlertTriggerEvent1 : OpenStringEnum<AlertTriggerEvent1>
{
    private AlertTriggerEvent1(string value) : base(value)
    {
    }

    public static readonly AlertTriggerEvent1 Create = new("create");

    public static readonly AlertTriggerEvent1 Update = new("update");

    public static readonly AlertTriggerEvent1 Delete = new("delete");

    public static readonly AlertTriggerEvent1 Ownership = new("ownership");

    public static readonly AlertTriggerEvent1 Batch = new("batch");

    public static readonly AlertTriggerEvent1 Account = new("account");

    public static readonly AlertTriggerEvent1 AccountCreated = new("account.created");

    public static readonly AlertTriggerEvent1 AccountUpdated = new("account.updated");

    public static readonly AlertTriggerEvent1 Payout = new("payout");

    public static readonly AlertTriggerEvent1 Fee = new("fee");

    public static readonly AlertTriggerEvent1 ChangerequestDeclined = new("changerequest.declined");

    public static readonly AlertTriggerEvent1 ChangerequestCreated = new("changerequest.created");

    public static readonly AlertTriggerEvent1 ChangerequestApproved = new("changerequest.approved");

    public static readonly AlertTriggerEvent1 ChangerequestManualReview = new("changerequest.manualReview");

    public static readonly AlertTriggerEvent1 Chargeback = new("chargeback");

    public static readonly AlertTriggerEvent1 ChargebackOpened = new("chargeback.opened");

    public static readonly AlertTriggerEvent1 ChargebackClosed = new("chargeback.closed");

    public static readonly AlertTriggerEvent1 ChargebackCreated = new("chargeback.created");

    public static readonly AlertTriggerEvent1 ChargebackLost = new("chargeback.lost");

    public static readonly AlertTriggerEvent1 ChargebackWon = new("chargeback.won");

    public static readonly AlertTriggerEvent1 ChargebackdocumentUploaded = new("chargebackdocument.uploaded");

    public static readonly AlertTriggerEvent1 DebitDisbursementRecovery = new("debit.disbursement.recovery");

    public static readonly AlertTriggerEvent1 DisbursementRequested = new("disbursement.requested");

    public static readonly AlertTriggerEvent1 DisbursementProcessing = new("disbursement.processing");

    public static readonly AlertTriggerEvent1 DisbursementProcessed = new("disbursement.processed");

    public static readonly AlertTriggerEvent1 DisbursementFailed = new("disbursement.failed");

    public static readonly AlertTriggerEvent1 DisbursementDenied = new("disbursement.denied");

    public static readonly AlertTriggerEvent1 DisbursementReport = new("disbursement.report");

    public static readonly AlertTriggerEvent1 DisbursementReturned = new("disbursement.returned");

    public static readonly AlertTriggerEvent1 DisbursementEntriesProcessed = new("disbursementEntries.processed");

    public static readonly AlertTriggerEvent1 InvoiceCreated = new("invoice.created");

    public static readonly AlertTriggerEvent1 InvoiceCancelled = new("invoice.cancelled");

    public static readonly AlertTriggerEvent1 InvoiceEmailed = new("invoice.emailed");

    public static readonly AlertTriggerEvent1 InvoiceExpired = new("invoice.expired");

    public static readonly AlertTriggerEvent1 InvoicePaid = new("invoice.paid");

    public static readonly AlertTriggerEvent1 InvoiceRefunded = new("invoice.refunded");

    public static readonly AlertTriggerEvent1 InvoiceViewed = new("invoice.viewed");

    public static readonly AlertTriggerEvent1 InvoiceResultFailure = new("invoiceResult.failure");

    public static readonly AlertTriggerEvent1 MerchantCreated = new("merchant.created");

    public static readonly AlertTriggerEvent1 MerchantBoarding = new("merchant.boarding");

    public static readonly AlertTriggerEvent1 MerchantBoarded = new("merchant.boarded");

    public static readonly AlertTriggerEvent1 MerchantClosed = new("merchant.closed");

    public static readonly AlertTriggerEvent1 MerchantConditionallyApproved = new("merchant.conditionally.approved");

    public static readonly AlertTriggerEvent1 MerchantFullyBoarded = new("merchant.fully.boarded");

    public static readonly AlertTriggerEvent1 MerchantPending = new("merchant.pending");

    public static readonly AlertTriggerEvent1 MerchantReserved = new("merchant.reserved");

    public static readonly AlertTriggerEvent1 MerchantIncomplete = new("merchant.incomplete");

    public static readonly AlertTriggerEvent1 MerchantFailed = new("merchant.failed");

    public static readonly AlertTriggerEvent1 MerchantHeld = new("merchant.held");

    public static readonly AlertTriggerEvent1 MessageCreated = new("message.created");

    public static readonly AlertTriggerEvent1 PaymentupdateReport = new("paymentupdate.report");

    public static readonly AlertTriggerEvent1 ResourceCreated = new("resource.created");

    public static readonly AlertTriggerEvent1 ResourceUpdated = new("resource.updated");

    public static readonly AlertTriggerEvent1 SubscriptionCreated = new("subscription.created");

    public static readonly AlertTriggerEvent1 SubscriptionApproved = new("subscription.approved");

    public static readonly AlertTriggerEvent1 SubscriptionFailed = new("subscription.failed");

    public static readonly AlertTriggerEvent1 TerminalTxnCreated = new("terminalTxn.created");

    public static readonly AlertTriggerEvent1 TerminalTxnApproved = new("terminalTxn.approved");

    public static readonly AlertTriggerEvent1 TerminalTxnFailed = new("terminalTxn.failed");

    public static readonly AlertTriggerEvent1 TxnCreated = new("txn.created");

    public static readonly AlertTriggerEvent1 TxnApproved = new("txn.approved");

    public static readonly AlertTriggerEvent1 TxnFailed = new("txn.failed");

    public static readonly AlertTriggerEvent1 TxnCaptured = new("txn.captured");

    public static readonly AlertTriggerEvent1 TxnSettled = new("txn.settled");

    public static readonly AlertTriggerEvent1 TxnReturned = new("txn.returned");

    public static readonly AlertTriggerEvent1 TxnEcheckFunded = new("txn.echeck.funded");

    public static readonly AlertTriggerEvent1 TxnDelayedFunding = new("txn.delayed.funding");

    public static readonly AlertTriggerEvent1 UpcomingDebitDisbursement = new("upcoming.debit.disbursement");

    public TResult Match<TResult>(Func<TResult> onCreate,
        Func<TResult> onUpdate,
        Func<TResult> onDelete,
        Func<TResult> onOwnership,
        Func<TResult> onBatch,
        Func<TResult> onAccount,
        Func<TResult> onAccountCreated,
        Func<TResult> onAccountUpdated,
        Func<TResult> onPayout,
        Func<TResult> onFee,
        Func<TResult> onChangerequestDeclined,
        Func<TResult> onChangerequestCreated,
        Func<TResult> onChangerequestApproved,
        Func<TResult> onChangerequestManualReview,
        Func<TResult> onChargeback,
        Func<TResult> onChargebackOpened,
        Func<TResult> onChargebackClosed,
        Func<TResult> onChargebackCreated,
        Func<TResult> onChargebackLost,
        Func<TResult> onChargebackWon,
        Func<TResult> onChargebackdocumentUploaded,
        Func<TResult> onDebitDisbursementRecovery,
        Func<TResult> onDisbursementRequested,
        Func<TResult> onDisbursementProcessing,
        Func<TResult> onDisbursementProcessed,
        Func<TResult> onDisbursementFailed,
        Func<TResult> onDisbursementDenied,
        Func<TResult> onDisbursementReport,
        Func<TResult> onDisbursementReturned,
        Func<TResult> onDisbursementEntriesProcessed,
        Func<TResult> onInvoiceCreated,
        Func<TResult> onInvoiceCancelled,
        Func<TResult> onInvoiceEmailed,
        Func<TResult> onInvoiceExpired,
        Func<TResult> onInvoicePaid,
        Func<TResult> onInvoiceRefunded,
        Func<TResult> onInvoiceViewed,
        Func<TResult> onInvoiceResultFailure,
        Func<TResult> onMerchantCreated,
        Func<TResult> onMerchantBoarding,
        Func<TResult> onMerchantBoarded,
        Func<TResult> onMerchantClosed,
        Func<TResult> onMerchantConditionallyApproved,
        Func<TResult> onMerchantFullyBoarded,
        Func<TResult> onMerchantPending,
        Func<TResult> onMerchantReserved,
        Func<TResult> onMerchantIncomplete,
        Func<TResult> onMerchantFailed,
        Func<TResult> onMerchantHeld,
        Func<TResult> onMessageCreated,
        Func<TResult> onPaymentupdateReport,
        Func<TResult> onResourceCreated,
        Func<TResult> onResourceUpdated,
        Func<TResult> onSubscriptionCreated,
        Func<TResult> onSubscriptionApproved,
        Func<TResult> onSubscriptionFailed,
        Func<TResult> onTerminalTxnCreated,
        Func<TResult> onTerminalTxnApproved,
        Func<TResult> onTerminalTxnFailed,
        Func<TResult> onTxnCreated,
        Func<TResult> onTxnApproved,
        Func<TResult> onTxnFailed,
        Func<TResult> onTxnCaptured,
        Func<TResult> onTxnSettled,
        Func<TResult> onTxnReturned,
        Func<TResult> onTxnEcheckFunded,
        Func<TResult> onTxnDelayedFunding,
        Func<TResult> onUpcomingDebitDisbursement,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Create => onCreate(),
            _ when this == Update => onUpdate(),
            _ when this == Delete => onDelete(),
            _ when this == Ownership => onOwnership(),
            _ when this == Batch => onBatch(),
            _ when this == Account => onAccount(),
            _ when this == AccountCreated => onAccountCreated(),
            _ when this == AccountUpdated => onAccountUpdated(),
            _ when this == Payout => onPayout(),
            _ when this == Fee => onFee(),
            _ when this == ChangerequestDeclined => onChangerequestDeclined(),
            _ when this == ChangerequestCreated => onChangerequestCreated(),
            _ when this == ChangerequestApproved => onChangerequestApproved(),
            _ when this == ChangerequestManualReview => onChangerequestManualReview(),
            _ when this == Chargeback => onChargeback(),
            _ when this == ChargebackOpened => onChargebackOpened(),
            _ when this == ChargebackClosed => onChargebackClosed(),
            _ when this == ChargebackCreated => onChargebackCreated(),
            _ when this == ChargebackLost => onChargebackLost(),
            _ when this == ChargebackWon => onChargebackWon(),
            _ when this == ChargebackdocumentUploaded => onChargebackdocumentUploaded(),
            _ when this == DebitDisbursementRecovery => onDebitDisbursementRecovery(),
            _ when this == DisbursementRequested => onDisbursementRequested(),
            _ when this == DisbursementProcessing => onDisbursementProcessing(),
            _ when this == DisbursementProcessed => onDisbursementProcessed(),
            _ when this == DisbursementFailed => onDisbursementFailed(),
            _ when this == DisbursementDenied => onDisbursementDenied(),
            _ when this == DisbursementReport => onDisbursementReport(),
            _ when this == DisbursementReturned => onDisbursementReturned(),
            _ when this == DisbursementEntriesProcessed => onDisbursementEntriesProcessed(),
            _ when this == InvoiceCreated => onInvoiceCreated(),
            _ when this == InvoiceCancelled => onInvoiceCancelled(),
            _ when this == InvoiceEmailed => onInvoiceEmailed(),
            _ when this == InvoiceExpired => onInvoiceExpired(),
            _ when this == InvoicePaid => onInvoicePaid(),
            _ when this == InvoiceRefunded => onInvoiceRefunded(),
            _ when this == InvoiceViewed => onInvoiceViewed(),
            _ when this == InvoiceResultFailure => onInvoiceResultFailure(),
            _ when this == MerchantCreated => onMerchantCreated(),
            _ when this == MerchantBoarding => onMerchantBoarding(),
            _ when this == MerchantBoarded => onMerchantBoarded(),
            _ when this == MerchantClosed => onMerchantClosed(),
            _ when this == MerchantConditionallyApproved => onMerchantConditionallyApproved(),
            _ when this == MerchantFullyBoarded => onMerchantFullyBoarded(),
            _ when this == MerchantPending => onMerchantPending(),
            _ when this == MerchantReserved => onMerchantReserved(),
            _ when this == MerchantIncomplete => onMerchantIncomplete(),
            _ when this == MerchantFailed => onMerchantFailed(),
            _ when this == MerchantHeld => onMerchantHeld(),
            _ when this == MessageCreated => onMessageCreated(),
            _ when this == PaymentupdateReport => onPaymentupdateReport(),
            _ when this == ResourceCreated => onResourceCreated(),
            _ when this == ResourceUpdated => onResourceUpdated(),
            _ when this == SubscriptionCreated => onSubscriptionCreated(),
            _ when this == SubscriptionApproved => onSubscriptionApproved(),
            _ when this == SubscriptionFailed => onSubscriptionFailed(),
            _ when this == TerminalTxnCreated => onTerminalTxnCreated(),
            _ when this == TerminalTxnApproved => onTerminalTxnApproved(),
            _ when this == TerminalTxnFailed => onTerminalTxnFailed(),
            _ when this == TxnCreated => onTxnCreated(),
            _ when this == TxnApproved => onTxnApproved(),
            _ when this == TxnFailed => onTxnFailed(),
            _ when this == TxnCaptured => onTxnCaptured(),
            _ when this == TxnSettled => onTxnSettled(),
            _ when this == TxnReturned => onTxnReturned(),
            _ when this == TxnEcheckFunded => onTxnEcheckFunded(),
            _ when this == TxnDelayedFunding => onTxnDelayedFunding(),
            _ when this == UpcomingDebitDisbursement => onUpcomingDebitDisbursement(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreate,
        Action onUpdate,
        Action onDelete,
        Action onOwnership,
        Action onBatch,
        Action onAccount,
        Action onAccountCreated,
        Action onAccountUpdated,
        Action onPayout,
        Action onFee,
        Action onChangerequestDeclined,
        Action onChangerequestCreated,
        Action onChangerequestApproved,
        Action onChangerequestManualReview,
        Action onChargeback,
        Action onChargebackOpened,
        Action onChargebackClosed,
        Action onChargebackCreated,
        Action onChargebackLost,
        Action onChargebackWon,
        Action onChargebackdocumentUploaded,
        Action onDebitDisbursementRecovery,
        Action onDisbursementRequested,
        Action onDisbursementProcessing,
        Action onDisbursementProcessed,
        Action onDisbursementFailed,
        Action onDisbursementDenied,
        Action onDisbursementReport,
        Action onDisbursementReturned,
        Action onDisbursementEntriesProcessed,
        Action onInvoiceCreated,
        Action onInvoiceCancelled,
        Action onInvoiceEmailed,
        Action onInvoiceExpired,
        Action onInvoicePaid,
        Action onInvoiceRefunded,
        Action onInvoiceViewed,
        Action onInvoiceResultFailure,
        Action onMerchantCreated,
        Action onMerchantBoarding,
        Action onMerchantBoarded,
        Action onMerchantClosed,
        Action onMerchantConditionallyApproved,
        Action onMerchantFullyBoarded,
        Action onMerchantPending,
        Action onMerchantReserved,
        Action onMerchantIncomplete,
        Action onMerchantFailed,
        Action onMerchantHeld,
        Action onMessageCreated,
        Action onPaymentupdateReport,
        Action onResourceCreated,
        Action onResourceUpdated,
        Action onSubscriptionCreated,
        Action onSubscriptionApproved,
        Action onSubscriptionFailed,
        Action onTerminalTxnCreated,
        Action onTerminalTxnApproved,
        Action onTerminalTxnFailed,
        Action onTxnCreated,
        Action onTxnApproved,
        Action onTxnFailed,
        Action onTxnCaptured,
        Action onTxnSettled,
        Action onTxnReturned,
        Action onTxnEcheckFunded,
        Action onTxnDelayedFunding,
        Action onUpcomingDebitDisbursement,
        Action<string> otherwise)
    {
        if (this == Create) onCreate();
        else if (this == Update) onUpdate();
        else if (this == Delete) onDelete();
        else if (this == Ownership) onOwnership();
        else if (this == Batch) onBatch();
        else if (this == Account) onAccount();
        else if (this == AccountCreated) onAccountCreated();
        else if (this == AccountUpdated) onAccountUpdated();
        else if (this == Payout) onPayout();
        else if (this == Fee) onFee();
        else if (this == ChangerequestDeclined) onChangerequestDeclined();
        else if (this == ChangerequestCreated) onChangerequestCreated();
        else if (this == ChangerequestApproved) onChangerequestApproved();
        else if (this == ChangerequestManualReview) onChangerequestManualReview();
        else if (this == Chargeback) onChargeback();
        else if (this == ChargebackOpened) onChargebackOpened();
        else if (this == ChargebackClosed) onChargebackClosed();
        else if (this == ChargebackCreated) onChargebackCreated();
        else if (this == ChargebackLost) onChargebackLost();
        else if (this == ChargebackWon) onChargebackWon();
        else if (this == ChargebackdocumentUploaded) onChargebackdocumentUploaded();
        else if (this == DebitDisbursementRecovery) onDebitDisbursementRecovery();
        else if (this == DisbursementRequested) onDisbursementRequested();
        else if (this == DisbursementProcessing) onDisbursementProcessing();
        else if (this == DisbursementProcessed) onDisbursementProcessed();
        else if (this == DisbursementFailed) onDisbursementFailed();
        else if (this == DisbursementDenied) onDisbursementDenied();
        else if (this == DisbursementReport) onDisbursementReport();
        else if (this == DisbursementReturned) onDisbursementReturned();
        else if (this == DisbursementEntriesProcessed) onDisbursementEntriesProcessed();
        else if (this == InvoiceCreated) onInvoiceCreated();
        else if (this == InvoiceCancelled) onInvoiceCancelled();
        else if (this == InvoiceEmailed) onInvoiceEmailed();
        else if (this == InvoiceExpired) onInvoiceExpired();
        else if (this == InvoicePaid) onInvoicePaid();
        else if (this == InvoiceRefunded) onInvoiceRefunded();
        else if (this == InvoiceViewed) onInvoiceViewed();
        else if (this == InvoiceResultFailure) onInvoiceResultFailure();
        else if (this == MerchantCreated) onMerchantCreated();
        else if (this == MerchantBoarding) onMerchantBoarding();
        else if (this == MerchantBoarded) onMerchantBoarded();
        else if (this == MerchantClosed) onMerchantClosed();
        else if (this == MerchantConditionallyApproved) onMerchantConditionallyApproved();
        else if (this == MerchantFullyBoarded) onMerchantFullyBoarded();
        else if (this == MerchantPending) onMerchantPending();
        else if (this == MerchantReserved) onMerchantReserved();
        else if (this == MerchantIncomplete) onMerchantIncomplete();
        else if (this == MerchantFailed) onMerchantFailed();
        else if (this == MerchantHeld) onMerchantHeld();
        else if (this == MessageCreated) onMessageCreated();
        else if (this == PaymentupdateReport) onPaymentupdateReport();
        else if (this == ResourceCreated) onResourceCreated();
        else if (this == ResourceUpdated) onResourceUpdated();
        else if (this == SubscriptionCreated) onSubscriptionCreated();
        else if (this == SubscriptionApproved) onSubscriptionApproved();
        else if (this == SubscriptionFailed) onSubscriptionFailed();
        else if (this == TerminalTxnCreated) onTerminalTxnCreated();
        else if (this == TerminalTxnApproved) onTerminalTxnApproved();
        else if (this == TerminalTxnFailed) onTerminalTxnFailed();
        else if (this == TxnCreated) onTxnCreated();
        else if (this == TxnApproved) onTxnApproved();
        else if (this == TxnFailed) onTxnFailed();
        else if (this == TxnCaptured) onTxnCaptured();
        else if (this == TxnSettled) onTxnSettled();
        else if (this == TxnReturned) onTxnReturned();
        else if (this == TxnEcheckFunded) onTxnEcheckFunded();
        else if (this == TxnDelayedFunding) onTxnDelayedFunding();
        else if (this == UpcomingDebitDisbursement) onUpcomingDebitDisbursement();
        else otherwise(Value);
    }
}
