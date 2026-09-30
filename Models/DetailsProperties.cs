using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

/// <summary>
/// Where the response lists multiple resources, the API splits the response into several 'pages'.
/// This object indicates the current and last available pages in the list.
/// </summary>
public record DetailsProperties
{
    /// <summary>
    /// The current page in the paginated resource list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current")]
    public int? Current { get; init; }

    /// <summary>
    /// The last available page in the paginated resource list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last")]
    public int? Last { get; init; }

    /// <summary>
    /// Indicates if another page of results is available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasMore")]
    public bool? HasMore { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
