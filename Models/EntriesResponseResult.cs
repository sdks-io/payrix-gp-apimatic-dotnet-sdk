using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record EntriesResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public EntriesResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
