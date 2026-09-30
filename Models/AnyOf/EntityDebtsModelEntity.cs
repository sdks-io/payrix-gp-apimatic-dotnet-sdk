using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Entity that owes money.
/// </summary>
[JsonConverter(typeof(EntityDebtsModelEntityConverter))]
public record EntityDebtsModelEntity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesResponse> _entitiesResponseValue;

    private EntityDebtsModelEntity(Optional<string> stringValue, Optional<EntitiesResponse> entitiesResponseValue)
    {
        _stringValue = stringValue;
        _entitiesResponseValue = entitiesResponseValue;
    }

    public static EntityDebtsModelEntity String(string value) => new(Optional<string>.Some(value), default);

    public static EntityDebtsModelEntity EntitiesResponse(EntitiesResponse value) =>
        new(default, Optional<EntitiesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesResponse(out EntitiesResponse value) => _entitiesResponseValue.TryGetValue(out value);

    public static implicit operator EntityDebtsModelEntity(string value) => String(value);

    public static implicit operator EntityDebtsModelEntity(EntitiesResponse value) => EntitiesResponse(value);
}

file sealed class EntityDebtsModelEntityConverter : JsonConverter<EntityDebtsModelEntity>
{
    public override EntityDebtsModelEntity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntityDebtsModelEntity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesResponse>(root, options, out var entitiesResponseValue))
        {
            return EntityDebtsModelEntity.EntitiesResponse(entitiesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntityDebtsModelEntity value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(EntityDebtsModelEntity)} contains no valid value to serialize.");
        }
    }
}
