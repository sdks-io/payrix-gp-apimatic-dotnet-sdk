using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TaxFormRequestsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public TaxFormRequestsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
