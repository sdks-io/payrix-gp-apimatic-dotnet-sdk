using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the messageThreads that owns this Messages resource.
/// </summary>
[JsonConverter(typeof(MessagesModelMessageThreadConverter))]
public record MessagesModelMessageThread
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<MessageThreadsResponse> _messageThreadsResponseValue;

    private MessagesModelMessageThread(Optional<string> stringValue,
        Optional<MessageThreadsResponse> messageThreadsResponseValue)
    {
        _stringValue = stringValue;
        _messageThreadsResponseValue = messageThreadsResponseValue;
    }

    public static MessagesModelMessageThread String(string value) => new(Optional<string>.Some(value), default);

    public static MessagesModelMessageThread MessageThreadsResponse(MessageThreadsResponse value) =>
        new(default, Optional<MessageThreadsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetMessageThreadsResponse(out MessageThreadsResponse value) =>
        _messageThreadsResponseValue.TryGetValue(out value);

    public static implicit operator MessagesModelMessageThread(string value) => String(value);

    public static implicit operator MessagesModelMessageThread(MessageThreadsResponse value) =>
        MessageThreadsResponse(value);
}

file sealed class MessagesModelMessageThreadConverter : JsonConverter<MessagesModelMessageThread>
{
    public override MessagesModelMessageThread Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return MessagesModelMessageThread.String(value);
        }
        if (JsonSerializer.TryDeserialize<MessageThreadsResponse>(root, options, out var messageThreadsResponseValue))
        {
            return MessagesModelMessageThread.MessageThreadsResponse(messageThreadsResponseValue);
        }
        throw new JsonException($"JSON does not match string or MessageThreadsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MessagesModelMessageThread value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetMessageThreadsResponse(out var messageThreadsResponseValue))
        {
            JsonSerializer.Serialize(writer, messageThreadsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(MessagesModelMessageThread)} contains no valid value to serialize.");
        }
    }
}
