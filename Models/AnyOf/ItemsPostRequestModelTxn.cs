using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The txn in which these items have been sold, A single txn may have many items.
/// </summary>
[JsonConverter(typeof(ItemsPostRequestModelTxnConverter))]
public record ItemsPostRequestModelTxn
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TxnsPostRequest> _txnsPostRequestValue;

    private ItemsPostRequestModelTxn(Optional<string> stringValue, Optional<TxnsPostRequest> txnsPostRequestValue)
    {
        _stringValue = stringValue;
        _txnsPostRequestValue = txnsPostRequestValue;
    }

    public static ItemsPostRequestModelTxn String(string value) => new(Optional<string>.Some(value), default);

    public static ItemsPostRequestModelTxn TxnsPostRequest(TxnsPostRequest value) =>
        new(default, Optional<TxnsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTxnsPostRequest(out TxnsPostRequest value) => _txnsPostRequestValue.TryGetValue(out value);

    public static implicit operator ItemsPostRequestModelTxn(string value) => String(value);

    public static implicit operator ItemsPostRequestModelTxn(TxnsPostRequest value) => TxnsPostRequest(value);
}

file sealed class ItemsPostRequestModelTxnConverter : JsonConverter<ItemsPostRequestModelTxn>
{
    public override ItemsPostRequestModelTxn Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ItemsPostRequestModelTxn.String(value);
        }
        if (JsonSerializer.TryDeserialize<TxnsPostRequest>(root, options, out var txnsPostRequestValue))
        {
            return ItemsPostRequestModelTxn.TxnsPostRequest(txnsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or TxnsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ItemsPostRequestModelTxn value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetTxnsPostRequest(out var txnsPostRequestValue))
        {
            JsonSerializer.Serialize(writer, txnsPostRequestValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ItemsPostRequestModelTxn)} contains no valid value to serialize.");
        }
    }
}
