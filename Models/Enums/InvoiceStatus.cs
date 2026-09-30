using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InvoiceStatus>))]
public sealed record InvoiceStatus : OpenStringEnum<InvoiceStatus>
{
    private InvoiceStatus(string value) : base(value)
    {
    }

    public static readonly InvoiceStatus Pending = new("pending");

    public static readonly InvoiceStatus Cancelled = new("cancelled");

    public static readonly InvoiceStatus Expired = new("expired");

    public static readonly InvoiceStatus Viewed = new("viewed");

    public static readonly InvoiceStatus Paid = new("paid");

    public static readonly InvoiceStatus Confirmed = new("confirmed");

    public static readonly InvoiceStatus Refunded = new("refunded");

    public static readonly InvoiceStatus Rejected = new("rejected");

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
