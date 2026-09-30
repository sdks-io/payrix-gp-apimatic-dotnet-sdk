using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of an account verification you want to perform.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>debit</c> - <b>Makes two challenge debits (debit1 and debit2).</b></description></item>
///   <item><description><c>credentials</c> - <b>Uses a bank account credential (username/password).</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountVerificationType2>))]
public sealed record AccountVerificationType2 : OpenStringEnum<AccountVerificationType2>
{
    private AccountVerificationType2(string value) : base(value)
    {
    }

    public static readonly AccountVerificationType2 Debit = new("debit");

    public static readonly AccountVerificationType2 Credentials = new("credentials");

    public TResult Match<TResult>(Func<TResult> onDebit,
        Func<TResult> onCredentials,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Debit => onDebit(),
            _ when this == Credentials => onCredentials(),
            _ => otherwise(Value)
        };

    public void Match(Action onDebit, Action onCredentials, Action<string> otherwise)
    {
        if (this == Debit) onDebit();
        else if (this == Credentials) onCredentials();
        else otherwise(Value);
    }
}
