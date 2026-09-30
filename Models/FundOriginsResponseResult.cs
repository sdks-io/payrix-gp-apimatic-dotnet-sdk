using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record FundOriginsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public FundOriginsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
