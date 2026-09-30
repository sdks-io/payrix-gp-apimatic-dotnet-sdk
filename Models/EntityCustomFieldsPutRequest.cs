using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record EntityCustomFieldsPutRequest
{
    /// <summary>
    /// Name of custom field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    /// <summary>
    /// Value of custom field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
