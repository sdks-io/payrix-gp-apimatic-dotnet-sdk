using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The platform used to process this Disbursement.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>ELAVON</c>  - <b>The Elavon processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV</c>  - <b>The Worldpay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE</c> - <b>The Worldpay (aka Vantiv) Core processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>TDBANK</c> - <b>External funding with TD Bank via the Operating Account.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>TDBANKCA</c> - <b>External funding with TD Bank Canada via the Operating Account.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSACH</c> - <b>The Wells Fargo ACH processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSFARGO</c> - <b>The Wells Fargo Merchant Services processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WFSINGLE</c> - <b>The WFSINGLE processor.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WORLDPAY</c> - <b>The WORLDPAY processor.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisbursementResultsPlatform2>))]
public sealed record DisbursementResultsPlatform2 : OpenStringEnum<DisbursementResultsPlatform2>
{
    private DisbursementResultsPlatform2(string value) : base(value)
    {
    }

    public static readonly DisbursementResultsPlatform2 Elavon = new("ELAVON");

    public static readonly DisbursementResultsPlatform2 Vantiv = new("VANTIV");

    public static readonly DisbursementResultsPlatform2 Vcore = new("VCORE");

    public static readonly DisbursementResultsPlatform2 Tdbank = new("TDBANK");

    public static readonly DisbursementResultsPlatform2 Tdbankca = new("TDBANKCA");

    public static readonly DisbursementResultsPlatform2 Wellsach = new("WELLSACH");

    public static readonly DisbursementResultsPlatform2 Wellsfargo = new("WELLSFARGO");

    public static readonly DisbursementResultsPlatform2 Wfsingle = new("WFSINGLE");

    public static readonly DisbursementResultsPlatform2 Worldpay = new("WORLDPAY");

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
