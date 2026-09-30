using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// An integer-boolean indicating whether or not the funding activity was triggered by a fee assessment.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Off</b></description></item>
///   <item><description><c>1</c> - <b>On</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<PendingEntriesIsEfe1>))]
public sealed record PendingEntriesIsEfe1 : OpenIntEnum<PendingEntriesIsEfe1>
{
    private PendingEntriesIsEfe1(long value) : base(value)
    {
    }

    public static readonly PendingEntriesIsEfe1 Value0 = new(0L);

    public static readonly PendingEntriesIsEfe1 Value1 = new(1L);

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
