using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalRefPlatform>))]
public sealed record TerminalRefPlatform : OpenStringEnum<TerminalRefPlatform>
{
    private TerminalRefPlatform(string value) : base(value)
    {
    }

    public static readonly TerminalRefPlatform Elavon = new("ELAVON");

    public static readonly TerminalRefPlatform Firstdata = new("FIRSTDATA");

    public static readonly TerminalRefPlatform Vcore = new("VCORE");

    public static readonly TerminalRefPlatform Vantiv = new("VANTIV");

    public static readonly TerminalRefPlatform Wellsfargo = new("WELLSFARGO");

    public static readonly TerminalRefPlatform Soundpayments = new("SOUNDPAYMENTS");

    public static readonly TerminalRefPlatform Payrix = new("PAYRIX");

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
