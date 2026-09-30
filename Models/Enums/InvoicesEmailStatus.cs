using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InvoicesEmailStatus>))]
public sealed record InvoicesEmailStatus : OpenStringEnum<InvoicesEmailStatus>
{
    private InvoicesEmailStatus(string value) : base(value)
    {
    }

    public static readonly InvoicesEmailStatus Send = new("send");

    public static readonly InvoicesEmailStatus Sent = new("sent");

    public static readonly InvoicesEmailStatus Pending = new("pending");

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
