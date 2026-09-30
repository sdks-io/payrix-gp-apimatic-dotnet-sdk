using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<OrgFlowRulesType>))]
public sealed record OrgFlowRulesType : OpenStringEnum<OrgFlowRulesType>
{
    private OrgFlowRulesType(string value) : base(value)
    {
    }

    public static readonly OrgFlowRulesType Mcc = new("MCC");

    public static readonly OrgFlowRulesType Custom = new("Custom");

    public TResult Match<TResult>(Func<TResult> onMcc, Func<TResult> onCustom, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mcc => onMcc(),
            _ when this == Custom => onCustom(),
            _ => otherwise(Value)
        };

    public void Match(Action onMcc, Action onCustom, Action<string> otherwise)
    {
        if (this == Mcc) onMcc();
        else if (this == Custom) onCustom();
        else otherwise(Value);
    }
}
