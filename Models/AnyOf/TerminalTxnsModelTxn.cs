using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The related txn this terminalTxn belongs to.
/// </summary>
[JsonConverter(typeof(TerminalTxnsModelTxnConverter))]
public record TerminalTxnsModelTxn
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TxnsResponse> _txnsResponseValue;

    private TerminalTxnsModelTxn(Optional<string> stringValue, Optional<TxnsResponse> txnsResponseValue)
    {
        _stringValue = stringValue;
        _txnsResponseValue = txnsResponseValue;
    }

    public static TerminalTxnsModelTxn String(string value) => new(Optional<string>.Some(value), default);

    public static TerminalTxnsModelTxn TxnsResponse(TxnsResponse value) =>
        new(default, Optional<TxnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTxnsResponse(out TxnsResponse value) => _txnsResponseValue.TryGetValue(out value);

    public static implicit operator TerminalTxnsModelTxn(string value) => String(value);

    public static implicit operator TerminalTxnsModelTxn(TxnsResponse value) => TxnsResponse(value);
}

file sealed class TerminalTxnsModelTxnConverter : JsonConverter<TerminalTxnsModelTxn>
{
    public override TerminalTxnsModelTxn Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TerminalTxnsModelTxn.String(value);
        }
        if (JsonSerializer.TryDeserialize<TxnsResponse>(root, options, out var txnsResponseValue))
        {
            return TerminalTxnsModelTxn.TxnsResponse(txnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TxnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TerminalTxnsModelTxn value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TerminalTxnsModelTxn)} contains no valid value to serialize.");
        }
    }
}
