using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the orgFlow resource that this orgFlowActions resource is associated with.
/// </summary>
[JsonConverter(typeof(OrgFlowRulesModelOrgFlowConverter))]
public record OrgFlowRulesModelOrgFlow
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<OrgFlowsResponse> _orgFlowsResponseValue;

    private OrgFlowRulesModelOrgFlow(Optional<string> stringValue, Optional<OrgFlowsResponse> orgFlowsResponseValue)
    {
        _stringValue = stringValue;
        _orgFlowsResponseValue = orgFlowsResponseValue;
    }

    public static OrgFlowRulesModelOrgFlow String(string value) => new(Optional<string>.Some(value), default);

    public static OrgFlowRulesModelOrgFlow OrgFlowsResponse(OrgFlowsResponse value) =>
        new(default, Optional<OrgFlowsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetOrgFlowsResponse(out OrgFlowsResponse value) => _orgFlowsResponseValue.TryGetValue(out value);

    public static implicit operator OrgFlowRulesModelOrgFlow(string value) => String(value);

    public static implicit operator OrgFlowRulesModelOrgFlow(OrgFlowsResponse value) => OrgFlowsResponse(value);
}

file sealed class OrgFlowRulesModelOrgFlowConverter : JsonConverter<OrgFlowRulesModelOrgFlow>
{
    public override OrgFlowRulesModelOrgFlow Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return OrgFlowRulesModelOrgFlow.String(value);
        }
        if (JsonSerializer.TryDeserialize<OrgFlowsResponse>(root, options, out var orgFlowsResponseValue))
        {
            return OrgFlowRulesModelOrgFlow.OrgFlowsResponse(orgFlowsResponseValue);
        }
        throw new JsonException($"JSON does not match string or OrgFlowsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, OrgFlowRulesModelOrgFlow value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetOrgFlowsResponse(out var orgFlowsResponseValue))
        {
            JsonSerializer.Serialize(writer, orgFlowsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(OrgFlowRulesModelOrgFlow)} contains no valid value to serialize.");
        }
    }
}
