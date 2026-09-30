using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Describes the action code related to the return.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>unknown</c> - <b>Unknown reason</b></description></item>
///   <item><description><c>nsf</c> - <b>Non-sufficient funds</b></description></item>
///   <item><description><c>badAccount</c> - <b>Bad Account Info</b></description></item>
///   <item><description><c>unauthorized</c> - <b>Unauthorized Transaction</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityReturnsActionCode1>))]
public sealed record EntityReturnsActionCode1 : OpenStringEnum<EntityReturnsActionCode1>
{
    private EntityReturnsActionCode1(string value) : base(value)
    {
    }

    public static readonly EntityReturnsActionCode1 Unknown = new("unknown");

    public static readonly EntityReturnsActionCode1 Nsf = new("nsf");

    public static readonly EntityReturnsActionCode1 BadAccount = new("badAccount");

    public static readonly EntityReturnsActionCode1 Unauthorized = new("unauthorized");

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
