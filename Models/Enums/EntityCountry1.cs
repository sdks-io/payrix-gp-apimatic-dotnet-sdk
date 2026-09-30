using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The country in the address associated with the Entity, currently accepting values including <c>USA</c> and <c>CAN</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityCountry1>))]
public sealed record EntityCountry1 : OpenStringEnum<EntityCountry1>
{
    private EntityCountry1(string value) : base(value)
    {
    }

    public static readonly EntityCountry1 Usa = new("USA");

    public static readonly EntityCountry1 Can = new("CAN");

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
