using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReservesLevel>))]
public sealed record ReservesLevel : OpenStringEnum<ReservesLevel>
{
    private ReservesLevel(string value) : base(value)
    {
    }

    public static readonly ReservesLevel Admin = new("admin");

    public static readonly ReservesLevel Division = new("division");

    public static readonly ReservesLevel Merchant = new("merchant");

    public static readonly ReservesLevel Partition = new("partition");

    public TResult Match<TResult>(Func<TResult> onAdmin,
        Func<TResult> onDivision,
        Func<TResult> onMerchant,
        Func<TResult> onPartition,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Admin => onAdmin(),
            _ when this == Division => onDivision(),
            _ when this == Merchant => onMerchant(),
            _ when this == Partition => onPartition(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdmin,
        Action onDivision,
        Action onMerchant,
        Action onPartition,
        Action<string> otherwise)
    {
        if (this == Admin) onAdmin();
        else if (this == Division) onDivision();
        else if (this == Merchant) onMerchant();
        else if (this == Partition) onPartition();
        else otherwise(Value);
    }
}
