using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Subscription resource that this Subscription Token is associated with. This is the Subscription that the Token identified in the 'token' field of this resource is responsible for paying for.
/// </summary>
[JsonConverter(typeof(SubscriptionTokensModelSubscriptionConverter))]
public record SubscriptionTokensModelSubscription
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<SubscriptionsResponse> _subscriptionsResponseValue;

    private SubscriptionTokensModelSubscription(Optional<string> stringValue,
        Optional<SubscriptionsResponse> subscriptionsResponseValue)
    {
        _stringValue = stringValue;
        _subscriptionsResponseValue = subscriptionsResponseValue;
    }

    public static SubscriptionTokensModelSubscription String(string value) =>
        new(Optional<string>.Some(value), default);

    public static SubscriptionTokensModelSubscription SubscriptionsResponse(SubscriptionsResponse value) =>
        new(default, Optional<SubscriptionsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetSubscriptionsResponse(out SubscriptionsResponse value) =>
        _subscriptionsResponseValue.TryGetValue(out value);

    public static implicit operator SubscriptionTokensModelSubscription(string value) => String(value);

    public static implicit operator SubscriptionTokensModelSubscription(SubscriptionsResponse value) =>
        SubscriptionsResponse(value);
}

file sealed class SubscriptionTokensModelSubscriptionConverter : JsonConverter<SubscriptionTokensModelSubscription>
{
    public override SubscriptionTokensModelSubscription Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SubscriptionTokensModelSubscription.String(value);
        }
        if (JsonSerializer.TryDeserialize<SubscriptionsResponse>(root, options, out var subscriptionsResponseValue))
        {
            return SubscriptionTokensModelSubscription.SubscriptionsResponse(subscriptionsResponseValue);
        }
        throw new JsonException($"JSON does not match string or SubscriptionsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        SubscriptionTokensModelSubscription value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetSubscriptionsResponse(out var subscriptionsResponseValue))
        {
            JsonSerializer.Serialize(writer, subscriptionsResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(SubscriptionTokensModelSubscription)} contains no valid value to serialize.");
        }
    }
}
