using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TerminalTxnsDatasPostRequest
{
    /// <summary>
    /// The identifier of the TerminalTxn associated with this TerminalTxnDatas resource.
    /// </summary>
    [JsonPropertyName("terminalTxn")]
    public required string TerminalTxn { get; init; }

    /// <summary>
    /// The Base64 encoded image of the signature captured at the time of entering the TerminalTxn.
    /// </summary>
    [JsonPropertyName("signature")]
    public required string Signature { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
