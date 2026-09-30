using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// This field indicates that this reserveEntry shows funds moving out of or into reserve. This field stores the identifier of the reserveEntry resource that moved the funds into or out of the reserve.
/// </summary>
[JsonConverter(typeof(ReserveEntriesModelReserveEntryConverter))]
public record ReserveEntriesModelReserveEntry
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ReserveEntriesResponse> _reserveEntriesResponseValue;

    private ReserveEntriesModelReserveEntry(Optional<string> stringValue,
        Optional<ReserveEntriesResponse> reserveEntriesResponseValue)
    {
        _stringValue = stringValue;
        _reserveEntriesResponseValue = reserveEntriesResponseValue;
    }

    public static ReserveEntriesModelReserveEntry String(string value) => new(Optional<string>.Some(value), default);

    public static ReserveEntriesModelReserveEntry ReserveEntriesResponse(ReserveEntriesResponse value) =>
        new(default, Optional<ReserveEntriesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetReserveEntriesResponse(out ReserveEntriesResponse value) =>
        _reserveEntriesResponseValue.TryGetValue(out value);

    public static implicit operator ReserveEntriesModelReserveEntry(string value) => String(value);

    public static implicit operator ReserveEntriesModelReserveEntry(ReserveEntriesResponse value) =>
        ReserveEntriesResponse(value);
}

file sealed class ReserveEntriesModelReserveEntryConverter : JsonConverter<ReserveEntriesModelReserveEntry>
{
    public override ReserveEntriesModelReserveEntry Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ReserveEntriesModelReserveEntry.String(value);
        }
        if (JsonSerializer.TryDeserialize<ReserveEntriesResponse>(root, options, out var reserveEntriesResponseValue))
        {
            return ReserveEntriesModelReserveEntry.ReserveEntriesResponse(reserveEntriesResponseValue);
        }
        throw new JsonException($"JSON does not match string or ReserveEntriesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ReserveEntriesModelReserveEntry value,
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
            throw new JsonException($"{nameof(ReserveEntriesModelReserveEntry)} contains no valid value to serialize.");
        }
    }
}
