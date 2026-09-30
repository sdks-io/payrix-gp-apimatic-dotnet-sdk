using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record FeesPostRequest
{
    /// <summary>
    /// The identifier of the Entity that will charge this Fee.
    /// </summary>
    [JsonPropertyName("entity")]
    public required string Entity { get; init; }

    /// <summary>
    /// The identifier of the Entity that this Fee applies for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forentity")]
    public string? Forentity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("org")]
    public OrgsPostRequest? Org { get; init; }

    [JsonPropertyName("type")]
    public required FeeType1 Type { get; init; }

    /// <summary>
    /// The name of this Fee.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A description of this Fee.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("schedule")]
    public required FeeSchedule1 Schedule { get; init; }

    /// <summary>
    /// A multiplier that you can use to adjust the schedule set in the 'schedule' field, if it is set to a duration-based trigger, such as daily, weekly, monthly, or annually.
    /// This field is specified as an integer and its value determines how the interval is multiplied..
    /// </summary>
    [JsonPropertyName("scheduleFactor")]
    public int? ScheduleFactor { get; init; } = 1;

    /// <summary>
    /// The date on which charging of the Fee should start.
    /// The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016.
    /// The value of this field must represent a date in the future, or the present date.
    /// </summary>
    [JsonPropertyName("start")]
    public required int Start { get; init; }

    /// <summary>
    /// The date on which charging of the Fee should end.
    /// The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016.
    /// The value of this field must represent a date in the future.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finish")]
    public int? Finish { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collection")]
    public FeeCollection1? Collection { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collectionFactor")]
    public FeesCollectionFactor1? CollectionFactor { get; init; }

    /// <summary>
    /// The number of days, weeks, months or years to go back when selecting data for collection calculation.
    /// </summary>
    [JsonPropertyName("collectionOffset")]
    public required int? CollectionOffset { get; init; }

    /// <summary>
    /// Whether to include the current period for the colleciton calculation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collectionIncludeCurrent")]
    public int? CollectionIncludeCurrent { get; init; }

    [JsonPropertyName("um")]
    public required FeeUm1 Um { get; init; }

    /// <summary>
    /// The total amount of this Fee.
    /// The units used in this field are determined by the value of the 'um' field on the Fee. If the 'um' field is set to 'percentage', then this field specifies the Fee percentage to levy in basis points. If the 'um' field is set to 'amount', then this field specifies the Fee in cents(up to three decimal points)
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The maximum amount to charge for this fee when setting a percent-based fee.
    /// <list type="bullet">
    ///   <item><description>Will be <c>null</c> for all other units.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maximum")]
    public double? Maximum { get; init; }

    [JsonPropertyName("currency")]
    public required object Currency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txnFee")]
    public FeesTxnFee1? TxnFee { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeModifiers")]
    public IReadOnlyList<FeeModifiersPostRequest>? FeeModifiers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeRules")]
    public IReadOnlyList<FeeRulesPostRequest>? FeeRules { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
