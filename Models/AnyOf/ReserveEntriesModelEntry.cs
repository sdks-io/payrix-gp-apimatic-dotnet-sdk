using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The entry ID associated with this pendingEntry.
/// </summary>
[JsonConverter(typeof(ReserveEntriesModelEntryConverter))]
public record ReserveEntriesModelEntry
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntriesResponse> _entriesResponseValue;

    private ReserveEntriesModelEntry(Optional<string> stringValue, Optional<EntriesResponse> entriesResponseValue)
    {
        _stringValue = stringValue;
        _entriesResponseValue = entriesResponseValue;
    }

    public static ReserveEntriesModelEntry String(string value) => new(Optional<string>.Some(value), default);

    public static ReserveEntriesModelEntry EntriesResponse(EntriesResponse value) =>
        new(default, Optional<EntriesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntriesResponse(out EntriesResponse value) => _entriesResponseValue.TryGetValue(out value);

    public static implicit operator ReserveEntriesModelEntry(string value) => String(value);

    public static implicit operator ReserveEntriesModelEntry(EntriesResponse value) => EntriesResponse(value);
}

file sealed class ReserveEntriesModelEntryConverter : JsonConverter<ReserveEntriesModelEntry>
{
    public override ReserveEntriesModelEntry Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ReserveEntriesModelEntry.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntriesResponse>(root, options, out var entriesResponseValue))
        {
            return ReserveEntriesModelEntry.EntriesResponse(entriesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntriesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ReserveEntriesModelEntry value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(ReserveEntriesModelEntry)} contains no valid value to serialize.");
        }
    }
}
