using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether or not the MFA is enabled.. &lt;details&gt; &lt;summary&gt;Valid Values&lt;/summary&gt;
///   - <c>0</c> - <b>MFA is disabled.</b>
///   - <c>1</c> - <b>MFA is enabled.</b>
///   &lt;/details&gt;
/// </summary>
[JsonConverter(typeof(IntEnumConverter<SessionMfaAuthenticated1>))]
public sealed record SessionMfaAuthenticated1 : OpenIntEnum<SessionMfaAuthenticated1>
{
    private SessionMfaAuthenticated1(long value) : base(value)
    {
    }

    public static readonly SessionMfaAuthenticated1 Value0 = new(0L);

    public static readonly SessionMfaAuthenticated1 Value1 = new(1L);

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
