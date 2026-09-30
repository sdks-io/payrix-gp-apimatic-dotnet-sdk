using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TxnsCopyReasons>))]
public sealed record TxnsCopyReasons : OpenStringEnum<TxnsCopyReasons>
{
    private TxnsCopyReasons(string value) : base(value)
    {
    }

    public static readonly TxnsCopyReasons Resubmission = new("resubmission");

    public static readonly TxnsCopyReasons Reauthorization = new("reauthorization");

    public TResult Match<TResult>(Func<TResult> onResubmission,
        Func<TResult> onReauthorization,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Resubmission => onResubmission(),
            _ when this == Reauthorization => onReauthorization(),
            _ => otherwise(Value)
        };

    public void Match(Action onResubmission, Action onReauthorization, Action<string> otherwise)
    {
        if (this == Resubmission) onResubmission();
        else if (this == Reauthorization) onReauthorization();
        else otherwise(Value);
    }
}
