using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The settlement record for this disbursement.
/// </summary>
[JsonConverter(typeof(DisbursementsModelSettlementConverter))]
public record DisbursementsModelSettlement
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<SettlementsResponse> _settlementsResponseValue;

    private DisbursementsModelSettlement(Optional<string> stringValue,
        Optional<SettlementsResponse> settlementsResponseValue)
    {
        _stringValue = stringValue;
        _settlementsResponseValue = settlementsResponseValue;
    }

    public static DisbursementsModelSettlement String(string value) => new(Optional<string>.Some(value), default);

    public static DisbursementsModelSettlement SettlementsResponse(SettlementsResponse value) =>
        new(default, Optional<SettlementsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetSettlementsResponse(out SettlementsResponse value) =>
        _settlementsResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementsModelSettlement(string value) => String(value);

    public static implicit operator DisbursementsModelSettlement(SettlementsResponse value) =>
        SettlementsResponse(value);
}

file sealed class DisbursementsModelSettlementConverter : JsonConverter<DisbursementsModelSettlement>
{
    public override DisbursementsModelSettlement Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementsModelSettlement.String(value);
        }
        if (JsonSerializer.TryDeserialize<SettlementsResponse>(root, options, out var settlementsResponseValue))
        {
            return DisbursementsModelSettlement.SettlementsResponse(settlementsResponseValue);
        }
        throw new JsonException($"JSON does not match string or SettlementsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DisbursementsModelSettlement value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(DisbursementsModelSettlement)} contains no valid value to serialize.");
        }
    }
}
