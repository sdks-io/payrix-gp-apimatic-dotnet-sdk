using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// What type of pinless charging is allowed on this debit card.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>none</c> - <b>No pinless support, PIN (Personal Identification Number) must always be provided.</b></description></item>
///   <item><description><c>restricted</c> - <b>Some pinless support, PIN (Personal Identification Number) may not always be necessary.</b></description></item>
///   <item><description><c>full</c> - <b>Full pinless support, PIN (Personal Identification Number) may be omitted for pinless payments.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BinsPinlessSupport1>))]
public sealed record BinsPinlessSupport1 : OpenStringEnum<BinsPinlessSupport1>
{
    private BinsPinlessSupport1(string value) : base(value)
    {
    }

    public static readonly BinsPinlessSupport1 None = new("none");

    public static readonly BinsPinlessSupport1 Restricted = new("restricted");

    public static readonly BinsPinlessSupport1 Full = new("full");

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
