using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AggregationType>))]
public sealed record AggregationType : OpenStringEnum<AggregationType>
{
    private AggregationType(string value) : base(value)
    {
    }

    public static readonly AggregationType EntityEntryEventMerchant = new("entityEntryEventMerchant");

    public static readonly AggregationType MerchantTxnApprovedAll = new("merchantTxnApprovedAll");

    public static readonly AggregationType MerchantTxnCapturedAll = new("merchantTxnCapturedAll");

    public static readonly AggregationType MerchantTxnFailedAll = new("merchantTxnFailedAll");

    public TResult Match<TResult>(Func<TResult> onEntityEntryEventMerchant,
        Func<TResult> onMerchantTxnApprovedAll,
        Func<TResult> onMerchantTxnCapturedAll,
        Func<TResult> onMerchantTxnFailedAll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == EntityEntryEventMerchant => onEntityEntryEventMerchant(),
            _ when this == MerchantTxnApprovedAll => onMerchantTxnApprovedAll(),
            _ when this == MerchantTxnCapturedAll => onMerchantTxnCapturedAll(),
            _ when this == MerchantTxnFailedAll => onMerchantTxnFailedAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onEntityEntryEventMerchant,
        Action onMerchantTxnApprovedAll,
        Action onMerchantTxnCapturedAll,
        Action onMerchantTxnFailedAll,
        Action<string> otherwise)
    {
        if (this == EntityEntryEventMerchant) onEntityEntryEventMerchant();
        else if (this == MerchantTxnApprovedAll) onMerchantTxnApprovedAll();
        else if (this == MerchantTxnCapturedAll) onMerchantTxnCapturedAll();
        else if (this == MerchantTxnFailedAll) onMerchantTxnFailedAll();
        else otherwise(Value);
    }
}
