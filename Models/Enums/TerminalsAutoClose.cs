using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<TerminalsAutoClose>))]
public sealed record TerminalsAutoClose : OpenIntEnum<TerminalsAutoClose>
{
    private TerminalsAutoClose(long value) : base(value)
    {
    }

    public static readonly TerminalsAutoClose Value0 = new(0L);

    public static readonly TerminalsAutoClose Value1 = new(1L);

    public static readonly TerminalsAutoClose Value2 = new(2L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0, Action onValue1, Action onValue2, Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else otherwise(Value);
    }
}
