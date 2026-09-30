using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Allows automatic enablement of simplified deposits for new boardings and allows enablement of existing boardings. Restricted to admin.
/// Valid Values :  - <c>1</c> - <b>Enabled</b>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<SimplifiedDepositEnabled2>))]
public sealed record SimplifiedDepositEnabled2 : OpenIntEnum<SimplifiedDepositEnabled2>
{
    private SimplifiedDepositEnabled2(long value) : base(value)
    {
    }

    public static readonly SimplifiedDepositEnabled2 Value1 = new(1L);

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
