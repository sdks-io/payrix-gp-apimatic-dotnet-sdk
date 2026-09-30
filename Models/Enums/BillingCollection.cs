using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BillingCollection>))]
public sealed record BillingCollection : OpenStringEnum<BillingCollection>
{
    private BillingCollection(string value) : base(value)
    {
    }

    public static readonly BillingCollection Entity = new("entity");

    public TResult Match<TResult>(Func<TResult> onEntity, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Entity => onEntity(),
            _ => otherwise(Value)
        };

    public void Match(Action onEntity, Action<string> otherwise)
    {
        if (this == Entity) onEntity();
        else otherwise(Value);
    }
}
