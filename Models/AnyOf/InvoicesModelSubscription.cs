using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Subscription of this invoice resource.
/// </summary>
[JsonConverter(typeof(InvoicesModelSubscriptionConverter))]
public record InvoicesModelSubscription
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<SubscriptionsResponse> _subscriptionsResponseValue;

    private InvoicesModelSubscription(Optional<string> stringValue,
        Optional<SubscriptionsResponse> subscriptionsResponseValue)
    {
        _stringValue = stringValue;
        _subscriptionsResponseValue = subscriptionsResponseValue;
    }

    public static InvoicesModelSubscription String(string value) => new(Optional<string>.Some(value), default);

    public static InvoicesModelSubscription SubscriptionsResponse(SubscriptionsResponse value) =>
        new(default, Optional<SubscriptionsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetSubscriptionsResponse(out SubscriptionsResponse value) =>
        _subscriptionsResponseValue.TryGetValue(out value);

    public static implicit operator InvoicesModelSubscription(string value) => String(value);

    public static implicit operator InvoicesModelSubscription(SubscriptionsResponse value) =>
        SubscriptionsResponse(value);
}

file sealed class InvoicesModelSubscriptionConverter : JsonConverter<InvoicesModelSubscription>
{
    public override InvoicesModelSubscription Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return InvoicesModelSubscription.String(value);
        }
        if (JsonSerializer.TryDeserialize<SubscriptionsResponse>(root, options, out var subscriptionsResponseValue))
        {
            return InvoicesModelSubscription.SubscriptionsResponse(subscriptionsResponseValue);
        }
        throw new JsonException($"JSON does not match string or SubscriptionsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, InvoicesModelSubscription value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(InvoicesModelSubscription)} contains no valid value to serialize.");
        }
    }
}
