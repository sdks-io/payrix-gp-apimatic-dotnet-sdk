using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record CredentialsPutRequest
{
    /// <summary>
    /// The name of this Credential resource.
    /// This field is stored as a text string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A description of this Credential resource.
    /// This field is stored as a text string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The username to use when authenticating to the integration associated with this Credential resource.
    /// This field is stored as a text string and must be between 1 and 50 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("username")]
    public string? Username { get; init; }

    /// <summary>
    /// The password to use when authenticating to the integration associated with this Credential resource.
    /// This field is stored as a text string and must be between 1 and 50 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    /// <summary>
    /// The username to use when connecting to the integration associated with this Credential resource.
    /// This field is stored as a text string and must be between 1 and 50 characters long.
    /// This field is only necessary when it is required by the integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connectUsername")]
    public string? ConnectUsername { get; init; }

    /// <summary>
    /// The password to use when connecting to the integration associated with this Credential resource.
    /// This field is stored as a text string and must be between 1 and 50 characters long.
    /// This field is only necessary when it is required by the integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connectPassword")]
    public string? ConnectPassword { get; init; }

    /// <summary>
    /// The secret resource identifier to use when connecting using this Credential.
    /// This field is only necessary when a private key is required by the integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
