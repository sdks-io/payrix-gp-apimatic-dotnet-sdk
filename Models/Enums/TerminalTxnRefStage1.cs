using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// An indicator showing what this terminalTxnRef refers to.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>activation</c> - <b>Terminal Activation</b></description></item>
///   <item><description><c>auth</c> - <b>Transaction Authorization</b></description></item>
///   <item><description><c>draft</c> - <b>Transaction Draft Number</b></description></item>
///   <item><description><c>file</c> - <b>Import File Ref</b></description></item>
///   <item><description><c>retrieval</c> - <b>Transaction Retrieval Number</b></description></item>
///   <item><description><c>acquirerTxnId</c> - <b>A unique identifier created by the acquirer to track and reconcile a specific transaction throughout its lifecycle.</b></description></item>
///   <item><description><c>origTxnId</c> - <b>The identifier of the original transaction, used to link related actions such as refunds, reversals, or adjustments back to the initial payment.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalTxnRefStage1>))]
public sealed record TerminalTxnRefStage1 : OpenStringEnum<TerminalTxnRefStage1>
{
    private TerminalTxnRefStage1(string value) : base(value)
    {
    }

    public static readonly TerminalTxnRefStage1 Activation = new("activation");

    public static readonly TerminalTxnRefStage1 Auth = new("auth");

    public static readonly TerminalTxnRefStage1 Draft = new("draft");

    public static readonly TerminalTxnRefStage1 File = new("file");

    public static readonly TerminalTxnRefStage1 Retrieval = new("retrieval");

    public static readonly TerminalTxnRefStage1 AcquirerTxnId = new("acquirerTxnId");

    public static readonly TerminalTxnRefStage1 OrigTxnId = new("origTxnId");

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
