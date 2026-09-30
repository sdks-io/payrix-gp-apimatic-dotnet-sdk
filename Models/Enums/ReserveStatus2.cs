using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The status of reserve.
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// - <c>1</c> - <b>The reserve is active.</b>
/// - <c>2</c> - <b>The reserve is under review.</b>
/// - <c>3</c> - <b>The reserve is inactive.</b>
/// &lt;/details&gt;
/// </summary>
[JsonConverter(typeof(IntEnumConverter<ReserveStatus2>))]
public sealed record ReserveStatus2 : OpenIntEnum<ReserveStatus2>
{
    private ReserveStatus2(long value) : base(value)
    {
    }

    public static readonly ReserveStatus2 Value1 = new(1L);

    public static readonly ReserveStatus2 Value2 = new(2L);

    public static readonly ReserveStatus2 Value3 = new(3L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action onValue2, Action onValue3, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else otherwise(Value);
    }
}
