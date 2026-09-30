using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record DecisionsPutRequest
{
    /// <summary>
    /// The identifier of the Login that owns this decisions resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// If this decision resource relates to an Org, then this field stores the identifier of the Org.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("org")]
    public string? Org { get; init; }

    /// <summary>
    /// If this decision resource relates to an Entity, then this field stores the identifier of the Entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    /// <summary>
    /// The identifier of a linked decision resource that acts in coordination with this decision. When you define a decision attribute here, the referenced decision becomes the 'parent' resource. The action field set on the 'parent' resource determines the action that occurs if all of the linked decisions fail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decision")]
    public string? Decision { get; init; }

    /// <summary>
    /// Identifier of the division to which the decision resource belongs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public string? Division { get; init; }

    /// <summary>
    /// Identifier of the partition to which the decision resource belongs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partition")]
    public string? Partition { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application")]
    public DecisionActionsApplication1? Application { get; init; }

    /// <summary>
    /// The levels of decision admin, merchant, division, partition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("level")]
    public string? Level { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public DecisionType1? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public DecisionsTarget1? Target { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public DescisionAction1? Action { get; init; }

    /// <summary>
    /// A sequence number to use when applying multiple linked decisions: When two or more decisions are linked using their 'decision' fields, the checks with lower 'sequence' numbers are applied first; this field is specified as an integer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sequence")]
    public int? Sequence { get; init; }

    /// <summary>
    /// The minimum value that the Transaction must be to target this decision, The unit of measure is determined by the type of check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public int? Amount { get; init; }

    /// <summary>
    /// The amount that the associated Transaction should be compared against. The units for this field depend on the type of check: for checks that are based on a ratio, specify the amount as a percentage in basis points; for checks that are based on a dollar amount, specify the amount in cents; for checks that are based on a count, specify the exact value as an integer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("period")]
    public DecisionsPeriod1? Period { get; init; }

    /// <summary>
    /// A multiplier that you can use to adjust the basic date range set in the 'period' field, such as daily, weekly, monthly, or annually; this field is specified as an integer and its value determines how the interval is multiplied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("periodFactor")]
    public int? PeriodFactor { get; init; }

    /// <summary>
    /// The schedule that determines when this Decision is triggered to check entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public string? Schedule { get; init; }

    /// <summary>
    /// A multiplier that you can use to adjust the schedule set in the 'schedule' field, if it is set to a duration-based trigger, such as daily, weekly, monthly, or annually. This field is specified as an integer and its value determines how the interval is multiplied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduleFactor")]
    public int? ScheduleFactor { get; init; }

    /// <summary>
    /// The date on which checking of the Decision should start is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016; the value of this field must represent a date in the future, or the present date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start")]
    public int? Start { get; init; }

    /// <summary>
    /// The date on which checking of the Decision should end. The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016. The value of this field must represent a date in the future.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finish")]
    public int? Finish { get; init; }

    /// <summary>
    /// A lower cut-off value for the score in this decision; the check fails if the score is equal to or below this value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("low")]
    public int? Low { get; init; }

    /// <summary>
    /// An upper cut-off value for the score in this decision; the check fails if the score is equal to or above this value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("high")]
    public int? High { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useCache")]
    public DecisionsUseCache1? UseCache { get; init; }

    /// <summary>
    /// The time caching limit to check for existing verification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cacheTime")]
    public int? CacheTime { get; init; }

    /// <summary>
    /// The options for the Verification are specified as a sum of the desired options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public int? Options { get; init; }

    /// <summary>
    /// The additionalOptions for the Verification are specified as a sum of the desired options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalOptions")]
    public int? AdditionalOptions { get; init; }

    /// <summary>
    /// The error message for the decision: If the field is null the error message will be a generic failure message, if the field is empty the error message will be a specific error message, if the field is set to a string the error message will be that string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; init; }

    /// <summary>
    /// The reason for the decision. If the field is null the error message will be a generic message, if the field is set to a string the reason message will be that string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
