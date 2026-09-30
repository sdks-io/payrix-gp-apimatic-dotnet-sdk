using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record AuthTokensPostRequest
{
    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    /// <summary>
    /// The customer identifier from the AuthToken used during authentication.
    /// </summary>
    [JsonPropertyName("customer")]
    public required string Customer { get; init; }

    /// <summary>
    /// The auto-generated token identifier.
    /// </summary>
    [JsonPropertyName("token")]
    public required string Token { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
