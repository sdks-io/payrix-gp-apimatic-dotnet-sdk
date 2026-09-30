using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record ChangeRequestsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ChangeRequestsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
