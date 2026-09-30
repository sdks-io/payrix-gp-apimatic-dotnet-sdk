using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record WatchlistsPostRequest
{
    /// <summary>
    /// The identifier of the Login associated with this Watchlist.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("integration")]
    public WatchlistIntegration2? Integration { get; init; }

    /// <summary>
    /// The name of this Watchlist.
    /// This field is stored as a text string and must be between 0 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A description of this Watchlist.
    /// This field is stored as a text string and must be between 0 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("default")]
    public required WatchlistsDefault2 Default { get; init; }

    /// <summary>
    /// A custom identifier for this Watchlist.
    /// This field is stored as a text string and must be between 0 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom")]
    public string? Custom { get; init; }

    [JsonPropertyName("inactive")]
    public required Inactive1 Inactive { get; init; }

    [JsonPropertyName("frozen")]
    public required Frozen1 Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
