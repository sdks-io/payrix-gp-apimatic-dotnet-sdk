using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record TerminalTxnRefPostRequest
{
    /// <summary>
    /// The parent terminalTxn that owns this terminalTxnRef and to which this reference applies A single terminalTxn may have many terminalTxnRef records.
    /// </summary>
    [JsonPropertyName("terminalTxn")]
    public required string TerminalTxn { get; init; }

    /// <summary>
    /// The reference value retrieved from the third party.
    /// </summary>
    [JsonPropertyName("ref")]
    public required string Ref { get; init; }

    [JsonPropertyName("stage")]
    public required TerminalTxnRefStage1 Stage { get; init; }

    [JsonPropertyName("platform")]
    public required PlatformModel1 Platform { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
