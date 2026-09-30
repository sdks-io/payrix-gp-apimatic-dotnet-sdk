using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of the invoice.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>send</c> - <b>Updated email status to indicate the invoice is ready to be sent to the customer.</b></description></item>
///   <item><description><c>sent</c> - <b>Updated email status once the invoice is sent to the customer.</b></description></item>
///   <item><description><c>pending</c> - <b>Updated email status pending</b></description></item>
/// </list>
/// <para>
///   &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoicesEmailStatus1>))]
public sealed record InvoicesEmailStatus1 : OpenStringEnum<InvoicesEmailStatus1>
{
    private InvoicesEmailStatus1(string value) : base(value)
    {
    }

    public static readonly InvoicesEmailStatus1 Send = new("send");

    public static readonly InvoicesEmailStatus1 Sent = new("sent");

    public static readonly InvoicesEmailStatus1 Pending = new("pending");

    public TResult Match<TResult>(Func<TResult> onSend,
        Func<TResult> onSent,
        Func<TResult> onPending,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Send => onSend(),
            _ when this == Sent => onSent(),
            _ when this == Pending => onPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onSend, Action onSent, Action onPending, Action<string> otherwise)
    {
        if (this == Send) onSend();
        else if (this == Sent) onSent();
        else if (this == Pending) onPending();
        else otherwise(Value);
    }
}
