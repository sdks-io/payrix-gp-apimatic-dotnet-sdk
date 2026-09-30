using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates if a transaction is being processed through a Mobile POS.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Non-mobile POS.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Mobile POS.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TxnsMobile1>))]
public sealed record TxnsMobile1 : OpenIntEnum<TxnsMobile1>
{
    private TxnsMobile1(long value) : base(value)
    {
    }

    public static readonly TxnsMobile1 Value0 = new(0L);

    public static readonly TxnsMobile1 Value1 = new(1L);

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
