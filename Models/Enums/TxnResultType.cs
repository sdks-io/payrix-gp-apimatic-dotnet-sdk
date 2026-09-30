using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<TxnResultType>))]
public sealed record TxnResultType : OpenIntEnum<TxnResultType>
{
    private TxnResultType(long value) : base(value)
    {
    }

    public static readonly TxnResultType Value1 = new(1L);

    public static readonly TxnResultType Value2 = new(2L);

    public static readonly TxnResultType Value3 = new(3L);

    public static readonly TxnResultType Value4 = new(4L);

    public static readonly TxnResultType Value5 = new(5L);

    public static readonly TxnResultType Value6 = new(6L);

    public static readonly TxnResultType Value7 = new(7L);

    public static readonly TxnResultType Value8 = new(8L);

    public static readonly TxnResultType Value9 = new(9L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
        Func<TResult> onValue7,
        Func<TResult> onValue8,
        Func<TResult> onValue9,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value6 => onValue6(),
            _ when this == Value7 => onValue7(),
            _ when this == Value8 => onValue8(),
            _ when this == Value9 => onValue9(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue6,
        Action onValue7,
        Action onValue8,
        Action onValue9,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value6) onValue6();
        else if (this == Value7) onValue7();
        else if (this == Value8) onValue8();
        else if (this == Value9) onValue9();
        else otherwise(Value);
    }
}
