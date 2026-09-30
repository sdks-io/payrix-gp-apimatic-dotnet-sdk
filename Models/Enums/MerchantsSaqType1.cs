using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Payment Card Industry Data Security Standard (PCI DSS) Self-assessment questionnaire (SAQ). Details about a merchant's business and the way they currently accept payments or plan to in the future.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>SAQ-A</c> - <b>Card-not-present merchants (e-commerce or mail/telephone-order) with PCI DSS-validated third-party payments service provider(s) and does not store cardholder data.</b></description></item>
///   <item><description><c>SAQ-A-EP</c> - <b>E-commerce merchants with PCI DSS-validated third-party payments service provider(s) with a website that doesn't directly collect cardholder data, but may impact it in some way, and does not store cardholder data.</b></description></item>
///   <item><description><c>SAQ-B</c> - <b>Merchants with imprint machines or standalone, dial-out terminals that do not store cardholder data.</b></description></item>
///   <item><description><c>SAQ-B-IP</c> - <b>Merchants with standalone, PTS-approved payment terminals that have an IP connection to the payment processor, but do not store cardholder data.</b></description></item>
///   <item><description><c>SAQ-C-VT</c> - <b>Merchants that enter single transactions manually into an internet-based terminal hosted by PCI DSS-validated third-party payments service provider(s) and does not store cardholder data.</b></description></item>
///   <item><description><c>SAQ-C</c> - <b>Merchants with payment application systems connected to the internet that do not store cardholder data.</b></description></item>
///   <item><description><c>SAQ-P2PE-HW</c> - <b>Merchants with hardware-only payment terminals managed by a PCI SSC-listed P2PE solution, and does not store cardholder data.</b></description></item>
///   <item><description><c>SAQ-D</c> - <b>Generic field for all Merchants that do not fall under the requirements for any above SAQ types.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantsSaqType1>))]
public sealed record MerchantsSaqType1 : OpenStringEnum<MerchantsSaqType1>
{
    private MerchantsSaqType1(string value) : base(value)
    {
    }

    public static readonly MerchantsSaqType1 SaqA = new("SAQ-A");

    public static readonly MerchantsSaqType1 SaqAEp = new("SAQ-A-EP");

    public static readonly MerchantsSaqType1 SaqB = new("SAQ-B");

    public static readonly MerchantsSaqType1 SaqBIp = new("SAQ-B-IP");

    public static readonly MerchantsSaqType1 SaqCVt = new("SAQ-C-VT");

    public static readonly MerchantsSaqType1 SaqC = new("SAQ-C");

    public static readonly MerchantsSaqType1 SaqP2PeHw = new("SAQ-P2PE-HW");

    public static readonly MerchantsSaqType1 SaqD = new("SAQ-D");

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
