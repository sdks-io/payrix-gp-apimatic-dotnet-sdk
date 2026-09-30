using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record EntityNextPayoutResponse
{
    /// <summary>
    /// The identifier of the Payout resource that is scheduled to process next for this Entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutId")]
    public string? PayoutId { get; init; }

    /// <summary>
    /// The date and time on which the next Payout is scheduled to process.
    /// This field is formatted as an ISO 8601 date and time string that includes the UTC offset, for example, '2026-09-05T00:00:00-04:00'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nextPayoutDate")]
    public string? NextPayoutDate { get; init; }

    /// <summary>
    /// The last 4 digits of the account number of the Account that is set on the next Payout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last4")]
    public string? Last4 { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public PayoutSchedule1? Schedule { get; init; }

    /// <summary>
    /// The total amount of this Payout.
    /// The units used in this field are determined by the value of the 'um' field on the Payout. If the 'um' field is set to '1' or '3', then this field specifies the Payout percentage to levy in basis points. If the 'um' field is set to '2', then this field specifies the Payout in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public long? Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("um")]
    public PayoutUm1? Um { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
