using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of logic to apply with this ProfitShare Rule.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>less</c> - <b>The ProfitShare applies only if the entry amount is lower than the amount set in the 'value' field of the ProfitShare Rule.</b></description></item>
///   <item><description><c>equal</c> - <b>The ProfitShare applies only if the entry amount is exactly the same as the amount set in the 'value' field of the ProfitShare Rule.</b></description></item>
///   <item><description><c>notEqual</c> - <b>The ProfitShare applies only if the entry amount is not exactly equal to the amount set in the 'value' field of the ProfitShare Rule.</b></description></item>
///   <item><description><c>greater</c> - <b>The ProfitShare applies only if the entry amount is higher than the amount set in the 'value' field of the ProfitShare Rule.</b></description></item>
///   <item><description><c>event</c> - <b>The ProfitShare applies only if the entry event is exactly the same as the event set in the 'value' field of the ProfitShare Rule.</b></description></item>
///   <item><description><c>notEvent</c> - <b>The ProfitShare applies only if the entry event is not exactly equal to the event set in the 'value' field of the ProfitShare Rule.</b></description></item>
///   <item><description><c>fee</c> - <b>The ProfitShare applies only if the entry fee is exactly the same as the fee set in the 'value' field of the ProfitShare Rule.</b></description></item>
///   <item><description><c>notFee</c> - <b>The ProfitShare applies only if the entry fee is not exactly equal to the fee set in the 'value' field of the ProfitShare Rule.</b></description></item>
///   <item><description><c>fromentity</c> - <b>The ProfitShare applies only if the entry fromentity (or opposingEntryfromentity) is exactly the same as the entity set in the 'value' field of the ProfitShare Rule.</b></description></item>
///   <item><description><c>notFromentity</c> - <b>The ProfitShare applies only if the entry fromentity (or opposingEntryfromentity) is not exactly equal to the entity set in the 'value' field of the ProfitShare Rule.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProfitShareRuleType2>))]
public sealed record ProfitShareRuleType2 : OpenStringEnum<ProfitShareRuleType2>
{
    private ProfitShareRuleType2(string value) : base(value)
    {
    }

    public static readonly ProfitShareRuleType2 Less = new("less");

    public static readonly ProfitShareRuleType2 Equal = new("equal");

    public static readonly ProfitShareRuleType2 NotEqual = new("notEqual");

    public static readonly ProfitShareRuleType2 Greater = new("greater");

    public static readonly ProfitShareRuleType2 Event = new("event");

    public static readonly ProfitShareRuleType2 NotEvent = new("notEvent");

    public static readonly ProfitShareRuleType2 Fee = new("fee");

    public static readonly ProfitShareRuleType2 NotFee = new("notFee");

    public static readonly ProfitShareRuleType2 Fromentity = new("fromentity");

    public static readonly ProfitShareRuleType2 NotFromentity = new("notFromentity");

    public TResult Match<TResult>(Func<TResult> onLess,
        Func<TResult> onEqual,
        Func<TResult> onNotEqual,
        Func<TResult> onGreater,
        Func<TResult> onEvent,
        Func<TResult> onNotEvent,
        Func<TResult> onFee,
        Func<TResult> onNotFee,
        Func<TResult> onFromentity,
        Func<TResult> onNotFromentity,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Less => onLess(),
            _ when this == Equal => onEqual(),
            _ when this == NotEqual => onNotEqual(),
            _ when this == Greater => onGreater(),
            _ when this == Event => onEvent(),
            _ when this == NotEvent => onNotEvent(),
            _ when this == Fee => onFee(),
            _ when this == NotFee => onNotFee(),
            _ when this == Fromentity => onFromentity(),
            _ when this == NotFromentity => onNotFromentity(),
            _ => otherwise(Value)
        };

    public void Match(Action onLess,
        Action onEqual,
        Action onNotEqual,
        Action onGreater,
        Action onEvent,
        Action onNotEvent,
        Action onFee,
        Action onNotFee,
        Action onFromentity,
        Action onNotFromentity,
        Action<string> otherwise)
    {
        if (this == Less) onLess();
        else if (this == Equal) onEqual();
        else if (this == NotEqual) onNotEqual();
        else if (this == Greater) onGreater();
        else if (this == Event) onEvent();
        else if (this == NotEvent) onNotEvent();
        else if (this == Fee) onFee();
        else if (this == NotFee) onNotFee();
        else if (this == Fromentity) onFromentity();
        else if (this == NotFromentity) onNotFromentity();
        else otherwise(Value);
    }
}
