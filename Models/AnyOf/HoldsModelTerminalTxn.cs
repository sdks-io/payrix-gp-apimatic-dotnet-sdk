using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The TerminalTxn id in which this Hold belongs to.
/// </summary>
[JsonConverter(typeof(HoldsModelTerminalTxnConverter))]
public record HoldsModelTerminalTxn
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TerminalTxnsResponse> _terminalTxnsResponseValue;

    private HoldsModelTerminalTxn(Optional<string> stringValue,
        Optional<TerminalTxnsResponse> terminalTxnsResponseValue)
    {
        _stringValue = stringValue;
        _terminalTxnsResponseValue = terminalTxnsResponseValue;
    }

    public static HoldsModelTerminalTxn String(string value) => new(Optional<string>.Some(value), default);

    public static HoldsModelTerminalTxn TerminalTxnsResponse(TerminalTxnsResponse value) =>
        new(default, Optional<TerminalTxnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTerminalTxnsResponse(out TerminalTxnsResponse value) =>
        _terminalTxnsResponseValue.TryGetValue(out value);

    public static implicit operator HoldsModelTerminalTxn(string value) => String(value);

    public static implicit operator HoldsModelTerminalTxn(TerminalTxnsResponse value) => TerminalTxnsResponse(value);
}

file sealed class HoldsModelTerminalTxnConverter : JsonConverter<HoldsModelTerminalTxn>
{
    public override HoldsModelTerminalTxn Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return HoldsModelTerminalTxn.String(value);
        }
        if (JsonSerializer.TryDeserialize<TerminalTxnsResponse>(root, options, out var terminalTxnsResponseValue))
        {
            return HoldsModelTerminalTxn.TerminalTxnsResponse(terminalTxnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TerminalTxnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, HoldsModelTerminalTxn value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(HoldsModelTerminalTxn)} contains no valid value to serialize.");
        }
    }
}
