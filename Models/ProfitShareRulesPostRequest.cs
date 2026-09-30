using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record ProfitShareRulesPostRequest
{
    [JsonPropertyName("profitShare")]
    public required ProfitSharesPostRequest ProfitShare { get; init; }

    /// <summary>
    /// The name of this ProfitShare Rule.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Description of the Profit Share Rules.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("type")]
    public required ProfitShareRuleType2 Type { get; init; }

    /// <summary>
    /// The value to compare against when evaluating this ProfitShare Rule.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    /// <summary>
    /// A name for a group of rules to be applied in conjunction when evaluating this ProfitShare Rule.
    /// When grouping is used the ProfitShare will be allowed to be processed if at least one of the rules are matched.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("grouping")]
    public string? Grouping { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
