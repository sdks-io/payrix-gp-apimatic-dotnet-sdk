using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record SessionsResponseItem
{
    /// <summary>
    /// The data object that the API returns for this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<SessionResponse>? Data { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public Details2? Details { get; init; }

    /// <summary>
    /// An array of zero or more errors that occurred when the API processed the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<ErrorItem>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
