using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record UpdateApplePayDomainResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responses")]
    public IReadOnlyList<object>? Responses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
