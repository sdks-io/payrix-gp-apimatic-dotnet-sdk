using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record EmbeddedFinanceResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public EmbeddedFinanceResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
