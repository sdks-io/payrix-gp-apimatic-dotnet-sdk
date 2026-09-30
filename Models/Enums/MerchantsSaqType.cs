using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MerchantsSaqType>))]
public sealed record MerchantsSaqType : OpenStringEnum<MerchantsSaqType>
{
    private MerchantsSaqType(string value) : base(value)
    {
    }

    public static readonly MerchantsSaqType SaqA = new("SAQ-A");

    public static readonly MerchantsSaqType SaqAEp = new("SAQ-A-EP");

    public static readonly MerchantsSaqType SaqB = new("SAQ-B");

    public static readonly MerchantsSaqType SaqBIp = new("SAQ-B-IP");

    public static readonly MerchantsSaqType SaqCVt = new("SAQ-C-VT");

    public static readonly MerchantsSaqType SaqC = new("SAQ-C");

    public static readonly MerchantsSaqType SaqP2PeHw = new("SAQ-P2PE-HW");

    public static readonly MerchantsSaqType SaqD = new("SAQ-D");

    public TResult Match<TResult>(Func<TResult> onSaqA,
        Func<TResult> onSaqAEp,
        Func<TResult> onSaqB,
        Func<TResult> onSaqBIp,
        Func<TResult> onSaqCVt,
        Func<TResult> onSaqC,
        Func<TResult> onSaqP2PeHw,
        Func<TResult> onSaqD,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SaqA => onSaqA(),
            _ when this == SaqAEp => onSaqAEp(),
            _ when this == SaqB => onSaqB(),
            _ when this == SaqBIp => onSaqBIp(),
            _ when this == SaqCVt => onSaqCVt(),
            _ when this == SaqC => onSaqC(),
            _ when this == SaqP2PeHw => onSaqP2PeHw(),
            _ when this == SaqD => onSaqD(),
            _ => otherwise(Value)
        };

    public void Match(Action onSaqA,
        Action onSaqAEp,
        Action onSaqB,
        Action onSaqBIp,
        Action onSaqCVt,
        Action onSaqC,
        Action onSaqP2PeHw,
        Action onSaqD,
        Action<string> otherwise)
    {
        if (this == SaqA) onSaqA();
        else if (this == SaqAEp) onSaqAEp();
        else if (this == SaqB) onSaqB();
        else if (this == SaqBIp) onSaqBIp();
        else if (this == SaqCVt) onSaqCVt();
        else if (this == SaqC) onSaqC();
        else if (this == SaqP2PeHw) onSaqP2PeHw();
        else if (this == SaqD) onSaqD();
        else otherwise(Value);
    }
}
