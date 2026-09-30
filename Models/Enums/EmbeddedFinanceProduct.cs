using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EmbeddedFinanceProduct>))]
public sealed record EmbeddedFinanceProduct : OpenStringEnum<EmbeddedFinanceProduct>
{
    private EmbeddedFinanceProduct(string value) : base(value)
    {
    }

    public static readonly EmbeddedFinanceProduct MerchantWorkingCapital = new("merchantWorkingCapital");

    public TResult Match<TResult>(Func<TResult> onMerchantWorkingCapital, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MerchantWorkingCapital => onMerchantWorkingCapital(),
            _ => otherwise(Value)
        };

    public void Match(Action onMerchantWorkingCapital, Action<string> otherwise)
    {
        if (this == MerchantWorkingCapital) onMerchantWorkingCapital();
        else otherwise(Value);
    }
}
