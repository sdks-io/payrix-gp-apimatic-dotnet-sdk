using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the PendingEntry that this DisbursementEntry resource refers to.
/// </summary>
[JsonConverter(typeof(DisbursementEntriesModelPendingEntryConverter))]
public record DisbursementEntriesModelPendingEntry
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PendingEntriesResponse> _pendingEntriesResponseValue;

    private DisbursementEntriesModelPendingEntry(Optional<string> stringValue,
        Optional<PendingEntriesResponse> pendingEntriesResponseValue)
    {
        _stringValue = stringValue;
        _pendingEntriesResponseValue = pendingEntriesResponseValue;
    }

    public static DisbursementEntriesModelPendingEntry String(string value) =>
        new(Optional<string>.Some(value), default);

    public static DisbursementEntriesModelPendingEntry PendingEntriesResponse(PendingEntriesResponse value) =>
        new(default, Optional<PendingEntriesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPendingEntriesResponse(out PendingEntriesResponse value) =>
        _pendingEntriesResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementEntriesModelPendingEntry(string value) => String(value);

    public static implicit operator DisbursementEntriesModelPendingEntry(PendingEntriesResponse value) =>
        PendingEntriesResponse(value);
}

file sealed class DisbursementEntriesModelPendingEntryConverter : JsonConverter<DisbursementEntriesModelPendingEntry>
{
    public override DisbursementEntriesModelPendingEntry Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementEntriesModelPendingEntry.String(value);
        }
        if (JsonSerializer.TryDeserialize<PendingEntriesResponse>(root, options, out var pendingEntriesResponseValue))
        {
            return DisbursementEntriesModelPendingEntry.PendingEntriesResponse(pendingEntriesResponseValue);
        }
        throw new JsonException($"JSON does not match string or PendingEntriesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DisbursementEntriesModelPendingEntry value,
        JsonSerializerOptions options)
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
            throw new JsonException(
                $"{nameof(DisbursementEntriesModelPendingEntry)} contains no valid value to serialize.");
        }
    }
}
