using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// This field indicates that this reserveEntry was triggered from a manual change to an entityReserve, and it stores the identifier of the entityReserve resource.
/// </summary>
[JsonConverter(typeof(ReserveEntriesModelEntityReserveConverter))]
public record ReserveEntriesModelEntityReserve
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntityReservesResponse> _entityReservesResponseValue;

    private ReserveEntriesModelEntityReserve(Optional<string> stringValue,
        Optional<EntityReservesResponse> entityReservesResponseValue)
    {
        _stringValue = stringValue;
        _entityReservesResponseValue = entityReservesResponseValue;
    }

    public static ReserveEntriesModelEntityReserve String(string value) => new(Optional<string>.Some(value), default);

    public static ReserveEntriesModelEntityReserve EntityReservesResponse(EntityReservesResponse value) =>
        new(default, Optional<EntityReservesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntityReservesResponse(out EntityReservesResponse value) =>
        _entityReservesResponseValue.TryGetValue(out value);

    public static implicit operator ReserveEntriesModelEntityReserve(string value) => String(value);

    public static implicit operator ReserveEntriesModelEntityReserve(EntityReservesResponse value) =>
        EntityReservesResponse(value);
}

file sealed class ReserveEntriesModelEntityReserveConverter : JsonConverter<ReserveEntriesModelEntityReserve>
{
    public override ReserveEntriesModelEntityReserve Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ReserveEntriesModelEntityReserve.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntityReservesResponse>(root, options, out var entityReservesResponseValue))
        {
            return ReserveEntriesModelEntityReserve.EntityReservesResponse(entityReservesResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntityReservesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ReserveEntriesModelEntityReserve value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEntityReservesResponse(out var entityReservesResponseValue))
        {
            JsonSerializer.Serialize(writer, entityReservesResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(ReserveEntriesModelEntityReserve)} contains no valid value to serialize.");
        }
    }
}
