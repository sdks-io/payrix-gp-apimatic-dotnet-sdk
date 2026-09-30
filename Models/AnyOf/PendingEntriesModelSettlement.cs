using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If the activity that this PendingEntry refers to is a Settlement, then this field stores the identifier of the corresponding Settlement resource.
/// </summary>
[JsonConverter(typeof(PendingEntriesModelSettlementConverter))]
public record PendingEntriesModelSettlement
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<SettlementsResponse> _settlementsResponseValue;

    private PendingEntriesModelSettlement(Optional<string> stringValue,
        Optional<SettlementsResponse> settlementsResponseValue)
    {
        _stringValue = stringValue;
        _settlementsResponseValue = settlementsResponseValue;
    }

    public static PendingEntriesModelSettlement String(string value) => new(Optional<string>.Some(value), default);

    public static PendingEntriesModelSettlement SettlementsResponse(SettlementsResponse value) =>
        new(default, Optional<SettlementsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetSettlementsResponse(out SettlementsResponse value) =>
        _settlementsResponseValue.TryGetValue(out value);

    public static implicit operator PendingEntriesModelSettlement(string value) => String(value);

    public static implicit operator PendingEntriesModelSettlement(SettlementsResponse value) =>
        SettlementsResponse(value);
}

file sealed class PendingEntriesModelSettlementConverter : JsonConverter<PendingEntriesModelSettlement>
{
    public override PendingEntriesModelSettlement Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PendingEntriesModelSettlement.String(value);
        }
        if (JsonSerializer.TryDeserialize<SettlementsResponse>(root, options, out var settlementsResponseValue))
        {
            return PendingEntriesModelSettlement.SettlementsResponse(settlementsResponseValue);
        }
        throw new JsonException($"JSON does not match string or SettlementsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        PendingEntriesModelSettlement value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetSettlementsResponse(out var settlementsResponseValue))
        {
            JsonSerializer.Serialize(writer, settlementsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PendingEntriesModelSettlement)} contains no valid value to serialize.");
        }
    }
}
