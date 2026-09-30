using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Entity who should pay this Fee on behalf of the Entity identified in the value of the 'entity' or 'org' field.
/// This field is optional. If it is set, then the Fee is charged to this Entity instead.
/// </summary>
[JsonConverter(typeof(FeeModifiersModelFromentityConverter))]
public record FeeModifiersModelFromentity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesResponse> _entitiesResponseValue;

    private FeeModifiersModelFromentity(Optional<string> stringValue, Optional<EntitiesResponse> entitiesResponseValue)
    {
        _stringValue = stringValue;
        _entitiesResponseValue = entitiesResponseValue;
    }

    public static FeeModifiersModelFromentity String(string value) => new(Optional<string>.Some(value), default);

    public static FeeModifiersModelFromentity EntitiesResponse(EntitiesResponse value) =>
        new(default, Optional<EntitiesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesResponse(out EntitiesResponse value) => _entitiesResponseValue.TryGetValue(out value);

    public static implicit operator FeeModifiersModelFromentity(string value) => String(value);

    public static implicit operator FeeModifiersModelFromentity(EntitiesResponse value) => EntitiesResponse(value);
}

file sealed class FeeModifiersModelFromentityConverter : JsonConverter<FeeModifiersModelFromentity>
{
    public override FeeModifiersModelFromentity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return FeeModifiersModelFromentity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesResponse>(root, options, out var entitiesResponseValue))
        {
            return FeeModifiersModelFromentity.EntitiesResponse(entitiesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, FeeModifiersModelFromentity value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(FeeModifiersModelFromentity)} contains no valid value to serialize.");
        }
    }
}
