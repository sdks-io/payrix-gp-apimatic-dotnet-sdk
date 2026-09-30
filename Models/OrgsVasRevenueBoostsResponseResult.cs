using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record OrgsVasRevenueBoostsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public OrgsVasRevenueBoostsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
