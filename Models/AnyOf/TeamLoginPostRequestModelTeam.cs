using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Team resource that the Login identified in the 'login' field should be marked as part of.
/// </summary>
[JsonConverter(typeof(TeamLoginPostRequestModelTeamConverter))]
public record TeamLoginPostRequestModelTeam
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TeamsPostRequest> _teamsPostRequestValue;

    private TeamLoginPostRequestModelTeam(Optional<string> stringValue,
        Optional<TeamsPostRequest> teamsPostRequestValue)
    {
        _stringValue = stringValue;
        _teamsPostRequestValue = teamsPostRequestValue;
    }

    public static TeamLoginPostRequestModelTeam String(string value) => new(Optional<string>.Some(value), default);

    public static TeamLoginPostRequestModelTeam TeamsPostRequest(TeamsPostRequest value) =>
        new(default, Optional<TeamsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTeamsPostRequest(out TeamsPostRequest value) => _teamsPostRequestValue.TryGetValue(out value);

    public static implicit operator TeamLoginPostRequestModelTeam(string value) => String(value);

    public static implicit operator TeamLoginPostRequestModelTeam(TeamsPostRequest value) => TeamsPostRequest(value);
}

file sealed class TeamLoginPostRequestModelTeamConverter : JsonConverter<TeamLoginPostRequestModelTeam>
{
    public override TeamLoginPostRequestModelTeam Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TeamLoginPostRequestModelTeam.String(value);
        }
        if (JsonSerializer.TryDeserialize<TeamsPostRequest>(root, options, out var teamsPostRequestValue))
        {
            return TeamLoginPostRequestModelTeam.TeamsPostRequest(teamsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or TeamsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        TeamLoginPostRequestModelTeam value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetTeamsPostRequest(out var teamsPostRequestValue))
        {
            JsonSerializer.Serialize(writer, teamsPostRequestValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TeamLoginPostRequestModelTeam)} contains no valid value to serialize.");
        }
    }
}
