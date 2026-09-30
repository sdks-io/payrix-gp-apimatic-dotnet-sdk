using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<FeeModifiersMarkupUm>))]
public sealed record FeeModifiersMarkupUm : OpenIntEnum<FeeModifiersMarkupUm>
{
    private FeeModifiersMarkupUm(long value) : base(value)
    {
    }

    public static readonly FeeModifiersMarkupUm Value1 = new(1L);

    public static readonly FeeModifiersMarkupUm Value2 = new(2L);

    public TResult Match<TResult>(Func<TResult> onValue1, Func<TResult> onValue2, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action onValue2, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else otherwise(Value);
    }
}
