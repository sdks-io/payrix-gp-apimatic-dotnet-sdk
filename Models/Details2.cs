using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record Details2
{
    /// <summary>
    /// A unique identifier set by the API client, that is echoed by the response.
    /// The request ID can be useful in troubleshooting and monitoring.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public int? RequestId { get; init; }

    /// <summary>
    /// Returns an empty array if we don't pass totals header.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totals")]
    public object? Totals { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page")]
    public Page? Page { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
