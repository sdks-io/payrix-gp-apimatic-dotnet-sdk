using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the AggregationResultGroup that this AggregationResult refers to.
/// </summary>
[JsonConverter(typeof(AggregationResultsModelAggregationResultGroupConverter))]
public record AggregationResultsModelAggregationResultGroup
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AggregationResultGroupsResponse> _aggregationResultGroupsResponseValue;

    private AggregationResultsModelAggregationResultGroup(Optional<string> stringValue,
        Optional<AggregationResultGroupsResponse> aggregationResultGroupsResponseValue)
    {
        _stringValue = stringValue;
        _aggregationResultGroupsResponseValue = aggregationResultGroupsResponseValue;
    }

    public static AggregationResultsModelAggregationResultGroup String(string value) =>
        new(Optional<string>.Some(value), default);

    public static AggregationResultsModelAggregationResultGroup AggregationResultGroupsResponse(AggregationResultGroupsResponse value) =>
        new(default, Optional<AggregationResultGroupsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAggregationResultGroupsResponse(out AggregationResultGroupsResponse value) =>
        _aggregationResultGroupsResponseValue.TryGetValue(out value);

    public static implicit operator AggregationResultsModelAggregationResultGroup(string value) => String(value);

    public static implicit operator AggregationResultsModelAggregationResultGroup(AggregationResultGroupsResponse value) =>
        AggregationResultGroupsResponse(value);
}

file sealed class AggregationResultsModelAggregationResultGroupConverter : JsonConverter<AggregationResultsModelAggregationResultGroup>
{
    public override AggregationResultsModelAggregationResultGroup Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AggregationResultsModelAggregationResultGroup.String(value);
        }
        if (JsonSerializer.TryDeserialize<AggregationResultGroupsResponse>(
            root,
            options,
            out var aggregationResultGroupsResponseValue))
        {
            return AggregationResultsModelAggregationResultGroup.AggregationResultGroupsResponse(
                aggregationResultGroupsResponseValue);
        }
        throw new JsonException(
            $"JSON does not match string or AggregationResultGroupsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        AggregationResultsModelAggregationResultGroup value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetAggregationResultGroupsResponse(out var aggregationResultGroupsResponseValue))
        {
            JsonSerializer.Serialize(writer, aggregationResultGroupsResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(AggregationResultsModelAggregationResultGroup)} contains no valid value to serialize.");
        }
    }
}
