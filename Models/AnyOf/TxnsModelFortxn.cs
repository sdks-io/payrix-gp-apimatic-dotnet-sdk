using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If this Transaction is related to another Transaction, then this field is set to the identifier of the other Transaction.
/// For example, if this Transaction is a refund, this field could be set to the identifier of the original sale Transaction.
/// </summary>
[JsonConverter(typeof(TxnsModelFortxnConverter))]
public record TxnsModelFortxn
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TxnsResponse> _txnsResponseValue;

    private TxnsModelFortxn(Optional<string> stringValue, Optional<TxnsResponse> txnsResponseValue)
    {
        _stringValue = stringValue;
        _txnsResponseValue = txnsResponseValue;
    }

    public static TxnsModelFortxn String(string value) => new(Optional<string>.Some(value), default);

    public static TxnsModelFortxn TxnsResponse(TxnsResponse value) => new(default, Optional<TxnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTxnsResponse(out TxnsResponse value) => _txnsResponseValue.TryGetValue(out value);

    public static implicit operator TxnsModelFortxn(string value) => String(value);

    public static implicit operator TxnsModelFortxn(TxnsResponse value) => TxnsResponse(value);
}

file sealed class TxnsModelFortxnConverter : JsonConverter<TxnsModelFortxn>
{
    public override TxnsModelFortxn Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TxnsModelFortxn.String(value);
        }
        if (JsonSerializer.TryDeserialize<TxnsResponse>(root, options, out var txnsResponseValue))
        {
            return TxnsModelFortxn.TxnsResponse(txnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TxnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TxnsModelFortxn value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TxnsModelFortxn)} contains no valid value to serialize.");
        }
    }
}
