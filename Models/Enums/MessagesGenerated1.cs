using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether this resource was automatically generated or not.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Message was automatically generated and a value of '0' means it was manually generated.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Message was manually generated.</b></description></item>
/// </list>
/// <para>
///   &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<MessagesGenerated1>))]
public sealed record MessagesGenerated1 : OpenIntEnum<MessagesGenerated1>
{
    private MessagesGenerated1(long value) : base(value)
    {
    }

    public static readonly MessagesGenerated1 Value0 = new(0L);

    public static readonly MessagesGenerated1 Value1 = new(1L);

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
