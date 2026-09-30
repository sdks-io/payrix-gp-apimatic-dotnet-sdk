using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record ApikeysResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ApikeysResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
