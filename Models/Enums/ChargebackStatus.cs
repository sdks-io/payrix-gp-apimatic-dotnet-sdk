using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChargebackStatus>))]
public sealed record ChargebackStatus : OpenStringEnum<ChargebackStatus>
{
    private ChargebackStatus(string value) : base(value)
    {
    }

    public static readonly ChargebackStatus Open = new("open");

    public static readonly ChargebackStatus Closed = new("closed");

    public static readonly ChargebackStatus Won = new("won");

    public static readonly ChargebackStatus Lost = new("lost");

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
