using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The last negative ReserveEntry processed included in the disbursement.
/// </summary>
[JsonConverter(typeof(DisbursementsModelLastNegativeReserveEntryConverter))]
public record DisbursementsModelLastNegativeReserveEntry
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ReserveEntriesResponse> _reserveEntriesResponseValue;

    private DisbursementsModelLastNegativeReserveEntry(Optional<string> stringValue,
        Optional<ReserveEntriesResponse> reserveEntriesResponseValue)
    {
        _stringValue = stringValue;
        _reserveEntriesResponseValue = reserveEntriesResponseValue;
    }

    public static DisbursementsModelLastNegativeReserveEntry String(string value) =>
        new(Optional<string>.Some(value), default);

    public static DisbursementsModelLastNegativeReserveEntry ReserveEntriesResponse(ReserveEntriesResponse value) =>
        new(default, Optional<ReserveEntriesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetReserveEntriesResponse(out ReserveEntriesResponse value) =>
        _reserveEntriesResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementsModelLastNegativeReserveEntry(string value) => String(value);

    public static implicit operator DisbursementsModelLastNegativeReserveEntry(ReserveEntriesResponse value) =>
        ReserveEntriesResponse(value);
}

file sealed class DisbursementsModelLastNegativeReserveEntryConverter : JsonConverter<DisbursementsModelLastNegativeReserveEntry>
{
    public override DisbursementsModelLastNegativeReserveEntry Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementsModelLastNegativeReserveEntry.String(value);
        }
        if (JsonSerializer.TryDeserialize<ReserveEntriesResponse>(root, options, out var reserveEntriesResponseValue))
        {
            return DisbursementsModelLastNegativeReserveEntry.ReserveEntriesResponse(reserveEntriesResponseValue);
        }
        throw new JsonException($"JSON does not match string or ReserveEntriesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DisbursementsModelLastNegativeReserveEntry value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetReserveEntriesResponse(out var reserveEntriesResponseValue))
        {
            JsonSerializer.Serialize(writer, reserveEntriesResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(DisbursementsModelLastNegativeReserveEntry)} contains no valid value to serialize.");
        }
    }
}
