using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<TerminalTxnStatus>))]
public sealed record TerminalTxnStatus : OpenIntEnum<TerminalTxnStatus>
{
    private TerminalTxnStatus(long value) : base(value)
    {
    }

    public static readonly TerminalTxnStatus Value0 = new(0L);

    public static readonly TerminalTxnStatus Value1 = new(1L);

    public static readonly TerminalTxnStatus Value2 = new(2L);

    public static readonly TerminalTxnStatus Value3 = new(3L);

    public static readonly TerminalTxnStatus Value4 = new(4L);

    public static readonly TerminalTxnStatus Value5 = new(5L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0,
        Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else otherwise(Value);
    }
}
