using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The txn in which these items have been sold, A single txn may have many items.
/// </summary>
[JsonConverter(typeof(ItemsModelTxnConverter))]
public record ItemsModelTxn
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TxnsResponse> _txnsResponseValue;

    private ItemsModelTxn(Optional<string> stringValue, Optional<TxnsResponse> txnsResponseValue)
    {
        _stringValue = stringValue;
        _txnsResponseValue = txnsResponseValue;
    }

    public static ItemsModelTxn String(string value) => new(Optional<string>.Some(value), default);

    public static ItemsModelTxn TxnsResponse(TxnsResponse value) => new(default, Optional<TxnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTxnsResponse(out TxnsResponse value) => _txnsResponseValue.TryGetValue(out value);

    public static implicit operator ItemsModelTxn(string value) => String(value);

    public static implicit operator ItemsModelTxn(TxnsResponse value) => TxnsResponse(value);
}

file sealed class ItemsModelTxnConverter : JsonConverter<ItemsModelTxn>
{
    public override ItemsModelTxn Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ItemsModelTxn.String(value);
        }
        if (JsonSerializer.TryDeserialize<TxnsResponse>(root, options, out var txnsResponseValue))
        {
            return ItemsModelTxn.TxnsResponse(txnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TxnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ItemsModelTxn value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(ItemsModelTxn)} contains no valid value to serialize.");
        }
    }
}
