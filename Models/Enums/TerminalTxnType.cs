using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<TerminalTxnType>))]
public sealed record TerminalTxnType : OpenIntEnum<TerminalTxnType>
{
    private TerminalTxnType(long value) : base(value)
    {
    }

    public static readonly TerminalTxnType Value1 = new(1L);

    public static readonly TerminalTxnType Value2 = new(2L);

    public static readonly TerminalTxnType Value4 = new(4L);

    public static readonly TerminalTxnType Value5 = new(5L);

    public static readonly TerminalTxnType Value13 = new(13L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue13,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value13 => onValue13(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue2,
        Action onValue4,
        Action onValue5,
        Action onValue13,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value13) onValue13();
        else otherwise(Value);
    }
}
