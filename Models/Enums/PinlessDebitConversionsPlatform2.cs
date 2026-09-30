using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The platform used to process this transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PinlessDebitConversionsPlatform2>))]
public sealed record PinlessDebitConversionsPlatform2 : OpenStringEnum<PinlessDebitConversionsPlatform2>
{
    private PinlessDebitConversionsPlatform2(string value) : base(value)
    {
    }

    public static readonly PinlessDebitConversionsPlatform2 Vcore = new("VCORE");

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
