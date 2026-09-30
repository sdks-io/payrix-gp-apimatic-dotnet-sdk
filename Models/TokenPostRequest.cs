using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record TokenPostRequest
{
    [JsonPropertyName("customer")]
    public required CustomersPostRequest Customer { get; init; }

    [JsonPropertyName("payment")]
    public required PaymentPostRequest Payment { get; init; }

    /// <summary>
    /// The expiry month for the payment method associated with this Token.In This field is stored as a text string in 'MMYY' format, where 'MM' is the number of a month and 'YY' is the last two digits of a year. For example, '0623' for June 2023. The value must reflect a future date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration")]
    public string? Expiration { get; init; }

    /// <summary>
    /// The name of this Token. This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A description of this Token. This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Custom, free-form field for client-supplied text, must be between 0 and 1000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom")]
    public string? Custom { get; init; }

    /// <summary>
    /// The customer reference from the authToken used for user authentication
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authTokenCustomer")]
    public string? AuthTokenCustomer { get; init; }

    /// <summary>
    /// The origin of the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origin")]
    public int? Origin { get; init; }

    /// <summary>
    /// Entry mode set to the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entryMode")]
    public int? EntryMode { get; init; }

    /// <summary>
    /// The omnitoken value. If this field has a value, the whole record is treated as an omnitoken.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("omnitoken")]
    public string? Omnitoken { get; init; }

    [JsonPropertyName("status")]
    public required TokenStatus1 Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountUpdaterEligible")]
    public AccountUpdaterEligible1? AccountUpdaterEligible { get; init; }

    [JsonPropertyName("inactive")]
    public required Inactive1 Inactive { get; init; }

    [JsonPropertyName("frozen")]
    public required Frozen1 Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriptionTokens")]
    public IReadOnlyList<SubscriptionTokensPostRequest>? SubscriptionTokens { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txns")]
    public IReadOnlyList<TxnsPostRequest>? Txns { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
