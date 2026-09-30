using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InvoiceType>))]
public sealed record InvoiceType : OpenStringEnum<InvoiceType>
{
    private InvoiceType(string value) : base(value)
    {
    }

    public static readonly InvoiceType Single = new("single");

    public static readonly InvoiceType MultiUse = new("multiUse");

    public static readonly InvoiceType Recurring = new("recurring");

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
