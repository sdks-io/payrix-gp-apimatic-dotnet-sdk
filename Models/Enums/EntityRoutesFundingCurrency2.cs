using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The currency for which this entity will be funded on.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>USD</c> - <b>US Dollar.</b></description></item>
///   <item><description><c>CAD</c> - <b>Canadian Dollar.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityRoutesFundingCurrency2>))]
public sealed record EntityRoutesFundingCurrency2 : OpenStringEnum<EntityRoutesFundingCurrency2>
{
    private EntityRoutesFundingCurrency2(string value) : base(value)
    {
    }

    public static readonly EntityRoutesFundingCurrency2 Usd = new("USD");

    public static readonly EntityRoutesFundingCurrency2 Cad = new("CAD");

    public TResult Match<TResult>(Func<TResult> onUsd, Func<TResult> onCad, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Usd => onUsd(),
            _ when this == Cad => onCad(),
            _ => otherwise(Value)
        };

    public void Match(Action onUsd, Action onCad, Action<string> otherwise)
    {
        if (this == Usd) onUsd();
        else if (this == Cad) onCad();
        else otherwise(Value);
    }
}
