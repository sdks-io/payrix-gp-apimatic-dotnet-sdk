using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record VerificationRefsResponse
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

    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// The identifier of the Entity that was verified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    /// <summary>
    /// The ID of the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txn")]
    public string? Txn { get; init; }

    /// <summary>
    /// The concept of change request is to get a second level authorization before actioning the result of a verification/policy run.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("changeRequest")]
    public string? ChangeRequest { get; init; }

    /// <summary>
    /// This is the reference from the integration response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ref")]
    public string? Ref { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskLevel")]
    public VerificationRiskLevel2? RiskLevel { get; init; }

    /// <summary>
    /// This is the stage where the decisions or policy run is been triggered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stage")]
    public string? Stage { get; init; }

    /// <summary>
    /// This is the name of the policy that is ran in this stage as returned from the integratio n response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public VerificationRefAction2? Action { get; init; }

    /// <summary>
    /// This is the ID of the policy as returned from the integration response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("policyUuid")]
    public string? PolicyUuid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
