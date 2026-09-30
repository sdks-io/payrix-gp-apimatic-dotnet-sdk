using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BinsPinlessSupport>))]
public sealed record BinsPinlessSupport : OpenStringEnum<BinsPinlessSupport>
{
    private BinsPinlessSupport(string value) : base(value)
    {
    }

    public static readonly BinsPinlessSupport None = new("none");

    public static readonly BinsPinlessSupport Restricted = new("restricted");

    public static readonly BinsPinlessSupport Full = new("full");

    public TResult Match<TResult>(Func<TResult> onNone,
        Func<TResult> onRestricted,
        Func<TResult> onFull,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == None => onNone(),
            _ when this == Restricted => onRestricted(),
            _ when this == Full => onFull(),
            _ => otherwise(Value)
        };

    public void Match(Action onNone, Action onRestricted, Action onFull, Action<string> otherwise)
    {
        if (this == None) onNone();
        else if (this == Restricted) onRestricted();
        else if (this == Full) onFull();
        else otherwise(Value);
    }
}
