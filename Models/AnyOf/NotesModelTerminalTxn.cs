using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the TerminalTxn that relates to this notes resource.
/// </summary>
[JsonConverter(typeof(NotesModelTerminalTxnConverter))]
public record NotesModelTerminalTxn
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TerminalTxnsResponse> _terminalTxnsResponseValue;

    private NotesModelTerminalTxn(Optional<string> stringValue,
        Optional<TerminalTxnsResponse> terminalTxnsResponseValue)
    {
        _stringValue = stringValue;
        _terminalTxnsResponseValue = terminalTxnsResponseValue;
    }

    public static NotesModelTerminalTxn String(string value) => new(Optional<string>.Some(value), default);

    public static NotesModelTerminalTxn TerminalTxnsResponse(TerminalTxnsResponse value) =>
        new(default, Optional<TerminalTxnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTerminalTxnsResponse(out TerminalTxnsResponse value) =>
        _terminalTxnsResponseValue.TryGetValue(out value);

    public static implicit operator NotesModelTerminalTxn(string value) => String(value);

    public static implicit operator NotesModelTerminalTxn(TerminalTxnsResponse value) => TerminalTxnsResponse(value);
}

file sealed class NotesModelTerminalTxnConverter : JsonConverter<NotesModelTerminalTxn>
{
    public override NotesModelTerminalTxn Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return NotesModelTerminalTxn.String(value);
        }
        if (JsonSerializer.TryDeserialize<TerminalTxnsResponse>(root, options, out var terminalTxnsResponseValue))
        {
            return NotesModelTerminalTxn.TerminalTxnsResponse(terminalTxnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TerminalTxnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, NotesModelTerminalTxn value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(NotesModelTerminalTxn)} contains no valid value to serialize.");
        }
    }
}
