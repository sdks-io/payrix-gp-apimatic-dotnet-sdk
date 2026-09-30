using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DisbursementResultsPlatform>))]
public sealed record DisbursementResultsPlatform : OpenStringEnum<DisbursementResultsPlatform>
{
    private DisbursementResultsPlatform(string value) : base(value)
    {
    }

    public static readonly DisbursementResultsPlatform Elavon = new("ELAVON");

    public static readonly DisbursementResultsPlatform Vantiv = new("VANTIV");

    public static readonly DisbursementResultsPlatform Vcore = new("VCORE");

    public static readonly DisbursementResultsPlatform Tdbank = new("TDBANK");

    public static readonly DisbursementResultsPlatform Tdbankca = new("TDBANKCA");

    public static readonly DisbursementResultsPlatform Wellsach = new("WELLSACH");

    public static readonly DisbursementResultsPlatform Wellsfargo = new("WELLSFARGO");

    public static readonly DisbursementResultsPlatform Wfsingle = new("WFSINGLE");

    public static readonly DisbursementResultsPlatform Worldpay = new("WORLDPAY");

    public TResult Match<TResult>(Func<TResult> onElavon,
        Func<TResult> onVantiv,
        Func<TResult> onVcore,
        Func<TResult> onTdbank,
        Func<TResult> onTdbankca,
        Func<TResult> onWellsach,
        Func<TResult> onWellsfargo,
        Func<TResult> onWfsingle,
        Func<TResult> onWorldpay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Elavon => onElavon(),
            _ when this == Vantiv => onVantiv(),
            _ when this == Vcore => onVcore(),
            _ when this == Tdbank => onTdbank(),
            _ when this == Tdbankca => onTdbankca(),
            _ when this == Wellsach => onWellsach(),
            _ when this == Wellsfargo => onWellsfargo(),
            _ when this == Wfsingle => onWfsingle(),
            _ when this == Worldpay => onWorldpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onElavon,
        Action onVantiv,
        Action onVcore,
        Action onTdbank,
        Action onTdbankca,
        Action onWellsach,
        Action onWellsfargo,
        Action onWfsingle,
        Action onWorldpay,
        Action<string> otherwise)
    {
        if (this == Elavon) onElavon();
        else if (this == Vantiv) onVantiv();
        else if (this == Vcore) onVcore();
        else if (this == Tdbank) onTdbank();
        else if (this == Tdbankca) onTdbankca();
        else if (this == Wellsach) onWellsach();
        else if (this == Wellsfargo) onWellsfargo();
        else if (this == Wfsingle) onWfsingle();
        else if (this == Worldpay) onWorldpay();
        else otherwise(Value);
    }
}
