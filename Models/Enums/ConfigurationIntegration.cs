using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConfigurationIntegration>))]
public sealed record ConfigurationIntegration : OpenStringEnum<ConfigurationIntegration>
{
    private ConfigurationIntegration(string value) : base(value)
    {
    }

    public static readonly ConfigurationIntegration Ach = new("ACH");

    public static readonly ConfigurationIntegration Apple = new("APPLE");

    public static readonly ConfigurationIntegration Elavon = new("ELAVON");

    public static readonly ConfigurationIntegration Fedach = new("FEDACH");

    public static readonly ConfigurationIntegration Firstdata = new("FIRSTDATA");

    public static readonly ConfigurationIntegration Legitscript = new("LEGITSCRIPT");

    public static readonly ConfigurationIntegration Neutrino = new("NEUTRINO");

    public static readonly ConfigurationIntegration Ofac = new("OFAC");

    public static readonly ConfigurationIntegration Omnitoken = new("OMNITOKEN");

    public static readonly ConfigurationIntegration Payrix = new("PAYRIX");

    public static readonly ConfigurationIntegration Plaid = new("PLAID");

    public static readonly ConfigurationIntegration Pushy = new("PUSHY");

    public static readonly ConfigurationIntegration Saferpayment = new("SAFERPAYMENT");

    public static readonly ConfigurationIntegration Sift = new("SIFT");

    public static readonly ConfigurationIntegration Socure = new("SOCURE");

    public static readonly ConfigurationIntegration Soundpayments = new("SOUNDPAYMENTS");

    public static readonly ConfigurationIntegration Tdbank = new("TDBANK");

    public static readonly ConfigurationIntegration Tdbankca = new("TDBANKCA");

    public static readonly ConfigurationIntegration Vantiv = new("VANTIV");

    public static readonly ConfigurationIntegration Vcore = new("VCORE");

    public static readonly ConfigurationIntegration Webshield = new("WEBSHIELD");

    public static readonly ConfigurationIntegration Wellsach = new("WELLSACH");

    public static readonly ConfigurationIntegration Wellsfargo = new("WELLSFARGO");

    public static readonly ConfigurationIntegration Wfsingle = new("WFSINGLE");

    public static readonly ConfigurationIntegration Worldpay = new("WORLDPAY");

    public TResult Match<TResult>(Func<TResult> onAch,
        Func<TResult> onApple,
        Func<TResult> onElavon,
        Func<TResult> onFedach,
        Func<TResult> onFirstdata,
        Func<TResult> onLegitscript,
        Func<TResult> onNeutrino,
        Func<TResult> onOfac,
        Func<TResult> onOmnitoken,
        Func<TResult> onPayrix,
        Func<TResult> onPlaid,
        Func<TResult> onPushy,
        Func<TResult> onSaferpayment,
        Func<TResult> onSift,
        Func<TResult> onSocure,
        Func<TResult> onSoundpayments,
        Func<TResult> onTdbank,
        Func<TResult> onTdbankca,
        Func<TResult> onVantiv,
        Func<TResult> onVcore,
        Func<TResult> onWebshield,
        Func<TResult> onWellsach,
        Func<TResult> onWellsfargo,
        Func<TResult> onWfsingle,
        Func<TResult> onWorldpay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ach => onAch(),
            _ when this == Apple => onApple(),
            _ when this == Elavon => onElavon(),
            _ when this == Fedach => onFedach(),
            _ when this == Firstdata => onFirstdata(),
            _ when this == Legitscript => onLegitscript(),
            _ when this == Neutrino => onNeutrino(),
            _ when this == Ofac => onOfac(),
            _ when this == Omnitoken => onOmnitoken(),
            _ when this == Payrix => onPayrix(),
            _ when this == Plaid => onPlaid(),
            _ when this == Pushy => onPushy(),
            _ when this == Saferpayment => onSaferpayment(),
            _ when this == Sift => onSift(),
            _ when this == Socure => onSocure(),
            _ when this == Soundpayments => onSoundpayments(),
            _ when this == Tdbank => onTdbank(),
            _ when this == Tdbankca => onTdbankca(),
            _ when this == Vantiv => onVantiv(),
            _ when this == Vcore => onVcore(),
            _ when this == Webshield => onWebshield(),
            _ when this == Wellsach => onWellsach(),
            _ when this == Wellsfargo => onWellsfargo(),
            _ when this == Wfsingle => onWfsingle(),
            _ when this == Worldpay => onWorldpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onAch,
        Action onApple,
        Action onElavon,
        Action onFedach,
        Action onFirstdata,
        Action onLegitscript,
        Action onNeutrino,
        Action onOfac,
        Action onOmnitoken,
        Action onPayrix,
        Action onPlaid,
        Action onPushy,
        Action onSaferpayment,
        Action onSift,
        Action onSocure,
        Action onSoundpayments,
        Action onTdbank,
        Action onTdbankca,
        Action onVantiv,
        Action onVcore,
        Action onWebshield,
        Action onWellsach,
        Action onWellsfargo,
        Action onWfsingle,
        Action onWorldpay,
        Action<string> otherwise)
    {
        if (this == Ach) onAch();
        else if (this == Apple) onApple();
        else if (this == Elavon) onElavon();
        else if (this == Fedach) onFedach();
        else if (this == Firstdata) onFirstdata();
        else if (this == Legitscript) onLegitscript();
        else if (this == Neutrino) onNeutrino();
        else if (this == Ofac) onOfac();
        else if (this == Omnitoken) onOmnitoken();
        else if (this == Payrix) onPayrix();
        else if (this == Plaid) onPlaid();
        else if (this == Pushy) onPushy();
        else if (this == Saferpayment) onSaferpayment();
        else if (this == Sift) onSift();
        else if (this == Socure) onSocure();
        else if (this == Soundpayments) onSoundpayments();
        else if (this == Tdbank) onTdbank();
        else if (this == Tdbankca) onTdbankca();
        else if (this == Vantiv) onVantiv();
        else if (this == Vcore) onVcore();
        else if (this == Webshield) onWebshield();
        else if (this == Wellsach) onWellsach();
        else if (this == Wellsfargo) onWellsfargo();
        else if (this == Wfsingle) onWfsingle();
        else if (this == Worldpay) onWorldpay();
        else otherwise(Value);
    }
}
