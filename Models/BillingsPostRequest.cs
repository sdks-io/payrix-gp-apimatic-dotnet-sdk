using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record BillingsPostRequest
{
    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    /// <summary>
    /// The alphanumeric identifier of the Entity associated with this Account.
    /// </summary>
    [JsonPropertyName("entity")]
    public required string Entity { get; init; }

    /// <summary>
    /// The alphanumeric identifier of the Entity associated with this Account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forentity")]
    public string? Forentity { get; init; }

    /// <summary>
    /// The identifier of the Org associated with this invoiceParameter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("org")]
    public string? Org { get; init; }

    /// <summary>
    /// ID of the division associated with this vendor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public string? Division { get; init; }

    /// <summary>
    /// The identifier of the Partition associated with this invoiceParameter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partition")]
    public string? Partition { get; init; }

    /// <summary>
    /// The billing details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("schedule")]
    public required BillingSchedule2 Schedule { get; init; }

    /// <summary>
    /// A multiplier that you can use to adjust the schedule set in the 'schedule' field, if it is set to a duration-based trigger, such as daily, weekly, monthly, or annually.
    /// This field is specified as an integer and its value determines how the interval is multiplied.
    /// </summary>
    [JsonPropertyName("scheduleFactor")]
    public int? ScheduleFactor { get; init; } = 1;

    /// <summary>
    /// The date on which this Billing period should start.
    /// </summary>
    [JsonPropertyName("start")]
    public required int Start { get; init; }

    /// <summary>
    /// The date on which this Billing period should end.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finish")]
    public int? Finish { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collection")]
    public BillingCollection2? Collection { get; init; }

    [JsonPropertyName("collectionFactor")]
    public required BillingsCollectionFactor2 CollectionFactor { get; init; }

    /// <summary>
    /// The number of days, weeks, months or years to go back when selecting data for collection calculation.
    /// </summary>
    [JsonPropertyName("collectionOffset")]
    public int? CollectionOffset { get; init; } = 1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collectionIncludeCurrent")]
    public BillingsCollectionIncludeCurrent2? CollectionIncludeCurrent { get; init; }

    [JsonPropertyName("currency")]
    public required object Currency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingEvents")]
    public IReadOnlyList<BillingEventsPostRequest>? BillingEvents { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingModifiers")]
    public IReadOnlyList<BillingModifiersPostRequest>? BillingModifiers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
