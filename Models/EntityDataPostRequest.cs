using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record EntityDataPostRequest
{
    /// <summary>
    /// The Entity associated with this EntityData.
    /// </summary>
    [JsonPropertyName("entity")]
    public required string Entity { get; init; }

    /// <summary>
    /// The Base64 encoded image of the signature captured at the time of creating the Entity.
    /// </summary>
    [JsonPropertyName("tcAcceptSignature")]
    public required string TcAcceptSignature { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
