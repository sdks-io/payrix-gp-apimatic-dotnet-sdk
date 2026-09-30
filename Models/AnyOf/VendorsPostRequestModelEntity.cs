using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Entity associated with this Vendor resource.
/// </summary>
[JsonConverter(typeof(VendorsPostRequestModelEntityConverter))]
public record VendorsPostRequestModelEntity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesPostRequest> _entitiesPostRequestValue;

    private VendorsPostRequestModelEntity(Optional<string> stringValue,
        Optional<EntitiesPostRequest> entitiesPostRequestValue)
    {
        _stringValue = stringValue;
        _entitiesPostRequestValue = entitiesPostRequestValue;
    }

    public static VendorsPostRequestModelEntity String(string value) => new(Optional<string>.Some(value), default);

    public static VendorsPostRequestModelEntity EntitiesPostRequest(EntitiesPostRequest value) =>
        new(default, Optional<EntitiesPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesPostRequest(out EntitiesPostRequest value) =>
        _entitiesPostRequestValue.TryGetValue(out value);

    public static implicit operator VendorsPostRequestModelEntity(string value) => String(value);

    public static implicit operator VendorsPostRequestModelEntity(EntitiesPostRequest value) =>
        EntitiesPostRequest(value);
}

file sealed class VendorsPostRequestModelEntityConverter : JsonConverter<VendorsPostRequestModelEntity>
{
    public override VendorsPostRequestModelEntity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return VendorsPostRequestModelEntity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesPostRequest>(root, options, out var entitiesPostRequestValue))
        {
            return VendorsPostRequestModelEntity.EntitiesPostRequest(entitiesPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        VendorsPostRequestModelEntity value,
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
            throw new JsonException($"{nameof(VendorsPostRequestModelEntity)} contains no valid value to serialize.");
        }
    }
}
