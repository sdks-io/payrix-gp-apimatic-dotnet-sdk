using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Org that this Aggregation applies to.
/// </summary>
[JsonConverter(typeof(AggregationsModelOrgConverter))]
public record AggregationsModelOrg
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<OrgsResponse> _orgsResponseValue;

    private AggregationsModelOrg(Optional<string> stringValue, Optional<OrgsResponse> orgsResponseValue)
    {
        _stringValue = stringValue;
        _orgsResponseValue = orgsResponseValue;
    }

    public static AggregationsModelOrg String(string value) => new(Optional<string>.Some(value), default);

    public static AggregationsModelOrg OrgsResponse(OrgsResponse value) =>
        new(default, Optional<OrgsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetOrgsResponse(out OrgsResponse value) => _orgsResponseValue.TryGetValue(out value);

    public static implicit operator AggregationsModelOrg(string value) => String(value);

    public static implicit operator AggregationsModelOrg(OrgsResponse value) => OrgsResponse(value);
}

file sealed class AggregationsModelOrgConverter : JsonConverter<AggregationsModelOrg>
{
    public override AggregationsModelOrg Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AggregationsModelOrg.String(value);
        }
        if (JsonSerializer.TryDeserialize<OrgsResponse>(root, options, out var orgsResponseValue))
        {
            return AggregationsModelOrg.OrgsResponse(orgsResponseValue);
        }
        throw new JsonException($"JSON does not match string or OrgsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AggregationsModelOrg value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetOrgsResponse(out var orgsResponseValue))
        {
            JsonSerializer.Serialize(writer, orgsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AggregationsModelOrg)} contains no valid value to serialize.");
        }
    }
}
