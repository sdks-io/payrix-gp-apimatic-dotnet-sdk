using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The identifier of the Platform associated with this fundingParameter.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>APPLE</c> - <b>The Apple Payment Processor.</b></description></item>
///   <item><description><c>ELAVON</c> - <b>The Elavon processor.</b></description></item>
///   <item><description><c>FIRSTDATA</c> - <b>The First Data processor.</b></description></item>
///   <item><description><c>GOOGLE</c> - <b>The Google Payment Processor.</b></description></item>
///   <item><description><c>VANTIV</c> - <b>The WorldPay (aka Vantiv or Litle) eComm (aka VAP) processor.</b></description></item>
///   <item><description><c>VCORE</c> - <b>The WorldPay (aka Vantiv) Core processor.</b></description></item>
///   <item><description><c>WELLSACH</c> - <b>The Wells Fargo ACH processor.</b></description></item>
///   <item><description><c>WELLSFARGO</c> - <b>The Wells Fargo Merchant Services processor.</b></description></item>
///   <item><description><c>WFSINGLE</c> - <b>The WFSINGLE processor.</b></description></item>
///   <item><description><c>WORLDPAY</c> - <b>The WORLDPAY processor.</b></description></item>
///   <item><description><c>TDBANKCA</c> - <b>External funding with TD Bank Canada via the Operating Account.</b></description></item>
///   <item><description><c>all</c> - <b>All Platform Processor.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundingParameterPlatform2>))]
public sealed record FundingParameterPlatform2 : OpenStringEnum<FundingParameterPlatform2>
{
    private FundingParameterPlatform2(string value) : base(value)
    {
    }

    public static readonly FundingParameterPlatform2 Apple = new("APPLE");

    public static readonly FundingParameterPlatform2 Elavon = new("ELAVON");

    public static readonly FundingParameterPlatform2 Firstdata = new("FIRSTDATA");

    public static readonly FundingParameterPlatform2 Google = new("GOOGLE");

    public static readonly FundingParameterPlatform2 Vantiv = new("VANTIV");

    public static readonly FundingParameterPlatform2 Vcore = new("VCORE");

    public static readonly FundingParameterPlatform2 Wellsach = new("WELLSACH");

    public static readonly FundingParameterPlatform2 Wellsfargo = new("WELLSFARGO");

    public static readonly FundingParameterPlatform2 Wfsingle = new("WFSINGLE");

    public static readonly FundingParameterPlatform2 Worldpay = new("WORLDPAY");

    public static readonly FundingParameterPlatform2 Tdbankca = new("TDBANKCA");

    public static readonly FundingParameterPlatform2 All = new("all");

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
