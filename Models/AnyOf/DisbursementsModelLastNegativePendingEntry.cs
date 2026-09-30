using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The last negative PendingEntry processed included in the disbursement.
/// </summary>
[JsonConverter(typeof(DisbursementsModelLastNegativePendingEntryConverter))]
public record DisbursementsModelLastNegativePendingEntry
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PendingEntriesResponse> _pendingEntriesResponseValue;

    private DisbursementsModelLastNegativePendingEntry(Optional<string> stringValue,
        Optional<PendingEntriesResponse> pendingEntriesResponseValue)
    {
        _stringValue = stringValue;
        _pendingEntriesResponseValue = pendingEntriesResponseValue;
    }

    public static DisbursementsModelLastNegativePendingEntry String(string value) =>
        new(Optional<string>.Some(value), default);

    public static DisbursementsModelLastNegativePendingEntry PendingEntriesResponse(PendingEntriesResponse value) =>
        new(default, Optional<PendingEntriesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPendingEntriesResponse(out PendingEntriesResponse value) =>
        _pendingEntriesResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementsModelLastNegativePendingEntry(string value) => String(value);

    public static implicit operator DisbursementsModelLastNegativePendingEntry(PendingEntriesResponse value) =>
        PendingEntriesResponse(value);
}

file sealed class DisbursementsModelLastNegativePendingEntryConverter : JsonConverter<DisbursementsModelLastNegativePendingEntry>
{
    public override DisbursementsModelLastNegativePendingEntry Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementsModelLastNegativePendingEntry.String(value);
        }
        if (JsonSerializer.TryDeserialize<PendingEntriesResponse>(root, options, out var pendingEntriesResponseValue))
        {
            return DisbursementsModelLastNegativePendingEntry.PendingEntriesResponse(pendingEntriesResponseValue);
        }
        throw new JsonException($"JSON does not match string or PendingEntriesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DisbursementsModelLastNegativePendingEntry value,
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
                $"{nameof(DisbursementsModelLastNegativePendingEntry)} contains no valid value to serialize.");
        }
    }
}
