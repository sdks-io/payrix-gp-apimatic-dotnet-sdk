using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TxnRefStage>))]
public sealed record TxnRefStage : OpenStringEnum<TxnRefStage>
{
    private TxnRefStage(string value) : base(value)
    {
    }

    public static readonly TxnRefStage Auth = new("auth");

    public static readonly TxnRefStage Capture = new("capture");

    public static readonly TxnRefStage Draft = new("draft");

    public static readonly TxnRefStage File = new("file");

    public static readonly TxnRefStage Network = new("network");

    public static readonly TxnRefStage Refund = new("refund");

    public static readonly TxnRefStage Retrieval = new("retrieval");

    public static readonly TxnRefStage ThreatMetrix = new("threatMetrix");

    public static readonly TxnRefStage TxnHash = new("txnHash");

    public static readonly TxnRefStage Arn = new("ARN");

    public static readonly TxnRefStage AcquirerTxnId = new("acquirerTxnId");

    public static readonly TxnRefStage OrigTxnId = new("origTxnId");

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
