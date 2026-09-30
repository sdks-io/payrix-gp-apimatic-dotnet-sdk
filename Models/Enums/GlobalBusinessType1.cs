using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The business registration type for the entity
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values for country USA&lt;/summary&gt;
/// </para>
/// <para>
/// - <c>ssn</c> - <b>Social Security Number.</b>
/// - <c>tin</c> - <b>Employer Identification Number.</b>
/// - <c>other</c> - <b>Other/Unknown TIN.</b>
/// &lt;/details&gt;
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values for country Canada&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>CD</c> - <b>Federal</b></description></item>
///   <item><description><c>AB</c> - <b>Alberta</b></description></item>
///   <item><description><c>BC</c> - <b>British Columbia</b></description></item>
///   <item><description><c>MB</c> - <b>Manitoba</b></description></item>
///   <item><description><c>NB</c> - <b>New Brunswick</b></description></item>
///   <item><description><c>NL</c> - <b>Newfoundland and Labrador</b></description></item>
///   <item><description><c>NT</c> - <b>Northwest Territories</b></description></item>
///   <item><description><c>NS</c> - <b>Nova Scotia</b></description></item>
///   <item><description><c>NU</c> - <b>Nunavut</b></description></item>
///   <item><description><c>ON</c> - <b>Ontario</b></description></item>
///   <item><description><c>PE</c> - <b>Prince Edward Island</b></description></item>
///   <item><description><c>QC</c> - <b>Quebec</b></description></item>
///   <item><description><c>SK</c> - <b>Saskatchewan</b></description></item>
///   <item><description><c>YT</c> - <b>Yukon</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GlobalBusinessType1>))]
public sealed record GlobalBusinessType1 : OpenStringEnum<GlobalBusinessType1>
{
    private GlobalBusinessType1(string value) : base(value)
    {
    }

    public static readonly GlobalBusinessType1 Ssn = new("ssn");

    public static readonly GlobalBusinessType1 Tin = new("tin");

    public static readonly GlobalBusinessType1 Other = new("other");

    public static readonly GlobalBusinessType1 Cd = new("CD");

    public static readonly GlobalBusinessType1 Ab = new("AB");

    public static readonly GlobalBusinessType1 Bc = new("BC");

    public static readonly GlobalBusinessType1 Mb = new("MB");

    public static readonly GlobalBusinessType1 Nb = new("NB");

    public static readonly GlobalBusinessType1 Nl = new("NL");

    public static readonly GlobalBusinessType1 Nt = new("NT");

    public static readonly GlobalBusinessType1 Ns = new("NS");

    public static readonly GlobalBusinessType1 Nu = new("NU");

    public static readonly GlobalBusinessType1 On = new("ON");

    public static readonly GlobalBusinessType1 Pe = new("PE");

    public static readonly GlobalBusinessType1 Qc = new("QC");

    public static readonly GlobalBusinessType1 Sk = new("SK");

    public static readonly GlobalBusinessType1 Yt = new("YT");

    public TResult Match<TResult>(Func<TResult> onSsn,
        Func<TResult> onTin,
        Func<TResult> onOther,
        Func<TResult> onCd,
        Func<TResult> onAb,
        Func<TResult> onBc,
        Func<TResult> onMb,
        Func<TResult> onNb,
        Func<TResult> onNl,
        Func<TResult> onNt,
        Func<TResult> onNs,
        Func<TResult> onNu,
        Func<TResult> onOn,
        Func<TResult> onPe,
        Func<TResult> onQc,
        Func<TResult> onSk,
        Func<TResult> onYt,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ssn => onSsn(),
            _ when this == Tin => onTin(),
            _ when this == Other => onOther(),
            _ when this == Cd => onCd(),
            _ when this == Ab => onAb(),
            _ when this == Bc => onBc(),
            _ when this == Mb => onMb(),
            _ when this == Nb => onNb(),
            _ when this == Nl => onNl(),
            _ when this == Nt => onNt(),
            _ when this == Ns => onNs(),
            _ when this == Nu => onNu(),
            _ when this == On => onOn(),
            _ when this == Pe => onPe(),
            _ when this == Qc => onQc(),
            _ when this == Sk => onSk(),
            _ when this == Yt => onYt(),
            _ => otherwise(Value)
        };

    public void Match(Action onSsn,
        Action onTin,
        Action onOther,
        Action onCd,
        Action onAb,
        Action onBc,
        Action onMb,
        Action onNb,
        Action onNl,
        Action onNt,
        Action onNs,
        Action onNu,
        Action onOn,
        Action onPe,
        Action onQc,
        Action onSk,
        Action onYt,
        Action<string> otherwise)
    {
        if (this == Ssn) onSsn();
        else if (this == Tin) onTin();
        else if (this == Other) onOther();
        else if (this == Cd) onCd();
        else if (this == Ab) onAb();
        else if (this == Bc) onBc();
        else if (this == Mb) onMb();
        else if (this == Nb) onNb();
        else if (this == Nl) onNl();
        else if (this == Nt) onNt();
        else if (this == Ns) onNs();
        else if (this == Nu) onNu();
        else if (this == On) onOn();
        else if (this == Pe) onPe();
        else if (this == Qc) onQc();
        else if (this == Sk) onSk();
        else if (this == Yt) onYt();
        else otherwise(Value);
    }
}
