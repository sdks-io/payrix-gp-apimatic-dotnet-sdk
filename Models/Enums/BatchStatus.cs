using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BatchStatus>))]
public sealed record BatchStatus : OpenStringEnum<BatchStatus>
{
    private BatchStatus(string value) : base(value)
    {
    }

    public static readonly BatchStatus Open = new("open");

    public static readonly BatchStatus Closed = new("closed");

    public TResult Match<TResult>(Func<TResult> onOpen, Func<TResult> onClosed, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Open => onOpen(),
            _ when this == Closed => onClosed(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpen, Action onClosed, Action<string> otherwise)
    {
        if (this == Open) onOpen();
        else if (this == Closed) onClosed();
        else otherwise(Value);
    }
}
