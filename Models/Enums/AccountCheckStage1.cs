using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The last stage completed for risk.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>createAccount</c> - <b>Create Account</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountCheckStage1>))]
public sealed record AccountCheckStage1 : OpenStringEnum<AccountCheckStage1>
{
    private AccountCheckStage1(string value) : base(value)
    {
    }

    public static readonly AccountCheckStage1 CreateAccount = new("createAccount");

    public TResult Match<TResult>(Func<TResult> onCreateAccount, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CreateAccount => onCreateAccount(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreateAccount, Action<string> otherwise)
    {
        if (this == CreateAccount) onCreateAccount();
        else otherwise(Value);
    }
}
