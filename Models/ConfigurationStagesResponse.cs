using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record ConfigurationStagesResponse
{
    /// <summary>
    /// The ID of this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The date and time at which this resource was created. The format should be YYYY-MM-DD HH:MM:SS.SSSS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? Created { get; init; }

    /// <summary>
    /// The date and time at which this resource was modified. The format should be YYYY-MM-DD HH:MM:SS.SSSS
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modified")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}.\\d{4}$")]
    public string? Modified { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creator")]
    public Creator18? Creator { get; init; }

    /// <summary>
    /// The identifier of the Login that last modified this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier")]
    public string? Modifier { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configuration")]
    public ConfigurationModel? Configuration { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public ConfigurationStageName2? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public ConfigurationStageMethod2? Method { get; init; }

    /// <summary>
    /// A free-form sequence identifier to order the execution of stages for a configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sequence")]
    public int? Sequence { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("input")]
    public ConfigurationStageInput2? Input { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output")]
    public ConfigurationStageOutput2? Output { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credential")]
    public ConfigurationStageCredentials2? Credential { get; init; }

    /// <summary>
    /// The url used for configurationStage resource. It will consist of a combination of at least one path, and restful id. Placeholders can be used for the restful ids such as https://sample.com/:placeholder:. Valid placeholders are: entity, merchant, member, chargeback, and document. The field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// The directory used once connected.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dir")]
    public string? Dir { get; init; }

    /// <summary>
    /// The indicator of the field when ref Id is found.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restId")]
    public string? RestId { get; init; }

    /// <summary>
    /// A string-JSON representing the data injection mapping between the third party’s response and our internal data array.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mapToData")]
    public string? MapToData { get; init; }

    /// <summary>
    /// The specification on how the file will be named on write.
    /// This field is stored as a JSON string and must be between 0 and 5000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("file")]
    public string? File { get; init; }

    /// <summary>
    /// The filter applied when successful on data read.
    /// This field is stored as a JSON string and must be between 0 and 5000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public string? Filter { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extension")]
    public ConfigurationStageExtension2? Extension { get; init; }

    /// <summary>
    /// The namespace used for the configurationStage resource.
    /// This field is stored as a text string and must be between 0 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    /// <summary>
    /// Only used in case the it is dynamic stage.
    /// This field is stored as a JSON string, must be between 0 and 5000 characters long, and have a property key name with value of stage name and id key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dynamicStage")]
    public string? DynamicStage { get; init; }

    /// <summary>
    /// With the specificity of the configuration stages, it holds different integration methods, part of it is holding specific connection details that is needed to consume the service. The curlOptions is used to hold those specifics, things like SSLCERT, SSLKEY etc
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("curlOptions")]
    public string? CurlOptions { get; init; }

    /// <summary>
    /// The headers used for the configurationStage resource.
    /// This field is stored as a JSON string and must be between 0 and 5000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headers")]
    public string? Headers { get; init; }

    /// <summary>
    /// Delay to be applied before calling the resource in microseconds.
    /// Range allowed between 0 and 10 secs (10000) miliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callDelay")]
    public int? CallDelay { get; init; }

    /// <summary>
    /// The connection timeout duration (in seconds) for API calls.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connectTimeout")]
    public int? ConnectTimeout { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fileConfigFilter")]
    public string? FileConfigFilter { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
