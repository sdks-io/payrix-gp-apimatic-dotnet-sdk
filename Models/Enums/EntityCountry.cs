using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntityCountry>))]
public sealed record EntityCountry : OpenStringEnum<EntityCountry>
{
    private EntityCountry(string value) : base(value)
    {
    }

    public static readonly EntityCountry Usa = new("USA");

    public static readonly EntityCountry Can = new("CAN");

    public TResult Match<TResult>(Func<TResult> onUsa, Func<TResult> onCan, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Usa => onUsa(),
            _ when this == Can => onCan(),
            _ => otherwise(Value)
        };

    public void Match(Action onUsa, Action onCan, Action<string> otherwise)
    {
        if (this == Usa) onUsa();
        else if (this == Can) onCan();
        else otherwise(Value);
    }
}
