using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record EntityRefsPostRequest
{
    /// <summary>
    /// The identifier of the Entity that owns this entityRefs resource.
    /// </summary>
    [JsonPropertyName("entity")]
    public required string? Entity { get; init; }

    /// <summary>
    /// The identifier of the Member associated with this entityRefs resource. Default value is 'null'
    /// </summary>
    [JsonPropertyName("member")]
    public required string? Member { get; init; }

    /// <summary>
    /// The original 'entity_route' that routed the merchant onto the platform which then returned this reference information, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityRoute")]
    public string? EntityRoute { get; init; }

    /// <summary>
    /// The reference code itself.
    /// This field is stored as a text string and must be between 0 and 50 characters long.
    /// </summary>
    [JsonPropertyName("ref")]
    public required string Ref { get; init; }

    [JsonPropertyName("stage")]
    public required EntityRefStage1 Stage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("staging")]
    public EntityRefStaging1? Staging { get; init; }

    [JsonPropertyName("platform")]
    public required EntityPlatform2 Platform { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public object? Currency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingCurrency")]
    public object? FundingCurrency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default")]
    public EntityDefault2? Default { get; init; }

    /// <summary>
    /// The FBO from which this entity refers to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fbo")]
    public string? Fbo { get; init; }

    /// <summary>
    /// A string-JSON of options for this reference value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public string? Options { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
