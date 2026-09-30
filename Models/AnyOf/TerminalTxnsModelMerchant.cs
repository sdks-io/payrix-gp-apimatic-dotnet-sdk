using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Merchant associated with this Transaction.
/// </summary>
[JsonConverter(typeof(TerminalTxnsModelMerchantConverter))]
public record TerminalTxnsModelMerchant
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<MerchantsResponse> _merchantsResponseValue;

    private TerminalTxnsModelMerchant(Optional<string> stringValue, Optional<MerchantsResponse> merchantsResponseValue)
    {
        _stringValue = stringValue;
        _merchantsResponseValue = merchantsResponseValue;
    }

    public static TerminalTxnsModelMerchant String(string value) => new(Optional<string>.Some(value), default);

    public static TerminalTxnsModelMerchant MerchantsResponse(MerchantsResponse value) =>
        new(default, Optional<MerchantsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetMerchantsResponse(out MerchantsResponse value) => _merchantsResponseValue.TryGetValue(out value);

    public static implicit operator TerminalTxnsModelMerchant(string value) => String(value);

    public static implicit operator TerminalTxnsModelMerchant(MerchantsResponse value) => MerchantsResponse(value);
}

file sealed class TerminalTxnsModelMerchantConverter : JsonConverter<TerminalTxnsModelMerchant>
{
    public override TerminalTxnsModelMerchant Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TerminalTxnsModelMerchant.String(value);
        }
        if (JsonSerializer.TryDeserialize<MerchantsResponse>(root, options, out var merchantsResponseValue))
        {
            return TerminalTxnsModelMerchant.MerchantsResponse(merchantsResponseValue);
        }
        throw new JsonException($"JSON does not match string or MerchantsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TerminalTxnsModelMerchant value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TerminalTxnsModelMerchant)} contains no valid value to serialize.");
        }
    }
}
