using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of logic to apply with this OrgFlow Rule.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>MCC</c> - <b>Type MCC.</b> The Orgflow applies based on the MCC properties of the merchants.</description></item>
///   <item><description><c>Custom</c> - <b>Type Custom.</b> The Orgflow applies based on the custom properties of the entities.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrgFlowRulesType1>))]
public sealed record OrgFlowRulesType1 : OpenStringEnum<OrgFlowRulesType1>
{
    private OrgFlowRulesType1(string value) : base(value)
    {
    }

    public static readonly OrgFlowRulesType1 Mcc = new("MCC");

    public static readonly OrgFlowRulesType1 Custom = new("Custom");

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
