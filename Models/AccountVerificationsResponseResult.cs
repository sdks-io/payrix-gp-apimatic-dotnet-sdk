using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record AccountVerificationsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public AccountVerificationsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
