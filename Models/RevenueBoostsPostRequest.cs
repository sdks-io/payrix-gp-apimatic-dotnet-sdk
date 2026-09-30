using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

/// <summary>
/// A request body for creating new networkPaymentManager
/// </summary>
public record RevenueBoostsPostRequest
{
    /// <summary>
    /// The identifier of the Entity that networkPaymentManager is associated with.
    /// </summary>
    [JsonPropertyName("entity")]
    public required string Entity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platform")]
    public RevenueBoostsPlatform1? Platform { get; init; }

    /// <summary>
    /// The identifier of the Org (group) that networkPaymentManager is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("org")]
    public string? Org { get; init; }

    /// <summary>
    /// The identifier of the Division that networkPaymentManager is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public string? Division { get; init; }

    /// <summary>
    /// The identifier of the Partition that networkPaymentManager is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partition")]
    public string? Partition { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
