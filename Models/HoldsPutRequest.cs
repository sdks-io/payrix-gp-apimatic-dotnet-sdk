using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record HoldsPutRequest
{
    /// <summary>
    /// The identifier of the Login that owns this holds resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// If this hold resource was triggered through Payrix Integration Risk, then this field stores the identifier of the VerificationRef.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationRef")]
    public string? VerificationRef { get; init; }

    /// <summary>
    /// If this hold was released, this will contain the timestamp for when it was released. (YYYY-MM-DD HH:II:SS)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("released")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}$")]
    public string? Released { get; init; }

    /// <summary>
    /// If this hold was reviewed, this will contain the timestamp for when it was reviewed. (YYYY-MM-DD HH:II:SS)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reviewed")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}$")]
    public string? Reviewed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("releaseAction")]
    public HoldsReleaseAction1? ReleaseAction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holdSource")]
    public HoldsHoldSource1? HoldSource { get; init; }

    /// <summary>
    /// reasonid for why a hold was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holdSourceId")]
    public string? HoldSourceId { get; init; }

    /// <summary>
    /// The timestamp when hold was considered to be delaying funding. (YYYY-MM-DD HH:II:SS)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delayedFundingStartDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}$")]
    public string? DelayedFundingStartDate { get; init; }

    /// <summary>
    /// The timestamp when hold stopped delaying funding, this might be due to the hold been released, cancelled or funded. (YYYY-MM-DD HH:II:SS)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delayedFundingEndDate")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}$")]
    public string? DelayedFundingEndDate { get; init; }

    /// <summary>
    /// The person who review the hold applied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("analyst")]
    public string? Analyst { get; init; }

    /// <summary>
    /// The timestamp for the most recent update of the analyst field. (YYYY-MM-DD HH:II:SS)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("claimed")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}$")]
    public string? Claimed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
