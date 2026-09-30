using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FundingParameterPaymentMethods>))]
public sealed record FundingParameterPaymentMethods : OpenStringEnum<FundingParameterPaymentMethods>
{
    private FundingParameterPaymentMethods(string value) : base(value)
    {
    }

    public static readonly FundingParameterPaymentMethods Amex = new("amex");

    public static readonly FundingParameterPaymentMethods Visa = new("visa");

    public static readonly FundingParameterPaymentMethods MasterCard = new("masterCard");

    public static readonly FundingParameterPaymentMethods Diners = new("diners");

    public static readonly FundingParameterPaymentMethods Discover = new("discover");

    public static readonly FundingParameterPaymentMethods Paypal = new("paypal");

    public static readonly FundingParameterPaymentMethods Debit = new("debit");

    public static readonly FundingParameterPaymentMethods Checking = new("checking");

    public static readonly FundingParameterPaymentMethods Savings = new("savings");

    public static readonly FundingParameterPaymentMethods CorpChecking = new("corpChecking");

    public static readonly FundingParameterPaymentMethods CorpSavings = new("corpSavings");

    public static readonly FundingParameterPaymentMethods Gift = new("gift");

    public static readonly FundingParameterPaymentMethods Ebt = new("ebt");

    public static readonly FundingParameterPaymentMethods Wic = new("wic");

    public static readonly FundingParameterPaymentMethods Accel = new("Accel");

    public static readonly FundingParameterPaymentMethods Ath = new("ATH");

    public static readonly FundingParameterPaymentMethods Affn = new("AFFN");

    public static readonly FundingParameterPaymentMethods Culiance = new("Culiance");

    public static readonly FundingParameterPaymentMethods Interlink = new("Interlink");

    public static readonly FundingParameterPaymentMethods Jeanie = new("Jeanie");

    public static readonly FundingParameterPaymentMethods Maestro = new("Maestro");

    public static readonly FundingParameterPaymentMethods Nyce = new("NYCE");

    public static readonly FundingParameterPaymentMethods Pulse = new("Pulse");

    public static readonly FundingParameterPaymentMethods Shazam = new("Shazam");

    public static readonly FundingParameterPaymentMethods Star = new("Star");

    public static readonly FundingParameterPaymentMethods Interac = new("Interac");

    public static readonly FundingParameterPaymentMethods Omnitoken = new("Omnitoken");

    public TResult Match<TResult>(Func<TResult> onAmex,
        Func<TResult> onVisa,
        Func<TResult> onMasterCard,
        Func<TResult> onDiners,
        Func<TResult> onDiscover,
        Func<TResult> onPaypal,
        Func<TResult> onDebit,
        Func<TResult> onChecking,
        Func<TResult> onSavings,
        Func<TResult> onCorpChecking,
        Func<TResult> onCorpSavings,
        Func<TResult> onGift,
        Func<TResult> onEbt,
        Func<TResult> onWic,
        Func<TResult> onAccel,
        Func<TResult> onAth,
        Func<TResult> onAffn,
        Func<TResult> onCuliance,
        Func<TResult> onInterlink,
        Func<TResult> onJeanie,
        Func<TResult> onMaestro,
        Func<TResult> onNyce,
        Func<TResult> onPulse,
        Func<TResult> onShazam,
        Func<TResult> onStar,
        Func<TResult> onInterac,
        Func<TResult> onOmnitoken,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Amex => onAmex(),
            _ when this == Visa => onVisa(),
            _ when this == MasterCard => onMasterCard(),
            _ when this == Diners => onDiners(),
            _ when this == Discover => onDiscover(),
            _ when this == Paypal => onPaypal(),
            _ when this == Debit => onDebit(),
            _ when this == Checking => onChecking(),
            _ when this == Savings => onSavings(),
            _ when this == CorpChecking => onCorpChecking(),
            _ when this == CorpSavings => onCorpSavings(),
            _ when this == Gift => onGift(),
            _ when this == Ebt => onEbt(),
            _ when this == Wic => onWic(),
            _ when this == Accel => onAccel(),
            _ when this == Ath => onAth(),
            _ when this == Affn => onAffn(),
            _ when this == Culiance => onCuliance(),
            _ when this == Interlink => onInterlink(),
            _ when this == Jeanie => onJeanie(),
            _ when this == Maestro => onMaestro(),
            _ when this == Nyce => onNyce(),
            _ when this == Pulse => onPulse(),
            _ when this == Shazam => onShazam(),
            _ when this == Star => onStar(),
            _ when this == Interac => onInterac(),
            _ when this == Omnitoken => onOmnitoken(),
            _ => otherwise(Value)
        };

    public void Match(Action onAmex,
        Action onVisa,
        Action onMasterCard,
        Action onDiners,
        Action onDiscover,
        Action onPaypal,
        Action onDebit,
        Action onChecking,
        Action onSavings,
        Action onCorpChecking,
        Action onCorpSavings,
        Action onGift,
        Action onEbt,
        Action onWic,
        Action onAccel,
        Action onAth,
        Action onAffn,
        Action onCuliance,
        Action onInterlink,
        Action onJeanie,
        Action onMaestro,
        Action onNyce,
        Action onPulse,
        Action onShazam,
        Action onStar,
        Action onInterac,
        Action onOmnitoken,
        Action<string> otherwise)
    {
        if (this == Amex) onAmex();
        else if (this == Visa) onVisa();
        else if (this == MasterCard) onMasterCard();
        else if (this == Diners) onDiners();
        else if (this == Discover) onDiscover();
        else if (this == Paypal) onPaypal();
        else if (this == Debit) onDebit();
        else if (this == Checking) onChecking();
        else if (this == Savings) onSavings();
        else if (this == CorpChecking) onCorpChecking();
        else if (this == CorpSavings) onCorpSavings();
        else if (this == Gift) onGift();
        else if (this == Ebt) onEbt();
        else if (this == Wic) onWic();
        else if (this == Accel) onAccel();
        else if (this == Ath) onAth();
        else if (this == Affn) onAffn();
        else if (this == Culiance) onCuliance();
        else if (this == Interlink) onInterlink();
        else if (this == Jeanie) onJeanie();
        else if (this == Maestro) onMaestro();
        else if (this == Nyce) onNyce();
        else if (this == Pulse) onPulse();
        else if (this == Shazam) onShazam();
        else if (this == Star) onStar();
        else if (this == Interac) onInterac();
        else if (this == Omnitoken) onOmnitoken();
        else otherwise(Value);
    }
}
