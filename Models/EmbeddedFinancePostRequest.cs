using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record EmbeddedFinancePostRequest
{
    /// <summary>
    /// The Date and time when an entity was enabled for embeddedFinance.\nThe date is specified as an eight digit string in YYYY-MM-DD hh:mm:ss format, for example, '2023-06-01 01:00:00' for June 01, 2023. 1:00 am.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enablementDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}")]
    public string? EnablementDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product")]
    public EmbeddedFinanceProduct2? Product { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platform")]
    public EmbededFinancePlatform2? Platform { get; init; }

    /// <summary>
    /// The identifier of the Entity that this embeddedFinance is associated to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    /// <summary>
    /// The identifier of the Org (group) that embeddedFinance is associated to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("org")]
    public string? Org { get; init; }

    /// <summary>
    /// The identifier of the Division that embeddedFinance  is associated to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public string? Division { get; init; }

    /// <summary>
    /// The identifier of the Partition that embeddedFinance is associated to.
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

    /// <summary>
    /// Contains configuration of the product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productContract")]
    public string? ProductContract { get; init; }

    /// <summary>
    /// The total approved loan amount for the partner’s merchants
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accumulatedLoanTotal")]
    public string? AccumulatedLoanTotal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
