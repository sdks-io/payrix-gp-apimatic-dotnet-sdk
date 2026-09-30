using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record MessagesResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public MessagesResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
