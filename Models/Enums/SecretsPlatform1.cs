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
/// <para>
/// - <c>APPLE</c> - <b>Apple Payment Processor</b>
/// - <c>ELAVON</c> - <b>ELAVON Payment Processor</b>
/// - <c>FIRSTDATA</c> - <b>FirstData Payment Processor</b>
/// - <c>GOOGLE</c> - <b>Google Payment Processor</b>
/// - <c>VANTIV</c> - <b>WorldPay / Vantiv eComm Payment Processor (VAP)</b>
/// - <c>VCORE</c> - <b>WorldPay / Vantiv Core Payment Processor</b>
/// - <c>WELLSACH</c> - <b>Wells Fargo Merchant Services Payment Processor (ACH)</b>
/// - <c>WELLSFARGO</c> - <b>Wells Fargo Merchant Services Payment Processor</b>
/// - <c>WFSINGLE</c> - <b>Wells Fargo Single Payment Processor</b>
/// - <c>WORLDPAY</c> - <b>WORLDPAY</b>
/// - <c>TDBANKCA</c> - <b>TDBANKCA</b>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SecretsPlatform1>))]
public sealed record SecretsPlatform1 : OpenStringEnum<SecretsPlatform1>
{
    private SecretsPlatform1(string value) : base(value)
    {
    }

    public static readonly SecretsPlatform1 Apple = new("APPLE");

    public static readonly SecretsPlatform1 Elavon = new("ELAVON");

    public static readonly SecretsPlatform1 Firstdata = new("FIRSTDATA");

    public static readonly SecretsPlatform1 Google = new("GOOGLE");

    public static readonly SecretsPlatform1 Vantiv = new("VANTIV");

    public static readonly SecretsPlatform1 Vcore = new("VCORE");

    public static readonly SecretsPlatform1 Wellsach = new("WELLSACH");

    public static readonly SecretsPlatform1 Wellsfargo = new("WELLSFARGO");

    public static readonly SecretsPlatform1 Wfsingle = new("WFSINGLE");

    public static readonly SecretsPlatform1 Worldpay = new("WORLDPAY");

    public static readonly SecretsPlatform1 Tdbankca = new("TDBANKCA");

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
