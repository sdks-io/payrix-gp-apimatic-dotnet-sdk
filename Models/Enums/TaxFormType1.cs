using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The tax document type.
/// Valid Value - <c>1099k</c> - <b>1099k Tax Document.</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TaxFormType1>))]
public sealed record TaxFormType1 : OpenStringEnum<TaxFormType1>
{
    private TaxFormType1(string value) : base(value)
    {
    }

    public static readonly TaxFormType1 _1099K = new("1099k");

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
