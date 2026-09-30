using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record TerminalRefsPostRequest
{
    /// <summary>
    /// The identifier of the Terminal that owns this terminalRefs resource.
    /// </summary>
    [JsonPropertyName("terminal")]
    public required string Terminal { get; init; }

    /// <summary>
    /// The reference code itself. This field is stored as a text string and must be between 0 and 50 characters long.
    /// </summary>
    [JsonPropertyName("ref")]
    public required string Ref { get; init; }

    [JsonPropertyName("stage")]
    public required TerminalRefStage2 Stage { get; init; }

    [JsonPropertyName("platform")]
    public required TerminalRefPlatform2 Platform { get; init; }

    [JsonPropertyName("processor")]
    public required TerminalRefsProcessor2 Processor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
