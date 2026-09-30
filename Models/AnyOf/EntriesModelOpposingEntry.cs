using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Entry that this Entry was created based on.
/// </summary>
[JsonConverter(typeof(EntriesModelOpposingEntryConverter))]
public record EntriesModelOpposingEntry
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntriesResponse> _entriesResponseValue;

    private EntriesModelOpposingEntry(Optional<string> stringValue, Optional<EntriesResponse> entriesResponseValue)
    {
        _stringValue = stringValue;
        _entriesResponseValue = entriesResponseValue;
    }

    public static EntriesModelOpposingEntry String(string value) => new(Optional<string>.Some(value), default);

    public static EntriesModelOpposingEntry EntriesResponse(EntriesResponse value) =>
        new(default, Optional<EntriesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntriesResponse(out EntriesResponse value) => _entriesResponseValue.TryGetValue(out value);

    public static implicit operator EntriesModelOpposingEntry(string value) => String(value);

    public static implicit operator EntriesModelOpposingEntry(EntriesResponse value) => EntriesResponse(value);
}

file sealed class EntriesModelOpposingEntryConverter : JsonConverter<EntriesModelOpposingEntry>
{
    public override EntriesModelOpposingEntry Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntriesModelOpposingEntry.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntriesResponse>(root, options, out var entriesResponseValue))
        {
            return EntriesModelOpposingEntry.EntriesResponse(entriesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntriesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntriesModelOpposingEntry value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEntriesResponse(out var entriesResponseValue))
        {
            JsonSerializer.Serialize(writer, entriesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EntriesModelOpposingEntry)} contains no valid value to serialize.");
        }
    }
}
