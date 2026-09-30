using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Entry that this ProfitShareResult refers to.
/// </summary>
[JsonConverter(typeof(ProfitShareResultsModelEntryConverter))]
public record ProfitShareResultsModelEntry
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntriesResponse> _entriesResponseValue;

    private ProfitShareResultsModelEntry(Optional<string> stringValue, Optional<EntriesResponse> entriesResponseValue)
    {
        _stringValue = stringValue;
        _entriesResponseValue = entriesResponseValue;
    }

    public static ProfitShareResultsModelEntry String(string value) => new(Optional<string>.Some(value), default);

    public static ProfitShareResultsModelEntry EntriesResponse(EntriesResponse value) =>
        new(default, Optional<EntriesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntriesResponse(out EntriesResponse value) => _entriesResponseValue.TryGetValue(out value);

    public static implicit operator ProfitShareResultsModelEntry(string value) => String(value);

    public static implicit operator ProfitShareResultsModelEntry(EntriesResponse value) => EntriesResponse(value);
}

file sealed class ProfitShareResultsModelEntryConverter : JsonConverter<ProfitShareResultsModelEntry>
{
    public override ProfitShareResultsModelEntry Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ProfitShareResultsModelEntry.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntriesResponse>(root, options, out var entriesResponseValue))
        {
            return ProfitShareResultsModelEntry.EntriesResponse(entriesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntriesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ProfitShareResultsModelEntry value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(ProfitShareResultsModelEntry)} contains no valid value to serialize.");
        }
    }
}
