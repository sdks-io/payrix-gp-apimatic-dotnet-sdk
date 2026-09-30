using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record AlertActionsPostRequest
{
    [JsonPropertyName("alert")]
    public required AlertsPostRequest Alert { get; init; }

    /// <summary>
    /// The request header name for authentication to the endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; init; }

    /// <summary>
    /// The request header value for authentication to the endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; init; }

    [JsonPropertyName("type")]
    public required AlertActionType1 Type { get; init; }

    /// <summary>
    /// When the 'type' field of this resource is set to 'web', this field determines the format that the Alert data should be sent in.
    /// </summary>
    [JsonPropertyName("options")]
    public required string Options { get; init; }

    /// <summary>
    /// A value used to deliver the alert. Thie field should be set to an email address if the type is email, an endpoint if the type is web, etc.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    /// <summary>
    /// The number of times an alert should be resent in case of a failure. This fields can only be set for web type alertActions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("retries")]
    public int? Retries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxAttemptsTempDisabled")]
    public AlertActionsMaxAttemptsTempDisabled1? MaxAttemptsTempDisabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
