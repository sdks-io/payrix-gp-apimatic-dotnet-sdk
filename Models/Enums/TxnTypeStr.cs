using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TxnTypeStr>))]
public sealed record TxnTypeStr : OpenStringEnum<TxnTypeStr>
{
    private TxnTypeStr(string value) : base(value)
    {
    }

    public static readonly TxnTypeStr _1 = new("1");

    public static readonly TxnTypeStr _2 = new("2");

    public static readonly TxnTypeStr _3 = new("3");

    public static readonly TxnTypeStr _4 = new("4");

    public static readonly TxnTypeStr _5 = new("5");

    public static readonly TxnTypeStr _7 = new("7");

    public static readonly TxnTypeStr _8 = new("8");

    public static readonly TxnTypeStr _11 = new("11");

    public static readonly TxnTypeStr _12 = new("12");

    public static readonly TxnTypeStr _14 = new("14");

    public TResult Match<TResult>(Func<TResult> on_1,
        Func<TResult> on_2,
        Func<TResult> on_3,
        Func<TResult> on_4,
        Func<TResult> on_5,
        Func<TResult> on_7,
        Func<TResult> on_8,
        Func<TResult> on_11,
        Func<TResult> on_12,
        Func<TResult> on_14,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _1 => on_1(),
            _ when this == _2 => on_2(),
            _ when this == _3 => on_3(),
            _ when this == _4 => on_4(),
            _ when this == _5 => on_5(),
            _ when this == _7 => on_7(),
            _ when this == _8 => on_8(),
            _ when this == _11 => on_11(),
            _ when this == _12 => on_12(),
            _ when this == _14 => on_14(),
            _ => otherwise(Value)
        };

    public void Match(Action on_1,
        Action on_2,
        Action on_3,
        Action on_4,
        Action on_5,
        Action on_7,
        Action on_8,
        Action on_11,
        Action on_12,
        Action on_14,
        Action<string> otherwise)
    {
        if (this == _1) on_1();
        else if (this == _2) on_2();
        else if (this == _3) on_3();
        else if (this == _4) on_4();
        else if (this == _5) on_5();
        else if (this == _7) on_7();
        else if (this == _8) on_8();
        else if (this == _11) on_11();
        else if (this == _12) on_12();
        else if (this == _14) on_14();
        else otherwise(Value);
    }
}
