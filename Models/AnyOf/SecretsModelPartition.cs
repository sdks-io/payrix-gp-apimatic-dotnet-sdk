using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Partition associated with this secret.
/// </summary>
[JsonConverter(typeof(SecretsModelPartitionConverter))]
public record SecretsModelPartition
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PartitionsResponse> _partitionsResponseValue;

    private SecretsModelPartition(Optional<string> stringValue, Optional<PartitionsResponse> partitionsResponseValue)
    {
        _stringValue = stringValue;
        _partitionsResponseValue = partitionsResponseValue;
    }

    public static SecretsModelPartition String(string value) => new(Optional<string>.Some(value), default);

    public static SecretsModelPartition PartitionsResponse(PartitionsResponse value) =>
        new(default, Optional<PartitionsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPartitionsResponse(out PartitionsResponse value) =>
        _partitionsResponseValue.TryGetValue(out value);

    public static implicit operator SecretsModelPartition(string value) => String(value);

    public static implicit operator SecretsModelPartition(PartitionsResponse value) => PartitionsResponse(value);
}

file sealed class SecretsModelPartitionConverter : JsonConverter<SecretsModelPartition>
{
    public override SecretsModelPartition Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SecretsModelPartition.String(value);
        }
        if (JsonSerializer.TryDeserialize<PartitionsResponse>(root, options, out var partitionsResponseValue))
        {
            return SecretsModelPartition.PartitionsResponse(partitionsResponseValue);
        }
        throw new JsonException($"JSON does not match string or PartitionsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, SecretsModelPartition value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetPartitionsResponse(out var partitionsResponseValue))
        {
            JsonSerializer.Serialize(writer, partitionsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SecretsModelPartition)} contains no valid value to serialize.");
        }
    }
}
