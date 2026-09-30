using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<VasEnablementStatusTargetType>))]
public sealed record VasEnablementStatusTargetType : OpenStringEnum<VasEnablementStatusTargetType>
{
    private VasEnablementStatusTargetType(string value) : base(value)
    {
    }

    public static readonly VasEnablementStatusTargetType Merchant = new("merchant");

    public static readonly VasEnablementStatusTargetType Entity = new("entity");

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
