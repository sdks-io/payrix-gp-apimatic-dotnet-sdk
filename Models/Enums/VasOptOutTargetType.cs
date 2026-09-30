using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<VasOptOutTargetType>))]
public sealed record VasOptOutTargetType : OpenStringEnum<VasOptOutTargetType>
{
    private VasOptOutTargetType(string value) : base(value)
    {
    }

    public static readonly VasOptOutTargetType Merchant = new("merchant");

    public static readonly VasOptOutTargetType Entity = new("entity");

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
