using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record CustomersResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public CustomersResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
