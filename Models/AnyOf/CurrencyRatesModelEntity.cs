using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If this currency rate relates to an entity, then this field stores the identifier of the Entity.
/// </summary>
[JsonConverter(typeof(CurrencyRatesModelEntityConverter))]
public record CurrencyRatesModelEntity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesResponse> _entitiesResponseValue;

    private CurrencyRatesModelEntity(Optional<string> stringValue, Optional<EntitiesResponse> entitiesResponseValue)
    {
        _stringValue = stringValue;
        _entitiesResponseValue = entitiesResponseValue;
    }

    public static CurrencyRatesModelEntity String(string value) => new(Optional<string>.Some(value), default);

    public static CurrencyRatesModelEntity EntitiesResponse(EntitiesResponse value) =>
        new(default, Optional<EntitiesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesResponse(out EntitiesResponse value) => _entitiesResponseValue.TryGetValue(out value);

    public static implicit operator CurrencyRatesModelEntity(string value) => String(value);

    public static implicit operator CurrencyRatesModelEntity(EntitiesResponse value) => EntitiesResponse(value);
}

file sealed class CurrencyRatesModelEntityConverter : JsonConverter<CurrencyRatesModelEntity>
{
    public override CurrencyRatesModelEntity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return CurrencyRatesModelEntity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesResponse>(root, options, out var entitiesResponseValue))
        {
            return CurrencyRatesModelEntity.EntitiesResponse(entitiesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CurrencyRatesModelEntity value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEntitiesResponse(out var entitiesResponseValue))
        {
            JsonSerializer.Serialize(writer, entitiesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CurrencyRatesModelEntity)} contains no valid value to serialize.");
        }
    }
}
