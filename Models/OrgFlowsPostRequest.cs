using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record OrgFlowsPostRequest
{
    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// The identifier of the Login resource for which this orgFlows resource is triggered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forlogin")]
    public string? Forlogin { get; init; }

    /// <summary>
    /// The identifier of the Team resource for which this orgFlows resource is triggered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team")]
    public string? Team { get; init; }

    /// <summary>
    /// The identified of the Division resource for which this orgFlows resource is triggered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public string? Division { get; init; }

    [JsonPropertyName("trigger")]
    public required OrgFlowTrigger1 Trigger { get; init; }

    /// <summary>
    /// The identified of the Partition resource for which this orgFlows resource is triggered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partition")]
    public string? Partition { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orgFlowActions")]
    public IReadOnlyList<OrgFlowActionsPostRequest>? OrgFlowActions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orgFlowRules")]
    public IReadOnlyList<OrgFlowRulesPostRequest>? OrgFlowRules { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
