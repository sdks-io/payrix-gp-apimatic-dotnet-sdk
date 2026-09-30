using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record EntityTermsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public EntityTermsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
