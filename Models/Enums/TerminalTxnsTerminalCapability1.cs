using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Capabilities of the terminal device.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Key entry only terminal.</b></description></item>
///   <item><description><c>2</c> - <b>Can read magnetic stripe.</b></description></item>
///   <item><description><c>3</c> - <b>Integrated circuit reader.</b></description></item>
///   <item><description><c>4</c> - <b>Can detect contactless payment.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TerminalTxnsTerminalCapability1>))]
public sealed record TerminalTxnsTerminalCapability1 : OpenIntEnum<TerminalTxnsTerminalCapability1>
{
    private TerminalTxnsTerminalCapability1(long value) : base(value)
    {
    }

    public static readonly TerminalTxnsTerminalCapability1 Value1 = new(1L);

    public static readonly TerminalTxnsTerminalCapability1 Value2 = new(2L);

    public static readonly TerminalTxnsTerminalCapability1 Value3 = new(3L);

    public static readonly TerminalTxnsTerminalCapability1 Value4 = new(4L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action onValue2, Action onValue3, Action onValue4, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else otherwise(Value);
    }
}
