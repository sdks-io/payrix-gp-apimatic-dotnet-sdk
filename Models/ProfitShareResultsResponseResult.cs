using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record ProfitShareResultsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ProfitShareResultsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
