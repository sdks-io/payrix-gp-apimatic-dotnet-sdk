using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record OrgEntitiesPutRequest
{
    /// <summary>
    /// The identifier of the Org that this orgEntity is associated with.
    /// </summary>
    [JsonPropertyName("org")]
    public required string Org { get; init; }

    /// <summary>
    /// The identifier of the Entity that this orgEntity is associated with.
    /// </summary>
    [JsonPropertyName("entity")]
    public required string Entity { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
