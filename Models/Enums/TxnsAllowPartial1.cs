using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether to allow partial amount authorizations of this Transaction. For example, if the transaction amount is $1000 and the processor only authorizes a smaller amount, then enabling this field lets the Transaction proceed anyway.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Partial amount authorizations are not allowed.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Partial amount authorizations are allowed.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TxnsAllowPartial1>))]
public sealed record TxnsAllowPartial1 : OpenIntEnum<TxnsAllowPartial1>
{
    private TxnsAllowPartial1(long value) : base(value)
    {
    }

    public static readonly TxnsAllowPartial1 Value0 = new(0L);

    public static readonly TxnsAllowPartial1 Value1 = new(1L);

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
