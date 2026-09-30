using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record SubscriptionsPostRequest
{
    /// <summary>
    /// The identifier of the Plan that this Subscription is associated with. The Plan determines the frequency and amount of each payment.
    /// </summary>
    [JsonPropertyName("plan")]
    public required string Plan { get; init; }

    /// <summary>
    /// For a plan that is attached to a billing, this is the paying entity to match to the generated statements of that billing for which the recurring payments will be made.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statementEntity")]
    public string? StatementEntity { get; init; }

    /// <summary>
    /// The identification of the first transaction processed through this subscription. This is used internally to process subsequent transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstTxn")]
    public string? FirstTxn { get; init; }

    /// <summary>
    /// The date on which the Subscription should start. The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016. The value of this field must represent a date in the future.
    /// </summary>
    [JsonPropertyName("start")]
    public required int Start { get; init; }

    /// <summary>
    /// The date on which the Subscription should finish. The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016. The value of this field must represent a date in the future.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finish")]
    public int? Finish { get; init; }

    /// <summary>
    /// The amount of the total sum of this Subscription that is made up of tax. This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax")]
    public long? Tax { get; init; }

    /// <summary>
    /// The descriptor used in this Subscription. This field is stored as a text string and must be between 1 and 50 characters long. If a value is not set, an attempt is made to set a default value from the merchant information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("descriptor")]
    public string? Descriptor { get; init; }

    /// <summary>
    /// The description of the Txn that will be created through this Subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txnDescription")]
    public string? TxnDescription { get; init; }

    /// <summary>
    /// The order of the Txn that will be created through this Subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origin")]
    public SubscriptionOrigin1? Origin { get; init; }

    /// <summary>
    /// Authentication token for 3D Secure transactions.
    /// </summary>
    [JsonPropertyName("authentication")]
    public required string Authentication { get; init; }

    /// <summary>
    /// Authentication reference ID for 3D Secure transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationId")]
    public string? AuthenticationId { get; init; }

    /// <summary>
    /// The current count of consecutive payment failures for this subscription.
    /// </summary>
    [JsonPropertyName("failures")]
    public required int Failures { get; init; }

    /// <summary>
    /// The maximum consecutive amount of payment failures to allow for this subscription before inactivating it.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxFailures")]
    public int? MaxFailures { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptionTokens")]
    public IReadOnlyList<SubscriptionTokensPostRequest>? SubscriptionTokens { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
