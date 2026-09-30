using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of this merchant result
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>general</c> - <b>General use for unspecified type.</b></description></item>
///   <item><description><c>internal</c> - <b>An internal failure result message.</b></description></item>
///   <item><description><c>data</c> - <b>Missing merchant boarding related data failure message.</b></description></item>
///   <item><description><c>legal</c> - <b>Result message related to legal matters.</b></description></item>
///   <item><description><c>denial</c> - <b>Merchant boarding denial result message.</b></description></item>
///   <item><description><c>platform</c> - <b>Processor boarding failure result message.</b></description></item>
///   <item><description><c>platformNote</c> - <b>Processor note from merchant boarding.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantType2>))]
public sealed record MerchantType2 : OpenStringEnum<MerchantType2>
{
    private MerchantType2(string value) : base(value)
    {
    }

    public static readonly MerchantType2 General = new("general");

    public static readonly MerchantType2 Internal = new("internal");

    public static readonly MerchantType2 Data = new("data");

    public static readonly MerchantType2 Legal = new("legal");

    public static readonly MerchantType2 Denial = new("denial");

    public static readonly MerchantType2 Platform = new("platform");

    public static readonly MerchantType2 PlatformNote = new("platformNote");

    public TResult Match<TResult>(Func<TResult> onGeneral,
        Func<TResult> onInternal,
        Func<TResult> onData,
        Func<TResult> onLegal,
        Func<TResult> onDenial,
        Func<TResult> onPlatform,
        Func<TResult> onPlatformNote,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == General => onGeneral(),
            _ when this == Internal => onInternal(),
            _ when this == Data => onData(),
            _ when this == Legal => onLegal(),
            _ when this == Denial => onDenial(),
            _ when this == Platform => onPlatform(),
            _ when this == PlatformNote => onPlatformNote(),
            _ => otherwise(Value)
        };

    public void Match(Action onGeneral,
        Action onInternal,
        Action onData,
        Action onLegal,
        Action onDenial,
        Action onPlatform,
        Action onPlatformNote,
        Action<string> otherwise)
    {
        if (this == General) onGeneral();
        else if (this == Internal) onInternal();
        else if (this == Data) onData();
        else if (this == Legal) onLegal();
        else if (this == Denial) onDenial();
        else if (this == Platform) onPlatform();
        else if (this == PlatformNote) onPlatformNote();
        else otherwise(Value);
    }
}
