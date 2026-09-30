using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MerchantStatusReason>))]
public sealed record MerchantStatusReason : OpenStringEnum<MerchantStatusReason>
{
    private MerchantStatusReason(string value) : base(value)
    {
    }

    public static readonly MerchantStatusReason Rejected = new("rejected");

    public static readonly MerchantStatusReason Fraud = new("fraud");

    public static readonly MerchantStatusReason NoResponse = new("noResponse");

    public static readonly MerchantStatusReason Withdrawn = new("withdrawn");

    public TResult Match<TResult>(Func<TResult> onRejected,
        Func<TResult> onFraud,
        Func<TResult> onNoResponse,
        Func<TResult> onWithdrawn,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Rejected => onRejected(),
            _ when this == Fraud => onFraud(),
            _ when this == NoResponse => onNoResponse(),
            _ when this == Withdrawn => onWithdrawn(),
            _ => otherwise(Value)
        };

    public void Match(Action onRejected,
        Action onFraud,
        Action onNoResponse,
        Action onWithdrawn,
        Action<string> otherwise)
    {
        if (this == Rejected) onRejected();
        else if (this == Fraud) onFraud();
        else if (this == NoResponse) onNoResponse();
        else if (this == Withdrawn) onWithdrawn();
        else otherwise(Value);
    }
}
