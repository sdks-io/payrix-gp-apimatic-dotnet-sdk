using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether this resource is incoming or outgoing.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>incoming</c> - <b>Incoming messages is assigned.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>outgoing</c> - <b>Outgoing message is assigned.</b></description></item>
/// </list>
/// <para>
///   &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MessageType1>))]
public sealed record MessageType1 : OpenStringEnum<MessageType1>
{
    private MessageType1(string value) : base(value)
    {
    }

    public static readonly MessageType1 Incoming = new("incoming");

    public static readonly MessageType1 Outgoing = new("outgoing");

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
