using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// Specifies whether this is the opposingMessage or not.
/// </summary>
[JsonConverter(typeof(MessagesModelOpposingMessageConverter))]
public record MessagesModelOpposingMessage
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<MessagesResponse> _messagesResponseValue;

    private MessagesModelOpposingMessage(Optional<string> stringValue, Optional<MessagesResponse> messagesResponseValue)
    {
        _stringValue = stringValue;
        _messagesResponseValue = messagesResponseValue;
    }

    public static MessagesModelOpposingMessage String(string value) => new(Optional<string>.Some(value), default);

    public static MessagesModelOpposingMessage MessagesResponse(MessagesResponse value) =>
        new(default, Optional<MessagesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetMessagesResponse(out MessagesResponse value) => _messagesResponseValue.TryGetValue(out value);

    public static implicit operator MessagesModelOpposingMessage(string value) => String(value);

    public static implicit operator MessagesModelOpposingMessage(MessagesResponse value) => MessagesResponse(value);
}

file sealed class MessagesModelOpposingMessageConverter : JsonConverter<MessagesModelOpposingMessage>
{
    public override MessagesModelOpposingMessage Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return MessagesModelOpposingMessage.String(value);
        }
        if (JsonSerializer.TryDeserialize<MessagesResponse>(root, options, out var messagesResponseValue))
        {
            return MessagesModelOpposingMessage.MessagesResponse(messagesResponseValue);
        }
        throw new JsonException($"JSON does not match string or MessagesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MessagesModelOpposingMessage value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetMessagesResponse(out var messagesResponseValue))
        {
            JsonSerializer.Serialize(writer, messagesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(MessagesModelOpposingMessage)} contains no valid value to serialize.");
        }
    }
}
