using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the record that is associated with this PendingEntry.
/// </summary>
[JsonConverter(typeof(ReserveEntriesModelEventIdConverter))]
public record ReserveEntriesModelEventId
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TxnsResponse> _txnsResponseValue;

    private ReserveEntriesModelEventId(Optional<string> stringValue, Optional<TxnsResponse> txnsResponseValue)
    {
        _stringValue = stringValue;
        _txnsResponseValue = txnsResponseValue;
    }

    public static ReserveEntriesModelEventId String(string value) => new(Optional<string>.Some(value), default);

    public static ReserveEntriesModelEventId TxnsResponse(TxnsResponse value) =>
        new(default, Optional<TxnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTxnsResponse(out TxnsResponse value) => _txnsResponseValue.TryGetValue(out value);

    public static implicit operator ReserveEntriesModelEventId(string value) => String(value);

    public static implicit operator ReserveEntriesModelEventId(TxnsResponse value) => TxnsResponse(value);
}

file sealed class ReserveEntriesModelEventIdConverter : JsonConverter<ReserveEntriesModelEventId>
{
    public override ReserveEntriesModelEventId Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ReserveEntriesModelEventId.String(value);
        }
        if (JsonSerializer.TryDeserialize<TxnsResponse>(root, options, out var txnsResponseValue))
        {
            return ReserveEntriesModelEventId.TxnsResponse(txnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TxnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ReserveEntriesModelEventId value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(ReserveEntriesModelEventId)} contains no valid value to serialize.");
        }
    }
}
