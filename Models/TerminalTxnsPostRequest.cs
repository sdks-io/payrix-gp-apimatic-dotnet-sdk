using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record TerminalTxnsPostRequest
{
    [JsonPropertyName("binType")]
    public required TerminalTxnsBinType1 BinType { get; init; }

    /// <summary>
    /// The expiration date of this Transaction. This field is stored as a text string in 'MMYY' format, where 'MM' is the number of a month and 'YY' is the last two digits of a year. For example, '0623' for June 2023. The value must reflect a future date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration")]
    public string? Expiration { get; init; }

    /// <summary>
    /// If this Terminal Transaction is related to another Terminal Transaction, then this field is set to the identifier of the other Terminal Transaction. For example, if this Terminal Transaction is a Refund, this field could be set to the identifier of the original Sale Terminal Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forterminalTxn")]
    public string? ForterminalTxn { get; init; }

    [JsonPropertyName("origin")]
    public required TerminalTxnOrigin1 Origin { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platform")]
    public PlatformModel1? Platform { get; init; }

    [JsonPropertyName("pos")]
    public required TerminalTxnsPos1 Pos { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receipt")]
    public TerminalTxnsReceipt1? Receipt { get; init; }

    /// <summary>
    /// The Terminal ID as set by the platform activating the terminal. This field is stored as a text string and must be between 0 and 50 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tid")]
    public string? Tid { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public TokenPostRequest? Token { get; init; }

    /// <summary>
    /// The last four numbers of the credit card associated with this Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentNumber")]
    public int? PaymentNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public TerminalTxnPaymentMethod1? PaymentMethod { get; init; }

    [JsonPropertyName("type")]
    public required TerminalTxnType1 Type { get; init; }

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
    /// The authorization code for this Transaction. This field is stored as a text string and must be between 0 and 20 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authCode")]
    public string? AuthCode { get; init; }

    /// <summary>
    /// The date on which the Transaction was authorized. The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016. The value of this field must represent a date in the past.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authDate")]
    public int? AuthDate { get; init; }

    /// <summary>
    /// The amount of the total sum of this Transaction that is given as cash back. This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashback")]
    public long? Cashback { get; init; }

    /// <summary>
    /// The client IP address from which the Transaction was created. Valid values are any Ipv4 or Ipv6 address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientIp")]
    public string? ClientIp { get; init; }

    /// <summary>
    /// The name of the company associated with this Transaction. nSetting this field is especially important when processing an eCheck from a company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public string? Company { get; init; }

    [JsonPropertyName("currency")]
    public required object Currency { get; init; }

    [JsonPropertyName("fundingCurrency")]
    public required object FundingCurrency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvvStatus")]
    public TerminalTxnsCvvStatus1? CvvStatus { get; init; }

    /// <summary>
    /// A description of this Transaction. This field is stored as a text string and must be between 0 and 1000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The discount applied to the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount")]
    public long? Discount { get; init; }

    /// <summary>
    /// The duty fee applicable to this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duty")]
    public long? Duty { get; init; }

    /// <summary>
    /// The email associated with this Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("swiped")]
    public required TerminalTxnsSwiped1 Swiped { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entryMode")]
    public EntryMode1? EntryMode { get; init; }

    /// <summary>
    /// Optional calculated fee amount indicator. This should be used in conjunction with txnFee setting on Fees resource. This field is specified in cents(up to three decimal points).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fee")]
    public double? Fee { get; init; }

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
    /// The identifier of the Merchant associated with this Transaction.
    /// </summary>
    [JsonPropertyName("merchant")]
    public required string Merchant { get; init; }

    /// <summary>
    /// The Merchant ID as set by the processor. This field is stored as a text string and must be between 0 and 50 characters long.
    /// </summary>
    [JsonPropertyName("mid")]
    public required string Mid { get; init; }

    /// <summary>
    /// The middle name associated with this Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middle")]
    public string? Middle { get; init; }

    /// <summary>
    /// The identifier of the Order associated with this Transaction. This field is stored as a text string and must be between 0 and 1000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }

    [JsonPropertyName("pin")]
    public required TerminalTxnsPin1 Pin { get; init; }

    /// <summary>
    /// Indicates whether the Transaction is reserved and the action that will be taken as a result.
    /// <para>
    /// &lt;details&gt;
    /// &lt;summary&gt;Valid Values&lt;/summary&gt;
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>0</c> - <b>No reserve.</b></description></item>
    /// </list>
    /// <para>
    /// &lt;/details&gt;
    /// </para>
    /// </summary>
    [JsonPropertyName("reserved")]
    public int Reserved { get; } = 0;

    /// <summary>
    /// The shipping fee pertaining to this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipping")]
    public long? Shipping { get; init; }

    [JsonPropertyName("signature")]
    public required TerminalTxnsSignature1 Signature { get; init; }

    /// <summary>
    /// The amount of the total sum of this Transaction that is made up of tax. This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax")]
    public long? Tax { get; init; }

    /// <summary>
    /// The identifier of the terminal that processed this Transaction. The identifier is taken from the terminal system and varies in format according to the type of terminal. This field is stored as a text string and must be between 0 and 50 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminal")]
    public string? Terminal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalCapability")]
    public TerminalTxnsTerminalCapability1? TerminalCapability { get; init; }

    /// <summary>
    /// The total amount of this Transaction. This field is specified as an integer in cents.
    /// </summary>
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unattended")]
    public TerminalTxnsUnattended1? Unattended { get; init; }

    [JsonPropertyName("status")]
    public required TerminalTxnStatus1 Status { get; init; }

    /// <summary>
    /// The first line of the address associated with this Transaction. This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    public string? Address1 { get; init; }

    /// <summary>
    /// The second line of the address associated with this Transaction. This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    public string? Address2 { get; init; }

    /// <summary>
    /// The name of the city in the address associated with this Transaction. This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// The U.S. state or Canadian province relevant to the address provided here. If the location is within the U.S. and Canada, specify the 2-character postal abbreviation for the state. If the location is outside of the U.S. and Canada, provide the full state name. This field is stored as a text string and must be between 2 and 100 characters long.
    /// <para>
    ///
    /// &lt;details&gt;
    /// &lt;summary&gt;U.S. States&lt;/summary&gt;
    ///
    ///  - <c>AK</c> - <b>Alaska (US)</b>
    ///
    ///  - <c>AR</c> - <b>Arkansas (US)</b>
    ///
    ///  - <c>AL</c> - <b>Alabama (US)</b>
    ///
    ///  - <c>AZ</c> - <b>Arizona (US)</b>
    ///
    ///  - <c>CA</c> - <b>California (US)</b>
    ///
    ///  - <c>CO</c> - <b>Colorado (US)</b>
    ///
    ///  - <c>CT</c> - <b>Connecticut (US)</b>
    ///
    ///  - <c>DE</c> - <b>Delaware (US)</b>
    ///
    ///  - <c>FL</c> - <b>Florida (US)</b>
    ///
    ///  - <c>GA</c> - <b>Georgia (US)</b>
    ///
    ///  - <c>HI</c> - <b>Hawaii (US)</b>
    ///
    ///  - <c>IA</c> - <b>Iowa (US)</b>
    ///
    ///  - <c>ID</c> - <b>Idaho (US)</b>
    ///
    ///  - <c>IL</c> - <b>Illinois (US)</b>
    ///
    ///  - <c>IN</c> - <b>Indiana (US)</b>
    ///
    ///  - <c>KY</c> - <b>Kentucky (US)</b>
    ///
    ///  - <c>KS</c> - <b>Kansas (US)</b>
    ///
    ///  - <c>LA</c> - <b>Louisiana (US)</b>
    ///
    ///  - <c>MA</c> - <b>Massachusetts (US)</b>
    ///
    ///  - <c>MD</c> - <b>Maryland (US)</b>
    ///
    ///  - <c>ME</c> - <b>Maine (US)</b>
    ///
    ///  - <c>MI</c> - <b>Michigan (US)</b>
    ///
    ///  - <c>MN</c> - <b>Minnesota (US)</b>
    ///
    ///  - <c>MO</c> - <b>Missouri (US)</b>
    ///
    ///  - <c>MS</c> - <b>Mississippi (US)</b>
    ///
    ///  - <c>MT</c> - <b>Montana (US)</b>
    ///
    ///  - <c>NC</c> - <b>North Carolina (US)</b>
    ///
    ///  - <c>ND</c> - <b>North Dakota (US)</b>
    ///
    ///  - <c>NE</c> - <b>Nebraska (US)</b>
    ///
    ///  - <c>NH</c> - <b>New Hampshire (US)</b>
    ///
    ///  - <c>NJ</c> - <b>New Jersey (US)</b>
    ///
    ///  - <c>NM</c> - <b>New Mexico (US)</b>
    ///
    ///  - <c>NV</c> - <b>Nevada (US)</b>
    ///
    ///  - <c>NY</c> - <b>New York (US)</b>
    ///
    ///  - <c>OH</c> - <b>Ohio (US)</b>
    ///
    ///  - <c>OK</c>- <b>Oklahoma (US)</b>
    ///
    ///  - <c>OR</c> - <b>Oregon (US)</b>
    ///
    ///  - <c>PA</c> - <b>Pennsylvania (US)</b>
    ///
    ///  - <c>RI</c> - <b>Rhode Island (US)</b>
    ///
    ///  - <c>SC</c>- <b>South Carolina (US)</b>
    ///
    ///  - <c>SD</c> - <b>South Dakota (US)</b>
    ///
    ///  - <c>TN</c> - <b>Tennessee (US)</b>
    ///
    ///  - <c>TX</c> - <b>Texas (US)</b>
    ///
    ///  - <c>UT</c> - <b>Utah (US)</b>
    ///
    ///  - <c>VA</c> - <b>Virginia (US)</b>
    ///
    ///  - <c>VT</c> - <b>Vermont (US)</b>
    ///
    ///  - <c>WA</c> - <b>Washington (US)</b>
    ///
    ///  - <c>WI</c> - <b>Wisconsin (US)</b>
    ///
    ///  - <c>WV</c> - <b>West Virginia (US)</b>
    ///
    ///  - <c>WY</c> - <b>Wyoming (US)</b>
    ///  &lt;/details&gt;
    /// </para>
    /// <para>
    ///
    /// </para>
    /// <para>
    ///  &lt;details&gt;
    /// &lt;summary&gt;Canada Provinces and Territories&lt;/summary&gt;
    ///
    ///  - <c>AB</c> - <b>Alberta (CAN)</b>
    ///
    ///  - <c>BC</c> - <b>British Columbia (CAN)</b>
    ///
    ///  - <c>MB</c> - <b>Manitoba (CAN)</b>
    ///
    ///  - <c>ON</c> - <b>Ontario (CAN)</b>
    ///
    ///  - <c>NS</c> - <b>Nova Scotia (CAN)</b>
    ///
    ///  - <c>NB</c> - <b>New Brunswick (CAN)</b>
    ///
    ///  - <c>NL</c> - <b>Newfoundland and Labrador (CAN)</b>
    ///
    ///  - <c>NT</c> - <b>Northwest Territories (CAN)</b>
    ///
    ///  - <c>NU</c> - <b>Nunavut (CAN)</b>
    ///
    ///  - <c>PE</c> - <b>Prince Edward Island (CAN)</b>
    ///
    ///  - <c>QC</c> - <b>Quebec (CAN)</b>
    ///
    ///  - <c>SK</c> - <b>Saskatchewan (CAN)</b>
    ///
    ///  - <c>YT</c> - <b>Yukon (CAN)</b>
    ///  &lt;/details&gt;
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// The ZIP code in the address associated with this Transaction. This field is stored as a text string and must be between 1 and 20 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("zip")]
    public string? Zip { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public Country142? Country { get; init; }

    /// <summary>
    /// The phone number associated with this Transaction. This field is stored as a text string and must be between 10 and 15 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public string? Phone { get; init; }

    [JsonPropertyName("inactive")]
    public required Inactive1 Inactive { get; init; }

    [JsonPropertyName("frozen")]
    public required Frozen1 Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalTxnData")]
    public TerminalTxnsDatasPostRequest? TerminalTxnData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    public IReadOnlyList<NotesPostRequest>? Notes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalTxnMetadatas")]
    public IReadOnlyList<TerminalTxnsMetadatasPostRequest>? TerminalTxnMetadatas { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalTxnRefs")]
    public IReadOnlyList<TerminalTxnRefPostRequest>? TerminalTxnRefs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalTxnResults")]
    public IReadOnlyList<TerminalTxnResultsPostRequest>? TerminalTxnResults { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
