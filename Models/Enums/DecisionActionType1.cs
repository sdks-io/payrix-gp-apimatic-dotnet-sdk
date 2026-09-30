using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of DecisionAction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>equal</c> - <b>Equal.</b></description></item>
///   <item><description><c>notEqual</c> - <b>Not Equal.</b></description></item>
///   <item><description><c>contains</c> - <b>Contains.</b></description></item>
///   <item><description><c>greater</c> - <b>Greater.</b></description></item>
///   <item><description><c>less</c> - <b>Less.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DecisionActionType1>))]
public sealed record DecisionActionType1 : OpenStringEnum<DecisionActionType1>
{
    private DecisionActionType1(string value) : base(value)
    {
    }

    public static readonly DecisionActionType1 Equal = new("equal");

    public static readonly DecisionActionType1 NotEqual = new("notEqual");

    public static readonly DecisionActionType1 Contains = new("contains");

    public static readonly DecisionActionType1 Greater = new("greater");

    public static readonly DecisionActionType1 Less = new("less");

    public TResult Match<TResult>(Func<TResult> onEqual,
        Func<TResult> onNotEqual,
        Func<TResult> onContains,
        Func<TResult> onGreater,
        Func<TResult> onLess,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Equal => onEqual(),
            _ when this == NotEqual => onNotEqual(),
            _ when this == Contains => onContains(),
            _ when this == Greater => onGreater(),
            _ when this == Less => onLess(),
            _ => otherwise(Value)
        };

    public void Match(Action onEqual,
        Action onNotEqual,
        Action onContains,
        Action onGreater,
        Action onLess,
        Action<string> otherwise)
    {
        if (this == Equal) onEqual();
        else if (this == NotEqual) onNotEqual();
        else if (this == Contains) onContains();
        else if (this == Greater) onGreater();
        else if (this == Less) onLess();
        else otherwise(Value);
    }
}
