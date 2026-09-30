using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the orgFlow resource that this orgFlowActions resource is associated with.
/// </summary>
[JsonConverter(typeof(OrgFlowRulesPostRequestModelOrgFlowConverter))]
public record OrgFlowRulesPostRequestModelOrgFlow
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<OrgFlowsPostRequest> _orgFlowsPostRequestValue;

    private OrgFlowRulesPostRequestModelOrgFlow(Optional<string> stringValue,
        Optional<OrgFlowsPostRequest> orgFlowsPostRequestValue)
    {
        _stringValue = stringValue;
        _orgFlowsPostRequestValue = orgFlowsPostRequestValue;
    }

    public static OrgFlowRulesPostRequestModelOrgFlow String(string value) =>
        new(Optional<string>.Some(value), default);

    public static OrgFlowRulesPostRequestModelOrgFlow OrgFlowsPostRequest(OrgFlowsPostRequest value) =>
        new(default, Optional<OrgFlowsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetOrgFlowsPostRequest(out OrgFlowsPostRequest value) =>
        _orgFlowsPostRequestValue.TryGetValue(out value);

    public static implicit operator OrgFlowRulesPostRequestModelOrgFlow(string value) => String(value);

    public static implicit operator OrgFlowRulesPostRequestModelOrgFlow(OrgFlowsPostRequest value) =>
        OrgFlowsPostRequest(value);
}

file sealed class OrgFlowRulesPostRequestModelOrgFlowConverter : JsonConverter<OrgFlowRulesPostRequestModelOrgFlow>
{
    public override OrgFlowRulesPostRequestModelOrgFlow Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return OrgFlowRulesPostRequestModelOrgFlow.String(value);
        }
        if (JsonSerializer.TryDeserialize<OrgFlowsPostRequest>(root, options, out var orgFlowsPostRequestValue))
        {
            return OrgFlowRulesPostRequestModelOrgFlow.OrgFlowsPostRequest(orgFlowsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or OrgFlowsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        OrgFlowRulesPostRequestModelOrgFlow value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetOrgFlowsPostRequest(out var orgFlowsPostRequestValue))
        {
            JsonSerializer.Serialize(writer, orgFlowsPostRequestValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(OrgFlowRulesPostRequestModelOrgFlow)} contains no valid value to serialize.");
        }
    }
}
