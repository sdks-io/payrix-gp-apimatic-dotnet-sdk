using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChargebackPlatform>))]
public sealed record ChargebackPlatform : OpenStringEnum<ChargebackPlatform>
{
    private ChargebackPlatform(string value) : base(value)
    {
    }

    public static readonly ChargebackPlatform Apple = new("APPLE");

    public static readonly ChargebackPlatform Elavon = new("ELAVON");

    public static readonly ChargebackPlatform Firstdata = new("FIRSTDATA");

    public static readonly ChargebackPlatform Google = new("GOOGLE");

    public static readonly ChargebackPlatform Vantiv = new("VANTIV");

    public static readonly ChargebackPlatform Vcore = new("VCORE");

    public static readonly ChargebackPlatform Wellsach = new("WELLSACH");

    public static readonly ChargebackPlatform Wellsfargo = new("WELLSFARGO");

    public static readonly ChargebackPlatform Wfsingle = new("WFSINGLE");

    public TResult Match<TResult>(Func<TResult> onApple,
        Func<TResult> onElavon,
        Func<TResult> onFirstdata,
        Func<TResult> onGoogle,
        Func<TResult> onVantiv,
        Func<TResult> onVcore,
        Func<TResult> onWellsach,
        Func<TResult> onWellsfargo,
        Func<TResult> onWfsingle,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Apple => onApple(),
            _ when this == Elavon => onElavon(),
            _ when this == Firstdata => onFirstdata(),
            _ when this == Google => onGoogle(),
            _ when this == Vantiv => onVantiv(),
            _ when this == Vcore => onVcore(),
            _ when this == Wellsach => onWellsach(),
            _ when this == Wellsfargo => onWellsfargo(),
            _ when this == Wfsingle => onWfsingle(),
            _ => otherwise(Value)
        };

    public void Match(Action onApple,
        Action onElavon,
        Action onFirstdata,
        Action onGoogle,
        Action onVantiv,
        Action onVcore,
        Action onWellsach,
        Action onWellsfargo,
        Action onWfsingle,
        Action<string> otherwise)
    {
        if (this == Apple) onApple();
        else if (this == Elavon) onElavon();
        else if (this == Firstdata) onFirstdata();
        else if (this == Google) onGoogle();
        else if (this == Vantiv) onVantiv();
        else if (this == Vcore) onVcore();
        else if (this == Wellsach) onWellsach();
        else if (this == Wellsfargo) onWellsfargo();
        else if (this == Wfsingle) onWfsingle();
        else otherwise(Value);
    }
}
