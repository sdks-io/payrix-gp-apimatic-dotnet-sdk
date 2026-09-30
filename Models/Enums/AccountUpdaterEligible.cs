using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<AccountUpdaterEligible>))]
public sealed record AccountUpdaterEligible : OpenIntEnum<AccountUpdaterEligible>
{
    private AccountUpdaterEligible(long value) : base(value)
    {
    }

    public static readonly AccountUpdaterEligible Value1 = new(1L);

    public static readonly AccountUpdaterEligible Value0 = new(0L);

    public TResult Match<TResult>(Func<TResult> onValue1, Func<TResult> onValue0, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value0 => onValue0(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action onValue0, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value0) onValue0();
        else otherwise(Value);
    }
}
