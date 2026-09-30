using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The ID of the entityDebt representing the relationship for the debt
/// </summary>
[JsonConverter(typeof(PendingEntriesModelEntityDebtConverter))]
public record PendingEntriesModelEntityDebt
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EntityDebtsResponse> _entityDebtsResponseValue;

    private PendingEntriesModelEntityDebt(Optional<string> stringValue,
        Optional<EntityDebtsResponse> entityDebtsResponseValue)
    {
        _stringValue = stringValue;
        _entityDebtsResponseValue = entityDebtsResponseValue;
    }

    public static PendingEntriesModelEntityDebt String(string value) => new(Optional<string>.Some(value), default);

    public static PendingEntriesModelEntityDebt EntityDebtsResponse(EntityDebtsResponse value) =>
        new(default, Optional<EntityDebtsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEntityDebtsResponse(out EntityDebtsResponse value) =>
        _entityDebtsResponseValue.TryGetValue(out value);

    public static implicit operator PendingEntriesModelEntityDebt(string value) => String(value);

    public static implicit operator PendingEntriesModelEntityDebt(EntityDebtsResponse value) =>
        EntityDebtsResponse(value);
}

file sealed class PendingEntriesModelEntityDebtConverter : JsonConverter<PendingEntriesModelEntityDebt>
{
    public override PendingEntriesModelEntityDebt Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PendingEntriesModelEntityDebt.String(value);
        }
        if (JsonSerializer.TryDeserialize<EntityDebtsResponse>(root, options, out var entityDebtsResponseValue))
        {
            return PendingEntriesModelEntityDebt.EntityDebtsResponse(entityDebtsResponseValue);
        }
        throw new JsonException($"JSON does not match string or EntityDebtsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        PendingEntriesModelEntityDebt value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEntityDebtsResponse(out var entityDebtsResponseValue))
        {
            JsonSerializer.Serialize(writer, entityDebtsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PendingEntriesModelEntityDebt)} contains no valid value to serialize.");
        }
    }
}
