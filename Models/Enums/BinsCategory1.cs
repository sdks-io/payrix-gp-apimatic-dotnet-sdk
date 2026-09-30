using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The category of the account product.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>classic</c> - <b>Classic credit or debit card.</b></description></item>
///   <item><description><c>business</c> - <b>Business credit or debit card.</b></description></item>
///   <item><description><c>corporate</c> - <b>Corporate credit or debit card.</b></description></item>
///   <item><description><c>fleet</c> - <b>Fleet card for transportation-related expenses.</b></description></item>
///   <item><description><c>hsaFsa</c> - <b>HSA (Health Savings Account) or FSA (Flexible Spending Account) card.</b></description></item>
///   <item><description><c>platinum</c> - <b>Platinum credit card.</b></description></item>
///   <item><description><c>prepaid</c> - <b>Prepaid card.</b></description></item>
///   <item><description><c>coreCard</c> - <b>Core card.</b></description></item>
///   <item><description><c>personal</c> - <b>Personal account.</b></description></item>
///   <item><description><c>standard</c> - <b>Standard account.</b></description></item>
///   <item><description><c>other</c> - <b>Other type of account.</b></description></item>
///   <item><description><c>international</c> - <b>International account.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BinsCategory1>))]
public sealed record BinsCategory1 : OpenStringEnum<BinsCategory1>
{
    private BinsCategory1(string value) : base(value)
    {
    }

    public static readonly BinsCategory1 Classic = new("classic");

    public static readonly BinsCategory1 Business = new("business");

    public static readonly BinsCategory1 Corporate = new("corporate");

    public static readonly BinsCategory1 Fleet = new("fleet");

    public static readonly BinsCategory1 HsaFsa = new("hsaFsa");

    public static readonly BinsCategory1 Platinum = new("platinum");

    public static readonly BinsCategory1 Prepaid = new("prepaid");

    public static readonly BinsCategory1 CoreCard = new("coreCard");

    public static readonly BinsCategory1 Personal = new("personal");

    public static readonly BinsCategory1 Standard = new("standard");

    public static readonly BinsCategory1 Other = new("other");

    public static readonly BinsCategory1 International = new("international");

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
