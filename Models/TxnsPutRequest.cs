using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record TxnsPutRequest
{
    /// <summary>
    /// If the Transaction is linked to a Batch, this field specifies the identifier of the Batch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch")]
    public string? Batch { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debtRepayment")]
    public TxnsDebtRepayment1? DebtRepayment { get; init; }

    /// <summary>
    /// For entry creation and deletion job sequencing: the current processed sequence number for this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processedSequence")]
    public int? ProcessedSequence { get; init; }

    /// <summary>
    /// A date indicating when this Transaction was funded.
    /// This field is set automatically.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("funded")]
    public int? Funded { get; init; }

    /// <summary>
    /// The transaction has been returned by the receiver.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returned")]
    public string? Returned { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingEnabled")]
    public TxnsFundingEnabled1? FundingEnabled { get; init; }

    /// <summary>
    /// For entry creation and deletion job sequencing: the current processed sequence number for this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestSequence")]
    public int? RequestSequence { get; init; }

    /// <summary>
    /// The token of the Tokens resource this Transaction is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public string? Token { get; init; }

    /// <summary>
    /// The customer identifier from the AuthToken used during authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authTokenCustomer")]
    public string? AuthTokenCustomer { get; init; }

    /// <summary>
    /// This field is stored as a text string and must be between 0 and 1000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel")]
    public string? Channel { get; init; }

    /// <summary>
    /// The client ip address from which the Transaction was created.
    /// Valid values are any Ipv4 or Ipv6 address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientIp")]
    public string? ClientIp { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public object? Currency { get; init; }

    /// <summary>
    /// When fee is set, this will track the amount of the fee that has been consumed.
    /// This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeConsumed")]
    public int? FeeConsumed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature")]
    public TerminalTxnsSignature1? Signature { get; init; }

    /// <summary>
    /// Threatmetrix session ID. Not for partner/referrer use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tmxSessionId")]
    public string? TmxSessionId { get; init; }

    /// <summary>
    /// For external recurring systems, this is the first transaction ID related to this recurring payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstTxn")]
    public string? FirstTxn { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
