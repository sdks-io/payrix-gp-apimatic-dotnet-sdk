using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CredentialIntegration>))]
public sealed record CredentialIntegration : OpenStringEnum<CredentialIntegration>
{
    private CredentialIntegration(string value) : base(value)
    {
    }

    public static readonly CredentialIntegration Apple = new("APPLE");

    public static readonly CredentialIntegration Elavon = new("ELAVON");

    public static readonly CredentialIntegration Fedach = new("FEDACH");

    public static readonly CredentialIntegration Firstdata = new("FIRSTDATA");

    public static readonly CredentialIntegration Neutrino = new("NEUTRINO");

    public static readonly CredentialIntegration Ofac = new("OFAC");

    public static readonly CredentialIntegration Payrix = new("PAYRIX");

    public static readonly CredentialIntegration Plaid = new("PLAID");

    public static readonly CredentialIntegration Sift = new("SIFT");

    public static readonly CredentialIntegration Socure = new("SOCURE");

    public static readonly CredentialIntegration Soundpayments = new("SOUNDPAYMENTS");

    public static readonly CredentialIntegration Tdbank = new("TDBANK");

    public static readonly CredentialIntegration Vantiv = new("VANTIV");

    public static readonly CredentialIntegration Vcore = new("VCORE");

    public static readonly CredentialIntegration Webshield = new("WEBSHIELD");

    public static readonly CredentialIntegration Wellsach = new("WELLSACH");

    public static readonly CredentialIntegration Wellsfargo = new("WELLSFARGO");

    public static readonly CredentialIntegration Wfsingle = new("WFSINGLE");

    public TResult Match<TResult>(Func<TResult> onApple,
        Func<TResult> onElavon,
        Func<TResult> onFedach,
        Func<TResult> onFirstdata,
        Func<TResult> onNeutrino,
        Func<TResult> onOfac,
        Func<TResult> onPayrix,
        Func<TResult> onPlaid,
        Func<TResult> onSift,
        Func<TResult> onSocure,
        Func<TResult> onSoundpayments,
        Func<TResult> onTdbank,
        Func<TResult> onVantiv,
        Func<TResult> onVcore,
        Func<TResult> onWebshield,
        Func<TResult> onWellsach,
        Func<TResult> onWellsfargo,
        Func<TResult> onWfsingle,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Apple => onApple(),
            _ when this == Elavon => onElavon(),
            _ when this == Fedach => onFedach(),
            _ when this == Firstdata => onFirstdata(),
            _ when this == Neutrino => onNeutrino(),
            _ when this == Ofac => onOfac(),
            _ when this == Payrix => onPayrix(),
            _ when this == Plaid => onPlaid(),
            _ when this == Sift => onSift(),
            _ when this == Socure => onSocure(),
            _ when this == Soundpayments => onSoundpayments(),
            _ when this == Tdbank => onTdbank(),
            _ when this == Vantiv => onVantiv(),
            _ when this == Vcore => onVcore(),
            _ when this == Webshield => onWebshield(),
            _ when this == Wellsach => onWellsach(),
            _ when this == Wellsfargo => onWellsfargo(),
            _ when this == Wfsingle => onWfsingle(),
            _ => otherwise(Value)
        };

    public void Match(Action onApple,
        Action onElavon,
        Action onFedach,
        Action onFirstdata,
        Action onNeutrino,
        Action onOfac,
        Action onPayrix,
        Action onPlaid,
        Action onSift,
        Action onSocure,
        Action onSoundpayments,
        Action onTdbank,
        Action onVantiv,
        Action onVcore,
        Action onWebshield,
        Action onWellsach,
        Action onWellsfargo,
        Action onWfsingle,
        Action<string> otherwise)
    {
        if (this == Apple) onApple();
        else if (this == Elavon) onElavon();
        else if (this == Fedach) onFedach();
        else if (this == Firstdata) onFirstdata();
        else if (this == Neutrino) onNeutrino();
        else if (this == Ofac) onOfac();
        else if (this == Payrix) onPayrix();
        else if (this == Plaid) onPlaid();
        else if (this == Sift) onSift();
        else if (this == Socure) onSocure();
        else if (this == Soundpayments) onSoundpayments();
        else if (this == Tdbank) onTdbank();
        else if (this == Vantiv) onVantiv();
        else if (this == Vcore) onVcore();
        else if (this == Webshield) onWebshield();
        else if (this == Wellsach) onWellsach();
        else if (this == Wellsfargo) onWellsfargo();
        else if (this == Wfsingle) onWfsingle();
        else otherwise(Value);
    }
}
