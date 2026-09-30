using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<VerificationRefAction>))]
public sealed record VerificationRefAction : OpenStringEnum<VerificationRefAction>
{
    private VerificationRefAction(string value) : base(value)
    {
    }

    public static readonly VerificationRefAction _0 = new("0");

    public static readonly VerificationRefAction _1 = new("1");

    public static readonly VerificationRefAction _3 = new("3");

    public static readonly VerificationRefAction _4 = new("4");

    public static readonly VerificationRefAction _5 = new("5");

    public static readonly VerificationRefAction _6 = new("6");

    public static readonly VerificationRefAction _8 = new("8");

    public static readonly VerificationRefAction ManualReview = new("manualReview");

    public static readonly VerificationRefAction Approved = new("approved");

    public static readonly VerificationRefAction Declined = new("declined");

    public TResult Match<TResult>(Func<TResult> on_0,
        Func<TResult> on_1,
        Func<TResult> on_3,
        Func<TResult> on_4,
        Func<TResult> on_5,
        Func<TResult> on_6,
        Func<TResult> on_8,
        Func<TResult> onManualReview,
        Func<TResult> onApproved,
        Func<TResult> onDeclined,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _0 => on_0(),
            _ when this == _1 => on_1(),
            _ when this == _3 => on_3(),
            _ when this == _4 => on_4(),
            _ when this == _5 => on_5(),
            _ when this == _6 => on_6(),
            _ when this == _8 => on_8(),
            _ when this == ManualReview => onManualReview(),
            _ when this == Approved => onApproved(),
            _ when this == Declined => onDeclined(),
            _ => otherwise(Value)
        };

    public void Match(Action on_0,
        Action on_1,
        Action on_3,
        Action on_4,
        Action on_5,
        Action on_6,
        Action on_8,
        Action onManualReview,
        Action onApproved,
        Action onDeclined,
        Action<string> otherwise)
    {
        if (this == _0) on_0();
        else if (this == _1) on_1();
        else if (this == _3) on_3();
        else if (this == _4) on_4();
        else if (this == _5) on_5();
        else if (this == _6) on_6();
        else if (this == _8) on_8();
        else if (this == ManualReview) onManualReview();
        else if (this == Approved) onApproved();
        else if (this == Declined) onDeclined();
        else otherwise(Value);
    }
}
