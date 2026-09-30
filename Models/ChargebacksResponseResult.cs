using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record ChargebacksResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ChargebacksResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
