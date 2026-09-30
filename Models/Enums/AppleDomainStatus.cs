using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AppleDomainStatus>))]
public sealed record AppleDomainStatus : OpenStringEnum<AppleDomainStatus>
{
    private AppleDomainStatus(string value) : base(value)
    {
    }

    public static readonly AppleDomainStatus RegistrationRequested = new("registration_requested");

    public static readonly AppleDomainStatus Registering = new("registering");

    public static readonly AppleDomainStatus Registered = new("registered");

    public static readonly AppleDomainStatus FailedRegistration = new("failed_registration");

    public static readonly AppleDomainStatus UnregistrationRequested = new("unregistration_requested");

    public static readonly AppleDomainStatus Unregistering = new("unregistering");

    public static readonly AppleDomainStatus Unregistered = new("unregistered");

    public TResult Match<TResult>(Func<TResult> onRegistrationRequested,
        Func<TResult> onRegistering,
        Func<TResult> onRegistered,
        Func<TResult> onFailedRegistration,
        Func<TResult> onUnregistrationRequested,
        Func<TResult> onUnregistering,
        Func<TResult> onUnregistered,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RegistrationRequested => onRegistrationRequested(),
            _ when this == Registering => onRegistering(),
            _ when this == Registered => onRegistered(),
            _ when this == FailedRegistration => onFailedRegistration(),
            _ when this == UnregistrationRequested => onUnregistrationRequested(),
            _ when this == Unregistering => onUnregistering(),
            _ when this == Unregistered => onUnregistered(),
            _ => otherwise(Value)
        };

    public void Match(Action onRegistrationRequested,
        Action onRegistering,
        Action onRegistered,
        Action onFailedRegistration,
        Action onUnregistrationRequested,
        Action onUnregistering,
        Action onUnregistered,
        Action<string> otherwise)
    {
        if (this == RegistrationRequested) onRegistrationRequested();
        else if (this == Registering) onRegistering();
        else if (this == Registered) onRegistered();
        else if (this == FailedRegistration) onFailedRegistration();
        else if (this == UnregistrationRequested) onUnregistrationRequested();
        else if (this == Unregistering) onUnregistering();
        else if (this == Unregistered) onUnregistered();
        else otherwise(Value);
    }
}
