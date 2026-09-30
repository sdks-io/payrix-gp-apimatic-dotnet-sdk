using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The platform used to process this resource.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>APPLE</c> - <b>The Apple Payment Processor.</b></description></item>
///   <item><description><c>ELAVON</c> - <b>The Elavon processor.</b></description></item>
///   <item><description><c>FIRSTDATA</c> - <b>The FirstData processor.</b></description></item>
///   <item><description><c>GOOGLE</c> - <b>The Google Payment Processor.</b></description></item>
///   <item><description><c>VANTIV</c> - <b>The WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
///   <item><description><c>VCORE</c> - <b>The WorldPay (aka Vantiv) Core processor.</b></description></item>
///   <item><description><c>TDBANKCA</c> - <b>External funding with TD Bank Canada via the Operating Account.</b></description></item>
///   <item><description><c>WELLSACH</c> - <b>The Wells Fargo ACH processor.</b></description></item>
///   <item><description><c>WELLSFARGO</c> - <b>The Wells Fargo Merchant Services processor.</b></description></item>
///   <item><description><c>WFSINGLE</c> - <b>The WFSINGLE processor.</b></description></item>
///   <item><description><c>WORLDPAY</c> - <b>The WORLDPAY processor.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlatformModel1>))]
public sealed record PlatformModel1 : OpenStringEnum<PlatformModel1>
{
    private PlatformModel1(string value) : base(value)
    {
    }

    public static readonly PlatformModel1 Apple = new("APPLE");

    public static readonly PlatformModel1 Elavon = new("ELAVON");

    public static readonly PlatformModel1 Firstdata = new("FIRSTDATA");

    public static readonly PlatformModel1 Google = new("GOOGLE");

    public static readonly PlatformModel1 Vantiv = new("VANTIV");

    public static readonly PlatformModel1 Vcore = new("VCORE");

    public static readonly PlatformModel1 Tdbankca = new("TDBANKCA");

    public static readonly PlatformModel1 Wellsach = new("WELLSACH");

    public static readonly PlatformModel1 Wellsfargo = new("WELLSFARGO");

    public static readonly PlatformModel1 Wfsingle = new("WFSINGLE");

    public static readonly PlatformModel1 Worldpay = new("WORLDPAY");

    public TResult Match<TResult>(Func<TResult> onApple,
        Func<TResult> onElavon,
        Func<TResult> onFirstdata,
        Func<TResult> onGoogle,
        Func<TResult> onVantiv,
        Func<TResult> onVcore,
        Func<TResult> onTdbankca,
        Func<TResult> onWellsach,
        Func<TResult> onWellsfargo,
        Func<TResult> onWfsingle,
        Func<TResult> onWorldpay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Apple => onApple(),
            _ when this == Elavon => onElavon(),
            _ when this == Firstdata => onFirstdata(),
            _ when this == Google => onGoogle(),
            _ when this == Vantiv => onVantiv(),
            _ when this == Vcore => onVcore(),
            _ when this == Tdbankca => onTdbankca(),
            _ when this == Wellsach => onWellsach(),
            _ when this == Wellsfargo => onWellsfargo(),
            _ when this == Wfsingle => onWfsingle(),
            _ when this == Worldpay => onWorldpay(),
            _ => otherwise(Value)
        };

    public void Match(Action onApple,
        Action onElavon,
        Action onFirstdata,
        Action onGoogle,
        Action onVantiv,
        Action onVcore,
        Action onTdbankca,
        Action onWellsach,
        Action onWellsfargo,
        Action onWfsingle,
        Action onWorldpay,
        Action<string> otherwise)
    {
        if (this == Apple) onApple();
        else if (this == Elavon) onElavon();
        else if (this == Firstdata) onFirstdata();
        else if (this == Google) onGoogle();
        else if (this == Vantiv) onVantiv();
        else if (this == Vcore) onVcore();
        else if (this == Tdbankca) onTdbankca();
        else if (this == Wellsach) onWellsach();
        else if (this == Wellsfargo) onWellsfargo();
        else if (this == Wfsingle) onWfsingle();
        else if (this == Worldpay) onWorldpay();
        else otherwise(Value);
    }
}
