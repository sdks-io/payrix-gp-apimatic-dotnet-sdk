using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The Tax Identification Number (TIN) status of the entity.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Pending</b></description></item>
///   <item><description><c>1</c> - <b>Valid</b></description></item>
///   <item><description><c>2</c> - <b>Invalid</b></description></item>
///   <item><description><c>3</c> - <b>Not required</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<EntitiesTinStatus2>))]
public sealed record EntitiesTinStatus2 : OpenIntEnum<EntitiesTinStatus2>
{
    private EntitiesTinStatus2(long value) : base(value)
    {
    }

    public static readonly EntitiesTinStatus2 Value0 = new(0L);

    public static readonly EntitiesTinStatus2 Value1 = new(1L);

    public static readonly EntitiesTinStatus2 Value2 = new(2L);

    public static readonly EntitiesTinStatus2 Value3 = new(3L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0, Action onValue1, Action onValue2, Action onValue3, Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else otherwise(Value);
    }
}
