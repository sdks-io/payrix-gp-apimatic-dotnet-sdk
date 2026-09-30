using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<PayoutFlowsSkipOffDays>))]
public sealed record PayoutFlowsSkipOffDays : OpenIntEnum<PayoutFlowsSkipOffDays>
{
    private PayoutFlowsSkipOffDays(long value) : base(value)
    {
    }

    public static readonly PayoutFlowsSkipOffDays Value0 = new(0L);

    public static readonly PayoutFlowsSkipOffDays Value1 = new(1L);

    public TResult Match<TResult>(Func<TResult> onValue0, Func<TResult> onValue1, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0, Action onValue1, Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else otherwise(Value);
    }
}
