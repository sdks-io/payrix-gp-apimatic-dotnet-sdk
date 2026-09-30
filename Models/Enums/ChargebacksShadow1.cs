using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Not shadowed.</b></description></item>
/// </list>
/// <para>
/// - <c>1</c> - <b>Shadowed.</b>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<ChargebacksShadow1>))]
public sealed record ChargebacksShadow1 : OpenIntEnum<ChargebacksShadow1>
{
    private ChargebacksShadow1(long value) : base(value)
    {
    }

    public static readonly ChargebacksShadow1 Value0 = new(0L);

    public static readonly ChargebacksShadow1 Value1 = new(1L);

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
