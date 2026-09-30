using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntityPendingRiskCheck>))]
public sealed record EntityPendingRiskCheck : OpenStringEnum<EntityPendingRiskCheck>
{
    private EntityPendingRiskCheck(string value) : base(value)
    {
    }

    public static readonly EntityPendingRiskCheck Pending = new("pending");

    public static readonly EntityPendingRiskCheck Successful = new("successful");

    public static readonly EntityPendingRiskCheck Failed = new("failed");

    public static readonly EntityPendingRiskCheck Manual = new("manual");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onSuccessful,
        Func<TResult> onFailed,
        Func<TResult> onManual,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Successful => onSuccessful(),
            _ when this == Failed => onFailed(),
            _ when this == Manual => onManual(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onSuccessful, Action onFailed, Action onManual, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Successful) onSuccessful();
        else if (this == Failed) onFailed();
        else if (this == Manual) onManual();
        else otherwise(Value);
    }
}
