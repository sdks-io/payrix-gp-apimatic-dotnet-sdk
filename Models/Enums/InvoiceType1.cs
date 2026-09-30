using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of invoice.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>single</c> - <b>A single-use invoice.</b></description></item>
///   <item><description><c>multiUse</c> - <b>A static, reusable invoice. (Payment Page.)</b></description></item>
///   <item><description><c>recurring</c> - <b>A subscription-based invoice.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceType1>))]
public sealed record InvoiceType1 : OpenStringEnum<InvoiceType1>
{
    private InvoiceType1(string value) : base(value)
    {
    }

    public static readonly InvoiceType1 Single = new("single");

    public static readonly InvoiceType1 MultiUse = new("multiUse");

    public static readonly InvoiceType1 Recurring = new("recurring");

    public TResult Match<TResult>(Func<TResult> onSingle,
        Func<TResult> onMultiUse,
        Func<TResult> onRecurring,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Single => onSingle(),
            _ when this == MultiUse => onMultiUse(),
            _ when this == Recurring => onRecurring(),
            _ => otherwise(Value)
        };

    public void Match(Action onSingle, Action onMultiUse, Action onRecurring, Action<string> otherwise)
    {
        if (this == Single) onSingle();
        else if (this == MultiUse) onMultiUse();
        else if (this == Recurring) onRecurring();
        else otherwise(Value);
    }
}
