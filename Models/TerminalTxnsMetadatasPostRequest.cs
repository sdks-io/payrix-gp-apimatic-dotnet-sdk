using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record TerminalTxnsMetadatasPostRequest
{
    /// <summary>
    /// The identifier of the Terminal Transaction associated with this TerminalTxnMetadatas resource.
    /// </summary>
    [JsonPropertyName("terminalTxn")]
    public required string TerminalTxn { get; init; }

    [JsonPropertyName("type")]
    public required TerminalTxnMetadataType1 Type { get; init; }

    [JsonPropertyName("field")]
    public required TerminalTxnsMetadatasField1 Field { get; init; }

    /// <summary>
    /// The value of the field. This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
