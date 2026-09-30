using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The platform used to process this Transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>ELAVON</c>  - The Elavon processor.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VANTIV</c>  - The WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>VCORE</c> - The WorldPay (aka Vantiv) Core processor.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>TDBANK</c> - External funding with TD Bank via the Operating Account.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>TDBANKCA</c> - External funding with TD Bank Canada via the Operating Account.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSACH</c> - The Wells Fargo ACH processor.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WELLSFARGO</c> - The Wells Fargo Merchant Services processor.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WFSINGLE</c> - The WFSINGLE processor.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>WORLDPAY</c> - The WORLDPAY processor.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisbursementRefPlatform1>))]
public sealed record DisbursementRefPlatform1 : OpenStringEnum<DisbursementRefPlatform1>
{
    private DisbursementRefPlatform1(string value) : base(value)
    {
    }

    public static readonly DisbursementRefPlatform1 Elavon = new("ELAVON");

    public static readonly DisbursementRefPlatform1 Vantiv = new("VANTIV");

    public static readonly DisbursementRefPlatform1 Vcore = new("VCORE");

    public static readonly DisbursementRefPlatform1 Tdbank = new("TDBANK");

    public static readonly DisbursementRefPlatform1 Tdbankca = new("TDBANKCA");

    public static readonly DisbursementRefPlatform1 Wellsach = new("WELLSACH");

    public static readonly DisbursementRefPlatform1 Wellsfargo = new("WELLSFARGO");

    public static readonly DisbursementRefPlatform1 Wfsingle = new("WFSINGLE");

    public static readonly DisbursementRefPlatform1 Worldpay = new("WORLDPAY");

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
