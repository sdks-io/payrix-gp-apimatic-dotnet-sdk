using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<FeeCollection>))]
public sealed record FeeCollection : OpenIntEnum<FeeCollection>
{
    private FeeCollection(long value) : base(value)
    {
    }

    public static readonly FeeCollection Value1 = new(1L);

    public static readonly FeeCollection Value2 = new(2L);

    public static readonly FeeCollection Value3 = new(3L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action onValue2, Action onValue3, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else otherwise(Value);
    }
}
