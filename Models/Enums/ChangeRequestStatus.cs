using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChangeRequestStatus>))]
public sealed record ChangeRequestStatus : OpenStringEnum<ChangeRequestStatus>
{
    private ChangeRequestStatus(string value) : base(value)
    {
    }

    public static readonly ChangeRequestStatus Pending = new("pending");

    public static readonly ChangeRequestStatus ManualReview = new("manualReview");

    public static readonly ChangeRequestStatus Approved = new("approved");

    public static readonly ChangeRequestStatus Declined = new("declined");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onManualReview,
        Func<TResult> onApproved,
        Func<TResult> onDeclined,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == ManualReview => onManualReview(),
            _ when this == Approved => onApproved(),
            _ when this == Declined => onDeclined(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onManualReview,
        Action onApproved,
        Action onDeclined,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == ManualReview) onManualReview();
        else if (this == Approved) onApproved();
        else if (this == Declined) onDeclined();
        else otherwise(Value);
    }
}
