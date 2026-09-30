using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DisbursementRefPlatform>))]
public sealed record DisbursementRefPlatform : OpenStringEnum<DisbursementRefPlatform>
{
    private DisbursementRefPlatform(string value) : base(value)
    {
    }

    public static readonly DisbursementRefPlatform Elavon = new("ELAVON");

    public static readonly DisbursementRefPlatform Vantiv = new("VANTIV");

    public static readonly DisbursementRefPlatform Vcore = new("VCORE");

    public static readonly DisbursementRefPlatform Tdbank = new("TDBANK");

    public static readonly DisbursementRefPlatform Tdbankca = new("TDBANKCA");

    public static readonly DisbursementRefPlatform Wellsach = new("WELLSACH");

    public static readonly DisbursementRefPlatform Wellsfargo = new("WELLSFARGO");

    public static readonly DisbursementRefPlatform Wfsingle = new("WFSINGLE");

    public static readonly DisbursementRefPlatform Worldpay = new("WORLDPAY");

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
