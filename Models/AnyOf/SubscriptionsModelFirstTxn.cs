using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identification of the first transaction processed through this subscription. This is used internally to process subsequent transactions.
/// </summary>
[JsonConverter(typeof(SubscriptionsModelFirstTxnConverter))]
public record SubscriptionsModelFirstTxn
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TxnsResponse> _txnsResponseValue;

    private SubscriptionsModelFirstTxn(Optional<string> stringValue, Optional<TxnsResponse> txnsResponseValue)
    {
        _stringValue = stringValue;
        _txnsResponseValue = txnsResponseValue;
    }

    public static SubscriptionsModelFirstTxn String(string value) => new(Optional<string>.Some(value), default);

    public static SubscriptionsModelFirstTxn TxnsResponse(TxnsResponse value) =>
        new(default, Optional<TxnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTxnsResponse(out TxnsResponse value) => _txnsResponseValue.TryGetValue(out value);

    public static implicit operator SubscriptionsModelFirstTxn(string value) => String(value);

    public static implicit operator SubscriptionsModelFirstTxn(TxnsResponse value) => TxnsResponse(value);
}

file sealed class SubscriptionsModelFirstTxnConverter : JsonConverter<SubscriptionsModelFirstTxn>
{
    public override SubscriptionsModelFirstTxn Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SubscriptionsModelFirstTxn.String(value);
        }
        if (JsonSerializer.TryDeserialize<TxnsResponse>(root, options, out var txnsResponseValue))
        {
            return SubscriptionsModelFirstTxn.TxnsResponse(txnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TxnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, SubscriptionsModelFirstTxn value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetTxnsResponse(out var txnsResponseValue))
        {
            JsonSerializer.Serialize(writer, txnsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SubscriptionsModelFirstTxn)} contains no valid value to serialize.");
        }
    }
}
