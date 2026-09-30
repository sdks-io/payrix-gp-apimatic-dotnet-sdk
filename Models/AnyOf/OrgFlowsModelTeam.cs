using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Team resource for which this orgFlows resource is triggered.
/// </summary>
[JsonConverter(typeof(OrgFlowsModelTeamConverter))]
public record OrgFlowsModelTeam
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<TeamsResponse> _teamsResponseValue;

    private OrgFlowsModelTeam(Optional<string> stringValue, Optional<TeamsResponse> teamsResponseValue)
    {
        _stringValue = stringValue;
        _teamsResponseValue = teamsResponseValue;
    }

    public static OrgFlowsModelTeam String(string value) => new(Optional<string>.Some(value), default);

    public static OrgFlowsModelTeam TeamsResponse(TeamsResponse value) =>
        new(default, Optional<TeamsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetTeamsResponse(out TeamsResponse value) => _teamsResponseValue.TryGetValue(out value);

    public static implicit operator OrgFlowsModelTeam(string value) => String(value);

    public static implicit operator OrgFlowsModelTeam(TeamsResponse value) => TeamsResponse(value);
}

file sealed class OrgFlowsModelTeamConverter : JsonConverter<OrgFlowsModelTeam>
{
    public override OrgFlowsModelTeam Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return OrgFlowsModelTeam.String(value);
        }
        if (JsonSerializer.TryDeserialize<TeamsResponse>(root, options, out var teamsResponseValue))
        {
            return OrgFlowsModelTeam.TeamsResponse(teamsResponseValue);
        }
        throw new JsonException($"JSON does not match string or TeamsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, OrgFlowsModelTeam value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(OrgFlowsModelTeam)} contains no valid value to serialize.");
        }
    }
}
