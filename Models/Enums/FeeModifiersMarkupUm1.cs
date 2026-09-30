using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The unit of measure for the markup amount for the Fee.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Fixed Amount.</b> Specified in the 'markupAmount' field as an integer in cents.</description></item>
///   <item><description><c>2</c> - <b>Percentage.</b> Specified in the 'markupAmount' field in basis points.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<FeeModifiersMarkupUm1>))]
public sealed record FeeModifiersMarkupUm1 : OpenIntEnum<FeeModifiersMarkupUm1>
{
    private FeeModifiersMarkupUm1(long value) : base(value)
    {
    }

    public static readonly FeeModifiersMarkupUm1 Value1 = new(1L);

    public static readonly FeeModifiersMarkupUm1 Value2 = new(2L);

    public TResult Match<TResult>(Func<TResult> onValue1, Func<TResult> onValue2, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action onValue2, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else otherwise(Value);
    }
}
