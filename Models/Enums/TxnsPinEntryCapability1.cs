using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates the PIN entry capability of the device, which can be unknown, capable, notCapable, or pinPadDown.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>unknown</c> - <b>Unknown PIN Entry Capability.</b></description></item>
///   <item><description><c>capable</c> - <b>Terminal can accept PINs.</b></description></item>
///   <item><description><c>notCapable</c> - <b>Terminal cannot accept entry of PINs.</b></description></item>
///   <item><description><c>pinPadDown</c> - <b>Terminal PIN Pad is down.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TxnsPinEntryCapability1>))]
public sealed record TxnsPinEntryCapability1 : OpenStringEnum<TxnsPinEntryCapability1>
{
    private TxnsPinEntryCapability1(string value) : base(value)
    {
    }

    public static readonly TxnsPinEntryCapability1 Unknown = new("unknown");

    public static readonly TxnsPinEntryCapability1 Capable = new("capable");

    public static readonly TxnsPinEntryCapability1 NotCapable = new("notCapable");

    public static readonly TxnsPinEntryCapability1 PinPadDown = new("pinPadDown");

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
