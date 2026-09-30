using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<VasEfeOffersOfferStatus>))]
public sealed record VasEfeOffersOfferStatus : OpenStringEnum<VasEfeOffersOfferStatus>
{
    private VasEfeOffersOfferStatus(string value) : base(value)
    {
    }

    public static readonly VasEfeOffersOfferStatus Active = new("ACTIVE");

    public static readonly VasEfeOffersOfferStatus Applied = new("APPLIED");

    public static readonly VasEfeOffersOfferStatus Approved = new("APPROVED");

    public static readonly VasEfeOffersOfferStatus Expired = new("EXPIRED");

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
