using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The Entities object which is paying the money.
/// </summary>
[JsonConverter(typeof(RevShareStatmentsModelForentityConverter))]
public record RevShareStatmentsModelForentity
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntitiesResponse> _entitiesResponseValue;

    private RevShareStatmentsModelForentity(Optional<string> stringValue,
        Optional<EntitiesResponse> entitiesResponseValue)
    {
        _stringValue = stringValue;
        _entitiesResponseValue = entitiesResponseValue;
    }

    public static RevShareStatmentsModelForentity String(string value) => new(Optional<string>.Some(value), default);

    public static RevShareStatmentsModelForentity EntitiesResponse(EntitiesResponse value) =>
        new(default, Optional<EntitiesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntitiesResponse(out EntitiesResponse value) => _entitiesResponseValue.TryGetValue(out value);

    public static implicit operator RevShareStatmentsModelForentity(string value) => String(value);

    public static implicit operator RevShareStatmentsModelForentity(EntitiesResponse value) => EntitiesResponse(value);
}

file sealed class RevShareStatmentsModelForentityConverter : JsonConverter<RevShareStatmentsModelForentity>
{
    public override RevShareStatmentsModelForentity Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return RevShareStatmentsModelForentity.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntitiesResponse>(root, options, out var entitiesResponseValue))
        {
            return RevShareStatmentsModelForentity.EntitiesResponse(entitiesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntitiesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        RevShareStatmentsModelForentity value,
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
            throw new JsonException($"{nameof(RevShareStatmentsModelForentity)} contains no valid value to serialize.");
        }
    }
}
