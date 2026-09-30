using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record MappingsPutRequest
{
    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// Name of Mappings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A description of this Mapping.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// A JSON document that describes the input fields that should be mapped.
    /// This field is stored as a text string and must be between 1 and 5000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("input")]
    public string? Input { get; init; }

    /// <summary>
    /// A JSON document that describes the fields that should appear in the output, after the input fields have been mapped.
    /// This field is stored as a text string and must be between 1 and 5000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output")]
    public string? Output { get; init; }

    /// <summary>
    /// A valid URL that represents the XML namespace of the input and output documents.
    /// This field is stored as a text string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
