using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntryOriginPlatform>))]
public sealed record EntryOriginPlatform : OpenStringEnum<EntryOriginPlatform>
{
    private EntryOriginPlatform(string value) : base(value)
    {
    }

    public static readonly EntryOriginPlatform Apple = new("APPLE");

    public static readonly EntryOriginPlatform Elavon = new("ELAVON");

    public static readonly EntryOriginPlatform Firstdata = new("FIRSTDATA");

    public static readonly EntryOriginPlatform Google = new("GOOGLE");

    public static readonly EntryOriginPlatform Vantiv = new("VANTIV");

    public static readonly EntryOriginPlatform Vcore = new("VCORE");

    public static readonly EntryOriginPlatform Wellsach = new("WELLSACH");

    public static readonly EntryOriginPlatform Wellsfargo = new("WELLSFARGO");

    public static readonly EntryOriginPlatform Wfsingle = new("WFSINGLE");

    public static readonly EntryOriginPlatform Worldpay = new("WORLDPAY");

    public static readonly EntryOriginPlatform Tdbankca = new("TDBANKCA");

    public TResult Match<TResult>(Func<TResult> onApple,
        Func<TResult> onElavon,
        Func<TResult> onFirstdata,
        Func<TResult> onGoogle,
        Func<TResult> onVantiv,
        Func<TResult> onVcore,
        Func<TResult> onWellsach,
        Func<TResult> onWellsfargo,
        Func<TResult> onWfsingle,
        Func<TResult> onWorldpay,
        Func<TResult> onTdbankca,
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
            _ when this == Worldpay => onWorldpay(),
            _ when this == Tdbankca => onTdbankca(),
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
        Action onWorldpay,
        Action onTdbankca,
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
        else if (this == Worldpay) onWorldpay();
        else if (this == Tdbankca) onTdbankca();
        else otherwise(Value);
    }
}
