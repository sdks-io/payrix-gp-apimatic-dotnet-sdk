using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The Chargeback's status. &lt;details&gt;&lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>open</c> - <b>Chargeback is open, responses may be submitted.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>closed</c> - <b>Chargeback is closed, responses may no longer be submitted.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>won</c> - <b>Chargeback won.</b></description></item>
///   <item><description><c>lost</c> - <b>Chargeback lost.</b></description></item>
/// </list>
/// <para>
///  &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChargebackStatusesStatus1>))]
public sealed record ChargebackStatusesStatus1 : OpenStringEnum<ChargebackStatusesStatus1>
{
    private ChargebackStatusesStatus1(string value) : base(value)
    {
    }

    public static readonly ChargebackStatusesStatus1 Open = new("open");

    public static readonly ChargebackStatusesStatus1 Closed = new("closed");

    public static readonly ChargebackStatusesStatus1 Won = new("won");

    public static readonly ChargebackStatusesStatus1 Lost = new("lost");

    public TResult Match<TResult>(Func<TResult> onOpen,
        Func<TResult> onClosed,
        Func<TResult> onWon,
        Func<TResult> onLost,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Open => onOpen(),
            _ when this == Closed => onClosed(),
            _ when this == Won => onWon(),
            _ when this == Lost => onLost(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpen, Action onClosed, Action onWon, Action onLost, Action<string> otherwise)
    {
        if (this == Open) onOpen();
        else if (this == Closed) onClosed();
        else if (this == Won) onWon();
        else if (this == Lost) onLost();
        else otherwise(Value);
    }
}
