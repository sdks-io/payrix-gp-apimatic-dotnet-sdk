using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Aggregation that this AggregationResult refers to.
/// </summary>
[JsonConverter(typeof(AggregationResultGroupsModelAggregationConverter))]
public record AggregationResultGroupsModelAggregation
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AggregationsResponse> _aggregationsResponseValue;

    private AggregationResultGroupsModelAggregation(Optional<string> stringValue,
        Optional<AggregationsResponse> aggregationsResponseValue)
    {
        _stringValue = stringValue;
        _aggregationsResponseValue = aggregationsResponseValue;
    }

    public static AggregationResultGroupsModelAggregation String(string value) =>
        new(Optional<string>.Some(value), default);

    public static AggregationResultGroupsModelAggregation AggregationsResponse(AggregationsResponse value) =>
        new(default, Optional<AggregationsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAggregationsResponse(out AggregationsResponse value) =>
        _aggregationsResponseValue.TryGetValue(out value);

    public static implicit operator AggregationResultGroupsModelAggregation(string value) => String(value);

    public static implicit operator AggregationResultGroupsModelAggregation(AggregationsResponse value) =>
        AggregationsResponse(value);
}

file sealed class AggregationResultGroupsModelAggregationConverter : JsonConverter<AggregationResultGroupsModelAggregation>
{
    public override AggregationResultGroupsModelAggregation Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AggregationResultGroupsModelAggregation.String(value);
        }
        if (JsonSerializer.TryDeserialize<AggregationsResponse>(root, options, out var aggregationsResponseValue))
        {
            return AggregationResultGroupsModelAggregation.AggregationsResponse(aggregationsResponseValue);
        }
        throw new JsonException($"JSON does not match string or AggregationsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        AggregationResultGroupsModelAggregation value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetAggregationsResponse(out var aggregationsResponseValue))
        {
            JsonSerializer.Serialize(writer, aggregationsResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(AggregationResultGroupsModelAggregation)} contains no valid value to serialize.");
        }
    }
}
