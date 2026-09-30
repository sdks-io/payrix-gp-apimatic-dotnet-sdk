using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The ID of the token record to associate with this terminal transaction request.
/// </summary>
[JsonConverter(typeof(TerminalTxnsModelTokenConverter))]
public record TerminalTxnsModelToken
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TokensResponse> _tokensResponseValue;

    private TerminalTxnsModelToken(Optional<string> stringValue, Optional<TokensResponse> tokensResponseValue)
    {
        _stringValue = stringValue;
        _tokensResponseValue = tokensResponseValue;
    }

    public static TerminalTxnsModelToken String(string value) => new(Optional<string>.Some(value), default);

    public static TerminalTxnsModelToken TokensResponse(TokensResponse value) =>
        new(default, Optional<TokensResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTokensResponse(out TokensResponse value) => _tokensResponseValue.TryGetValue(out value);

    public static implicit operator TerminalTxnsModelToken(string value) => String(value);

    public static implicit operator TerminalTxnsModelToken(TokensResponse value) => TokensResponse(value);
}

file sealed class TerminalTxnsModelTokenConverter : JsonConverter<TerminalTxnsModelToken>
{
    public override TerminalTxnsModelToken Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TerminalTxnsModelToken.String(value);
        }
        if (JsonSerializer.TryDeserialize<TokensResponse>(root, options, out var tokensResponseValue))
        {
            return TerminalTxnsModelToken.TokensResponse(tokensResponseValue);
        }
        throw new JsonException($"JSON does not match string or TokensResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TerminalTxnsModelToken value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetTokensResponse(out var tokensResponseValue))
        {
            JsonSerializer.Serialize(writer, tokensResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TerminalTxnsModelToken)} contains no valid value to serialize.");
        }
    }
}
