using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConfirmCodeType>))]
public sealed record ConfirmCodeType : OpenStringEnum<ConfirmCodeType>
{
    private ConfirmCodeType(string value) : base(value)
    {
    }

    public static readonly ConfirmCodeType Password = new("password");

    public static readonly ConfirmCodeType Email = new("email");

    public TResult Match<TResult>(Func<TResult> onPassword, Func<TResult> onEmail, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Password => onPassword(),
            _ when this == Email => onEmail(),
            _ => otherwise(Value)
        };

    public void Match(Action onPassword, Action onEmail, Action<string> otherwise)
    {
        if (this == Password) onPassword();
        else if (this == Email) onEmail();
        else otherwise(Value);
    }
}
