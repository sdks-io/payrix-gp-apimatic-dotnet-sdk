using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record AggregationResultsGroupsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public AggregationResultsGroupsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
