using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record OrgFlowActionsPostRequest
{
    /// <summary>
    /// The identifier of the orgFlow resource that this orgFlowActions resource is associated with.
    /// </summary>
    [JsonPropertyName("orgFlow")]
    public required string OrgFlow { get; init; }

    [JsonPropertyName("org")]
    public required OrgsPostRequest Org { get; init; }

    [JsonPropertyName("action")]
    public required OrgFlowAction2 Action { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
