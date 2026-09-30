using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record SubscriptionTokensResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public SubscriptionTokensResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
