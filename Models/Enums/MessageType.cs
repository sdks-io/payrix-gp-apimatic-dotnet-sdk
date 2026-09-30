using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MessageType>))]
public sealed record MessageType : OpenStringEnum<MessageType>
{
    private MessageType(string value) : base(value)
    {
    }

    public static readonly MessageType Incoming = new("incoming");

    public static readonly MessageType Outgoing = new("outgoing");

    public TResult Match<TResult>(Func<TResult> onIncoming,
        Func<TResult> onOutgoing,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Incoming => onIncoming(),
            _ when this == Outgoing => onOutgoing(),
            _ => otherwise(Value)
        };

    public void Match(Action onIncoming, Action onOutgoing, Action<string> otherwise)
    {
        if (this == Incoming) onIncoming();
        else if (this == Outgoing) onOutgoing();
        else otherwise(Value);
    }
}
