using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// Specifies whether this is the opposingMessage or not.
/// </summary>
[JsonConverter(typeof(MessagesPostModelOpposingMessageConverter))]
public record MessagesPostModelOpposingMessage
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<MessagesResponse> _messagesResponseValue;

    private MessagesPostModelOpposingMessage(Optional<string> stringValue,
        Optional<MessagesResponse> messagesResponseValue)
    {
        _stringValue = stringValue;
        _messagesResponseValue = messagesResponseValue;
    }

    public static MessagesPostModelOpposingMessage String(string value) => new(Optional<string>.Some(value), default);

    public static MessagesPostModelOpposingMessage MessagesResponse(MessagesResponse value) =>
        new(default, Optional<MessagesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetMessagesResponse(out MessagesResponse value) => _messagesResponseValue.TryGetValue(out value);

    public static implicit operator MessagesPostModelOpposingMessage(string value) => String(value);

    public static implicit operator MessagesPostModelOpposingMessage(MessagesResponse value) => MessagesResponse(value);
}

file sealed class MessagesPostModelOpposingMessageConverter : JsonConverter<MessagesPostModelOpposingMessage>
{
    public override MessagesPostModelOpposingMessage Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return MessagesPostModelOpposingMessage.String(value);
        }
        if (JsonSerializer.TryDeserialize<MessagesResponse>(root, options, out var messagesResponseValue))
        {
            return MessagesPostModelOpposingMessage.MessagesResponse(messagesResponseValue);
        }
        throw new JsonException($"JSON does not match string or MessagesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        MessagesPostModelOpposingMessage value,
        JsonSerializerOptions options)
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
            throw new JsonException(
                $"{nameof(MessagesPostModelOpposingMessage)} contains no valid value to serialize.");
        }
    }
}
