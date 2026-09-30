using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TokenStatus>))]
public sealed record TokenStatus : OpenStringEnum<TokenStatus>
{
    private TokenStatus(string value) : base(value)
    {
    }

    public static readonly TokenStatus Pending = new("pending");

    public static readonly TokenStatus Ready = new("ready");

    public TResult Match<TResult>(Func<TResult> onPending, Func<TResult> onReady, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Ready => onReady(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onReady, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Ready) onReady();
        else otherwise(Value);
    }
}
