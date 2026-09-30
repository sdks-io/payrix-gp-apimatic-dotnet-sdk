using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the ReserveEntry that this DisbursementEntry resource refers to.
/// </summary>
[JsonConverter(typeof(DisbursementEntriesModelReserveEntryConverter))]
public record DisbursementEntriesModelReserveEntry
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ReserveEntriesResponse> _reserveEntriesResponseValue;

    private DisbursementEntriesModelReserveEntry(Optional<string> stringValue,
        Optional<ReserveEntriesResponse> reserveEntriesResponseValue)
    {
        _stringValue = stringValue;
        _reserveEntriesResponseValue = reserveEntriesResponseValue;
    }

    public static DisbursementEntriesModelReserveEntry String(string value) =>
        new(Optional<string>.Some(value), default);

    public static DisbursementEntriesModelReserveEntry ReserveEntriesResponse(ReserveEntriesResponse value) =>
        new(default, Optional<ReserveEntriesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetReserveEntriesResponse(out ReserveEntriesResponse value) =>
        _reserveEntriesResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementEntriesModelReserveEntry(string value) => String(value);

    public static implicit operator DisbursementEntriesModelReserveEntry(ReserveEntriesResponse value) =>
        ReserveEntriesResponse(value);
}

file sealed class DisbursementEntriesModelReserveEntryConverter : JsonConverter<DisbursementEntriesModelReserveEntry>
{
    public override DisbursementEntriesModelReserveEntry Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementEntriesModelReserveEntry.String(value);
        }
        if (JsonSerializer.TryDeserialize<ReserveEntriesResponse>(root, options, out var reserveEntriesResponseValue))
        {
            return DisbursementEntriesModelReserveEntry.ReserveEntriesResponse(reserveEntriesResponseValue);
        }
        throw new JsonException($"JSON does not match string or ReserveEntriesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DisbursementEntriesModelReserveEntry value,
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
                $"{nameof(DisbursementEntriesModelReserveEntry)} contains no valid value to serialize.");
        }
    }
}
