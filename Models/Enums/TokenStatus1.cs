using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates if this token is ready for use in transactions and subscriptions or not.
/// A token without complete payment details will be marked as 'pending'.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>pending</c> - <b>The payment data is not yet available, Token is not ready for use.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>ready</c> - <b>The payment data is available, Token is ready for use.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TokenStatus1>))]
public sealed record TokenStatus1 : OpenStringEnum<TokenStatus1>
{
    private TokenStatus1(string value) : base(value)
    {
    }

    public static readonly TokenStatus1 Pending = new("pending");

    public static readonly TokenStatus1 Ready = new("ready");

    public TResult Match<TResult>(Func<TResult> onPending, Func<TResult> onReady, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Ready => onReady(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onReady, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Ready) onReady();
        else otherwise(Value);
    }
}
