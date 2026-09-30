using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// ID of the chargeback message associated with this chargeback.
/// </summary>
[JsonConverter(typeof(ChargebackStatusesModelChargebackMessageConverter))]
public record ChargebackStatusesModelChargebackMessage
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ChargebackMessageResponse> _chargebackMessageResponseValue;

    private ChargebackStatusesModelChargebackMessage(Optional<string> stringValue,
        Optional<ChargebackMessageResponse> chargebackMessageResponseValue)
    {
        _stringValue = stringValue;
        _chargebackMessageResponseValue = chargebackMessageResponseValue;
    }

    public static ChargebackStatusesModelChargebackMessage String(string value) =>
        new(Optional<string>.Some(value), default);

    public static ChargebackStatusesModelChargebackMessage ChargebackMessageResponse(ChargebackMessageResponse value) =>
        new(default, Optional<ChargebackMessageResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetChargebackMessageResponse(out ChargebackMessageResponse value) =>
        _chargebackMessageResponseValue.TryGetValue(out value);

    public static implicit operator ChargebackStatusesModelChargebackMessage(string value) => String(value);

    public static implicit operator ChargebackStatusesModelChargebackMessage(ChargebackMessageResponse value) =>
        ChargebackMessageResponse(value);
}

file sealed class ChargebackStatusesModelChargebackMessageConverter : JsonConverter<ChargebackStatusesModelChargebackMessage>
{
    public override ChargebackStatusesModelChargebackMessage Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ChargebackStatusesModelChargebackMessage.String(value);
        }
        if (JsonSerializer.TryDeserialize<ChargebackMessageResponse>(
            root,
            options,
            out var chargebackMessageResponseValue))
        {
            return ChargebackStatusesModelChargebackMessage.ChargebackMessageResponse(chargebackMessageResponseValue);
        }
        throw new JsonException($"JSON does not match string or ChargebackMessageResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ChargebackStatusesModelChargebackMessage value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetChargebackMessageResponse(out var chargebackMessageResponseValue))
        {
            JsonSerializer.Serialize(writer, chargebackMessageResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(ChargebackStatusesModelChargebackMessage)} contains no valid value to serialize.");
        }
    }
}
