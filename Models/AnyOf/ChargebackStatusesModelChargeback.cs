using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// ID of the related chargeback.
/// </summary>
[JsonConverter(typeof(ChargebackStatusesModelChargebackConverter))]
public record ChargebackStatusesModelChargeback
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ChargebacksResponse> _chargebacksResponseValue;

    private ChargebackStatusesModelChargeback(Optional<string> stringValue,
        Optional<ChargebacksResponse> chargebacksResponseValue)
    {
        _stringValue = stringValue;
        _chargebacksResponseValue = chargebacksResponseValue;
    }

    public static ChargebackStatusesModelChargeback String(string value) => new(Optional<string>.Some(value), default);

    public static ChargebackStatusesModelChargeback ChargebacksResponse(ChargebacksResponse value) =>
        new(default, Optional<ChargebacksResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetChargebacksResponse(out ChargebacksResponse value) =>
        _chargebacksResponseValue.TryGetValue(out value);

    public static implicit operator ChargebackStatusesModelChargeback(string value) => String(value);

    public static implicit operator ChargebackStatusesModelChargeback(ChargebacksResponse value) =>
        ChargebacksResponse(value);
}

file sealed class ChargebackStatusesModelChargebackConverter : JsonConverter<ChargebackStatusesModelChargeback>
{
    public override ChargebackStatusesModelChargeback Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ChargebackStatusesModelChargeback.String(value);
        }
        if (JsonSerializer.TryDeserialize<ChargebacksResponse>(root, options, out var chargebacksResponseValue))
        {
            return ChargebackStatusesModelChargeback.ChargebacksResponse(chargebacksResponseValue);
        }
        throw new JsonException($"JSON does not match string or ChargebacksResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ChargebackStatusesModelChargeback value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetChargebacksResponse(out var chargebacksResponseValue))
        {
            JsonSerializer.Serialize(writer, chargebacksResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(ChargebackStatusesModelChargeback)} contains no valid value to serialize.");
        }
    }
}
