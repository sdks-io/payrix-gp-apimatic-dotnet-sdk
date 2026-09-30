using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of the fee.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Fee.</b> A Standard Fee.</description></item>
///   <item><description><c>2</c> - <b>Assessment.</b> A Third-Party Platform Fee.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<FeeType1>))]
public sealed record FeeType1 : OpenIntEnum<FeeType1>
{
    private FeeType1(long value) : base(value)
    {
    }

    public static readonly FeeType1 Value1 = new(1L);

    public static readonly FeeType1 Value2 = new(2L);

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
