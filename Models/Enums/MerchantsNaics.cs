using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MerchantsNaics>))]
public sealed record MerchantsNaics : OpenStringEnum<MerchantsNaics>
{
    private MerchantsNaics(string value) : base(value)
    {
    }

    public static readonly MerchantsNaics _11 = new("11");

    public static readonly MerchantsNaics _21 = new("21");

    public static readonly MerchantsNaics _22 = new("22");

    public static readonly MerchantsNaics _23 = new("23");

    public static readonly MerchantsNaics _3133 = new("31-33");

    public static readonly MerchantsNaics _41 = new("41");

    public static readonly MerchantsNaics _4445 = new("44-45");

    public static readonly MerchantsNaics _4849 = new("48-49");

    public static readonly MerchantsNaics _51 = new("51");

    public static readonly MerchantsNaics _52 = new("52");

    public static readonly MerchantsNaics _53 = new("53");

    public static readonly MerchantsNaics _54 = new("54");

    public static readonly MerchantsNaics _55 = new("55");

    public static readonly MerchantsNaics _56 = new("56");

    public static readonly MerchantsNaics _61 = new("61");

    public static readonly MerchantsNaics _62 = new("62");

    public static readonly MerchantsNaics _71 = new("71");

    public static readonly MerchantsNaics _72 = new("72");

    public static readonly MerchantsNaics _81 = new("81");

    public static readonly MerchantsNaics _9192 = new("91/92");

    public TResult Match<TResult>(Func<TResult> on_11,
        Func<TResult> on_21,
        Func<TResult> on_22,
        Func<TResult> on_23,
        Func<TResult> on_3133,
        Func<TResult> on_41,
        Func<TResult> on_4445,
        Func<TResult> on_4849,
        Func<TResult> on_51,
        Func<TResult> on_52,
        Func<TResult> on_53,
        Func<TResult> on_54,
        Func<TResult> on_55,
        Func<TResult> on_56,
        Func<TResult> on_61,
        Func<TResult> on_62,
        Func<TResult> on_71,
        Func<TResult> on_72,
        Func<TResult> on_81,
        Func<TResult> on_9192,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _11 => on_11(),
            _ when this == _21 => on_21(),
            _ when this == _22 => on_22(),
            _ when this == _23 => on_23(),
            _ when this == _3133 => on_3133(),
            _ when this == _41 => on_41(),
            _ when this == _4445 => on_4445(),
            _ when this == _4849 => on_4849(),
            _ when this == _51 => on_51(),
            _ when this == _52 => on_52(),
            _ when this == _53 => on_53(),
            _ when this == _54 => on_54(),
            _ when this == _55 => on_55(),
            _ when this == _56 => on_56(),
            _ when this == _61 => on_61(),
            _ when this == _62 => on_62(),
            _ when this == _71 => on_71(),
            _ when this == _72 => on_72(),
            _ when this == _81 => on_81(),
            _ when this == _9192 => on_9192(),
            _ => otherwise(Value)
        };

    public void Match(Action on_11,
        Action on_21,
        Action on_22,
        Action on_23,
        Action on_3133,
        Action on_41,
        Action on_4445,
        Action on_4849,
        Action on_51,
        Action on_52,
        Action on_53,
        Action on_54,
        Action on_55,
        Action on_56,
        Action on_61,
        Action on_62,
        Action on_71,
        Action on_72,
        Action on_81,
        Action on_9192,
        Action<string> otherwise)
    {
        if (this == _11) on_11();
        else if (this == _21) on_21();
        else if (this == _22) on_22();
        else if (this == _23) on_23();
        else if (this == _3133) on_3133();
        else if (this == _41) on_41();
        else if (this == _4445) on_4445();
        else if (this == _4849) on_4849();
        else if (this == _51) on_51();
        else if (this == _52) on_52();
        else if (this == _53) on_53();
        else if (this == _54) on_54();
        else if (this == _55) on_55();
        else if (this == _56) on_56();
        else if (this == _61) on_61();
        else if (this == _62) on_62();
        else if (this == _71) on_71();
        else if (this == _72) on_72();
        else if (this == _81) on_81();
        else if (this == _9192) on_9192();
        else otherwise(Value);
    }
}
