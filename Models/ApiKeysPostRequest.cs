using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record ApiKeysPostRequest
{
    /// <summary>
    /// The login under which to perform this action. If you do not supply a login in this field, then the API defaults to the login that is currently authenticated.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    /// <summary>
    /// The name for the key. An apikey may represent a private (secret) key code that is used internally (server-side) by the application authenticating to the API.
    /// <para>
    ///  A private key should never be exposed to external/untrusted entities and should be immediately deactivated if compromised. All API resources and actions can be accessed/performed with a private apikey.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Description of ApiKeys.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("public")]
    public ApiKeyPublic1? Public { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public ApikeysToken1? Token { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
