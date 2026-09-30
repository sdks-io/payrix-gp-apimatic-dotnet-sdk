using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The processor that issued this terminalTxnRef.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>APPLE</c> - <b>APPLE</b></description></item>
///   <item><description><c>ELAVON</c> - <b>ELAVON</b></description></item>
///   <item><description><c>FIRSTDATA</c> - <b>FIRSTDATA</b></description></item>
///   <item><description><c>GOOGLE</c> - <b>GOOGLE</b></description></item>
///   <item><description><c>VANTIV</c> - <b>VANTIV</b></description></item>
///   <item><description><c>VCORE</c> - <b>VCORE</b></description></item>
///   <item><description><c>WELLSACH</c> - <b>WELLSACH</b></description></item>
///   <item><description><c>WELLSFARGO</c> - <b>WELLSFARGO</b></description></item>
///   <item><description><c>WFSINGLE</c> - <b>WFSINGLE</b></description></item>
///   <item><description><c>WORLDPAY</c> - <b>WORLDPAY</b></description></item>
///   <item><description><c>TDBANKCA</c> - <b>TDBANKCA</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityPlatform2>))]
public sealed record EntityPlatform2 : OpenStringEnum<EntityPlatform2>
{
    private EntityPlatform2(string value) : base(value)
    {
    }

    public static readonly EntityPlatform2 Apple = new("APPLE");

    public static readonly EntityPlatform2 Elavon = new("ELAVON");

    public static readonly EntityPlatform2 Firstdata = new("FIRSTDATA");

    public static readonly EntityPlatform2 Google = new("GOOGLE");

    public static readonly EntityPlatform2 Vantiv = new("VANTIV");

    public static readonly EntityPlatform2 Vcore = new("VCORE");

    public static readonly EntityPlatform2 Wellsach = new("WELLSACH");

    public static readonly EntityPlatform2 Wellsfargo = new("WELLSFARGO");

    public static readonly EntityPlatform2 Wfsingle = new("WFSINGLE");

    public static readonly EntityPlatform2 Worldpay = new("WORLDPAY");

    public static readonly EntityPlatform2 Tdbankca = new("TDBANKCA");

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
