using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TxnsPinEntryCapability>))]
public sealed record TxnsPinEntryCapability : OpenStringEnum<TxnsPinEntryCapability>
{
    private TxnsPinEntryCapability(string value) : base(value)
    {
    }

    public static readonly TxnsPinEntryCapability Unknown = new("unknown");

    public static readonly TxnsPinEntryCapability Capable = new("capable");

    public static readonly TxnsPinEntryCapability NotCapable = new("notCapable");

    public static readonly TxnsPinEntryCapability PinPadDown = new("pinPadDown");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onCapable,
        Func<TResult> onNotCapable,
        Func<TResult> onPinPadDown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Capable => onCapable(),
            _ when this == NotCapable => onNotCapable(),
            _ when this == PinPadDown => onPinPadDown(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onCapable,
        Action onNotCapable,
        Action onPinPadDown,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Capable) onCapable();
        else if (this == NotCapable) onNotCapable();
        else if (this == PinPadDown) onPinPadDown();
        else otherwise(Value);
    }
}
