using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TxnStatusStr>))]
public sealed record TxnStatusStr : OpenStringEnum<TxnStatusStr>
{
    private TxnStatusStr(string value) : base(value)
    {
    }

    public static readonly TxnStatusStr _0 = new("0");

    public static readonly TxnStatusStr _1 = new("1");

    public static readonly TxnStatusStr _2 = new("2");

    public static readonly TxnStatusStr _3 = new("3");

    public static readonly TxnStatusStr _4 = new("4");

    public static readonly TxnStatusStr _5 = new("5");

    public TResult Match<TResult>(Func<TResult> on_0,
        Func<TResult> on_1,
        Func<TResult> on_2,
        Func<TResult> on_3,
        Func<TResult> on_4,
        Func<TResult> on_5,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _0 => on_0(),
            _ when this == _1 => on_1(),
            _ when this == _2 => on_2(),
            _ when this == _3 => on_3(),
            _ when this == _4 => on_4(),
            _ when this == _5 => on_5(),
            _ => otherwise(Value)
        };

    public void Match(Action on_0,
        Action on_1,
        Action on_2,
        Action on_3,
        Action on_4,
        Action on_5,
        Action<string> otherwise)
    {
        if (this == _0) on_0();
        else if (this == _1) on_1();
        else if (this == _2) on_2();
        else if (this == _3) on_3();
        else if (this == _4) on_4();
        else if (this == _5) on_5();
        else otherwise(Value);
    }
}
