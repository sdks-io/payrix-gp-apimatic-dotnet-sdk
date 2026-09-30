using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// This field indicates that this reserveEntry was triggered from an automatic reserve, and it stores the identifier of the Reserve resource.
/// </summary>
[JsonConverter(typeof(ReserveEntriesModelReserveConverter))]
public record ReserveEntriesModelReserve
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ReservesResponse> _reservesResponseValue;

    private ReserveEntriesModelReserve(Optional<string> stringValue, Optional<ReservesResponse> reservesResponseValue)
    {
        _stringValue = stringValue;
        _reservesResponseValue = reservesResponseValue;
    }

    public static ReserveEntriesModelReserve String(string value) => new(Optional<string>.Some(value), default);

    public static ReserveEntriesModelReserve ReservesResponse(ReservesResponse value) =>
        new(default, Optional<ReservesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetReservesResponse(out ReservesResponse value) => _reservesResponseValue.TryGetValue(out value);

    public static implicit operator ReserveEntriesModelReserve(string value) => String(value);

    public static implicit operator ReserveEntriesModelReserve(ReservesResponse value) => ReservesResponse(value);
}

file sealed class ReserveEntriesModelReserveConverter : JsonConverter<ReserveEntriesModelReserve>
{
    public override ReserveEntriesModelReserve Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ReserveEntriesModelReserve.String(value);
        }
        if (JsonSerializer.TryDeserialize<ReservesResponse>(root, options, out var reservesResponseValue))
        {
            return ReserveEntriesModelReserve.ReservesResponse(reservesResponseValue);
        }
        throw new JsonException($"JSON does not match string or ReservesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ReserveEntriesModelReserve value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetReservesResponse(out var reservesResponseValue))
        {
            JsonSerializer.Serialize(writer, reservesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ReserveEntriesModelReserve)} contains no valid value to serialize.");
        }
    }
}
