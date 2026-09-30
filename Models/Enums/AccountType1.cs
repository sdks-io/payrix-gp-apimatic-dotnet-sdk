using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of financial account: debit, credit, or both.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>all</c> - <b>Debit/checking and credit</b></description></item>
///   <item><description><c>credit</c> - <b>Credit only</b></description></item>
///   <item><description><c>debit</c> - <b>Debit/checking only</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType1>))]
public sealed record AccountType1 : OpenStringEnum<AccountType1>
{
    private AccountType1(string value) : base(value)
    {
    }

    public static readonly AccountType1 All = new("all");

    public static readonly AccountType1 Credit = new("credit");

    public static readonly AccountType1 Debit = new("debit");

    public TResult Match<TResult>(Func<TResult> onAll,
        Func<TResult> onCredit,
        Func<TResult> onDebit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == All => onAll(),
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ => otherwise(Value)
        };

    public void Match(Action onAll, Action onCredit, Action onDebit, Action<string> otherwise)
    {
        if (this == All) onAll();
        else if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else otherwise(Value);
    }
}
