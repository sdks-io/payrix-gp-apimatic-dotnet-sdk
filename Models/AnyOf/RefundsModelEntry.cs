using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Entries resource that is being refunded.
/// </summary>
[JsonConverter(typeof(RefundsModelEntryConverter))]
public record RefundsModelEntry
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntriesResponse> _entriesResponseValue;

    private RefundsModelEntry(Optional<string> stringValue, Optional<EntriesResponse> entriesResponseValue)
    {
        _stringValue = stringValue;
        _entriesResponseValue = entriesResponseValue;
    }

    public static RefundsModelEntry String(string value) => new(Optional<string>.Some(value), default);

    public static RefundsModelEntry EntriesResponse(EntriesResponse value) =>
        new(default, Optional<EntriesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntriesResponse(out EntriesResponse value) => _entriesResponseValue.TryGetValue(out value);

    public static implicit operator RefundsModelEntry(string value) => String(value);

    public static implicit operator RefundsModelEntry(EntriesResponse value) => EntriesResponse(value);
}

file sealed class RefundsModelEntryConverter : JsonConverter<RefundsModelEntry>
{
    public override RefundsModelEntry Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return RefundsModelEntry.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntriesResponse>(root, options, out var entriesResponseValue))
        {
            return RefundsModelEntry.EntriesResponse(entriesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntriesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, RefundsModelEntry value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(RefundsModelEntry)} contains no valid value to serialize.");
        }
    }
}
