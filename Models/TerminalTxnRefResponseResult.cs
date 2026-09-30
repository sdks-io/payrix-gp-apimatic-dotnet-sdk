using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TerminalTxnRefResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public TerminalTxnRefResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
