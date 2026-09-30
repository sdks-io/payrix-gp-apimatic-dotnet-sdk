using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier (ID) of the team that this Alert relates to. The Alert is triggered based on the activity of this Team.
/// </summary>
[JsonConverter(typeof(AlertsModelTeamConverter))]
public record AlertsModelTeam
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TeamsResponse> _teamsResponseValue;

    private AlertsModelTeam(Optional<string> stringValue, Optional<TeamsResponse> teamsResponseValue)
    {
        _stringValue = stringValue;
        _teamsResponseValue = teamsResponseValue;
    }

    public static AlertsModelTeam String(string value) => new(Optional<string>.Some(value), default);

    public static AlertsModelTeam TeamsResponse(TeamsResponse value) =>
        new(default, Optional<TeamsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTeamsResponse(out TeamsResponse value) => _teamsResponseValue.TryGetValue(out value);

    public static implicit operator AlertsModelTeam(string value) => String(value);

    public static implicit operator AlertsModelTeam(TeamsResponse value) => TeamsResponse(value);
}

file sealed class AlertsModelTeamConverter : JsonConverter<AlertsModelTeam>
{
    public override AlertsModelTeam Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AlertsModelTeam.String(value);
        }
        if (JsonSerializer.TryDeserialize<TeamsResponse>(root, options, out var teamsResponseValue))
        {
            return AlertsModelTeam.TeamsResponse(teamsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TeamsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AlertsModelTeam value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(AlertsModelTeam)} contains no valid value to serialize.");
        }
    }
}
