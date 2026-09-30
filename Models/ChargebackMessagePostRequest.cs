using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record ChargebackMessagePostRequest
{
    /// <summary>
    /// The identifier of the Chargeback resource that this chargebackMessage relates to.
    /// </summary>
    [JsonPropertyName("chargeback")]
    public required string Chargeback { get; init; }

    /// <summary>
    /// The date of this chargebackMessage.
    /// The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public string? Date { get; init; }

    [JsonPropertyName("type")]
    public required ChargebackMessageType1 Type { get; init; }

    /// <summary>
    /// The fromQueue element that specifies the queue in which the chargeback resided prior to the performance of the specified activity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fromQueue")]
    public string? FromQueue { get; init; }

    /// <summary>
    /// The toQueue element that specifies queue to which the chargeback moved after the performance of the specified activity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("toQueue")]
    public string? ToQueue { get; init; }

    /// <summary>
    /// The identifier of the Contact for this chargebackMessage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contact")]
    public string? Contact { get; init; }

    /// <summary>
    /// The amount that this chargebackMessage corresponds to.
    /// For example, if the 'type' is set to '3' (Accept Liability), then this amount indicates that the liability should be for this amount.
    /// This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public long? Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public object? Currency { get; init; }

    /// <summary>
    /// A free-text note relating to this chargebackMessage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    public string? Note { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public ChargebackMessageStatus1? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("imported")]
    public ChargebackMessageImported1? Imported { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
