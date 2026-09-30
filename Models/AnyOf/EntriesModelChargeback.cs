using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If the activity that this Entry refers to is a Chargeback, then this field stores the identifier of the corresponding Chargeback resource.
/// </summary>
[JsonConverter(typeof(EntriesModelChargebackConverter))]
public record EntriesModelChargeback
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ChargebacksResponse> _chargebacksResponseValue;

    private EntriesModelChargeback(Optional<string> stringValue, Optional<ChargebacksResponse> chargebacksResponseValue)
    {
        _stringValue = stringValue;
        _chargebacksResponseValue = chargebacksResponseValue;
    }

    public static EntriesModelChargeback String(string value) => new(Optional<string>.Some(value), default);

    public static EntriesModelChargeback ChargebacksResponse(ChargebacksResponse value) =>
        new(default, Optional<ChargebacksResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetChargebacksResponse(out ChargebacksResponse value) =>
        _chargebacksResponseValue.TryGetValue(out value);

    public static implicit operator EntriesModelChargeback(string value) => String(value);

    public static implicit operator EntriesModelChargeback(ChargebacksResponse value) => ChargebacksResponse(value);
}

file sealed class EntriesModelChargebackConverter : JsonConverter<EntriesModelChargeback>
{
    public override EntriesModelChargeback Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntriesModelChargeback.String(value);
        }
        if (JsonSerializer.TryDeserialize<ChargebacksResponse>(root, options, out var chargebacksResponseValue))
        {
            return EntriesModelChargeback.ChargebacksResponse(chargebacksResponseValue);
        }
        throw new JsonException($"JSON does not match string or ChargebacksResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntriesModelChargeback value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(EntriesModelChargeback)} contains no valid value to serialize.");
        }
    }
}
