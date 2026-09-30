using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TaxFormType>))]
public sealed record TaxFormType : OpenStringEnum<TaxFormType>
{
    private TaxFormType(string value) : base(value)
    {
    }

    public static readonly TaxFormType _1099K = new("1099k");

    public TResult Match<TResult>(Func<TResult> on_1099K, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _1099K => on_1099K(),
            _ => otherwise(Value)
        };

    public void Match(Action on_1099K, Action<string> otherwise)
    {
        if (this == _1099K) on_1099K();
        else otherwise(Value);
    }
}
