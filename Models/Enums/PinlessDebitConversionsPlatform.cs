using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PinlessDebitConversionsPlatform>))]
public sealed record PinlessDebitConversionsPlatform : OpenStringEnum<PinlessDebitConversionsPlatform>
{
    private PinlessDebitConversionsPlatform(string value) : base(value)
    {
    }

    public static readonly PinlessDebitConversionsPlatform Vcore = new("VCORE");

    public TResult Match<TResult>(Func<TResult> onVcore, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Vcore => onVcore(),
            _ => otherwise(Value)
        };

    public void Match(Action onVcore, Action<string> otherwise)
    {
        if (this == Vcore) onVcore();
        else otherwise(Value);
    }
}
