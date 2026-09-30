using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the record that is associated with this DisbursementEntry resource.
/// </summary>
[JsonConverter(typeof(DisbursementEntriesModelEventIdConverter))]
public record DisbursementEntriesModelEventId
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TxnsResponse> _txnsResponseValue;

    private DisbursementEntriesModelEventId(Optional<string> stringValue, Optional<TxnsResponse> txnsResponseValue)
    {
        _stringValue = stringValue;
        _txnsResponseValue = txnsResponseValue;
    }

    public static DisbursementEntriesModelEventId String(string value) => new(Optional<string>.Some(value), default);

    public static DisbursementEntriesModelEventId TxnsResponse(TxnsResponse value) =>
        new(default, Optional<TxnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTxnsResponse(out TxnsResponse value) => _txnsResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementEntriesModelEventId(string value) => String(value);

    public static implicit operator DisbursementEntriesModelEventId(TxnsResponse value) => TxnsResponse(value);
}

file sealed class DisbursementEntriesModelEventIdConverter : JsonConverter<DisbursementEntriesModelEventId>
{
    public override DisbursementEntriesModelEventId Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementEntriesModelEventId.String(value);
        }
        if (JsonSerializer.TryDeserialize<TxnsResponse>(root, options, out var txnsResponseValue))
        {
            return DisbursementEntriesModelEventId.TxnsResponse(txnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TxnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DisbursementEntriesModelEventId value,
        JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(DisbursementEntriesModelEventId)} contains no valid value to serialize.");
        }
    }
}
