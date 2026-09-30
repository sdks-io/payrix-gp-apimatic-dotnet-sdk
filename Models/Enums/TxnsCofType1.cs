using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of Card On File transaction when using a token is single, scheduled, or unscheduled.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <para>
/// - <c>single</c>  - <b>Individual Transaction.</b>
/// - <c>scheduled</c>  - <b>Scheduled Transaction.</b>
/// - <c>unscheduled</c>  - <b>Unscheduled sequential Transaction.</b>
/// - <c>installment</c>  - <b>Installment Transaction.</b>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TxnsCofType1>))]
public sealed record TxnsCofType1 : OpenStringEnum<TxnsCofType1>
{
    private TxnsCofType1(string value) : base(value)
    {
    }

    public static readonly TxnsCofType1 Single = new("single");

    public static readonly TxnsCofType1 Scheduled = new("scheduled");

    public static readonly TxnsCofType1 Unscheduled = new("unscheduled");

    public static readonly TxnsCofType1 Installment = new("installment");

    public TResult Match<TResult>(Func<TResult> onSingle,
        Func<TResult> onScheduled,
        Func<TResult> onUnscheduled,
        Func<TResult> onInstallment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Single => onSingle(),
            _ when this == Scheduled => onScheduled(),
            _ when this == Unscheduled => onUnscheduled(),
            _ when this == Installment => onInstallment(),
            _ => otherwise(Value)
        };

    public void Match(Action onSingle,
        Action onScheduled,
        Action onUnscheduled,
        Action onInstallment,
        Action<string> otherwise)
    {
        if (this == Single) onSingle();
        else if (this == Scheduled) onScheduled();
        else if (this == Unscheduled) onUnscheduled();
        else if (this == Installment) onInstallment();
        else otherwise(Value);
    }
}
