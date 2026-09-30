using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether or not the Session is created using SSO. &lt;details&gt; &lt;summary&gt;Valid Values&lt;/summary&gt;
///   - <c>0</c> - <b>Session not created with SSO.</b>
///   - <c>1</c> - <b>Session created with SSO.</b>
///   &lt;/details&gt;
/// </summary>
[JsonConverter(typeof(IntEnumConverter<SessionSso2>))]
public sealed record SessionSso2 : OpenIntEnum<SessionSso2>
{
    private SessionSso2(long value) : base(value)
    {
    }

    public static readonly SessionSso2 Value0 = new(0L);

    public static readonly SessionSso2 Value1 = new(1L);

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
