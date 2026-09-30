using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record ConfirmCodesPostRequest
{
    /// <summary>
    /// The identifier of the Login resource that this confirmation code relates to.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    [JsonPropertyName("type")]
    public required ConfirmCodeType1 Type { get; init; }

    /// <summary>
    /// The cryptographically secure, randomly generated key to be used for verification.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>
    /// If the 'type' of this confirmation code is '2' (email), then this field represents the email address that requires verification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
