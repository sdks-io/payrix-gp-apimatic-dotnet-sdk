using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The reason for manual or closure status.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <para>
///   <c>rejected</c> - <b>Merchant account rejected for servicing.</b>
/// </para>
/// <para>
/// <c>fraud</c> - <b>Merchant or submission was determined to be fraudulent.</b>
/// </para>
/// <para>
/// <c>noResponse</c> - <b>No response given in expected time frame for verification/validation inquiry.</b>
/// </para>
/// <para>
/// <c>withdrawn</c> - <b>Merchant submission withdrawn.</b>
/// </para>
/// <para>
///
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MerchantStatusReason1>))]
public sealed record MerchantStatusReason1 : OpenStringEnum<MerchantStatusReason1>
{
    private MerchantStatusReason1(string value) : base(value)
    {
    }

    public static readonly MerchantStatusReason1 Rejected = new("rejected");

    public static readonly MerchantStatusReason1 Fraud = new("fraud");

    public static readonly MerchantStatusReason1 NoResponse = new("noResponse");

    public static readonly MerchantStatusReason1 Withdrawn = new("withdrawn");

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
