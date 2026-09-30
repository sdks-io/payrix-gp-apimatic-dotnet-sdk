using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MccType>))]
public sealed record MccType : OpenStringEnum<MccType>
{
    private MccType(string value) : base(value)
    {
    }

    public static readonly MccType Blacklist = new("blacklist");

    public static readonly MccType Whitelist = new("whitelist");

    public TResult Match<TResult>(Func<TResult> onBlacklist,
        Func<TResult> onWhitelist,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Blacklist => onBlacklist(),
            _ when this == Whitelist => onWhitelist(),
            _ => otherwise(Value)
        };

    public void Match(Action onBlacklist, Action onWhitelist, Action<string> otherwise)
    {
        if (this == Blacklist) onBlacklist();
        else if (this == Whitelist) onWhitelist();
        else otherwise(Value);
    }
}
