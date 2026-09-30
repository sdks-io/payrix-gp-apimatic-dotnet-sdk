using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TokenResultsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public TokenResultsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
