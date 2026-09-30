using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record OrgFlowRulesResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public OrgFlowRulesResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
