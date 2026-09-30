using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<SimplifiedDepositEnabled>))]
public sealed record SimplifiedDepositEnabled : OpenIntEnum<SimplifiedDepositEnabled>
{
    private SimplifiedDepositEnabled(long value) : base(value)
    {
    }

    public static readonly SimplifiedDepositEnabled Value1 = new(1L);

    public TResult Match<TResult>(Func<TResult> onValue1, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else otherwise(Value);
    }
}
