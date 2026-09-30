using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record SaferPaymentsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public SaferPaymentsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
