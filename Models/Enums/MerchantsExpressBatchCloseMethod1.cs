using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// This field indicates the batch close method for this merchant applicable to Express platform.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>TimeInitiated</c> - <b>Batch close occurs at specific time intervals (Automated).</b></description></item>
///   <item><description><c>MerchantInitiated</c> - <b>Batch close occurs when initiated by the Merchant (Manual).</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantsExpressBatchCloseMethod1>))]
public sealed record MerchantsExpressBatchCloseMethod1 : OpenStringEnum<MerchantsExpressBatchCloseMethod1>
{
    private MerchantsExpressBatchCloseMethod1(string value) : base(value)
    {
    }

    public static readonly MerchantsExpressBatchCloseMethod1 TimeInitiated = new("TimeInitiated");

    public static readonly MerchantsExpressBatchCloseMethod1 MerchantInitiated = new("MerchantInitiated");

    public TResult Match<TResult>(Func<TResult> onTimeInitiated,
        Func<TResult> onMerchantInitiated,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TimeInitiated => onTimeInitiated(),
            _ when this == MerchantInitiated => onMerchantInitiated(),
            _ => otherwise(Value)
        };

    public void Match(Action onTimeInitiated, Action onMerchantInitiated, Action<string> otherwise)
    {
        if (this == TimeInitiated) onTimeInitiated();
        else if (this == MerchantInitiated) onMerchantInitiated();
        else otherwise(Value);
    }
}
