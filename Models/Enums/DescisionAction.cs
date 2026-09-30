using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<DescisionAction>))]
public sealed record DescisionAction : OpenIntEnum<DescisionAction>
{
    private DescisionAction(long value) : base(value)
    {
    }

    public static readonly DescisionAction Value0 = new(0L);

    public static readonly DescisionAction Value1 = new(1L);

    public static readonly DescisionAction Value3 = new(3L);

    public static readonly DescisionAction Value4 = new(4L);

    public static readonly DescisionAction Value5 = new(5L);

    public static readonly DescisionAction Value6 = new(6L);

    public static readonly DescisionAction Value7 = new(7L);

    public static readonly DescisionAction Value8 = new(8L);

    public static readonly DescisionAction Value9 = new(9L);

    public static readonly DescisionAction Value10 = new(10L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
        Func<TResult> onValue7,
        Func<TResult> onValue8,
        Func<TResult> onValue9,
        Func<TResult> onValue10,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value6 => onValue6(),
            _ when this == Value7 => onValue7(),
            _ when this == Value8 => onValue8(),
            _ when this == Value9 => onValue9(),
            _ when this == Value10 => onValue10(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0,
        Action onValue1,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue6,
        Action onValue7,
        Action onValue8,
        Action onValue9,
        Action onValue10,
        Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value6) onValue6();
        else if (this == Value7) onValue7();
        else if (this == Value8) onValue8();
        else if (this == Value9) onValue9();
        else if (this == Value10) onValue10();
        else otherwise(Value);
    }
}
