using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record PayoutPutRequest
{
    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// The token of the Account that this Payout is associated with.
    /// This account will either receive the funds or be debited for the funds every time a Disbursement occurs, depending on the direction of the Disbursement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public string? Account { get; init; }

    /// <summary>
    /// The identifier of the Entity that this Payout is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    /// <summary>
    /// The identifier of a Billing that this Payout is associated with. Payout associated with a Billing record will be used to pay for Statements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing")]
    public string? Billing { get; init; }

    /// <summary>
    /// The identifier of the PayoutFlow associated with this Payout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutFlow")]
    public string? PayoutFlow { get; init; }

    /// <summary>
    /// The name of this Payout.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A description of this Payout.
    /// This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public PayoutSchedule1? Schedule { get; init; }

    /// <summary>
    /// A multiplier that you can use to adjust the schedule set in the 'schedule' field, if it is set to a duration-based trigger, such as daily, weekly, monthly, or annually.
    /// This field is specified as an integer and its value determines how the interval is multiplied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduleFactor")]
    public int? ScheduleFactor { get; init; }

    /// <summary>
    /// The date on which payment of the Payout should start.
    /// The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016.
    /// The value of this field must represent a date in the future, or the present date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start")]
    public int? Start { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public object? Currency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("um")]
    public PayoutUm1? Um { get; init; }

    /// <summary>
    /// The total amount of this Payout.
    /// The units used in this field are determined by the value of the 'um' field on the Payout. If the 'um' field is set to '1' or '3', then this field specifies the Payout percentage to levy in basis points. If the 'um' field is set to '2', then this field specifies the Payout in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public long? Amount { get; init; }

    /// <summary>
    /// The threshold that will ensure no disbursement is generated if it doesn't reach the minimum value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minimum")]
    public long? Minimum { get; init; }

    /// <summary>
    /// The maximum threshold for a disbursement. Any amount in a disbursement exceeding this value will not be released, and will roll over to the next disbursement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maximum")]
    public long? Maximum { get; init; }

    /// <summary>
    /// An optional field indicating the minimum balance you want to maintain, despite any Payouts occurring. If the Payout would reduce the balance to below this value, then it is not processed.
    /// This field is specified as an integer in cents.
    /// For example, a float value of 1000 would ensure that a balance of 10 USD is maintained at all times.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("float")]
    public long? Float { get; init; }

    /// <summary>
    /// The secondary billing descriptor to appear on the bank statements for the payout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondaryDescriptor")]
    public string? SecondaryDescriptor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skipOffDays")]
    public PayoutFlowsSkipOffDays1? SkipOffDays { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sameDay")]
    public PayoutFlowsSameDay1? SameDay { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
