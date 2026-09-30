using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EmbededFinancePlatform>))]
public sealed record EmbededFinancePlatform : OpenStringEnum<EmbededFinancePlatform>
{
    private EmbededFinancePlatform(string value) : base(value)
    {
    }

    public static readonly EmbededFinancePlatform Parafin = new("PARAFIN");

    public static readonly EmbededFinancePlatform Atelio = new("ATELIO");

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
