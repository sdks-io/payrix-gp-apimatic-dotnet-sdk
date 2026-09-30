using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TerminalTxnDatasResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public TerminalTxnDatasResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
