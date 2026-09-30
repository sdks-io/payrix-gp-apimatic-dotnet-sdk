using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FundingParameterPlatform>))]
public sealed record FundingParameterPlatform : OpenStringEnum<FundingParameterPlatform>
{
    private FundingParameterPlatform(string value) : base(value)
    {
    }

    public static readonly FundingParameterPlatform Apple = new("APPLE");

    public static readonly FundingParameterPlatform Elavon = new("ELAVON");

    public static readonly FundingParameterPlatform Firstdata = new("FIRSTDATA");

    public static readonly FundingParameterPlatform Google = new("GOOGLE");

    public static readonly FundingParameterPlatform Vantiv = new("VANTIV");

    public static readonly FundingParameterPlatform Vcore = new("VCORE");

    public static readonly FundingParameterPlatform Wellsach = new("WELLSACH");

    public static readonly FundingParameterPlatform Wellsfargo = new("WELLSFARGO");

    public static readonly FundingParameterPlatform Wfsingle = new("WFSINGLE");

    public static readonly FundingParameterPlatform Worldpay = new("WORLDPAY");

    public static readonly FundingParameterPlatform Tdbankca = new("TDBANKCA");

    public static readonly FundingParameterPlatform All = new("all");

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
        Func<TResult> onAll,
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
            _ when this == All => onAll(),
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
        Action onAll,
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
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
