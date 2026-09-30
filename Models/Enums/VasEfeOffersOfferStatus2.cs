using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates the status of a cash advance application submitted by the sub-merchant
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VasEfeOffersOfferStatus2>))]
public sealed record VasEfeOffersOfferStatus2 : OpenStringEnum<VasEfeOffersOfferStatus2>
{
    private VasEfeOffersOfferStatus2(string value) : base(value)
    {
    }

    public static readonly VasEfeOffersOfferStatus2 Active = new("ACTIVE");

    public static readonly VasEfeOffersOfferStatus2 Applied = new("APPLIED");

    public static readonly VasEfeOffersOfferStatus2 Approved = new("APPROVED");

    public static readonly VasEfeOffersOfferStatus2 Expired = new("EXPIRED");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onApplied,
        Func<TResult> onApproved,
        Func<TResult> onExpired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Applied => onApplied(),
            _ when this == Approved => onApproved(),
            _ when this == Expired => onExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onApplied, Action onApproved, Action onExpired, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Applied) onApplied();
        else if (this == Approved) onApproved();
        else if (this == Expired) onExpired();
        else otherwise(Value);
    }
}
