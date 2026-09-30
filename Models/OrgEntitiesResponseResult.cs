using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record OrgEntitiesResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public OrgEntitiesResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
