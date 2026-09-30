using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Token resource that this Subscription Token is associated with. This resource identifies the means of payment for the Subscription identified in the 'subscription' field of this resource.
/// </summary>
[JsonConverter(typeof(SubscriptionTokensModelTokenConverter))]
public record SubscriptionTokensModelToken
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TokensResponse> _tokensResponseValue;

    private SubscriptionTokensModelToken(Optional<string> stringValue, Optional<TokensResponse> tokensResponseValue)
    {
        _stringValue = stringValue;
        _tokensResponseValue = tokensResponseValue;
    }

    public static SubscriptionTokensModelToken String(string value) => new(Optional<string>.Some(value), default);

    public static SubscriptionTokensModelToken TokensResponse(TokensResponse value) =>
        new(default, Optional<TokensResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTokensResponse(out TokensResponse value) => _tokensResponseValue.TryGetValue(out value);

    public static implicit operator SubscriptionTokensModelToken(string value) => String(value);

    public static implicit operator SubscriptionTokensModelToken(TokensResponse value) => TokensResponse(value);
}

file sealed class SubscriptionTokensModelTokenConverter : JsonConverter<SubscriptionTokensModelToken>
{
    public override SubscriptionTokensModelToken Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SubscriptionTokensModelToken.String(value);
        }
        if (JsonSerializer.TryDeserialize<TokensResponse>(root, options, out var tokensResponseValue))
        {
            return SubscriptionTokensModelToken.TokensResponse(tokensResponseValue);
        }
        throw new JsonException($"JSON does not match string or TokensResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, SubscriptionTokensModelToken value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(SubscriptionTokensModelToken)} contains no valid value to serialize.");
        }
    }
}
