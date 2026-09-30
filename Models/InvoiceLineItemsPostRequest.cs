using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record InvoiceLineItemsPostRequest
{
    /// <summary>
    /// The identifier of the Invoice that owns this InvoiceLineItem.
    /// </summary>
    [JsonPropertyName("invoice")]
    public required string Invoice { get; init; }

    /// <summary>
    /// The identifier of the InvoiceItem associated with this InvoiceLineItem.
    /// </summary>
    [JsonPropertyName("invoiceItem")]
    public required string InvoiceItem { get; init; }

    /// <summary>
    /// The quantity purchased for this line item, specified as an integer.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? Quantity { get; init; } = 1;

    /// <summary>
    /// The price for each item, this field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public long? Price { get; init; }

    /// <summary>
    /// The discount for the line item, this field is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount")]
    public long? Discount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
