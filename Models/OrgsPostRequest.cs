using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record OrgsPostRequest
{
    /// <summary>
    /// The Login that owns this Org.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billings")]
    public IReadOnlyList<BillingsPostRequest>? Billings { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeModifiers")]
    public IReadOnlyList<FeeModifiersPostRequest>? FeeModifiers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fees")]
    public IReadOnlyList<FeesPostRequest>? Fees { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceParameters")]
    public IReadOnlyList<InvoiceParametersPostRequest>? InvoiceParameters { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orgEntities")]
    public IReadOnlyList<OrgEntitiesPostRequest>? OrgEntities { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutFlows")]
    public IReadOnlyList<PayoutFlowsPostRequest>? PayoutFlows { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profitShares")]
    public IReadOnlyList<ProfitSharesPostRequest>? ProfitShares { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reserves")]
    public IReadOnlyList<ReservesPostRequest>? Reserves { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secrets")]
    public IReadOnlyList<SecretsPostRequest>? Secrets { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
