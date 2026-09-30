using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record FraudSightEnablementsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public FraudSightEnablementsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
