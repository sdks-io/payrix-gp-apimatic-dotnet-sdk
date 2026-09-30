using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The Product type to which embeddedFinance belongs to.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EmbeddedFinanceProduct2>))]
public sealed record EmbeddedFinanceProduct2 : OpenStringEnum<EmbeddedFinanceProduct2>
{
    private EmbeddedFinanceProduct2(string value) : base(value)
    {
    }

    public static readonly EmbeddedFinanceProduct2 MerchantWorkingCapital = new("merchantWorkingCapital");

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
