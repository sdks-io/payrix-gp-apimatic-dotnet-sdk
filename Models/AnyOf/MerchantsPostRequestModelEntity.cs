using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The Entity associated with this Merchant.
/// </summary>
[JsonConverter(typeof(MerchantsPostRequestModelEntityConverter))]
public record MerchantsPostRequestModelEntity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesPostRequest> _entitiesPostRequestValue;

    private MerchantsPostRequestModelEntity(Optional<string> stringValue,
        Optional<EntitiesPostRequest> entitiesPostRequestValue)
    {
        _stringValue = stringValue;
        _entitiesPostRequestValue = entitiesPostRequestValue;
    }

    public static MerchantsPostRequestModelEntity String(string value) => new(Optional<string>.Some(value), default);

    public static MerchantsPostRequestModelEntity EntitiesPostRequest(EntitiesPostRequest value) =>
        new(default, Optional<EntitiesPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesPostRequest(out EntitiesPostRequest value) =>
        _entitiesPostRequestValue.TryGetValue(out value);

    public static implicit operator MerchantsPostRequestModelEntity(string value) => String(value);

    public static implicit operator MerchantsPostRequestModelEntity(EntitiesPostRequest value) =>
        EntitiesPostRequest(value);
}

file sealed class MerchantsPostRequestModelEntityConverter : JsonConverter<MerchantsPostRequestModelEntity>
{
    public override MerchantsPostRequestModelEntity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return MerchantsPostRequestModelEntity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesPostRequest>(root, options, out var entitiesPostRequestValue))
        {
            return MerchantsPostRequestModelEntity.EntitiesPostRequest(entitiesPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        MerchantsPostRequestModelEntity value,
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
            throw new JsonException($"{nameof(MerchantsPostRequestModelEntity)} contains no valid value to serialize.");
        }
    }
}
