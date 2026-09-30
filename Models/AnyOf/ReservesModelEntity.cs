using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Entity that this Reserve applies to.
/// </summary>
[JsonConverter(typeof(ReservesModelEntityConverter))]
public record ReservesModelEntity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesResponse> _entitiesResponseValue;

    private ReservesModelEntity(Optional<string> stringValue, Optional<EntitiesResponse> entitiesResponseValue)
    {
        _stringValue = stringValue;
        _entitiesResponseValue = entitiesResponseValue;
    }

    public static ReservesModelEntity String(string value) => new(Optional<string>.Some(value), default);

    public static ReservesModelEntity EntitiesResponse(EntitiesResponse value) =>
        new(default, Optional<EntitiesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesResponse(out EntitiesResponse value) => _entitiesResponseValue.TryGetValue(out value);

    public static implicit operator ReservesModelEntity(string value) => String(value);

    public static implicit operator ReservesModelEntity(EntitiesResponse value) => EntitiesResponse(value);
}

file sealed class ReservesModelEntityConverter : JsonConverter<ReservesModelEntity>
{
    public override ReservesModelEntity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ReservesModelEntity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesResponse>(root, options, out var entitiesResponseValue))
        {
            return ReservesModelEntity.EntitiesResponse(entitiesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ReservesModelEntity value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(ReservesModelEntity)} contains no valid value to serialize.");
        }
    }
}
