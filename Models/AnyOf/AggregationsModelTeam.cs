using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Team that this Aggregation applies to.
/// </summary>
[JsonConverter(typeof(AggregationsModelTeamConverter))]
public record AggregationsModelTeam
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TeamsResponse> _teamsResponseValue;

    private AggregationsModelTeam(Optional<string> stringValue, Optional<TeamsResponse> teamsResponseValue)
    {
        _stringValue = stringValue;
        _teamsResponseValue = teamsResponseValue;
    }

    public static AggregationsModelTeam String(string value) => new(Optional<string>.Some(value), default);

    public static AggregationsModelTeam TeamsResponse(TeamsResponse value) =>
        new(default, Optional<TeamsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTeamsResponse(out TeamsResponse value) => _teamsResponseValue.TryGetValue(out value);

    public static implicit operator AggregationsModelTeam(string value) => String(value);

    public static implicit operator AggregationsModelTeam(TeamsResponse value) => TeamsResponse(value);
}

file sealed class AggregationsModelTeamConverter : JsonConverter<AggregationsModelTeam>
{
    public override AggregationsModelTeam Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AggregationsModelTeam.String(value);
        }
        if (JsonSerializer.TryDeserialize<TeamsResponse>(root, options, out var teamsResponseValue))
        {
            return AggregationsModelTeam.TeamsResponse(teamsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TeamsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AggregationsModelTeam value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetTeamsResponse(out var teamsResponseValue))
        {
            JsonSerializer.Serialize(writer, teamsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AggregationsModelTeam)} contains no valid value to serialize.");
        }
    }
}
