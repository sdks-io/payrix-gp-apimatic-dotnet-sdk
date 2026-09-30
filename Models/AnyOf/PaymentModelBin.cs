using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// Bin identifier for this payment.
/// </summary>
[JsonConverter(typeof(PaymentModelBinConverter))]
public record PaymentModelBin
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<BinsResponse> _binsResponseValue;

    private PaymentModelBin(Optional<string> stringValue, Optional<BinsResponse> binsResponseValue)
    {
        _stringValue = stringValue;
        _binsResponseValue = binsResponseValue;
    }

    public static PaymentModelBin String(string value) => new(Optional<string>.Some(value), default);

    public static PaymentModelBin BinsResponse(BinsResponse value) => new(default, Optional<BinsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetBinsResponse(out BinsResponse value) => _binsResponseValue.TryGetValue(out value);

    public static implicit operator PaymentModelBin(string value) => String(value);

    public static implicit operator PaymentModelBin(BinsResponse value) => BinsResponse(value);
}

file sealed class PaymentModelBinConverter : JsonConverter<PaymentModelBin>
{
    public override PaymentModelBin Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PaymentModelBin.String(value);
        }
        if (JsonSerializer.TryDeserialize<BinsResponse>(root, options, out var binsResponseValue))
        {
            return PaymentModelBin.BinsResponse(binsResponseValue);
        }
        throw new JsonException($"JSON does not match string or BinsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PaymentModelBin value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetBinsResponse(out var binsResponseValue))
        {
            JsonSerializer.Serialize(writer, binsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PaymentModelBin)} contains no valid value to serialize.");
        }
    }
}
