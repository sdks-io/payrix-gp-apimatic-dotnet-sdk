using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of the transaction.
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
///  - <c>pending</c> - <b>Pending</b>
///  - <c>cancelled</c> - <b>Cancelled</b>
///  - <c>expired</c> - <b>Expired</b>
///  - <c>viewed</c> - <b>Viewed</b>
///  - <c>paid</c> - <b>Paid</b>
///  - <c>confirmed</c> - <b>Confirmed</b>
///  - <c>refunded</c> - <b>Refunded</b>
///  - <c>rejected</c> - <b>Rejected</b>
///  &lt;/details&gt;
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceStatus1>))]
public sealed record InvoiceStatus1 : OpenStringEnum<InvoiceStatus1>
{
    private InvoiceStatus1(string value) : base(value)
    {
    }

    public static readonly InvoiceStatus1 Pending = new("pending");

    public static readonly InvoiceStatus1 Cancelled = new("cancelled");

    public static readonly InvoiceStatus1 Expired = new("expired");

    public static readonly InvoiceStatus1 Viewed = new("viewed");

    public static readonly InvoiceStatus1 Paid = new("paid");

    public static readonly InvoiceStatus1 Confirmed = new("confirmed");

    public static readonly InvoiceStatus1 Refunded = new("refunded");

    public static readonly InvoiceStatus1 Rejected = new("rejected");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onCancelled,
        Func<TResult> onExpired,
        Func<TResult> onViewed,
        Func<TResult> onPaid,
        Func<TResult> onConfirmed,
        Func<TResult> onRefunded,
        Func<TResult> onRejected,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Cancelled => onCancelled(),
            _ when this == Expired => onExpired(),
            _ when this == Viewed => onViewed(),
            _ when this == Paid => onPaid(),
            _ when this == Confirmed => onConfirmed(),
            _ when this == Refunded => onRefunded(),
            _ when this == Rejected => onRejected(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onCancelled,
        Action onExpired,
        Action onViewed,
        Action onPaid,
        Action onConfirmed,
        Action onRefunded,
        Action onRejected,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Cancelled) onCancelled();
        else if (this == Expired) onExpired();
        else if (this == Viewed) onViewed();
        else if (this == Paid) onPaid();
        else if (this == Confirmed) onConfirmed();
        else if (this == Refunded) onRefunded();
        else if (this == Rejected) onRejected();
        else otherwise(Value);
    }
}
