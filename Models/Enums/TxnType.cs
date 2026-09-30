using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<TxnType>))]
public sealed record TxnType : OpenIntEnum<TxnType>
{
    private TxnType(long value) : base(value)
    {
    }

    public static readonly TxnType Value1 = new(1L);

    public static readonly TxnType Value2 = new(2L);

    public static readonly TxnType Value3 = new(3L);

    public static readonly TxnType Value4 = new(4L);

    public static readonly TxnType Value5 = new(5L);

    public static readonly TxnType Value7 = new(7L);

    public static readonly TxnType Value8 = new(8L);

    public static readonly TxnType Value11 = new(11L);

    public static readonly TxnType Value12 = new(12L);

    public static readonly TxnType Value14 = new(14L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue7,
        Func<TResult> onValue8,
        Func<TResult> onValue11,
        Func<TResult> onValue12,
        Func<TResult> onValue14,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value7 => onValue7(),
            _ when this == Value8 => onValue8(),
            _ when this == Value11 => onValue11(),
            _ when this == Value12 => onValue12(),
            _ when this == Value14 => onValue14(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue7,
        Action onValue8,
        Action onValue11,
        Action onValue12,
        Action onValue14,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value7) onValue7();
        else if (this == Value8) onValue8();
        else if (this == Value11) onValue11();
        else if (this == Value12) onValue12();
        else if (this == Value14) onValue14();
        else otherwise(Value);
    }
}
