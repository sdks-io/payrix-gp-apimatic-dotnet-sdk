using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record ErrorItem
{
    /// <summary>
    /// The error code associated with a particular error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public int? Code { get; init; }

    /// <summary>
    /// The severity level of a particular error.
    /// Possible values are '0' (informational), '1' (warning), '2' (error) and '4' (failure).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("severity")]
    public int? Severity { get; init; }

    /// <summary>
    /// The message associated with a particular error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("msg")]
    public string? Msg { get; init; }

    /// <summary>
    /// Field name associated with error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public string? Field { get; init; }

    /// <summary>
    /// An identifying string code for this error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
