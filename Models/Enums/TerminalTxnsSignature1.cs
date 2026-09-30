using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether a signature should be captured during this Transaction.
/// <list type="bullet">
///   <item><description>You can set this field if you want the terminal to take a signature for the Transaction.</description></item>
///   <item><description>The API also sets this field automatically if you associate a signature to the Transaction by creating a 'terminalTxnDatas' resource.</description></item>
/// </list>
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Not captured.</b></description></item>
///   <item><description><c>1</c> - <b>Captured.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TerminalTxnsSignature1>))]
public sealed record TerminalTxnsSignature1 : OpenIntEnum<TerminalTxnsSignature1>
{
    private TerminalTxnsSignature1(long value) : base(value)
    {
    }

    public static readonly TerminalTxnsSignature1 Value0 = new(0L);

    public static readonly TerminalTxnsSignature1 Value1 = new(1L);

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
