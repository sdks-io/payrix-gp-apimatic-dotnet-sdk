using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// Entity for which we are creating custom field.
/// </summary>
[JsonConverter(typeof(EntityCustomFieldsPostRequestModelEntityConverter))]
public record EntityCustomFieldsPostRequestModelEntity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesPostRequest> _entitiesPostRequestValue;

    private EntityCustomFieldsPostRequestModelEntity(Optional<string> stringValue,
        Optional<EntitiesPostRequest> entitiesPostRequestValue)
    {
        _stringValue = stringValue;
        _entitiesPostRequestValue = entitiesPostRequestValue;
    }

    public static EntityCustomFieldsPostRequestModelEntity String(string value) =>
        new(Optional<string>.Some(value), default);

    public static EntityCustomFieldsPostRequestModelEntity EntitiesPostRequest(EntitiesPostRequest value) =>
        new(default, Optional<EntitiesPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesPostRequest(out EntitiesPostRequest value) =>
        _entitiesPostRequestValue.TryGetValue(out value);

    public static implicit operator EntityCustomFieldsPostRequestModelEntity(string value) => String(value);

    public static implicit operator EntityCustomFieldsPostRequestModelEntity(EntitiesPostRequest value) =>
        EntitiesPostRequest(value);
}

file sealed class EntityCustomFieldsPostRequestModelEntityConverter : JsonConverter<EntityCustomFieldsPostRequestModelEntity>
{
    public override EntityCustomFieldsPostRequestModelEntity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntityCustomFieldsPostRequestModelEntity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesPostRequest>(root, options, out var entitiesPostRequestValue))
        {
            return EntityCustomFieldsPostRequestModelEntity.EntitiesPostRequest(entitiesPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        EntityCustomFieldsPostRequestModelEntity value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEntitiesPostRequest(out var entitiesPostRequestValue))
        {
            JsonSerializer.Serialize(writer, entitiesPostRequestValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(EntityCustomFieldsPostRequestModelEntity)} contains no valid value to serialize.");
        }
    }
}
