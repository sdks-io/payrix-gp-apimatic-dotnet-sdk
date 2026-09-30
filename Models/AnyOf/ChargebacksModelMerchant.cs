using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The ID of the merchant associated with the Chargeback.
/// </summary>
[JsonConverter(typeof(ChargebacksModelMerchantConverter))]
public record ChargebacksModelMerchant
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<MerchantsResponse> _merchantsResponseValue;

    private ChargebacksModelMerchant(Optional<string> stringValue, Optional<MerchantsResponse> merchantsResponseValue)
    {
        _stringValue = stringValue;
        _merchantsResponseValue = merchantsResponseValue;
    }

    public static ChargebacksModelMerchant String(string value) => new(Optional<string>.Some(value), default);

    public static ChargebacksModelMerchant MerchantsResponse(MerchantsResponse value) =>
        new(default, Optional<MerchantsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetMerchantsResponse(out MerchantsResponse value) => _merchantsResponseValue.TryGetValue(out value);

    public static implicit operator ChargebacksModelMerchant(string value) => String(value);

    public static implicit operator ChargebacksModelMerchant(MerchantsResponse value) => MerchantsResponse(value);
}

file sealed class ChargebacksModelMerchantConverter : JsonConverter<ChargebacksModelMerchant>
{
    public override ChargebacksModelMerchant Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ChargebacksModelMerchant.String(value);
        }
        if (JsonSerializer.TryDeserialize<MerchantsResponse>(root, options, out var merchantsResponseValue))
        {
            return ChargebacksModelMerchant.MerchantsResponse(merchantsResponseValue);
        }
        throw new JsonException($"JSON does not match string or MerchantsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ChargebacksModelMerchant value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetMerchantsResponse(out var merchantsResponseValue))
        {
            JsonSerializer.Serialize(writer, merchantsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ChargebacksModelMerchant)} contains no valid value to serialize.");
        }
    }
}
