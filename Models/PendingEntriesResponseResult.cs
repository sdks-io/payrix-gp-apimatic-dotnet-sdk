using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record PendingEntriesResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public PendingEntriesResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
