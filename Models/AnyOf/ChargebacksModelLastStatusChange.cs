using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The ChargebackStatus representing the latest status change for this Chargeback.
/// </summary>
[JsonConverter(typeof(ChargebacksModelLastStatusChangeConverter))]
public record ChargebacksModelLastStatusChange
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ChargebackStatusesResponse> _chargebackStatusesResponseValue;

    private ChargebacksModelLastStatusChange(Optional<string> stringValue,
        Optional<ChargebackStatusesResponse> chargebackStatusesResponseValue)
    {
        _stringValue = stringValue;
        _chargebackStatusesResponseValue = chargebackStatusesResponseValue;
    }

    public static ChargebacksModelLastStatusChange String(string value) => new(Optional<string>.Some(value), default);

    public static ChargebacksModelLastStatusChange ChargebackStatusesResponse(ChargebackStatusesResponse value) =>
        new(default, Optional<ChargebackStatusesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetChargebackStatusesResponse(out ChargebackStatusesResponse value) =>
        _chargebackStatusesResponseValue.TryGetValue(out value);

    public static implicit operator ChargebacksModelLastStatusChange(string value) => String(value);

    public static implicit operator ChargebacksModelLastStatusChange(ChargebackStatusesResponse value) =>
        ChargebackStatusesResponse(value);
}

file sealed class ChargebacksModelLastStatusChangeConverter : JsonConverter<ChargebacksModelLastStatusChange>
{
    public override ChargebacksModelLastStatusChange Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ChargebacksModelLastStatusChange.String(value);
        }
        if (JsonSerializer.TryDeserialize<ChargebackStatusesResponse>(
            root,
            options,
            out var chargebackStatusesResponseValue))
        {
            return ChargebacksModelLastStatusChange.ChargebackStatusesResponse(chargebackStatusesResponseValue);
        }
        throw new JsonException($"JSON does not match string or ChargebackStatusesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ChargebacksModelLastStatusChange value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetChargebackStatusesResponse(out var chargebackStatusesResponseValue))
        {
            JsonSerializer.Serialize(writer, chargebackStatusesResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(ChargebacksModelLastStatusChange)} contains no valid value to serialize.");
        }
    }
}
