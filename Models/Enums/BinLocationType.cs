using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BinLocationType>))]
public sealed record BinLocationType : OpenStringEnum<BinLocationType>
{
    private BinLocationType(string value) : base(value)
    {
    }

    public static readonly BinLocationType Branch = new("branch");

    public static readonly BinLocationType Main = new("main");

    public TResult Match<TResult>(Func<TResult> onBranch, Func<TResult> onMain, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Branch => onBranch(),
            _ when this == Main => onMain(),
            _ => otherwise(Value)
        };

    public void Match(Action onBranch, Action onMain, Action<string> otherwise)
    {
        if (this == Branch) onBranch();
        else if (this == Main) onMain();
        else otherwise(Value);
    }
}
