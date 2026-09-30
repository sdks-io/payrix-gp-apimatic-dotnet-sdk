using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UnauthReason>))]
public sealed record UnauthReason : OpenStringEnum<UnauthReason>
{
    private UnauthReason(string value) : base(value)
    {
    }

    public static readonly UnauthReason Incomplete = new("incomplete");

    public static readonly UnauthReason Timeout = new("timeout");

    public static readonly UnauthReason ClerkCancelled = new("clerkCancelled");

    public static readonly UnauthReason CustomerCancelled = new("customerCancelled");

    public static readonly UnauthReason Misdispense = new("misdispense");

    public static readonly UnauthReason HardwareFailure = new("hardwareFailure");

    public static readonly UnauthReason SuspectedFraud = new("suspectedFraud");

    public TResult Match<TResult>(Func<TResult> onIncomplete,
        Func<TResult> onTimeout,
        Func<TResult> onClerkCancelled,
        Func<TResult> onCustomerCancelled,
        Func<TResult> onMisdispense,
        Func<TResult> onHardwareFailure,
        Func<TResult> onSuspectedFraud,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Incomplete => onIncomplete(),
            _ when this == Timeout => onTimeout(),
            _ when this == ClerkCancelled => onClerkCancelled(),
            _ when this == CustomerCancelled => onCustomerCancelled(),
            _ when this == Misdispense => onMisdispense(),
            _ when this == HardwareFailure => onHardwareFailure(),
            _ when this == SuspectedFraud => onSuspectedFraud(),
            _ => otherwise(Value)
        };

    public void Match(Action onIncomplete,
        Action onTimeout,
        Action onClerkCancelled,
        Action onCustomerCancelled,
        Action onMisdispense,
        Action onHardwareFailure,
        Action onSuspectedFraud,
        Action<string> otherwise)
    {
        if (this == Incomplete) onIncomplete();
        else if (this == Timeout) onTimeout();
        else if (this == ClerkCancelled) onClerkCancelled();
        else if (this == CustomerCancelled) onCustomerCancelled();
        else if (this == Misdispense) onMisdispense();
        else if (this == HardwareFailure) onHardwareFailure();
        else if (this == SuspectedFraud) onSuspectedFraud();
        else otherwise(Value);
    }
}
