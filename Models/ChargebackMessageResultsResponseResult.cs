using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record ChargebackMessageResultsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ChargebackMessageResultsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
