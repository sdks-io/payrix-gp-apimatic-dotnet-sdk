using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProfitShareType>))]
public sealed record ProfitShareType : OpenStringEnum<ProfitShareType>
{
    private ProfitShareType(string value) : base(value)
    {
    }

    public static readonly ProfitShareType Income = new("income");

    public static readonly ProfitShareType Expense = new("expense");

    public static readonly ProfitShareType Both = new("both");

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
