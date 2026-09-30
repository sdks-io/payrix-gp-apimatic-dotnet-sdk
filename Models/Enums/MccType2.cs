using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Type. Indicates if the Mcc is blacklisted/whitelisted.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>blacklist</c> - <b>Indicates if the Mcc is blacklisted.</b></description></item>
///   <item><description><c>whitelist</c> - <b>Indicates if the Mcc is whitelisted.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MccType2>))]
public sealed record MccType2 : OpenStringEnum<MccType2>
{
    private MccType2(string value) : base(value)
    {
    }

    public static readonly MccType2 Blacklist = new("blacklist");

    public static readonly MccType2 Whitelist = new("whitelist");

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
