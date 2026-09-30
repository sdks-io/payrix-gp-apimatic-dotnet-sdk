using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record TerminalTxnsPutRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("binType")]
    public TerminalTxnsBinType1? BinType { get; init; }

    /// <summary>
    /// The expiration date of this Transaction. This field is stored as a text string in 'MMYY' format, where 'MM' is the number of a month and 'YY' is the last two digits of a year. For example, '0623' for June 2023. The value must reflect a future date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration")]
    public string? Expiration { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment")]
    public Payment5? Payment { get; init; }

    /// <summary>
    /// Sequencial number that uniquely identifies the terminalTxn.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("traceNumber")]
    public long? TraceNumber { get; init; }

    /// <summary>
    /// The related txn this terminalTxn belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txn")]
    public string? Txn { get; init; }

    /// <summary>
    /// The ID of the token record to associate with this terminal transaction request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public string? Token { get; init; }

    /// <summary>
    /// The last four numbers of the credit card associated with this Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentNumber")]
    public int? PaymentNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public TerminalTxnPaymentMethod1? PaymentMethod { get; init; }

    /// <summary>
    /// This field indicates the tip amount associated with a transaction. This value is for reporting purposes only, because transaction amount includes this amount in the total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tip")]
    public long? Tip { get; init; }

    /// <summary>
    /// Field identifying Payrix PAX terminal originating app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originatingApp")]
    public string? OriginatingApp { get; init; }

    /// <summary>
    /// Field identifying original Payrix Verifone transaction reference number, used for refunds and cancellation request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OEMTTxnRefNumber")]
    public string? OemtTxnRefNumber { get; init; }

    /// <summary>
    /// Express assigned identifier i.e. Software Id being used in express terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("posApplicationId")]
    public string? PosApplicationId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unattended")]
    public TerminalTxnsUnattended1? Unattended { get; init; }

    /// <summary>
    /// Software Name being used in express terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("posApplicationName")]
    public string? PosApplicationName { get; init; }

    /// <summary>
    /// Software version being used in express terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("posApplicationVersion")]
    public string? PosApplicationVersion { get; init; }

    /// <summary>
    /// Express Reference Number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerReferenceNumber")]
    public string? CustomerReferenceNumber { get; init; }

    /// <summary>
    /// The gateway transaction ID relates to Express Transaction ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gatewayTransactionId")]
    public string? GatewayTransactionId { get; init; }

    /// <summary>
    /// Express ticket Number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerTicketNumber")]
    public string? CustomerTicketNumber { get; init; }

    /// <summary>
    /// The client IP address from which the transaction was created, valid values are any IPv4 or IPv6 address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientIp")]
    public string? ClientIp { get; init; }

    /// <summary>
    /// A description of this Transaction. This field is stored as a text string and must be between 0 and 1000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swiped")]
    public TerminalTxnsSwiped1? Swiped { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emv")]
    public TerminalTxnsEmv1? Emv { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entryMode")]
    public EntryMode1? EntryMode { get; init; }

    /// <summary>
    /// The first name associated with this Transaction. For eCheck transactions, either first or last is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("first")]
    public string? First { get; init; }

    /// <summary>
    /// The last name associated with this Transaction. For eCheck transactions, either first or last is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last")]
    public string? Last { get; init; }

    /// <summary>
    /// The middle name associated with this Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middle")]
    public string? Middle { get; init; }

    /// <summary>
    /// The identifier of the Order associated with this Transaction, This field is stored as a text string and must be between 0 and 1000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reserved")]
    public TerminalTxnReserved1? Reserved { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature")]
    public TerminalTxnsSignature1? Signature { get; init; }

    /// <summary>
    /// The total amount of this Transaction, This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public long? Total { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public TerminalTxnStatus1? Status { get; init; }

    /// <summary>
    /// Card network transaction ID associated with this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardNetworkTransactionId")]
    public string? CardNetworkTransactionId { get; init; }

    /// <summary>
    /// The OmniToken associated with this Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("omnitoken")]
    public string? Omnitoken { get; init; }

    /// <summary>
    /// The amount of the total sum of this Transaction that is made up of convenience fee. Fee charged when card payment is an alternative form of payment not ordinarily accepted by a merchant or service provider. This field is specified as an integer in cents. [currently not active]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("convenienceFee")]
    public int? ConvenienceFee { get; init; }

    /// <summary>
    /// Surcharge amount included in the total amount of the transaction. A surcharge fee is an additional charge added to the price of a purchase when a customer pays with a credit card. This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharge")]
    public int? Surcharge { get; init; }

    /// <summary>
    /// The device type indicator for the terminal.
    /// <para>
    /// &lt;details&gt;
    /// &lt;summary&gt;Valid Values&lt;/summary&gt;
    /// </para>
    /// <para>
    ///   - <c>1</c> - <b>Apple (Worldpay as PSP)</b>
    ///   - <c>2</c> - <b>Android (Worldpay as PSP)</b>
    ///   - <c>3</c> - <b>Apple (Worldpay not PSP)</b>
    ///   - <c>4</c> - <b>Android (Worldpay not PSP)</b>
    ///
    /// &lt;/details&gt;
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("softPosDeviceTypeIndicator")]
    public string? SoftPosDeviceTypeIndicator { get; init; }

    /// <summary>
    /// The software POS ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("softPosId")]
    public string? SoftPosId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hsaFsaCardIndicator")]
    public TerminalTxnsHsaFsaCardIndicator1? HsaFsaCardIndicator { get; init; }

    /// <summary>
    /// The gateway terminal ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gatewayTerminalId")]
    public string? GatewayTerminalId { get; init; }

    /// <summary>
    /// The billing Descriptor that is used when the transaction is part of a subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("descriptor")]
    public string? Descriptor { get; init; }

    /// <summary>
    /// The reference number associated with the card network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardNetworkBankNetReferenceNumber")]
    public string? CardNetworkBankNetReferenceNumber { get; init; }

    /// <summary>
    /// The settlement date associated with the card network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardNetworkBankNetSettlementDate")]
    public string? CardNetworkBankNetSettlementDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
