using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record DisbursementEntriesResponse
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disbursement")]
    public Disbursement2? Disbursement { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entry")]
    public Entry2? Entry { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pendingEntry")]
    public PendingEntry? PendingEntry { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reserveEntry")]
    public ReserveEntry? ReserveEntry { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event")]
    public DisbursementEntryEvent2? Event { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventId")]
    public EventIdModel? EventId { get; init; }

    /// <summary>
    /// The total amount of this DisbursementEntry, This field is specified in cents(up to three decimal points).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }

    /// <summary>
    /// The total amount used of this DisbursementEntry, This field is specified in cents(up to three decimal points).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountUsed")]
    public double? AmountUsed { get; init; }

    /// <summary>
    /// A description of this DisbursementEntry.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
