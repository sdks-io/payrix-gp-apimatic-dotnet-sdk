using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// A list of references related to this Transaction.
/// </summary>
[JsonConverter(typeof(TxnsModelTxnRefsConverter))]
public record TxnsModelTxnRefs
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TxnRefsResponse> _txnRefsResponseValue;

    private TxnsModelTxnRefs(Optional<string> stringValue, Optional<TxnRefsResponse> txnRefsResponseValue)
    {
        _stringValue = stringValue;
        _txnRefsResponseValue = txnRefsResponseValue;
    }

    public static TxnsModelTxnRefs String(string value) => new(Optional<string>.Some(value), default);

    public static TxnsModelTxnRefs TxnRefsResponse(TxnRefsResponse value) =>
        new(default, Optional<TxnRefsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTxnRefsResponse(out TxnRefsResponse value) => _txnRefsResponseValue.TryGetValue(out value);

    public static implicit operator TxnsModelTxnRefs(string value) => String(value);

    public static implicit operator TxnsModelTxnRefs(TxnRefsResponse value) => TxnRefsResponse(value);
}

file sealed class TxnsModelTxnRefsConverter : JsonConverter<TxnsModelTxnRefs>
{
    public override TxnsModelTxnRefs Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TxnsModelTxnRefs.String(value);
        }
        if (JsonSerializer.TryDeserialize<TxnRefsResponse>(root, options, out var txnRefsResponseValue))
        {
            return TxnsModelTxnRefs.TxnRefsResponse(txnRefsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TxnRefsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TxnsModelTxnRefs value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetTxnRefsResponse(out var txnRefsResponseValue))
        {
            JsonSerializer.Serialize(writer, txnRefsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TxnsModelTxnRefs)} contains no valid value to serialize.");
        }
    }
}
