using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The platform that issued this terminalRef.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>ELAVON</c> - <b>ELAVON Payments Platform.</b></description></item>
///   <item><description><c>FIRSTDATA</c> - <b>FirstData Payments Platform.</b></description></item>
///   <item><description><c>VCORE</c> - <b>WorldPay / Vantiv Core Payments Platform.</b></description></item>
///   <item><description><c>VANTIV</c> - <b>WorldPay / Vantiv eComm Payments (VAP) Platform.</b></description></item>
///   <item><description><c>WELLSFARGO</c> - <b>Wells Fargo Merchant Services Payments Platform.</b></description></item>
///   <item><description><c>SOUNDPAYMENTS</c> - <b>SoundPayments EMV and POS Payments Platform.</b></description></item>
///   <item><description><c>PAYRIX</c> - <b>Payrix Merchant Payments Platform.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalRefPlatform2>))]
public sealed record TerminalRefPlatform2 : OpenStringEnum<TerminalRefPlatform2>
{
    private TerminalRefPlatform2(string value) : base(value)
    {
    }

    public static readonly TerminalRefPlatform2 Elavon = new("ELAVON");

    public static readonly TerminalRefPlatform2 Firstdata = new("FIRSTDATA");

    public static readonly TerminalRefPlatform2 Vcore = new("VCORE");

    public static readonly TerminalRefPlatform2 Vantiv = new("VANTIV");

    public static readonly TerminalRefPlatform2 Wellsfargo = new("WELLSFARGO");

    public static readonly TerminalRefPlatform2 Soundpayments = new("SOUNDPAYMENTS");

    public static readonly TerminalRefPlatform2 Payrix = new("PAYRIX");

    public TResult Match<TResult>(Func<TResult> onElavon,
        Func<TResult> onFirstdata,
        Func<TResult> onVcore,
        Func<TResult> onVantiv,
        Func<TResult> onWellsfargo,
        Func<TResult> onSoundpayments,
        Func<TResult> onPayrix,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Elavon => onElavon(),
            _ when this == Firstdata => onFirstdata(),
            _ when this == Vcore => onVcore(),
            _ when this == Vantiv => onVantiv(),
            _ when this == Wellsfargo => onWellsfargo(),
            _ when this == Soundpayments => onSoundpayments(),
            _ when this == Payrix => onPayrix(),
            _ => otherwise(Value)
        };

    public void Match(Action onElavon,
        Action onFirstdata,
        Action onVcore,
        Action onVantiv,
        Action onWellsfargo,
        Action onSoundpayments,
        Action onPayrix,
        Action<string> otherwise)
    {
        if (this == Elavon) onElavon();
        else if (this == Firstdata) onFirstdata();
        else if (this == Vcore) onVcore();
        else if (this == Vantiv) onVantiv();
        else if (this == Wellsfargo) onWellsfargo();
        else if (this == Soundpayments) onSoundpayments();
        else if (this == Payrix) onPayrix();
        else otherwise(Value);
    }
}
