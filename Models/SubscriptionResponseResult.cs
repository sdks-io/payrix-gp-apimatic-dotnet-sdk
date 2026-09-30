using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record SubscriptionResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public SubscriptionResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
