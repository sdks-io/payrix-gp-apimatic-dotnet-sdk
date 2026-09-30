using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AlertTriggerEvent>))]
public sealed record AlertTriggerEvent : OpenStringEnum<AlertTriggerEvent>
{
    private AlertTriggerEvent(string value) : base(value)
    {
    }

    public static readonly AlertTriggerEvent Create = new("create");

    public static readonly AlertTriggerEvent Update = new("update");

    public static readonly AlertTriggerEvent Delete = new("delete");

    public static readonly AlertTriggerEvent Ownership = new("ownership");

    public static readonly AlertTriggerEvent Batch = new("batch");

    public static readonly AlertTriggerEvent Account = new("account");

    public static readonly AlertTriggerEvent AccountCreated = new("account.created");

    public static readonly AlertTriggerEvent AccountUpdated = new("account.updated");

    public static readonly AlertTriggerEvent Payout = new("payout");

    public static readonly AlertTriggerEvent Fee = new("fee");

    public static readonly AlertTriggerEvent ChangerequestDeclined = new("changerequest.declined");

    public static readonly AlertTriggerEvent ChangerequestCreated = new("changerequest.created");

    public static readonly AlertTriggerEvent ChangerequestApproved = new("changerequest.approved");

    public static readonly AlertTriggerEvent ChangerequestManualReview = new("changerequest.manualReview");

    public static readonly AlertTriggerEvent Chargeback = new("chargeback");

    public static readonly AlertTriggerEvent ChargebackOpened = new("chargeback.opened");

    public static readonly AlertTriggerEvent ChargebackClosed = new("chargeback.closed");

    public static readonly AlertTriggerEvent ChargebackCreated = new("chargeback.created");

    public static readonly AlertTriggerEvent ChargebackLost = new("chargeback.lost");

    public static readonly AlertTriggerEvent ChargebackWon = new("chargeback.won");

    public static readonly AlertTriggerEvent ChargebackdocumentUploaded = new("chargebackdocument.uploaded");

    public static readonly AlertTriggerEvent DebitDisbursementRecovery = new("debit.disbursement.recovery");

    public static readonly AlertTriggerEvent DisbursementRequested = new("disbursement.requested");

    public static readonly AlertTriggerEvent DisbursementProcessing = new("disbursement.processing");

    public static readonly AlertTriggerEvent DisbursementProcessed = new("disbursement.processed");

    public static readonly AlertTriggerEvent DisbursementFailed = new("disbursement.failed");

    public static readonly AlertTriggerEvent DisbursementDenied = new("disbursement.denied");

    public static readonly AlertTriggerEvent DisbursementReport = new("disbursement.report");

    public static readonly AlertTriggerEvent DisbursementReturned = new("disbursement.returned");

    public static readonly AlertTriggerEvent DisbursementEntriesProcessed = new("disbursementEntries.processed");

    public static readonly AlertTriggerEvent InvoiceCreated = new("invoice.created");

    public static readonly AlertTriggerEvent InvoiceCancelled = new("invoice.cancelled");

    public static readonly AlertTriggerEvent InvoiceEmailed = new("invoice.emailed");

    public static readonly AlertTriggerEvent InvoiceExpired = new("invoice.expired");

    public static readonly AlertTriggerEvent InvoicePaid = new("invoice.paid");

    public static readonly AlertTriggerEvent InvoiceRefunded = new("invoice.refunded");

    public static readonly AlertTriggerEvent InvoiceViewed = new("invoice.viewed");

    public static readonly AlertTriggerEvent InvoiceResultFailure = new("invoiceResult.failure");

    public static readonly AlertTriggerEvent MerchantCreated = new("merchant.created");

    public static readonly AlertTriggerEvent MerchantBoarding = new("merchant.boarding");

    public static readonly AlertTriggerEvent MerchantBoarded = new("merchant.boarded");

    public static readonly AlertTriggerEvent MerchantClosed = new("merchant.closed");

    public static readonly AlertTriggerEvent MerchantConditionallyApproved = new("merchant.conditionally.approved");

    public static readonly AlertTriggerEvent MerchantFullyBoarded = new("merchant.fully.boarded");

    public static readonly AlertTriggerEvent MerchantPending = new("merchant.pending");

    public static readonly AlertTriggerEvent MerchantReserved = new("merchant.reserved");

    public static readonly AlertTriggerEvent MerchantIncomplete = new("merchant.incomplete");

    public static readonly AlertTriggerEvent MerchantFailed = new("merchant.failed");

    public static readonly AlertTriggerEvent MerchantHeld = new("merchant.held");

    public static readonly AlertTriggerEvent MessageCreated = new("message.created");

    public static readonly AlertTriggerEvent PaymentupdateReport = new("paymentupdate.report");

    public static readonly AlertTriggerEvent ResourceCreated = new("resource.created");

    public static readonly AlertTriggerEvent ResourceUpdated = new("resource.updated");

    public static readonly AlertTriggerEvent SubscriptionCreated = new("subscription.created");

    public static readonly AlertTriggerEvent SubscriptionApproved = new("subscription.approved");

    public static readonly AlertTriggerEvent SubscriptionFailed = new("subscription.failed");

    public static readonly AlertTriggerEvent TerminalTxnCreated = new("terminalTxn.created");

    public static readonly AlertTriggerEvent TerminalTxnApproved = new("terminalTxn.approved");

    public static readonly AlertTriggerEvent TerminalTxnFailed = new("terminalTxn.failed");

    public static readonly AlertTriggerEvent TxnCreated = new("txn.created");

    public static readonly AlertTriggerEvent TxnApproved = new("txn.approved");

    public static readonly AlertTriggerEvent TxnFailed = new("txn.failed");

    public static readonly AlertTriggerEvent TxnCaptured = new("txn.captured");

    public static readonly AlertTriggerEvent TxnSettled = new("txn.settled");

    public static readonly AlertTriggerEvent TxnReturned = new("txn.returned");

    public static readonly AlertTriggerEvent TxnEcheckFunded = new("txn.echeck.funded");

    public static readonly AlertTriggerEvent TxnDelayedFunding = new("txn.delayed.funding");

    public static readonly AlertTriggerEvent UpcomingDebitDisbursement = new("upcoming.debit.disbursement");

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
