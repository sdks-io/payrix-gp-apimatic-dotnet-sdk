using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChargebackMessageResultType>))]
public sealed record ChargebackMessageResultType : OpenStringEnum<ChargebackMessageResultType>
{
    private ChargebackMessageResultType(string value) : base(value)
    {
    }

    public static readonly ChargebackMessageResultType General = new("general");

    public static readonly ChargebackMessageResultType Platform = new("platform");

    public TResult Match<TResult>(Func<TResult> onGeneral, Func<TResult> onPlatform, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == General => onGeneral(),
            _ when this == Platform => onPlatform(),
            _ => otherwise(Value)
        };

    public void Match(Action onGeneral, Action onPlatform, Action<string> otherwise)
    {
        if (this == General) onGeneral();
        else if (this == Platform) onPlatform();
        else otherwise(Value);
    }
}
