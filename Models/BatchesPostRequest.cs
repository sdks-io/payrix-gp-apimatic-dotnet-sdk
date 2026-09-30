using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record BatchesPostRequest
{
    /// <summary>
    /// The identifier of the Merchant that is associated with this Batch.
    /// </summary>
    [JsonPropertyName("merchant")]
    public required string Merchant { get; init; }

    [JsonPropertyName("platform")]
    public required PlatformModel1 Platform { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public BatchStatus1? Status { get; init; }

    /// <summary>
    /// The reference code of the batch.
    /// This field is automatically generated and stored as a text string and must be between 0 and 50 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ref")]
    public string? Ref { get; init; }

    /// <summary>
    /// The merchant's reference code of the batch.
    /// This field is stored as a text string and must be between 0 and 50 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientRef")]
    public string? ClientRef { get; init; }

    /// <summary>
    /// Internal ID set for processing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingId")]
    public string? ProcessingId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
