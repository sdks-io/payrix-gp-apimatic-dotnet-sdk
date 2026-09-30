using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Team resource that the Login identified in the 'login' field should be marked as part of.
/// </summary>
[JsonConverter(typeof(TeamLoginModelTeamConverter))]
public record TeamLoginModelTeam
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TeamsResponse> _teamsResponseValue;

    private TeamLoginModelTeam(Optional<string> stringValue, Optional<TeamsResponse> teamsResponseValue)
    {
        _stringValue = stringValue;
        _teamsResponseValue = teamsResponseValue;
    }

    public static TeamLoginModelTeam String(string value) => new(Optional<string>.Some(value), default);

    public static TeamLoginModelTeam TeamsResponse(TeamsResponse value) =>
        new(default, Optional<TeamsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTeamsResponse(out TeamsResponse value) => _teamsResponseValue.TryGetValue(out value);

    public static implicit operator TeamLoginModelTeam(string value) => String(value);

    public static implicit operator TeamLoginModelTeam(TeamsResponse value) => TeamsResponse(value);
}

file sealed class TeamLoginModelTeamConverter : JsonConverter<TeamLoginModelTeam>
{
    public override TeamLoginModelTeam Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TeamLoginModelTeam.String(value);
        }
        if (JsonSerializer.TryDeserialize<TeamsResponse>(root, options, out var teamsResponseValue))
        {
            return TeamLoginModelTeam.TeamsResponse(teamsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TeamsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TeamLoginModelTeam value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TeamLoginModelTeam)} contains no valid value to serialize.");
        }
    }
}
