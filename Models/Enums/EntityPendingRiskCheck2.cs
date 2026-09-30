using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether it is pending a risk check.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>pending</c> - <b>Pending</b></description></item>
///   <item><description><c>successful</c> - <b>Successful</b></description></item>
///   <item><description><c>failed</c> - <b>Failed</b></description></item>
///   <item><description><c>manual</c> - <b>Manual</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityPendingRiskCheck2>))]
public sealed record EntityPendingRiskCheck2 : OpenStringEnum<EntityPendingRiskCheck2>
{
    private EntityPendingRiskCheck2(string value) : base(value)
    {
    }

    public static readonly EntityPendingRiskCheck2 Pending = new("pending");

    public static readonly EntityPendingRiskCheck2 Successful = new("successful");

    public static readonly EntityPendingRiskCheck2 Failed = new("failed");

    public static readonly EntityPendingRiskCheck2 Manual = new("manual");

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
