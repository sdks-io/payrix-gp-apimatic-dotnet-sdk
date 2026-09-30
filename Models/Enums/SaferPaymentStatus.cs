using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SaferPaymentStatus>))]
public sealed record SaferPaymentStatus : OpenStringEnum<SaferPaymentStatus>
{
    private SaferPaymentStatus(string value) : base(value)
    {
    }

    public static readonly SaferPaymentStatus Compliance = new("compliance");

    public static readonly SaferPaymentStatus NonCompliance = new("non-compliance");

    public static readonly SaferPaymentStatus Pending = new("pending");

    public TResult Match<TResult>(Func<TResult> onCompliance,
        Func<TResult> onNonCompliance,
        Func<TResult> onPending,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Compliance => onCompliance(),
            _ when this == NonCompliance => onNonCompliance(),
            _ when this == Pending => onPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompliance, Action onNonCompliance, Action onPending, Action<string> otherwise)
    {
        if (this == Compliance) onCompliance();
        else if (this == NonCompliance) onNonCompliance();
        else if (this == Pending) onPending();
        else otherwise(Value);
    }
}
