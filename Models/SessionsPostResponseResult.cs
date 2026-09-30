using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record SessionsPostResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public SessionsPostResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
