using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InvoiceResultStatus>))]
public sealed record InvoiceResultStatus : OpenStringEnum<InvoiceResultStatus>
{
    private InvoiceResultStatus(string value) : base(value)
    {
    }

    public static readonly InvoiceResultStatus Success = new("success");

    public static readonly InvoiceResultStatus Failure = new("failure");

    public TResult Match<TResult>(Func<TResult> onSuccess, Func<TResult> onFailure, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Failure => onFailure(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess, Action onFailure, Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Failure) onFailure();
        else otherwise(Value);
    }
}
