using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record AdjustmentsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public AdjustmentsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
