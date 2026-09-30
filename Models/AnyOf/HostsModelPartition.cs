using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Partition resource that this Host belongs to.
/// </summary>
[JsonConverter(typeof(HostsModelPartitionConverter))]
public record HostsModelPartition
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PartitionsResponse> _partitionsResponseValue;

    private HostsModelPartition(Optional<string> stringValue, Optional<PartitionsResponse> partitionsResponseValue)
    {
        _stringValue = stringValue;
        _partitionsResponseValue = partitionsResponseValue;
    }

    public static HostsModelPartition String(string value) => new(Optional<string>.Some(value), default);

    public static HostsModelPartition PartitionsResponse(PartitionsResponse value) =>
        new(default, Optional<PartitionsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPartitionsResponse(out PartitionsResponse value) =>
        _partitionsResponseValue.TryGetValue(out value);

    public static implicit operator HostsModelPartition(string value) => String(value);

    public static implicit operator HostsModelPartition(PartitionsResponse value) => PartitionsResponse(value);
}

file sealed class HostsModelPartitionConverter : JsonConverter<HostsModelPartition>
{
    public override HostsModelPartition Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return HostsModelPartition.String(value);
        }
        if (JsonSerializer.TryDeserialize<PartitionsResponse>(root, options, out var partitionsResponseValue))
        {
            return HostsModelPartition.PartitionsResponse(partitionsResponseValue);
        }
        throw new JsonException($"JSON does not match string or PartitionsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, HostsModelPartition value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(HostsModelPartition)} contains no valid value to serialize.");
        }
    }
}
