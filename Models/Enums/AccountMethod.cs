using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<AccountMethod>))]
public sealed record AccountMethod : OpenIntEnum<AccountMethod>
{
    private AccountMethod(long value) : base(value)
    {
    }

    public static readonly AccountMethod Value8 = new(8L);

    public static readonly AccountMethod Value9 = new(9L);

    public static readonly AccountMethod Value10 = new(10L);

    public static readonly AccountMethod Value11 = new(11L);

    public TResult Match<TResult>(Func<TResult> onValue8,
        Func<TResult> onValue9,
        Func<TResult> onValue10,
        Func<TResult> onValue11,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value8 => onValue8(),
            _ when this == Value9 => onValue9(),
            _ when this == Value10 => onValue10(),
            _ when this == Value11 => onValue11(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue8, Action onValue9, Action onValue10, Action onValue11, Action<long> otherwise)
    {
        if (this == Value8) onValue8();
        else if (this == Value9) onValue9();
        else if (this == Value10) onValue10();
        else if (this == Value11) onValue11();
        else otherwise(Value);
    }
}
