using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether the Chargeback is actionable and can be responded to.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Not actionable</b></description></item>
/// </list>
/// <para>
/// - <c>1</c> - <b>Actionable</b>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<ChargebacksActionable1>))]
public sealed record ChargebacksActionable1 : OpenIntEnum<ChargebacksActionable1>
{
    private ChargebacksActionable1(long value) : base(value)
    {
    }

    public static readonly ChargebacksActionable1 Value0 = new(0L);

    public static readonly ChargebacksActionable1 Value1 = new(1L);

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
