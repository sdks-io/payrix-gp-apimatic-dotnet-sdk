using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The action to take in relation to the Entity being processed.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>add</c> - <b>Add the referenced Entity to the referenced Org.</b></description></item>
///   <item><description><c>remove</c> - <b>Remove the referenced Entity from the referenced Org.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrgFlowAction2>))]
public sealed record OrgFlowAction2 : OpenStringEnum<OrgFlowAction2>
{
    private OrgFlowAction2(string value) : base(value)
    {
    }

    public static readonly OrgFlowAction2 Add = new("add");

    public static readonly OrgFlowAction2 Remove = new("remove");

    public TResult Match<TResult>(Func<TResult> onAdd, Func<TResult> onRemove, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Add => onAdd(),
            _ when this == Remove => onRemove(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdd, Action onRemove, Action<string> otherwise)
    {
        if (this == Add) onAdd();
        else if (this == Remove) onRemove();
        else otherwise(Value);
    }
}
