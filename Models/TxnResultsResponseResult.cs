using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TxnResultsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public TxnResultsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
