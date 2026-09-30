using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// If the terminal should be manually or automatically closed for the day.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Automatic</b></description></item>
///   <item><description><c>1</c> - <b>Manual</b></description></item>
///   <item><description><c>2</c> - <b>None</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TerminalsAutoClose1>))]
public sealed record TerminalsAutoClose1 : OpenIntEnum<TerminalsAutoClose1>
{
    private TerminalsAutoClose1(long value) : base(value)
    {
    }

    public static readonly TerminalsAutoClose1 Value0 = new(0L);

    public static readonly TerminalsAutoClose1 Value1 = new(1L);

    public static readonly TerminalsAutoClose1 Value2 = new(2L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0, Action onValue1, Action onValue2, Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else otherwise(Value);
    }
}
