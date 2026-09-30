using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// This field indicates the entity's current status for the provided service.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status11>))]
public sealed record Status11 : OpenStringEnum<Status11>
{
    private Status11(string value) : base(value)
    {
    }

    public static readonly Status11 Enabled = new("enabled");

    public static readonly Status11 Disabled = new("disabled");

    public TResult Match<TResult>(Func<TResult> onEnabled, Func<TResult> onDisabled, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Enabled => onEnabled(),
            _ when this == Disabled => onDisabled(),
            _ => otherwise(Value)
        };

    public void Match(Action onEnabled, Action onDisabled, Action<string> otherwise)
    {
        if (this == Enabled) onEnabled();
        else if (this == Disabled) onDisabled();
        else otherwise(Value);
    }
}
