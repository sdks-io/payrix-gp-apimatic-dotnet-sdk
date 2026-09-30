using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of score result on the related Decision.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>low</c> - <b>Only applies if the check hit the low of the parent decision.</b></description></item>
///   <item><description><c>high</c> - <b>Only applies if the check hit the high of the parent decision.</b></description></item>
///   <item><description><c>none</c> - <b>Only applies if the check did not hit the high or low of the parent decision.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DecisionActionsScoreType1>))]
public sealed record DecisionActionsScoreType1 : OpenStringEnum<DecisionActionsScoreType1>
{
    private DecisionActionsScoreType1(string value) : base(value)
    {
    }

    public static readonly DecisionActionsScoreType1 Low = new("low");

    public static readonly DecisionActionsScoreType1 High = new("high");

    public static readonly DecisionActionsScoreType1 None = new("none");

    public TResult Match<TResult>(Func<TResult> onLow,
        Func<TResult> onHigh,
        Func<TResult> onNone,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Low => onLow(),
            _ when this == High => onHigh(),
            _ when this == None => onNone(),
            _ => otherwise(Value)
        };

    public void Match(Action onLow, Action onHigh, Action onNone, Action<string> otherwise)
    {
        if (this == Low) onLow();
        else if (this == High) onHigh();
        else if (this == None) onNone();
        else otherwise(Value);
    }
}
