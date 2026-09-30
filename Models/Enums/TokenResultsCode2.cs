using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The code type of the tokenResult.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>omnitokenMinting</c> - <b>Indicates omnitoken minting event</b></description></item>
///   <item><description><c>omnitokenLookup</c> - <b>Indicates omnitoken lookup event</b></description></item>
///   <item><description><c>omnitokenUsage</c> - <b>Indicates omnitoken usage event</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TokenResultsCode2>))]
public sealed record TokenResultsCode2 : OpenStringEnum<TokenResultsCode2>
{
    private TokenResultsCode2(string value) : base(value)
    {
    }

    public static readonly TokenResultsCode2 OmnitokenMinting = new("omnitokenMinting");

    public static readonly TokenResultsCode2 OmnitokenLookup = new("omnitokenLookup");

    public static readonly TokenResultsCode2 OmnitokenUsage = new("omnitokenUsage");

    public TResult Match<TResult>(Func<TResult> onOmnitokenMinting,
        Func<TResult> onOmnitokenLookup,
        Func<TResult> onOmnitokenUsage,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OmnitokenMinting => onOmnitokenMinting(),
            _ when this == OmnitokenLookup => onOmnitokenLookup(),
            _ when this == OmnitokenUsage => onOmnitokenUsage(),
            _ => otherwise(Value)
        };

    public void Match(Action onOmnitokenMinting,
        Action onOmnitokenLookup,
        Action onOmnitokenUsage,
        Action<string> otherwise)
    {
        if (this == OmnitokenMinting) onOmnitokenMinting();
        else if (this == OmnitokenLookup) onOmnitokenLookup();
        else if (this == OmnitokenUsage) onOmnitokenUsage();
        else otherwise(Value);
    }
}
