using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// An indicator showing what this txnRef refers to, such as auth, capture, draft, file, refund, or an unknown value.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>auth</c>  -  <b>Related to transaction authorization stage.</b></description></item>
///   <item><description><c>capture</c>  -  <b>Related to transaction capture stage.</b></description></item>
///   <item><description><c>draft</c>  -  <b>Transaction is in draft stage. Draft locator for transaction.</b></description></item>
///   <item><description><c>file</c>  -  <b>Import Transaction Reference file.</b></description></item>
///   <item><description><c>refund</c>  -  <b>Related to transaction refund stage.</b></description></item>
///   <item><description><c>retrieval</c>  -  <b>A reference to the retrieval number (a reference exchanged with the processor for later cross-reference).</b></description></item>
///   <item><description><c>threatMetrix</c>  -  <b>Threat Matrix.</b></description></item>
///   <item><description><c>acquirerTxnId</c>  -  <b>A unique identifier created by the acquirer to track and reconcile a specific transaction throughout its lifecycle.</b></description></item>
///   <item><description><c>origTxnId</c>  -  <b>The identifier of the original transaction, used to link related actions such as refunds, reversals, or adjustments back to the initial payment.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TxnRefStage1>))]
public sealed record TxnRefStage1 : OpenStringEnum<TxnRefStage1>
{
    private TxnRefStage1(string value) : base(value)
    {
    }

    public static readonly TxnRefStage1 Auth = new("auth");

    public static readonly TxnRefStage1 Capture = new("capture");

    public static readonly TxnRefStage1 Draft = new("draft");

    public static readonly TxnRefStage1 File = new("file");

    public static readonly TxnRefStage1 Network = new("network");

    public static readonly TxnRefStage1 Refund = new("refund");

    public static readonly TxnRefStage1 Retrieval = new("retrieval");

    public static readonly TxnRefStage1 ThreatMetrix = new("threatMetrix");

    public static readonly TxnRefStage1 TxnHash = new("txnHash");

    public static readonly TxnRefStage1 Arn = new("ARN");

    public static readonly TxnRefStage1 AcquirerTxnId = new("acquirerTxnId");

    public static readonly TxnRefStage1 OrigTxnId = new("origTxnId");

    public TResult Match<TResult>(Func<TResult> onAuth,
        Func<TResult> onCapture,
        Func<TResult> onDraft,
        Func<TResult> onFile,
        Func<TResult> onNetwork,
        Func<TResult> onRefund,
        Func<TResult> onRetrieval,
        Func<TResult> onThreatMetrix,
        Func<TResult> onTxnHash,
        Func<TResult> onArn,
        Func<TResult> onAcquirerTxnId,
        Func<TResult> onOrigTxnId,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Auth => onAuth(),
            _ when this == Capture => onCapture(),
            _ when this == Draft => onDraft(),
            _ when this == File => onFile(),
            _ when this == Network => onNetwork(),
            _ when this == Refund => onRefund(),
            _ when this == Retrieval => onRetrieval(),
            _ when this == ThreatMetrix => onThreatMetrix(),
            _ when this == TxnHash => onTxnHash(),
            _ when this == Arn => onArn(),
            _ when this == AcquirerTxnId => onAcquirerTxnId(),
            _ when this == OrigTxnId => onOrigTxnId(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuth,
        Action onCapture,
        Action onDraft,
        Action onFile,
        Action onNetwork,
        Action onRefund,
        Action onRetrieval,
        Action onThreatMetrix,
        Action onTxnHash,
        Action onArn,
        Action onAcquirerTxnId,
        Action onOrigTxnId,
        Action<string> otherwise)
    {
        if (this == Auth) onAuth();
        else if (this == Capture) onCapture();
        else if (this == Draft) onDraft();
        else if (this == File) onFile();
        else if (this == Network) onNetwork();
        else if (this == Refund) onRefund();
        else if (this == Retrieval) onRetrieval();
        else if (this == ThreatMetrix) onThreatMetrix();
        else if (this == TxnHash) onTxnHash();
        else if (this == Arn) onArn();
        else if (this == AcquirerTxnId) onAcquirerTxnId();
        else if (this == OrigTxnId) onOrigTxnId();
        else otherwise(Value);
    }
}
