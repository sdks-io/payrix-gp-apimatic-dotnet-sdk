using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Token resource that this Subscription Token is associated with. This resource identifies the means of payment for the Subscription identified in the 'subscription' field of this resource.
/// </summary>
[JsonConverter(typeof(SubscriptionTokensPostRequestModelTokenConverter))]
public record SubscriptionTokensPostRequestModelToken
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TokenPostRequest> _tokenPostRequestValue;

    private SubscriptionTokensPostRequestModelToken(Optional<string> stringValue,
        Optional<TokenPostRequest> tokenPostRequestValue)
    {
        _stringValue = stringValue;
        _tokenPostRequestValue = tokenPostRequestValue;
    }

    public static SubscriptionTokensPostRequestModelToken String(string value) =>
        new(Optional<string>.Some(value), default);

    public static SubscriptionTokensPostRequestModelToken TokenPostRequest(TokenPostRequest value) =>
        new(default, Optional<TokenPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTokenPostRequest(out TokenPostRequest value) => _tokenPostRequestValue.TryGetValue(out value);

    public static implicit operator SubscriptionTokensPostRequestModelToken(string value) => String(value);

    public static implicit operator SubscriptionTokensPostRequestModelToken(TokenPostRequest value) =>
        TokenPostRequest(value);
}

file sealed class SubscriptionTokensPostRequestModelTokenConverter : JsonConverter<SubscriptionTokensPostRequestModelToken>
{
    public override SubscriptionTokensPostRequestModelToken Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SubscriptionTokensPostRequestModelToken.String(value);
        }
        if (JsonSerializer.TryDeserialize<TokenPostRequest>(root, options, out var tokenPostRequestValue))
        {
            return SubscriptionTokensPostRequestModelToken.TokenPostRequest(tokenPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or TokenPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SubscriptionTokensPostRequestModelToken value,
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
                $"{nameof(SubscriptionTokensPostRequestModelToken)} contains no valid value to serialize.");
        }
    }
}
