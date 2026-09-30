using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of the statement.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>pending</c> - <b>Statement amount is owed and is pending payment.</b></description></item>
///   <item><description><c>processing</c> - <b>A payment is processing for this statement, pending completion.</b></description></item>
///   <item><description><c>partiallyPaid</c> - <b>The statement was partially paid, some amount is still outstanding.</b></description></item>
///   <item><description><c>paid</c> - <b>The statement was paid in full.</b></description></item>
///   <item><description><c>partiallyCancelled</c> - <b>The statement was partially cancelled, some amount is still outstanding.</b></description></item>
///   <item><description><c>cancelled</c> - <b>The statement was completely cancelled and is no longer due for payment.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatementStatus1>))]
public sealed record StatementStatus1 : OpenStringEnum<StatementStatus1>
{
    private StatementStatus1(string value) : base(value)
    {
    }

    public static readonly StatementStatus1 Pending = new("pending");

    public static readonly StatementStatus1 Processing = new("processing");

    public static readonly StatementStatus1 PartiallyPaid = new("partiallyPaid");

    public static readonly StatementStatus1 Paid = new("paid");

    public static readonly StatementStatus1 PartiallyCancelled = new("partiallyCancelled");

    public static readonly StatementStatus1 Cancelled = new("cancelled");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onProcessing,
        Func<TResult> onPartiallyPaid,
        Func<TResult> onPaid,
        Func<TResult> onPartiallyCancelled,
        Func<TResult> onCancelled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Processing => onProcessing(),
            _ when this == PartiallyPaid => onPartiallyPaid(),
            _ when this == Paid => onPaid(),
            _ when this == PartiallyCancelled => onPartiallyCancelled(),
            _ when this == Cancelled => onCancelled(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onProcessing,
        Action onPartiallyPaid,
        Action onPaid,
        Action onPartiallyCancelled,
        Action onCancelled,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Processing) onProcessing();
        else if (this == PartiallyPaid) onPartiallyPaid();
        else if (this == Paid) onPaid();
        else if (this == PartiallyCancelled) onPartiallyCancelled();
        else if (this == Cancelled) onCancelled();
        else otherwise(Value);
    }
}
