using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MerchantType>))]
public sealed record MerchantType : OpenStringEnum<MerchantType>
{
    private MerchantType(string value) : base(value)
    {
    }

    public static readonly MerchantType General = new("general");

    public static readonly MerchantType Internal = new("internal");

    public static readonly MerchantType Data = new("data");

    public static readonly MerchantType Legal = new("legal");

    public static readonly MerchantType Denial = new("denial");

    public static readonly MerchantType Platform = new("platform");

    public static readonly MerchantType PlatformNote = new("platformNote");

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
