using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Merchant associated with this Plan.
/// </summary>
[JsonConverter(typeof(PlansModelMerchantConverter))]
public record PlansModelMerchant
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<MerchantsResponse> _merchantsResponseValue;

    private PlansModelMerchant(Optional<string> stringValue, Optional<MerchantsResponse> merchantsResponseValue)
    {
        _stringValue = stringValue;
        _merchantsResponseValue = merchantsResponseValue;
    }

    public static PlansModelMerchant String(string value) => new(Optional<string>.Some(value), default);

    public static PlansModelMerchant MerchantsResponse(MerchantsResponse value) =>
        new(default, Optional<MerchantsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetMerchantsResponse(out MerchantsResponse value) => _merchantsResponseValue.TryGetValue(out value);

    public static implicit operator PlansModelMerchant(string value) => String(value);

    public static implicit operator PlansModelMerchant(MerchantsResponse value) => MerchantsResponse(value);
}

file sealed class PlansModelMerchantConverter : JsonConverter<PlansModelMerchant>
{
    public override PlansModelMerchant Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PlansModelMerchant.String(value);
        }
        if (JsonSerializer.TryDeserialize<MerchantsResponse>(root, options, out var merchantsResponseValue))
        {
            return PlansModelMerchant.MerchantsResponse(merchantsResponseValue);
        }
        throw new JsonException($"JSON does not match string or MerchantsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PlansModelMerchant value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(PlansModelMerchant)} contains no valid value to serialize.");
        }
    }
}
