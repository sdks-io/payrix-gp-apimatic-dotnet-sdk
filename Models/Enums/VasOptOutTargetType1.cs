using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of entity to opt out. Must be either 'merchant' or 'entity'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VasOptOutTargetType1>))]
public sealed record VasOptOutTargetType1 : OpenStringEnum<VasOptOutTargetType1>
{
    private VasOptOutTargetType1(string value) : base(value)
    {
    }

    public static readonly VasOptOutTargetType1 Merchant = new("merchant");

    public static readonly VasOptOutTargetType1 Entity = new("entity");

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
