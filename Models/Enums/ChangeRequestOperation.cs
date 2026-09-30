using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChangeRequestOperation>))]
public sealed record ChangeRequestOperation : OpenStringEnum<ChangeRequestOperation>
{
    private ChangeRequestOperation(string value) : base(value)
    {
    }

    public static readonly ChangeRequestOperation Create = new("create");

    public static readonly ChangeRequestOperation Update = new("update");

    public TResult Match<TResult>(Func<TResult> onCreate, Func<TResult> onUpdate, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Create => onCreate(),
            _ when this == Update => onUpdate(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreate, Action onUpdate, Action<string> otherwise)
    {
        if (this == Create) onCreate();
        else if (this == Update) onUpdate();
        else otherwise(Value);
    }
}
