using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Determines whether one-off Payouts are considered when the next Payout is selected.
/// Set this field to '1' to exclude Payouts with a 'schedule' of '5' (Single). Set this field to '0', or omit it, to include them.
/// </summary>
[JsonConverter(typeof(IntEnumConverter<ExcludeSingle1>))]
public sealed record ExcludeSingle1 : OpenIntEnum<ExcludeSingle1>
{
    private ExcludeSingle1(long value) : base(value)
    {
    }

    public static readonly ExcludeSingle1 Value0 = new(0L);

    public static readonly ExcludeSingle1 Value1 = new(1L);

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
