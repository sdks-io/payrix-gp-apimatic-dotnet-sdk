using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates if the Profit Share should be processed when there is an income, expense, or both.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>income</c> - <b>Profit Share processing for income-only.</b></description></item>
///   <item><description><c>expense</c> - <b>Profit Share processing for expense-only.</b></description></item>
///   <item><description><c>both</c> - <b>Profit Share processing for both income and expense.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProfitShareType1>))]
public sealed record ProfitShareType1 : OpenStringEnum<ProfitShareType1>
{
    private ProfitShareType1(string value) : base(value)
    {
    }

    public static readonly ProfitShareType1 Income = new("income");

    public static readonly ProfitShareType1 Expense = new("expense");

    public static readonly ProfitShareType1 Both = new("both");

    public TResult Match<TResult>(Func<TResult> onIncome,
        Func<TResult> onExpense,
        Func<TResult> onBoth,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Income => onIncome(),
            _ when this == Expense => onExpense(),
            _ when this == Both => onBoth(),
            _ => otherwise(Value)
        };

    public void Match(Action onIncome, Action onExpense, Action onBoth, Action<string> otherwise)
    {
        if (this == Income) onIncome();
        else if (this == Expense) onExpense();
        else if (this == Both) onBoth();
        else otherwise(Value);
    }
}
