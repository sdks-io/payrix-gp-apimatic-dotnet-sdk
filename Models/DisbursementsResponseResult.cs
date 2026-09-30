using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record DisbursementsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public DisbursementsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
