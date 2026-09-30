using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Determines if the themes is the default one for the host.
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// <para>
///   - <c>0</c> - <b>On</b>
///   - <c>1</c> - <b>Off</b>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<HostThemesDefault2>))]
public sealed record HostThemesDefault2 : OpenIntEnum<HostThemesDefault2>
{
    private HostThemesDefault2(long value) : base(value)
    {
    }

    public static readonly HostThemesDefault2 Value0 = new(0L);

    public static readonly HostThemesDefault2 Value1 = new(1L);

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
