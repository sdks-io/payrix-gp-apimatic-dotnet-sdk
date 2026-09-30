using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether this entityRef is the default one. Default entityRefs will have priority when processing transactions with no MID or Platform set. &lt;details&gt; &lt;summary&gt;Valid Values&lt;/summary&gt; - <c>0</c> - <b>Not default.</b> - <c>1</c> - <b>Default.</b> &lt;/details&gt;
/// </summary>
[JsonConverter(typeof(IntEnumConverter<EntityDefault2>))]
public sealed record EntityDefault2 : OpenIntEnum<EntityDefault2>
{
    private EntityDefault2(long value) : base(value)
    {
    }

    public static readonly EntityDefault2 Value0 = new(0L);

    public static readonly EntityDefault2 Value1 = new(1L);

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
