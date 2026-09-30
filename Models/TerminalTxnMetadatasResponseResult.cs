using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TerminalTxnMetadatasResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public TerminalTxnMetadatasResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
