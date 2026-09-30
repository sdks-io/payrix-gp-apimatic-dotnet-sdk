using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The token of the Tokens resource this Transaction is associated with.
/// </summary>
[JsonConverter(typeof(TxnsModelTokenConverter))]
public record TxnsModelToken
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TokensResponse> _tokensResponseValue;

    private TxnsModelToken(Optional<string> stringValue, Optional<TokensResponse> tokensResponseValue)
    {
        _stringValue = stringValue;
        _tokensResponseValue = tokensResponseValue;
    }

    public static TxnsModelToken String(string value) => new(Optional<string>.Some(value), default);

    public static TxnsModelToken TokensResponse(TokensResponse value) =>
        new(default, Optional<TokensResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTokensResponse(out TokensResponse value) => _tokensResponseValue.TryGetValue(out value);

    public static implicit operator TxnsModelToken(string value) => String(value);

    public static implicit operator TxnsModelToken(TokensResponse value) => TokensResponse(value);
}

file sealed class TxnsModelTokenConverter : JsonConverter<TxnsModelToken>
{
    public override TxnsModelToken Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TxnsModelToken.String(value);
        }
        if (JsonSerializer.TryDeserialize<TokensResponse>(root, options, out var tokensResponseValue))
        {
            return TxnsModelToken.TokensResponse(tokensResponseValue);
        }
        throw new JsonException($"JSON does not match string or TokensResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TxnsModelToken value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TxnsModelToken)} contains no valid value to serialize.");
        }
    }
}
