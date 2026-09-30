using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Chargeback resource that this chargebackMessage relates to.
/// </summary>
[JsonConverter(typeof(ChargebackMessageModelChargebackConverter))]
public record ChargebackMessageModelChargeback
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ChargebacksResponse> _chargebacksResponseValue;

    private ChargebackMessageModelChargeback(Optional<string> stringValue,
        Optional<ChargebacksResponse> chargebacksResponseValue)
    {
        _stringValue = stringValue;
        _chargebacksResponseValue = chargebacksResponseValue;
    }

    public static ChargebackMessageModelChargeback String(string value) => new(Optional<string>.Some(value), default);

    public static ChargebackMessageModelChargeback ChargebacksResponse(ChargebacksResponse value) =>
        new(default, Optional<ChargebacksResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetChargebacksResponse(out ChargebacksResponse value) =>
        _chargebacksResponseValue.TryGetValue(out value);

    public static implicit operator ChargebackMessageModelChargeback(string value) => String(value);

    public static implicit operator ChargebackMessageModelChargeback(ChargebacksResponse value) =>
        ChargebacksResponse(value);
}

file sealed class ChargebackMessageModelChargebackConverter : JsonConverter<ChargebackMessageModelChargeback>
{
    public override ChargebackMessageModelChargeback Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ChargebackMessageModelChargeback.String(value);
        }
        if (JsonSerializer.TryDeserialize<ChargebacksResponse>(root, options, out var chargebacksResponseValue))
        {
            return ChargebackMessageModelChargeback.ChargebacksResponse(chargebacksResponseValue);
        }
        throw new JsonException($"JSON does not match string or ChargebacksResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ChargebackMessageModelChargeback value,
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
                $"{nameof(ChargebackMessageModelChargeback)} contains no valid value to serialize.");
        }
    }
}
