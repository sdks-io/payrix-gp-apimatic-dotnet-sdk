using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The Value Added Service to retrieve the enablement status for. Currently only 'FraudSight' is supported.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VasEnablementStatusService1>))]
public sealed record VasEnablementStatusService1 : OpenStringEnum<VasEnablementStatusService1>
{
    private VasEnablementStatusService1(string value) : base(value)
    {
    }

    public static readonly VasEnablementStatusService1 FraudSight = new("fraudSight");

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
