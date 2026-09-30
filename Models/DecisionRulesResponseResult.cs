using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record DecisionRulesResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public DecisionRulesResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
