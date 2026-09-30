using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record DecisionActionsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public DecisionActionsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
