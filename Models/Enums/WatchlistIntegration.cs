using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<WatchlistIntegration>))]
public sealed record WatchlistIntegration : OpenStringEnum<WatchlistIntegration>
{
    private WatchlistIntegration(string value) : base(value)
    {
    }

    public static readonly WatchlistIntegration Apple = new("APPLE");

    public static readonly WatchlistIntegration Elavon = new("ELAVON");

    public static readonly WatchlistIntegration Fedach = new("FEDACH");

    public static readonly WatchlistIntegration Firstdata = new("FIRSTDATA");

    public static readonly WatchlistIntegration Neutrino = new("NEUTRINO");

    public static readonly WatchlistIntegration Ofac = new("OFAC");

    public static readonly WatchlistIntegration Payrix = new("PAYRIX");

    public static readonly WatchlistIntegration Plaid = new("PLAID");

    public static readonly WatchlistIntegration Sift = new("SIFT");

    public static readonly WatchlistIntegration Socure = new("SOCURE");

    public static readonly WatchlistIntegration Soundpayments = new("SOUNDPAYMENTS");

    public static readonly WatchlistIntegration Tdbank = new("TDBANK");

    public static readonly WatchlistIntegration Tdbankca = new("TDBANKCA");

    public static readonly WatchlistIntegration Vantiv = new("VANTIV");

    public static readonly WatchlistIntegration Vcore = new("VCORE");

    public static readonly WatchlistIntegration Webshield = new("WEBSHIELD");

    public static readonly WatchlistIntegration Wellsach = new("WELLSACH");

    public static readonly WatchlistIntegration Wellsfargo = new("WELLSFARGO");

    public static readonly WatchlistIntegration Wfsingle = new("WFSINGLE");

    public static readonly WatchlistIntegration Worldpay = new("WORLDPAY");

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
