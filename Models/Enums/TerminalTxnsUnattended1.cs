using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether the card was swiped at an unattended terminal during this Transaction.
/// This field is set to '0' by default.
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Attended terminal.</b></description></item>
///   <item><description><c>1</c> - <b>Unattended terminal.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TerminalTxnsUnattended1>))]
public sealed record TerminalTxnsUnattended1 : OpenIntEnum<TerminalTxnsUnattended1>
{
    private TerminalTxnsUnattended1(long value) : base(value)
    {
    }

    public static readonly TerminalTxnsUnattended1 Value0 = new(0L);

    public static readonly TerminalTxnsUnattended1 Value1 = new(1L);

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
