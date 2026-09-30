using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The platform used to process transactions.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>APPLE</c> - <b>The Apple Payment Processor (Deprecated).</b></description></item>
///   <item><description><c>ELAVON</c> - <b>The Elavon processor (Deprecated).</b></description></item>
///   <item><description><c>FIRSTDATA</c> - <b>The FirstData processor (Deprecated).</b></description></item>
///   <item><description><c>GOOGLE</c> - <b>The Google Payment Processor (Deprecated).</b></description></item>
///   <item><description><c>VANTIV</c> - <b>The WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
///   <item><description><c>VCORE</c> - <b>The WorldPay (aka Vantiv) Core processor.</b></description></item>
///   <item><description><c>WELLSACH</c> - <b>The Wells Fargo ACH processor.</b></description></item>
///   <item><description><c>WELLSFARGO</c> - <b>The Wells Fargo Merchant Services processor (Deprecated).</b></description></item>
///   <item><description><c>WFSINGLE</c> - <b>The WFSINGLE processor (Deprecated).</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TxnsPlatform1>))]
public sealed record TxnsPlatform1 : OpenStringEnum<TxnsPlatform1>
{
    private TxnsPlatform1(string value) : base(value)
    {
    }

    public static readonly TxnsPlatform1 Apple = new("APPLE");

    public static readonly TxnsPlatform1 Elavon = new("ELAVON");

    public static readonly TxnsPlatform1 Firstdata = new("FIRSTDATA");

    public static readonly TxnsPlatform1 Google = new("GOOGLE");

    public static readonly TxnsPlatform1 Vantiv = new("VANTIV");

    public static readonly TxnsPlatform1 Vcore = new("VCORE");

    public static readonly TxnsPlatform1 Wellsach = new("WELLSACH");

    public static readonly TxnsPlatform1 Wellsfargo = new("WELLSFARGO");

    public static readonly TxnsPlatform1 Wfsingle = new("WFSINGLE");

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
