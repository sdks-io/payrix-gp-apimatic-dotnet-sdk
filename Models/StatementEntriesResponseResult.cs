using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record StatementEntriesResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public StatementEntriesResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
