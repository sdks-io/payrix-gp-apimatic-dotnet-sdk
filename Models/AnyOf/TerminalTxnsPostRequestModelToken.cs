using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The ID of the token record to associate with this terminal transaction request.
/// </summary>
[JsonConverter(typeof(TerminalTxnsPostRequestModelTokenConverter))]
public record TerminalTxnsPostRequestModelToken
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TokenPostRequest> _tokenPostRequestValue;

    private TerminalTxnsPostRequestModelToken(Optional<string> stringValue,
        Optional<TokenPostRequest> tokenPostRequestValue)
    {
        _stringValue = stringValue;
        _tokenPostRequestValue = tokenPostRequestValue;
    }

    public static TerminalTxnsPostRequestModelToken String(string value) => new(Optional<string>.Some(value), default);

    public static TerminalTxnsPostRequestModelToken TokenPostRequest(TokenPostRequest value) =>
        new(default, Optional<TokenPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTokenPostRequest(out TokenPostRequest value) => _tokenPostRequestValue.TryGetValue(out value);

    public static implicit operator TerminalTxnsPostRequestModelToken(string value) => String(value);

    public static implicit operator TerminalTxnsPostRequestModelToken(TokenPostRequest value) =>
        TokenPostRequest(value);
}

file sealed class TerminalTxnsPostRequestModelTokenConverter : JsonConverter<TerminalTxnsPostRequestModelToken>
{
    public override TerminalTxnsPostRequestModelToken Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TerminalTxnsPostRequestModelToken.String(value);
        }
        if (JsonSerializer.TryDeserialize<TokenPostRequest>(root, options, out var tokenPostRequestValue))
        {
            return TerminalTxnsPostRequestModelToken.TokenPostRequest(tokenPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or TokenPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        TerminalTxnsPostRequestModelToken value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetTokenPostRequest(out var tokenPostRequestValue))
        {
            JsonSerializer.Serialize(writer, tokenPostRequestValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(TerminalTxnsPostRequestModelToken)} contains no valid value to serialize.");
        }
    }
}
