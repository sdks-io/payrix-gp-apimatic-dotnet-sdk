using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The reason for the auth reversal.
/// This field is set to 'customerCancelled' by default.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>incomplete</c> - <b>Transaction Incomplete.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>timeout</c> - <b>Transaction Timeout.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>clerkCancelled</c> - <b>Transaction Cancelled by Clerk.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>customerCancelled</c> - <b>Transaction Cancelled by Customer.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>misdispense</c> - <b>Misdispense.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>hardwareFailure</c> - <b>Hardware Failure.</b></description></item>
/// </list>
/// <para>
/// - <c>suspectedFraud</c> - <b>Suspected Fraud.</b>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UnauthReason1>))]
public sealed record UnauthReason1 : OpenStringEnum<UnauthReason1>
{
    private UnauthReason1(string value) : base(value)
    {
    }

    public static readonly UnauthReason1 Incomplete = new("incomplete");

    public static readonly UnauthReason1 Timeout = new("timeout");

    public static readonly UnauthReason1 ClerkCancelled = new("clerkCancelled");

    public static readonly UnauthReason1 CustomerCancelled = new("customerCancelled");

    public static readonly UnauthReason1 Misdispense = new("misdispense");

    public static readonly UnauthReason1 HardwareFailure = new("hardwareFailure");

    public static readonly UnauthReason1 SuspectedFraud = new("suspectedFraud");

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
