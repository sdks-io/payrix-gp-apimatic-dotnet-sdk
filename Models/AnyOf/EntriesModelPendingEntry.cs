using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The ID of the pending entry that is associated with this entry.
/// </summary>
[JsonConverter(typeof(EntriesModelPendingEntryConverter))]
public record EntriesModelPendingEntry
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PendingEntriesResponse> _pendingEntriesResponseValue;

    private EntriesModelPendingEntry(Optional<string> stringValue,
        Optional<PendingEntriesResponse> pendingEntriesResponseValue)
    {
        _stringValue = stringValue;
        _pendingEntriesResponseValue = pendingEntriesResponseValue;
    }

    public static EntriesModelPendingEntry String(string value) => new(Optional<string>.Some(value), default);

    public static EntriesModelPendingEntry PendingEntriesResponse(PendingEntriesResponse value) =>
        new(default, Optional<PendingEntriesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPendingEntriesResponse(out PendingEntriesResponse value) =>
        _pendingEntriesResponseValue.TryGetValue(out value);

    public static implicit operator EntriesModelPendingEntry(string value) => String(value);

    public static implicit operator EntriesModelPendingEntry(PendingEntriesResponse value) =>
        PendingEntriesResponse(value);
}

file sealed class EntriesModelPendingEntryConverter : JsonConverter<EntriesModelPendingEntry>
{
    public override EntriesModelPendingEntry Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntriesModelPendingEntry.String(value);
        }
        if (JsonSerializer.TryDeserialize<PendingEntriesResponse>(root, options, out var pendingEntriesResponseValue))
        {
            return EntriesModelPendingEntry.PendingEntriesResponse(pendingEntriesResponseValue);
        }
        throw new JsonException($"JSON does not match string or PendingEntriesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntriesModelPendingEntry value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetPendingEntriesResponse(out var pendingEntriesResponseValue))
        {
            JsonSerializer.Serialize(writer, pendingEntriesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EntriesModelPendingEntry)} contains no valid value to serialize.");
        }
    }
}
