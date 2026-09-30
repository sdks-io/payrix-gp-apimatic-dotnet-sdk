using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of record to retrieve the enablement status for. Must be either 'merchant' or 'entity'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VasEnablementStatusTargetType1>))]
public sealed record VasEnablementStatusTargetType1 : OpenStringEnum<VasEnablementStatusTargetType1>
{
    private VasEnablementStatusTargetType1(string value) : base(value)
    {
    }

    public static readonly VasEnablementStatusTargetType1 Merchant = new("merchant");

    public static readonly VasEnablementStatusTargetType1 Entity = new("entity");

    public TResult Match<TResult>(Func<TResult> onMerchant, Func<TResult> onEntity, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Merchant => onMerchant(),
            _ when this == Entity => onEntity(),
            _ => otherwise(Value)
        };

    public void Match(Action onMerchant, Action onEntity, Action<string> otherwise)
    {
        if (this == Merchant) onMerchant();
        else if (this == Entity) onEntity();
        else otherwise(Value);
    }
}
