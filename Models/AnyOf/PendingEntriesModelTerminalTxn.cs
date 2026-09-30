using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The terminal transaction ID from which the funding activity was triggered.
/// </summary>
[JsonConverter(typeof(PendingEntriesModelTerminalTxnConverter))]
public record PendingEntriesModelTerminalTxn
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TerminalTxnsResponse> _terminalTxnsResponseValue;

    private PendingEntriesModelTerminalTxn(Optional<string> stringValue,
        Optional<TerminalTxnsResponse> terminalTxnsResponseValue)
    {
        _stringValue = stringValue;
        _terminalTxnsResponseValue = terminalTxnsResponseValue;
    }

    public static PendingEntriesModelTerminalTxn String(string value) => new(Optional<string>.Some(value), default);

    public static PendingEntriesModelTerminalTxn TerminalTxnsResponse(TerminalTxnsResponse value) =>
        new(default, Optional<TerminalTxnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTerminalTxnsResponse(out TerminalTxnsResponse value) =>
        _terminalTxnsResponseValue.TryGetValue(out value);

    public static implicit operator PendingEntriesModelTerminalTxn(string value) => String(value);

    public static implicit operator PendingEntriesModelTerminalTxn(TerminalTxnsResponse value) =>
        TerminalTxnsResponse(value);
}

file sealed class PendingEntriesModelTerminalTxnConverter : JsonConverter<PendingEntriesModelTerminalTxn>
{
    public override PendingEntriesModelTerminalTxn Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PendingEntriesModelTerminalTxn.String(value);
        }
        if (JsonSerializer.TryDeserialize<TerminalTxnsResponse>(root, options, out var terminalTxnsResponseValue))
        {
            return PendingEntriesModelTerminalTxn.TerminalTxnsResponse(terminalTxnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TerminalTxnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        PendingEntriesModelTerminalTxn value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetTerminalTxnsResponse(out var terminalTxnsResponseValue))
        {
            JsonSerializer.Serialize(writer, terminalTxnsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PendingEntriesModelTerminalTxn)} contains no valid value to serialize.");
        }
    }
}
