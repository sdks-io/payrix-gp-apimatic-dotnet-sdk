using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of aggregation. This will automatically set the search and total values.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>entityEntryEventMerchant</c> - <b>A merchant entry.</b></description></item>
///   <item><description><c>merchantTxnApprovedAll</c> - <b>All merchant transactions approved.</b></description></item>
///   <item><description><c>merchantTxnCapturedAll</c> - <b>All merchant transactions captured.</b></description></item>
///   <item><description><c>merchantTxnFailedAll</c> - <b>All merchant transactions failed.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AggregationType1>))]
public sealed record AggregationType1 : OpenStringEnum<AggregationType1>
{
    private AggregationType1(string value) : base(value)
    {
    }

    public static readonly AggregationType1 EntityEntryEventMerchant = new("entityEntryEventMerchant");

    public static readonly AggregationType1 MerchantTxnApprovedAll = new("merchantTxnApprovedAll");

    public static readonly AggregationType1 MerchantTxnCapturedAll = new("merchantTxnCapturedAll");

    public static readonly AggregationType1 MerchantTxnFailedAll = new("merchantTxnFailedAll");

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
