using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Subscription resource that this Subscription Token is associated with. This is the Subscription that the Token identified in the 'token' field of this resource is responsible for paying for.
/// </summary>
[JsonConverter(typeof(SubscriptionTokensPostRequestModelSubscriptionConverter))]
public record SubscriptionTokensPostRequestModelSubscription
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<SubscriptionsPostRequest> _subscriptionsPostRequestValue;

    private SubscriptionTokensPostRequestModelSubscription(Optional<string> stringValue,
        Optional<SubscriptionsPostRequest> subscriptionsPostRequestValue)
    {
        _stringValue = stringValue;
        _subscriptionsPostRequestValue = subscriptionsPostRequestValue;
    }

    public static SubscriptionTokensPostRequestModelSubscription String(string value) =>
        new(Optional<string>.Some(value), default);

    public static SubscriptionTokensPostRequestModelSubscription SubscriptionsPostRequest(SubscriptionsPostRequest value) =>
        new(default, Optional<SubscriptionsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetSubscriptionsPostRequest(out SubscriptionsPostRequest value) =>
        _subscriptionsPostRequestValue.TryGetValue(out value);

    public static implicit operator SubscriptionTokensPostRequestModelSubscription(string value) => String(value);

    public static implicit operator SubscriptionTokensPostRequestModelSubscription(SubscriptionsPostRequest value) =>
        SubscriptionsPostRequest(value);
}

file sealed class SubscriptionTokensPostRequestModelSubscriptionConverter : JsonConverter<SubscriptionTokensPostRequestModelSubscription>
{
    public override SubscriptionTokensPostRequestModelSubscription Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SubscriptionTokensPostRequestModelSubscription.String(value);
        }
        if (JsonSerializer.TryDeserialize<SubscriptionsPostRequest>(
            root,
            options,
            out var subscriptionsPostRequestValue))
        {
            return SubscriptionTokensPostRequestModelSubscription.SubscriptionsPostRequest(
                subscriptionsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or SubscriptionsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SubscriptionTokensPostRequestModelSubscription value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetSubscriptionsPostRequest(out var subscriptionsPostRequestValue))
        {
            JsonSerializer.Serialize(writer, subscriptionsPostRequestValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(SubscriptionTokensPostRequestModelSubscription)} contains no valid value to serialize.");
        }
    }
}
