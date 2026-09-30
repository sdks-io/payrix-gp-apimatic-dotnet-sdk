using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If the Transaction is linked to a Batch, this field specifies the identifier of the Batch.
/// </summary>
[JsonConverter(typeof(TxnsModelBatchConverter))]
public record TxnsModelBatch
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<BatchesResponse> _batchesResponseValue;

    private TxnsModelBatch(Optional<string> stringValue, Optional<BatchesResponse> batchesResponseValue)
    {
        _stringValue = stringValue;
        _batchesResponseValue = batchesResponseValue;
    }

    public static TxnsModelBatch String(string value) => new(Optional<string>.Some(value), default);

    public static TxnsModelBatch BatchesResponse(BatchesResponse value) =>
        new(default, Optional<BatchesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetBatchesResponse(out BatchesResponse value) => _batchesResponseValue.TryGetValue(out value);

    public static implicit operator TxnsModelBatch(string value) => String(value);

    public static implicit operator TxnsModelBatch(BatchesResponse value) => BatchesResponse(value);
}

file sealed class TxnsModelBatchConverter : JsonConverter<TxnsModelBatch>
{
    public override TxnsModelBatch Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TxnsModelBatch.String(value);
        }
        if (JsonSerializer.TryDeserialize<BatchesResponse>(root, options, out var batchesResponseValue))
        {
            return TxnsModelBatch.BatchesResponse(batchesResponseValue);
        }
        throw new JsonException($"JSON does not match string or BatchesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TxnsModelBatch value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetBatchesResponse(out var batchesResponseValue))
        {
            JsonSerializer.Serialize(writer, batchesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TxnsModelBatch)} contains no valid value to serialize.");
        }
    }
}
