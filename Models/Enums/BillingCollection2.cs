using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Determines who will be billed.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>entity</c> - <b>The entity will be billed.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BillingCollection2>))]
public sealed record BillingCollection2 : OpenStringEnum<BillingCollection2>
{
    private BillingCollection2(string value) : base(value)
    {
    }

    public static readonly BillingCollection2 Entity = new("entity");

    public TResult Match<TResult>(Func<TResult> onEntity, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Entity => onEntity(),
            _ => otherwise(Value)
        };

    public void Match(Action onEntity, Action<string> otherwise)
    {
        if (this == Entity) onEntity();
        else otherwise(Value);
    }
}
