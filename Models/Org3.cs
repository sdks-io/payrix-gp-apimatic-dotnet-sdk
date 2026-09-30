using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record Org3
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
    [JsonPropertyName("login")]
    public Login2? Login { get; init; }

    /// <summary>
    /// The name of this Org.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A description of this Org.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// This is used to specify a default fee for a group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultFeeFromEntity")]
    public string? DefaultFeeFromEntity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aggregations")]
    public IReadOnlyList<AggregationsResponse>? Aggregations { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingModifiers")]
    public IReadOnlyList<BillingModifiersResponse>? BillingModifiers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billings")]
    public IReadOnlyList<BillingsResponse>? Billings { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decisions")]
    public IReadOnlyList<DecisionsResponse>? Decisions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embeddedFinance")]
    public IReadOnlyList<EmbeddedFinanceResponse>? EmbeddedFinance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeModifiers")]
    public IReadOnlyList<FeeModifiersResponse>? FeeModifiers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fees")]
    public IReadOnlyList<FeesResponse>? Fees { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceParameters")]
    public IReadOnlyList<InvoiceParametersResponse>? InvoiceParameters { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orgEntities")]
    public IReadOnlyList<OrgEntitiesResponse>? OrgEntities { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("omniTokens")]
    public IReadOnlyList<OmniTokensResponse>? OmniTokens { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutFlows")]
    public IReadOnlyList<PayoutFlowsResponse>? PayoutFlows { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profitShares")]
    public IReadOnlyList<ProfitSharesResponse>? ProfitShares { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
