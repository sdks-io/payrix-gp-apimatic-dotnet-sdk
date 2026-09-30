using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record OmniTokensResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public OmniTokensResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
