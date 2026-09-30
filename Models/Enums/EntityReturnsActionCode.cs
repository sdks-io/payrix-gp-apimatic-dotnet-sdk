using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntityReturnsActionCode>))]
public sealed record EntityReturnsActionCode : OpenStringEnum<EntityReturnsActionCode>
{
    private EntityReturnsActionCode(string value) : base(value)
    {
    }

    public static readonly EntityReturnsActionCode Unknown = new("unknown");

    public static readonly EntityReturnsActionCode Nsf = new("nsf");

    public static readonly EntityReturnsActionCode BadAccount = new("badAccount");

    public static readonly EntityReturnsActionCode Unauthorized = new("unauthorized");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onNsf,
        Func<TResult> onBadAccount,
        Func<TResult> onUnauthorized,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Nsf => onNsf(),
            _ when this == BadAccount => onBadAccount(),
            _ when this == Unauthorized => onUnauthorized(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onNsf,
        Action onBadAccount,
        Action onUnauthorized,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Nsf) onNsf();
        else if (this == BadAccount) onBadAccount();
        else if (this == Unauthorized) onUnauthorized();
        else otherwise(Value);
    }
}
