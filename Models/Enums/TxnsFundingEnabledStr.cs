using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TxnsFundingEnabledStr>))]
public sealed record TxnsFundingEnabledStr : OpenStringEnum<TxnsFundingEnabledStr>
{
    private TxnsFundingEnabledStr(string value) : base(value)
    {
    }

    public static readonly TxnsFundingEnabledStr _0 = new("0");

    public static readonly TxnsFundingEnabledStr _1 = new("1");

    public TResult Match<TResult>(Func<TResult> on_0, Func<TResult> on_1, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _0 => on_0(),
            _ when this == _1 => on_1(),
            _ => otherwise(Value)
        };

    public void Match(Action on_0, Action on_1, Action<string> otherwise)
    {
        if (this == _0) on_0();
        else if (this == _1) on_1();
        else otherwise(Value);
    }
}
