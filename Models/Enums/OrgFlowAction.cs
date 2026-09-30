using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<OrgFlowAction>))]
public sealed record OrgFlowAction : OpenStringEnum<OrgFlowAction>
{
    private OrgFlowAction(string value) : base(value)
    {
    }

    public static readonly OrgFlowAction Add = new("add");

    public static readonly OrgFlowAction Remove = new("remove");

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
