using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record Datum
{
    /// <summary>
    /// The opt-out status result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
