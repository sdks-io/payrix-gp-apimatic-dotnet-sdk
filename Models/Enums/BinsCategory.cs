using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BinsCategory>))]
public sealed record BinsCategory : OpenStringEnum<BinsCategory>
{
    private BinsCategory(string value) : base(value)
    {
    }

    public static readonly BinsCategory Classic = new("classic");

    public static readonly BinsCategory Business = new("business");

    public static readonly BinsCategory Corporate = new("corporate");

    public static readonly BinsCategory Fleet = new("fleet");

    public static readonly BinsCategory HsaFsa = new("hsaFsa");

    public static readonly BinsCategory Platinum = new("platinum");

    public static readonly BinsCategory Prepaid = new("prepaid");

    public static readonly BinsCategory CoreCard = new("coreCard");

    public static readonly BinsCategory Personal = new("personal");

    public static readonly BinsCategory Standard = new("standard");

    public static readonly BinsCategory Other = new("other");

    public static readonly BinsCategory International = new("international");

    public TResult Match<TResult>(Func<TResult> onClassic,
        Func<TResult> onBusiness,
        Func<TResult> onCorporate,
        Func<TResult> onFleet,
        Func<TResult> onHsaFsa,
        Func<TResult> onPlatinum,
        Func<TResult> onPrepaid,
        Func<TResult> onCoreCard,
        Func<TResult> onPersonal,
        Func<TResult> onStandard,
        Func<TResult> onOther,
        Func<TResult> onInternational,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Classic => onClassic(),
            _ when this == Business => onBusiness(),
            _ when this == Corporate => onCorporate(),
            _ when this == Fleet => onFleet(),
            _ when this == HsaFsa => onHsaFsa(),
            _ when this == Platinum => onPlatinum(),
            _ when this == Prepaid => onPrepaid(),
            _ when this == CoreCard => onCoreCard(),
            _ when this == Personal => onPersonal(),
            _ when this == Standard => onStandard(),
            _ when this == Other => onOther(),
            _ when this == International => onInternational(),
            _ => otherwise(Value)
        };

    public void Match(Action onClassic,
        Action onBusiness,
        Action onCorporate,
        Action onFleet,
        Action onHsaFsa,
        Action onPlatinum,
        Action onPrepaid,
        Action onCoreCard,
        Action onPersonal,
        Action onStandard,
        Action onOther,
        Action onInternational,
        Action<string> otherwise)
    {
        if (this == Classic) onClassic();
        else if (this == Business) onBusiness();
        else if (this == Corporate) onCorporate();
        else if (this == Fleet) onFleet();
        else if (this == HsaFsa) onHsaFsa();
        else if (this == Platinum) onPlatinum();
        else if (this == Prepaid) onPrepaid();
        else if (this == CoreCard) onCoreCard();
        else if (this == Personal) onPersonal();
        else if (this == Standard) onStandard();
        else if (this == Other) onOther();
        else if (this == International) onInternational();
        else otherwise(Value);
    }
}
