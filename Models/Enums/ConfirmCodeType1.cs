using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of this confirmCode.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>password</c> - <b>Forgot Password</b></description></item>
///   <item><description><c>email</c> - <b>Verify Email</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConfirmCodeType1>))]
public sealed record ConfirmCodeType1 : OpenStringEnum<ConfirmCodeType1>
{
    private ConfirmCodeType1(string value) : base(value)
    {
    }

    public static readonly ConfirmCodeType1 Password = new("password");

    public static readonly ConfirmCodeType1 Email = new("email");

    public TResult Match<TResult>(Func<TResult> onPassword, Func<TResult> onEmail, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Password => onPassword(),
            _ when this == Email => onEmail(),
            _ => otherwise(Value)
        };

    public void Match(Action onPassword, Action onEmail, Action<string> otherwise)
    {
        if (this == Password) onPassword();
        else if (this == Email) onEmail();
        else otherwise(Value);
    }
}
