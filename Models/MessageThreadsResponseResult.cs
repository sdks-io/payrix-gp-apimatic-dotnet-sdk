using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record MessageThreadsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public MessageThreadsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
