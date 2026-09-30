using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates whether the Transaction is reserved and the action that will be taken as a result.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>No reserve.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TerminalTxnReserved1>))]
public sealed record TerminalTxnReserved1 : OpenIntEnum<TerminalTxnReserved1>
{
    private TerminalTxnReserved1(long value) : base(value)
    {
    }

    public static readonly TerminalTxnReserved1 Value0 = new(0L);

    public TResult Match<TResult>(Func<TResult> onValue0, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0, Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else otherwise(Value);
    }
}
