using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record LoginsHelpersResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public LoginsHelpersResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
