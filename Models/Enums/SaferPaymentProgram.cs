using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SaferPaymentProgram>))]
public sealed record SaferPaymentProgram : OpenStringEnum<SaferPaymentProgram>
{
    private SaferPaymentProgram(string value) : base(value)
    {
    }

    public static readonly SaferPaymentProgram Basic = new("basic");

    public static readonly SaferPaymentProgram Managed = new("managed");

    public TResult Match<TResult>(Func<TResult> onBasic, Func<TResult> onManaged, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Basic => onBasic(),
            _ when this == Managed => onManaged(),
            _ => otherwise(Value)
        };

    public void Match(Action onBasic, Action onManaged, Action<string> otherwise)
    {
        if (this == Basic) onBasic();
        else if (this == Managed) onManaged();
        else otherwise(Value);
    }
}
