using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

/// <summary>
/// Configurable data to be used to enhance security.
/// </summary>
public record TxnSessionsConfigurations
{
    /// <summary>
    /// duration refers to How many minutes this key should live (automated voided when tried to use after expired).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration")]
    public int? Duration { get; init; }

    /// <summary>
    /// maxTimesApproved refers to how many approved transactions related it can be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTimesApproved")]
    public int? MaxTimesApproved { get; init; }

    /// <summary>
    /// maxTimesUse refers to how many times we can make request with this key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTimesUse")]
    public int? MaxTimesUse { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
