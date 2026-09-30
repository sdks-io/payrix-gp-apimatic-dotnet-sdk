using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If this currency rate relates to a division, then this field stores the identifier of the Division.
/// </summary>
[JsonConverter(typeof(CurrencyRatesModelDivisionConverter))]
public record CurrencyRatesModelDivision
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<DivisionsResponse> _divisionsResponseValue;

    private CurrencyRatesModelDivision(Optional<string> stringValue, Optional<DivisionsResponse> divisionsResponseValue)
    {
        _stringValue = stringValue;
        _divisionsResponseValue = divisionsResponseValue;
    }

    public static CurrencyRatesModelDivision String(string value) => new(Optional<string>.Some(value), default);

    public static CurrencyRatesModelDivision DivisionsResponse(DivisionsResponse value) =>
        new(default, Optional<DivisionsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDivisionsResponse(out DivisionsResponse value) => _divisionsResponseValue.TryGetValue(out value);

    public static implicit operator CurrencyRatesModelDivision(string value) => String(value);

    public static implicit operator CurrencyRatesModelDivision(DivisionsResponse value) => DivisionsResponse(value);
}

file sealed class CurrencyRatesModelDivisionConverter : JsonConverter<CurrencyRatesModelDivision>
{
    public override CurrencyRatesModelDivision Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return CurrencyRatesModelDivision.String(value);
        }
        if (JsonSerializer.TryDeserialize<DivisionsResponse>(root, options, out var divisionsResponseValue))
        {
            return CurrencyRatesModelDivision.DivisionsResponse(divisionsResponseValue);
        }
        throw new JsonException($"JSON does not match string or DivisionsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CurrencyRatesModelDivision value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetDivisionsResponse(out var divisionsResponseValue))
        {
            JsonSerializer.Serialize(writer, divisionsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CurrencyRatesModelDivision)} contains no valid value to serialize.");
        }
    }
}
