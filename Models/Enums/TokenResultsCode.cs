using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TokenResultsCode>))]
public sealed record TokenResultsCode : OpenStringEnum<TokenResultsCode>
{
    private TokenResultsCode(string value) : base(value)
    {
    }

    public static readonly TokenResultsCode OmnitokenMinting = new("omnitokenMinting");

    public static readonly TokenResultsCode OmnitokenLookup = new("omnitokenLookup");

    public static readonly TokenResultsCode OmnitokenUsage = new("omnitokenUsage");

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
