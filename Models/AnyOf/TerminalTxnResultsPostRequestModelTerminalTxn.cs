using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the TerminalTxn associated with this terminalTxnResults resource.
/// </summary>
[JsonConverter(typeof(TerminalTxnResultsPostRequestModelTerminalTxnConverter))]
public record TerminalTxnResultsPostRequestModelTerminalTxn
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TerminalTxnsResponse> _terminalTxnsResponseValue;

    private TerminalTxnResultsPostRequestModelTerminalTxn(Optional<string> stringValue,
        Optional<TerminalTxnsResponse> terminalTxnsResponseValue)
    {
        _stringValue = stringValue;
        _terminalTxnsResponseValue = terminalTxnsResponseValue;
    }

    public static TerminalTxnResultsPostRequestModelTerminalTxn String(string value) =>
        new(Optional<string>.Some(value), default);

    public static TerminalTxnResultsPostRequestModelTerminalTxn TerminalTxnsResponse(TerminalTxnsResponse value) =>
        new(default, Optional<TerminalTxnsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTerminalTxnsResponse(out TerminalTxnsResponse value) =>
        _terminalTxnsResponseValue.TryGetValue(out value);

    public static implicit operator TerminalTxnResultsPostRequestModelTerminalTxn(string value) => String(value);

    public static implicit operator TerminalTxnResultsPostRequestModelTerminalTxn(TerminalTxnsResponse value) =>
        TerminalTxnsResponse(value);
}

file sealed class TerminalTxnResultsPostRequestModelTerminalTxnConverter : JsonConverter<TerminalTxnResultsPostRequestModelTerminalTxn>
{
    public override TerminalTxnResultsPostRequestModelTerminalTxn Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TerminalTxnResultsPostRequestModelTerminalTxn.String(value);
        }
        if (JsonSerializer.TryDeserialize<TerminalTxnsResponse>(root, options, out var terminalTxnsResponseValue))
        {
            return TerminalTxnResultsPostRequestModelTerminalTxn.TerminalTxnsResponse(terminalTxnsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TerminalTxnsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        TerminalTxnResultsPostRequestModelTerminalTxn value,
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
            throw new JsonException(
                $"{nameof(TerminalTxnResultsPostRequestModelTerminalTxn)} contains no valid value to serialize.");
        }
    }
}
