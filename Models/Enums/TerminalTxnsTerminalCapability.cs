using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<TerminalTxnsTerminalCapability>))]
public sealed record TerminalTxnsTerminalCapability : OpenIntEnum<TerminalTxnsTerminalCapability>
{
    private TerminalTxnsTerminalCapability(long value) : base(value)
    {
    }

    public static readonly TerminalTxnsTerminalCapability Value1 = new(1L);

    public static readonly TerminalTxnsTerminalCapability Value2 = new(2L);

    public static readonly TerminalTxnsTerminalCapability Value3 = new(3L);

    public static readonly TerminalTxnsTerminalCapability Value4 = new(4L);

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
