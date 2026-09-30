using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record AuthTokensResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public AuthTokensResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
