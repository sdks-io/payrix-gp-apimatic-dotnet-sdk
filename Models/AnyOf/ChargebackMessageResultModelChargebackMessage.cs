using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the chargebackMessage resource that this chargebackMessageResult relates to.
/// </summary>
[JsonConverter(typeof(ChargebackMessageResultModelChargebackMessageConverter))]
public record ChargebackMessageResultModelChargebackMessage
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ChargebackMessageResponse> _chargebackMessageResponseValue;

    private ChargebackMessageResultModelChargebackMessage(Optional<string> stringValue,
        Optional<ChargebackMessageResponse> chargebackMessageResponseValue)
    {
        _stringValue = stringValue;
        _chargebackMessageResponseValue = chargebackMessageResponseValue;
    }

    public static ChargebackMessageResultModelChargebackMessage String(string value) =>
        new(Optional<string>.Some(value), default);

    public static ChargebackMessageResultModelChargebackMessage ChargebackMessageResponse(ChargebackMessageResponse value) =>
        new(default, Optional<ChargebackMessageResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetChargebackMessageResponse(out ChargebackMessageResponse value) =>
        _chargebackMessageResponseValue.TryGetValue(out value);

    public static implicit operator ChargebackMessageResultModelChargebackMessage(string value) => String(value);

    public static implicit operator ChargebackMessageResultModelChargebackMessage(ChargebackMessageResponse value) =>
        ChargebackMessageResponse(value);
}

file sealed class ChargebackMessageResultModelChargebackMessageConverter : JsonConverter<ChargebackMessageResultModelChargebackMessage>
{
    public override ChargebackMessageResultModelChargebackMessage Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ChargebackMessageResultModelChargebackMessage.String(value);
        }
        if (JsonSerializer.TryDeserialize<ChargebackMessageResponse>(
            root,
            options,
            out var chargebackMessageResponseValue))
        {
            return ChargebackMessageResultModelChargebackMessage.ChargebackMessageResponse(
                chargebackMessageResponseValue);
        }
        throw new JsonException($"JSON does not match string or ChargebackMessageResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ChargebackMessageResultModelChargebackMessage value,
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
                $"{nameof(ChargebackMessageResultModelChargebackMessage)} contains no valid value to serialize.");
        }
    }
}
