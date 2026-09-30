using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<VasOptOutService>))]
public sealed record VasOptOutService : OpenStringEnum<VasOptOutService>
{
    private VasOptOutService(string value) : base(value)
    {
    }

    public static readonly VasOptOutService FraudSight = new("fraudSight");

    public TResult Match<TResult>(Func<TResult> onFraudSight, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FraudSight => onFraudSight(),
            _ => otherwise(Value)
        };

    public void Match(Action onFraudSight, Action<string> otherwise)
    {
        if (this == FraudSight) onFraudSight();
        else otherwise(Value);
    }
}
