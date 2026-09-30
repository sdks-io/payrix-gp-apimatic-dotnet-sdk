using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<GlobalBusinessType>))]
public sealed record GlobalBusinessType : OpenStringEnum<GlobalBusinessType>
{
    private GlobalBusinessType(string value) : base(value)
    {
    }

    public static readonly GlobalBusinessType Ssn = new("ssn");

    public static readonly GlobalBusinessType Tin = new("tin");

    public static readonly GlobalBusinessType Other = new("other");

    public static readonly GlobalBusinessType Cd = new("CD");

    public static readonly GlobalBusinessType Ab = new("AB");

    public static readonly GlobalBusinessType Bc = new("BC");

    public static readonly GlobalBusinessType Mb = new("MB");

    public static readonly GlobalBusinessType Nb = new("NB");

    public static readonly GlobalBusinessType Nl = new("NL");

    public static readonly GlobalBusinessType Nt = new("NT");

    public static readonly GlobalBusinessType Ns = new("NS");

    public static readonly GlobalBusinessType Nu = new("NU");

    public static readonly GlobalBusinessType On = new("ON");

    public static readonly GlobalBusinessType Pe = new("PE");

    public static readonly GlobalBusinessType Qc = new("QC");

    public static readonly GlobalBusinessType Sk = new("SK");

    public static readonly GlobalBusinessType Yt = new("YT");

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
