using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The payment platform integration using credential logins.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>APPLE</c> - <b>Apple API</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ELAVON</c> - <b>Elavon API</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FEDACH</c> - <b>FedACH Account Integration</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>FIRSTDATA</c> - <b>FirstData / Clover Integration</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>NEUTRINO</c> - <b>Neutrino eCommerce Integration</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>OFAC</c> - <b>Office of Foreign Assets Control Sanctions</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>PAYRIX</c> - <b>Payrix API</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>PLAID</c> - <b>Plaid Account Integration</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>SIFT</c> - <b>Sift Fraud Management</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>SOCURE</c> - <b>Socure ID Verification</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>SOUNDPAYMENTS</c> - <b>Sound Payments POS</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>TDBANK</c> - <b>TD Bank Platform</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV</c> - <b>WorldPay / Vantiv eComm Platform</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE</c> - <b>WorldPay / Vantiv Core Platform</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WEBSHIELD</c> - <b>Web Shield Merchant Monitoring</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSACH</c> - <b>Wells Fargo Merchant Services ACH Processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSFARGO</c> - <b>Wells Fargo Merchant Services Payment Processor</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WFSINGLE</c> - <b>Wells Fargo Single Payment Processors</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CredentialIntegration1>))]
public sealed record CredentialIntegration1 : OpenStringEnum<CredentialIntegration1>
{
    private CredentialIntegration1(string value) : base(value)
    {
    }

    public static readonly CredentialIntegration1 Apple = new("APPLE");

    public static readonly CredentialIntegration1 Elavon = new("ELAVON");

    public static readonly CredentialIntegration1 Fedach = new("FEDACH");

    public static readonly CredentialIntegration1 Firstdata = new("FIRSTDATA");

    public static readonly CredentialIntegration1 Neutrino = new("NEUTRINO");

    public static readonly CredentialIntegration1 Ofac = new("OFAC");

    public static readonly CredentialIntegration1 Payrix = new("PAYRIX");

    public static readonly CredentialIntegration1 Plaid = new("PLAID");

    public static readonly CredentialIntegration1 Sift = new("SIFT");

    public static readonly CredentialIntegration1 Socure = new("SOCURE");

    public static readonly CredentialIntegration1 Soundpayments = new("SOUNDPAYMENTS");

    public static readonly CredentialIntegration1 Tdbank = new("TDBANK");

    public static readonly CredentialIntegration1 Vantiv = new("VANTIV");

    public static readonly CredentialIntegration1 Vcore = new("VCORE");

    public static readonly CredentialIntegration1 Webshield = new("WEBSHIELD");

    public static readonly CredentialIntegration1 Wellsach = new("WELLSACH");

    public static readonly CredentialIntegration1 Wellsfargo = new("WELLSFARGO");

    public static readonly CredentialIntegration1 Wfsingle = new("WFSINGLE");

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
