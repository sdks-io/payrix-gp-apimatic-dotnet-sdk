using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The minimum level of complexity that all passwords used in this Partition must have.
/// There are four complexity 'factors' that can be evaluated. These are the presence
/// of the following character types in the password: lowercase characters, uppercase
/// characters, integers, and special characters. For instance, the password '123a'
/// would get a complexity rating of '2', since it contains integers and lowercase characters.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Needs to include one type.</b></description></item>
///   <item><description><c>2</c> - <b>Needs to include two types.</b></description></item>
///   <item><description><c>3</c> - <b>Needs to include three types.</b></description></item>
///   <item><description><c>4</c> - <b>Needs to include four types.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<MinPasswordComplexity2>))]
public sealed record MinPasswordComplexity2 : OpenIntEnum<MinPasswordComplexity2>
{
    private MinPasswordComplexity2(long value) : base(value)
    {
    }

    public static readonly MinPasswordComplexity2 Value1 = new(1L);

    public static readonly MinPasswordComplexity2 Value2 = new(2L);

    public static readonly MinPasswordComplexity2 Value3 = new(3L);

    public static readonly MinPasswordComplexity2 Value4 = new(4L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action onValue2, Action onValue3, Action onValue4, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else otherwise(Value);
    }
}
