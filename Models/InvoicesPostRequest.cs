using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record InvoicesPostRequest
{
    /// <summary>
    /// The identifier of the Login of this invoice resource.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    /// <summary>
    /// The identifier of the Merchant of this invoice resource.
    /// </summary>
    [JsonPropertyName("merchant")]
    public required string? Merchant { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public CustomersPostRequest? Customer { get; init; }

    /// <summary>
    /// The identifier of the Subscription of this invoice resource.
    /// </summary>
    [JsonPropertyName("subscription")]
    public required string? Subscription { get; init; }

    /// <summary>
    /// The invoice number.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; init; }

    /// <summary>
    /// The methods of payment allowed for this invoice. This field accepts multiple options concatenated into a
    /// single string with a pipe (|) separator between each option.
    /// <para>
    /// &lt;details&gt;
    /// &lt;summary&gt;Allowed Values&lt;/summary&gt;
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>Amex</c> - <b>American Express</b></description></item>
    ///   <item><description><c>Visa</c> - <b>Visa card</b></description></item>
    ///   <item><description><c>Mc</c> - <b>MasterCard</b></description></item>
    ///   <item><description><c>Diners</c> - <b>Diners Club card</b></description></item>
    ///   <item><description><c>Discover</c> - <b>Discover card</b></description></item>
    ///   <item><description><c>PayPal</c> - <b>PayPal payment method</b></description></item>
    ///   <item><description><c>Debit</c> - <b>Debit card</b></description></item>
    ///   <item><description><c>Checking</c> - <b>Checking account</b></description></item>
    ///   <item><description><c>Savings</c> - <b>Savings account</b></description></item>
    ///   <item><description><c>CorpChecking</c> - <b>Corporate checking account</b></description></item>
    ///   <item><description><c>CorpSavings</c> - <b>Corporate savings account</b></description></item>
    ///   <item><description><c>Gift</c> - <b>Gift card</b></description></item>
    ///   <item><description><c>EBT</c> - <b>Electronic Benefits Transfer</b></description></item>
    ///   <item><description><c>WIC</c> - <b>Women, Infants, and Children program</b></description></item>
    ///   <item><description><c>Accel</c> - <b>Accel network</b></description></item>
    ///   <item><description><c>ATH</c> - <b>ATH network</b></description></item>
    ///   <item><description><c>AFFN</c> - <b>Armed Forces Financial Network</b></description></item>
    ///   <item><description><c>Culiance</c> - <b>Culiance network</b></description></item>
    ///   <item><description><c>Interlink</c> - <b>Interlink network</b></description></item>
    ///   <item><description><c>Jeanie</c> - <b>Jeanie network</b></description></item>
    ///   <item><description><c>Maestro</c> - <b>Maestro card</b></description></item>
    ///   <item><description><c>NYCE</c> - <b>NYCE network</b></description></item>
    ///   <item><description><c>Pulse</c> - <b>Pulse network</b></description></item>
    ///   <item><description><c>Shazam</c> - <b>Shazam network</b></description></item>
    ///   <item><description><c>Star</c> - <b>Star network</b></description></item>
    ///   <item><description><c>Interac</c> - <b>Interac network</b></description></item>
    ///   <item><description><c>Omnitoken</c> - <b>Omnitoken</b></description></item>
    /// </list>
    /// <para>
    /// &lt;/details&gt;
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedPaymentMethods")]
    public string? AllowedPaymentMethods { get; init; }

    /// <summary>
    /// The title of the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// The message that will be sent with the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// The total amount for this invoice.
    /// </summary>
    [JsonPropertyName("total")]
    public long? Total { get; init; } = 0L;

    /// <summary>
    /// The tax amount for this invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax")]
    public long? Tax { get; init; }

    /// <summary>
    /// The discount amount applied to this invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount")]
    public long? Discount { get; init; }

    /// <summary>
    /// The date the invoice is due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dueDate")]
    public int? DueDate { get; init; }

    /// <summary>
    /// The date the invoice is due.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expirationDate")]
    public int? ExpirationDate { get; init; }

    /// <summary>
    /// The date to send this invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sendOn")]
    public int? SendOn { get; init; }

    [JsonPropertyName("status")]
    public required InvoiceStatus1 Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emailStatus")]
    public InvoicesEmailStatus1? EmailStatus { get; init; }

    /// <summary>
    /// The email addresses to send the invoice to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emails")]
    public string? Emails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public InvoiceType1? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoiceLineItems")]
    public IReadOnlyList<InvoiceLineItemsPostRequest>? InvoiceLineItems { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
