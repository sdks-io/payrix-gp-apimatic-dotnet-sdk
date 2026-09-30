using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TerminalsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public TerminalsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
