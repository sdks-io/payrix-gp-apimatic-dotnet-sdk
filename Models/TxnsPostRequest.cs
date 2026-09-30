using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record TxnsPostRequest
{
    [JsonPropertyName("allowPartial")]
    public required TxnsAllowPartial1 AllowPartial { get; init; }

    /// <summary>
    /// If the Transaction is linked to a Batch, this field specifies the identifier of the Batch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch")]
    public string? Batch { get; init; }

    /// <summary>
    /// Authentication token returned by the network in a 3DSecure txn.
    /// </summary>
    [JsonPropertyName("authentication")]
    public required string Authentication { get; init; }

    /// <summary>
    /// Optional transaction ID returned by the network in a 3DSecure txn.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationId")]
    public string? AuthenticationId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cofType")]
    public TxnsCofType1? CofType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencyConversion")]
    public CurrencyConversion1? CurrencyConversion { get; init; }

    [JsonPropertyName("debtRepayment")]
    public required TxnsDebtRepayment1 DebtRepayment { get; init; }

    /// <summary>
    /// The expiration date of this Transaction.
    /// This field is stored as a text string in 'MMYY' format, where 'MM' is the number of a month and 'YY' is the last two digits of a year. For example, '0623' for June 2023.
    /// The value must reflect a future date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration")]
    public string? Expiration { get; init; }

    /// <summary>
    /// If this Transaction is related to another Transaction, then this field is set to the identifier of the other Transaction.
    /// For example, if this Transaction is a refund, this field could be set to the identifier of the original sale Transaction.
    /// </summary>
    [JsonPropertyName("fortxn")]
    public required string Fortxn { get; init; }

    /// <summary>
    /// Reauthorize this referenced Transaction. For example, to process a resubmission of a declined Transaction or to reauthorize an expired Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fromtxn")]
    public string? Fromtxn { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("copyReason")]
    public TxnsCopyReasons1? CopyReason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mobile")]
    public TxnsMobile1? Mobile { get; init; }

    [JsonPropertyName("origin")]
    public required TxnOrigin1 Origin { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinEntryCapability")]
    public TxnsPinEntryCapability1? PinEntryCapability { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platform")]
    public TxnsPlatform1? Platform { get; init; }

    /// <summary>
    /// For entry creation and deletion job sequencing: the current processed sequence number for this transaction.
    /// </summary>
    [JsonPropertyName("processedSequence")]
    public int? ProcessedSequence { get; init; } = 0;

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
    /// FBO (for benefit of) in which each entry origin belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fbo")]
    public string? Fbo { get; init; }

    /// <summary>
    /// For entry creation and deletion job sequencing: the current processed sequence number for this transaction.
    /// </summary>
    [JsonPropertyName("requestSequence")]
    public int? RequestSequence { get; init; } = 0;

    /// <summary>
    /// The statement ID for which this transaction is being processed as payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statement")]
    public string? Statement { get; init; }

    /// <summary>
    /// The token of the Tokens resource this Transaction is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public string? Token { get; init; }

    [JsonPropertyName("type")]
    public required TxnType1 Type { get; init; }

    [JsonPropertyName("unauthReason")]
    public required UnauthReason1 UnauthReason { get; init; }

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
    /// The amount of the total sum of this Transaction that is given as cash back.
    /// This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashback")]
    public long? Cashback { get; init; }

    /// <summary>
    /// The client ip address from which the Transaction was created.
    /// Valid values are any Ipv4 or Ipv6 address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientIp")]
    public string? ClientIp { get; init; }

    /// <summary>
    /// The name of the company associated with this Transaction.
    /// Setting this field is especially important when processing an eCheck from a company.
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
    /// A description of this Transaction.
    /// This field is stored as a text string and must be between 0 and 1000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The customer discount, in cents, already applied to the total for this transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount")]
    public long? Discount { get; init; }

    /// <summary>
    /// The amount of the total, in cents, that represents the duties charged to the customer
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
    /// Optional calculated fee amount indicator. This should be used in conjunction with txnFee setting on Fees resource,
    /// This field is specified in cents(up to three decimal points)
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
    /// The Merchant ID as set by the processor.
    /// This field is stored as a text string and must be between 0 and 50 characters long.
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
    /// The identifier of the Order associated with this Transaction.
    /// This field is stored as a text string and must be between 0 and 1000 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }

    [JsonPropertyName("pin")]
    public required TerminalTxnsPin1 Pin { get; init; }

    /// <summary>
    /// The amount of the total, in cents, that represents the shipping cost charged to the customer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipping")]
    public long? Shipping { get; init; }

    [JsonPropertyName("signature")]
    public required TerminalTxnsSignature1 Signature { get; init; }

    /// <summary>
    /// The amount of the total sum of this Transaction that is made up of tax.
    /// This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax")]
    public long? Tax { get; init; }

    /// <summary>
    /// The amount of the total sum of this Transaction that is made up of surcharge.
    /// This field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharge")]
    public long? Surcharge { get; init; }

    /// <summary>
    /// The identifier of the terminal that processed this Transaction.
    /// The identifier is taken from the terminal system and varies in format according to the type of terminal.
    /// This field is stored as a text string and must be between 0 and 50 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminal")]
    public string? Terminal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalCapability")]
    public TerminalTxnsTerminalCapability1? TerminalCapability { get; init; }

    /// <summary>
    /// The total amount of this Transaction.
    /// This field is specified as an integer in cents.For example, $10.15 would be entered as 1015.
    /// </summary>
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    [JsonPropertyName("unattended")]
    public required TerminalTxnsUnattended1 Unattended { get; init; }

    /// <summary>
    /// The first line of the address associated with this Transaction.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    public string? Address1 { get; init; }

    /// <summary>
    /// The second line of the address associated with this Transaction.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    public string? Address2 { get; init; }

    /// <summary>
    /// The name of the city in the address associated with this Transaction.
    /// This field is stored as a text string and must be between 1 and 500 characters long.
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
    /// The ZIP code in the address associated with this Transaction.
    /// This field is stored as a text string and must be between 1 and 20 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("zip")]
    public string? Zip { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public Country142? Country { get; init; }

    /// <summary>
    /// The phone number associated with this Transaction.
    /// This field is stored as a text string and must be between 10 and 15 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public string? Phone { get; init; }

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

    [JsonPropertyName("payment")]
    public required Payment4 Payment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
