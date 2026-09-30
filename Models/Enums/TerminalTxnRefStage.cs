using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalTxnRefStage>))]
public sealed record TerminalTxnRefStage : OpenStringEnum<TerminalTxnRefStage>
{
    private TerminalTxnRefStage(string value) : base(value)
    {
    }

    public static readonly TerminalTxnRefStage Activation = new("activation");

    public static readonly TerminalTxnRefStage Auth = new("auth");

    public static readonly TerminalTxnRefStage Draft = new("draft");

    public static readonly TerminalTxnRefStage File = new("file");

    public static readonly TerminalTxnRefStage Retrieval = new("retrieval");

    public static readonly TerminalTxnRefStage AcquirerTxnId = new("acquirerTxnId");

    public static readonly TerminalTxnRefStage OrigTxnId = new("origTxnId");

    public TResult Match<TResult>(Func<TResult> onActivation,
        Func<TResult> onAuth,
        Func<TResult> onDraft,
        Func<TResult> onFile,
        Func<TResult> onRetrieval,
        Func<TResult> onAcquirerTxnId,
        Func<TResult> onOrigTxnId,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Activation => onActivation(),
            _ when this == Auth => onAuth(),
            _ when this == Draft => onDraft(),
            _ when this == File => onFile(),
            _ when this == Retrieval => onRetrieval(),
            _ when this == AcquirerTxnId => onAcquirerTxnId(),
            _ when this == OrigTxnId => onOrigTxnId(),
            _ => otherwise(Value)
        };

    public void Match(Action onActivation,
        Action onAuth,
        Action onDraft,
        Action onFile,
        Action onRetrieval,
        Action onAcquirerTxnId,
        Action onOrigTxnId,
        Action<string> otherwise)
    {
        if (this == Activation) onActivation();
        else if (this == Auth) onAuth();
        else if (this == Draft) onDraft();
        else if (this == File) onFile();
        else if (this == Retrieval) onRetrieval();
        else if (this == AcquirerTxnId) onAcquirerTxnId();
        else if (this == OrigTxnId) onOrigTxnId();
        else otherwise(Value);
    }
}
