using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of configuration resource.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>create</c> - <b>Create type of configuration.</b></description></item>
///   <item><description><c>read</c> - <b>Read type of configuration.</b></description></item>
///   <item><description><c>update</c> - <b>Update type of configuration.</b></description></item>
///   <item><description><c>delete</c> - <b>Delete type of configuration.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConfigurationType1>))]
public sealed record ConfigurationType1 : OpenStringEnum<ConfigurationType1>
{
    private ConfigurationType1(string value) : base(value)
    {
    }

    public static readonly ConfigurationType1 Create = new("create");

    public static readonly ConfigurationType1 Read = new("read");

    public static readonly ConfigurationType1 Update = new("update");

    public static readonly ConfigurationType1 Delete = new("delete");

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
