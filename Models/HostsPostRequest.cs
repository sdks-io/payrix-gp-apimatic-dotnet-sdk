using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record HostsPostRequest
{
    /// <summary>
    /// The identifier of the Partition resource that this Host belongs to.
    /// </summary>
    [JsonPropertyName("partition")]
    public required string Partition { get; init; }

    /// <summary>
    /// The identifier of the Division resource that this Host belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public string? Division { get; init; }

    /// <summary>
    /// The fully-qualified host name of the API for this Host.
    /// For example, 'api.example.com'.
    /// This field must be unique.
    /// </summary>
    [JsonPropertyName("api")]
    public required string Api { get; init; }

    /// <summary>
    /// The fully-qualified host name of the portal for this Host.
    /// For example, 'portal.example.com'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("portal")]
    public string? Portal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
