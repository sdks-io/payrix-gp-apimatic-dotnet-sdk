using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record AggregationsPutRequest
{
    /// <summary>
    /// The identifier of the Login that owns this Aggregation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// The identifier of the Entity that this Aggregation applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    /// <summary>
    /// The identifier of the Login that this Aggregation applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forlogin")]
    public string? Forlogin { get; init; }

    /// <summary>
    /// The identifier of the Org that this Aggregation applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("org")]
    public string? Org { get; init; }

    /// <summary>
    /// The identifier of the Team that this Aggregation applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team")]
    public string? Team { get; init; }

    /// <summary>
    /// The identifier of the Division that this Aggregation applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public string? Division { get; init; }

    /// <summary>
    /// The identifier of the Partition that this Aggregation applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partition")]
    public string? Partition { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public AggregationType1? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("level")]
    public AggregationsLevel1? Level { get; init; }

    /// <summary>
    /// The name of this Aggregation. This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A description of this Aggregation. This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resource")]
    public Resource1? Resource { get; init; }

    /// <summary>
    /// The search query used to find records and apply the desired calculation. This field is stored as a text string and must be between 0 and 1000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("search")]
    public string? Search { get; init; }

    /// <summary>
    /// The specification of the desired aggregation functions including count, sum, min and max. This field is stored as a text string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totals")]
    public string? Totals { get; init; }

    /// <summary>
    /// Degrouping is the reverse process of grouping, where progressively smaller groups are removed to provide aggregated results at higher levels. This is useful when you want to see overall totals without the detailed breakdowns. For example, degrouping can be used to sum up all transactions across all merchants and payment methods, providing a total approval count without needing to look at individual merchant or payment method details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("degrouping")]
    public string? Degrouping { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public AggregationStatus1? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public AggregationSchedule1? Schedule { get; init; }

    /// <summary>
    /// A multiplier that you can use to adjust the schedule set in the 'schedule' field, such as daily, weekly, monthly, or annually. In This field is specified as an integer and its value determines how the interval is multiplied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduleFactor")]
    public int? ScheduleFactor { get; init; }

    /// <summary>
    /// The date on which the aggregation processing should start. The date is specified as a twelve digit string in YYYYMMDDHHII format, for example, '201601201528' for January 20, 2016 at 15:28 (3:28 pm). The value of this field must represent a date in the future, or the present date. When the schedule is set to HOURLY (1) the minute part of the time must be divisible by 10 (15:10, 15:20, 15:30, etc...).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start")]
    public long? Start { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default")]
    public AggregationDefault1? Default { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
