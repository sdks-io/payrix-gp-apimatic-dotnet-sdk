using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConfigurationType>))]
public sealed record ConfigurationType : OpenStringEnum<ConfigurationType>
{
    private ConfigurationType(string value) : base(value)
    {
    }

    public static readonly ConfigurationType Create = new("create");

    public static readonly ConfigurationType Read = new("read");

    public static readonly ConfigurationType Update = new("update");

    public static readonly ConfigurationType Delete = new("delete");

    public TResult Match<TResult>(Func<TResult> onCreate,
        Func<TResult> onRead,
        Func<TResult> onUpdate,
        Func<TResult> onDelete,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Create => onCreate(),
            _ when this == Read => onRead(),
            _ when this == Update => onUpdate(),
            _ when this == Delete => onDelete(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreate, Action onRead, Action onUpdate, Action onDelete, Action<string> otherwise)
    {
        if (this == Create) onCreate();
        else if (this == Read) onRead();
        else if (this == Update) onUpdate();
        else if (this == Delete) onDelete();
        else otherwise(Value);
    }
}
