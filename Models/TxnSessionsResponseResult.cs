using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TxnSessionsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public TxnSessionsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
