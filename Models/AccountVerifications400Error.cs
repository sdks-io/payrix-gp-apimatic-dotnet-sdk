using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record AccountVerifications400Error
{
    /// <summary>
    /// An array of zero or more errors that occurred when the API processed the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<ErrorFourHundredProperties>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
