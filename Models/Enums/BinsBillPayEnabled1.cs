using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether this card may be used for bill pay features.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Bill pay capability disabled.</b></description></item>
///   <item><description><c>1</c> - <b>Bill pay capability enabled.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<BinsBillPayEnabled1>))]
public sealed record BinsBillPayEnabled1 : OpenIntEnum<BinsBillPayEnabled1>
{
    private BinsBillPayEnabled1(long value) : base(value)
    {
    }

    public static readonly BinsBillPayEnabled1 Value0 = new(0L);

    public static readonly BinsBillPayEnabled1 Value1 = new(1L);

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
