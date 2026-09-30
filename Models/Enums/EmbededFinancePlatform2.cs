using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The Platform to which embeddedFinance should be applied.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EmbededFinancePlatform2>))]
public sealed record EmbededFinancePlatform2 : OpenStringEnum<EmbededFinancePlatform2>
{
    private EmbededFinancePlatform2(string value) : base(value)
    {
    }

    public static readonly EmbededFinancePlatform2 Parafin = new("PARAFIN");

    public static readonly EmbededFinancePlatform2 Atelio = new("ATELIO");

    public TResult Match<TResult>(Func<TResult> onParafin, Func<TResult> onAtelio, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Parafin => onParafin(),
            _ when this == Atelio => onAtelio(),
            _ => otherwise(Value)
        };

    public void Match(Action onParafin, Action onAtelio, Action<string> otherwise)
    {
        if (this == Parafin) onParafin();
        else if (this == Atelio) onAtelio();
        else otherwise(Value);
    }
}
