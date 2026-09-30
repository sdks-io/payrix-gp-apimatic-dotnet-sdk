using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record RevenueBoostsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public RevenueBoostsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
