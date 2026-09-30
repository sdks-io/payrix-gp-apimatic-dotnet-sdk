using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// For a plan that is attached to a billing, this is the paying entity to match to the generated statements of that billing for which the recurring payments will be made.
/// </summary>
[JsonConverter(typeof(SubscriptionsModelStatementEntityConverter))]
public record SubscriptionsModelStatementEntity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesResponse> _entitiesResponseValue;

    private SubscriptionsModelStatementEntity(Optional<string> stringValue,
        Optional<EntitiesResponse> entitiesResponseValue)
    {
        _stringValue = stringValue;
        _entitiesResponseValue = entitiesResponseValue;
    }

    public static SubscriptionsModelStatementEntity String(string value) => new(Optional<string>.Some(value), default);

    public static SubscriptionsModelStatementEntity EntitiesResponse(EntitiesResponse value) =>
        new(default, Optional<EntitiesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesResponse(out EntitiesResponse value) => _entitiesResponseValue.TryGetValue(out value);

    public static implicit operator SubscriptionsModelStatementEntity(string value) => String(value);

    public static implicit operator SubscriptionsModelStatementEntity(EntitiesResponse value) =>
        EntitiesResponse(value);
}

file sealed class SubscriptionsModelStatementEntityConverter : JsonConverter<SubscriptionsModelStatementEntity>
{
    public override SubscriptionsModelStatementEntity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SubscriptionsModelStatementEntity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesResponse>(root, options, out var entitiesResponseValue))
        {
            return SubscriptionsModelStatementEntity.EntitiesResponse(entitiesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SubscriptionsModelStatementEntity value,
        JsonSerializerOptions options)
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
            throw new JsonException(
                $"{nameof(SubscriptionsModelStatementEntity)} contains no valid value to serialize.");
        }
    }
}
