using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record AggregationResultsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public AggregationResultsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
