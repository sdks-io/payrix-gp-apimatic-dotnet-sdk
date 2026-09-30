using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record DecisionActionsPutRequest
{
    /// <summary>
    /// The identifier of the Decision to which this resource applies
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decision")]
    public string? Decision { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public DescisionActionsAction1? Action { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application")]
    public DecisionActionsApplication1? Application { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scoreType")]
    public DecisionActionsScoreType1? ScoreType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public DecisionActionType1? Type { get; init; }

    /// <summary>
    /// The result field to check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public string? Field { get; init; }

    /// <summary>
    /// The score to check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("score")]
    public string? Score { get; init; }

    /// <summary>
    /// The decisionAction data will be matched with verificationReuslts data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public string? Data { get; init; }

    /// <summary>
    /// The decisionAction message will be matched with verificationReuslts message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// The decisionAction code will be matched with verificationReuslts code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// A name for a group of decisionActions to be applied in conjunction when evaluating this DecisionAction; when grouping is used, the DecisionActions will not apply unless they all match.
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
