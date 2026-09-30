using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the EntityReturn that is related to this messageThread.
/// </summary>
[JsonConverter(typeof(MessageThreadsModelEntityReturnConverter))]
public record MessageThreadsModelEntityReturn
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntityReturnsResponse> _entityReturnsResponseValue;

    private MessageThreadsModelEntityReturn(Optional<string> stringValue,
        Optional<EntityReturnsResponse> entityReturnsResponseValue)
    {
        _stringValue = stringValue;
        _entityReturnsResponseValue = entityReturnsResponseValue;
    }

    public static MessageThreadsModelEntityReturn String(string value) => new(Optional<string>.Some(value), default);

    public static MessageThreadsModelEntityReturn EntityReturnsResponse(EntityReturnsResponse value) =>
        new(default, Optional<EntityReturnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntityReturnsResponse(out EntityReturnsResponse value) =>
        _entityReturnsResponseValue.TryGetValue(out value);

    public static implicit operator MessageThreadsModelEntityReturn(string value) => String(value);

    public static implicit operator MessageThreadsModelEntityReturn(EntityReturnsResponse value) =>
        EntityReturnsResponse(value);
}

file sealed class MessageThreadsModelEntityReturnConverter : JsonConverter<MessageThreadsModelEntityReturn>
{
    public override MessageThreadsModelEntityReturn Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return MessageThreadsModelEntityReturn.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntityReturnsResponse>(root, options, out var entityReturnsResponseValue))
        {
            return MessageThreadsModelEntityReturn.EntityReturnsResponse(entityReturnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntityReturnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        MessageThreadsModelEntityReturn value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEntityReturnsResponse(out var entityReturnsResponseValue))
        {
            JsonSerializer.Serialize(writer, entityReturnsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(MessageThreadsModelEntityReturn)} contains no valid value to serialize.");
        }
    }
}
