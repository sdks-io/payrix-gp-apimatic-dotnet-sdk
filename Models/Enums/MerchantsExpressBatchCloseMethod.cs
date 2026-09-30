using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MerchantsExpressBatchCloseMethod>))]
public sealed record MerchantsExpressBatchCloseMethod : OpenStringEnum<MerchantsExpressBatchCloseMethod>
{
    private MerchantsExpressBatchCloseMethod(string value) : base(value)
    {
    }

    public static readonly MerchantsExpressBatchCloseMethod TimeInitiated = new("TimeInitiated");

    public static readonly MerchantsExpressBatchCloseMethod MerchantInitiated = new("MerchantInitiated");

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
