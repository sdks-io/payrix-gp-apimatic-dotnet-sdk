using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record BillingEventsPostRequest
{
    /// <summary>
    /// The billing to which this billingEvent applies.
    /// </summary>
    [JsonPropertyName("billing")]
    public required string Billing { get; init; }

    [JsonPropertyName("event")]
    public required BillingEvent1 Event { get; init; }

    /// <summary>
    /// The record ID of a specific schedule for the event chosen for which the billing configuration applies, all other records of the same event are excluded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventSchedule")]
    public string? EventSchedule { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deductFromBalance")]
    public BillingEventsDeductFromBalance1? DeductFromBalance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
