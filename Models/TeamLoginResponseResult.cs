using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TeamLoginResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public TeamLoginResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
