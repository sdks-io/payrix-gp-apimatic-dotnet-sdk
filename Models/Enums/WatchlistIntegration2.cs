using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The integration related to this Watchlist.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>APPLE</c> - <b>APPLE integration.</b></description></item>
///   <item><description><c>ELAVON</c> - <b>ELAVON integration.</b></description></item>
///   <item><description><c>FEDACH</c> - <b>FEDACH integration.</b></description></item>
///   <item><description><c>FIRSTDATA</c> - <b>FIRSTDATA integration.</b></description></item>
///   <item><description><c>NEUTRINO</c> - <b>NEUTRINO integration.</b></description></item>
///   <item><description><c>OFAC</c> - <b>OFAC integration.</b></description></item>
///   <item><description><c>PAYRIX</c> - <b>PAYRIX integration.</b></description></item>
///   <item><description><c>PLAID</c> - <b>PLAID integration.</b></description></item>
///   <item><description><c>SIFT</c> - <b>SIFT integration.</b></description></item>
///   <item><description><c>SOCURE</c> - <b>SOCURE integration.</b></description></item>
///   <item><description><c>SOUNDPAYMENTS</c> - <b>SOUNDPAYMENTS integration.</b></description></item>
///   <item><description><c>TDBANK</c> - <b>TDBANK integration.</b></description></item>
///   <item><description><c>TDBANKCA</c> - <b>TDBANKCA integration.</b></description></item>
///   <item><description><c>VANTIV</c> - <b>VANTIV integration.</b></description></item>
///   <item><description><c>VCORE</c> - <b>VCORE integration.</b></description></item>
///   <item><description><c>WEBSHIELD</c> - <b>WEBSHIELD integration.</b></description></item>
///   <item><description><c>WELLSACH</c> - <b>WELLSACH integration.</b></description></item>
///   <item><description><c>WELLSFARGO</c> - <b>WELLSFARGO integration.</b></description></item>
///   <item><description><c>WFSINGLE</c> - <b>WFSINGLE integration.</b></description></item>
///   <item><description><c>WORLDPAY</c> - <b>WORLDPAY integration.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WatchlistIntegration2>))]
public sealed record WatchlistIntegration2 : OpenStringEnum<WatchlistIntegration2>
{
    private WatchlistIntegration2(string value) : base(value)
    {
    }

    public static readonly WatchlistIntegration2 Apple = new("APPLE");

    public static readonly WatchlistIntegration2 Elavon = new("ELAVON");

    public static readonly WatchlistIntegration2 Fedach = new("FEDACH");

    public static readonly WatchlistIntegration2 Firstdata = new("FIRSTDATA");

    public static readonly WatchlistIntegration2 Neutrino = new("NEUTRINO");

    public static readonly WatchlistIntegration2 Ofac = new("OFAC");

    public static readonly WatchlistIntegration2 Payrix = new("PAYRIX");

    public static readonly WatchlistIntegration2 Plaid = new("PLAID");

    public static readonly WatchlistIntegration2 Sift = new("SIFT");

    public static readonly WatchlistIntegration2 Socure = new("SOCURE");

    public static readonly WatchlistIntegration2 Soundpayments = new("SOUNDPAYMENTS");

    public static readonly WatchlistIntegration2 Tdbank = new("TDBANK");

    public static readonly WatchlistIntegration2 Tdbankca = new("TDBANKCA");

    public static readonly WatchlistIntegration2 Vantiv = new("VANTIV");

    public static readonly WatchlistIntegration2 Vcore = new("VCORE");

    public static readonly WatchlistIntegration2 Webshield = new("WEBSHIELD");

    public static readonly WatchlistIntegration2 Wellsach = new("WELLSACH");

    public static readonly WatchlistIntegration2 Wellsfargo = new("WELLSFARGO");

    public static readonly WatchlistIntegration2 Wfsingle = new("WFSINGLE");

    public static readonly WatchlistIntegration2 Worldpay = new("WORLDPAY");

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
