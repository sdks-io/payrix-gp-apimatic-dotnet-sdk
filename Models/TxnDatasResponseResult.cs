using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TxnDatasResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public TxnDatasResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
