using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record InvoiceItemsPutRequest
{
    /// <summary>
    /// The identifier of the Login that owns this Invoiceitem.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// The desired name of this InvoiceItem. This field is stored as a text string and must be between 1 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item")]
    public string? Item { get; init; }

    /// <summary>
    /// The description of this InvoiceItem. This field is stored as a text string and must be between 0 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// A custom field of this InvoiceItem. This field is stored as a text string and must be between 0 and 500 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom")]
    public string? Custom { get; init; }

    /// <summary>
    /// The price of this InvoiceItem is specified as an integer in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public long? Price { get; init; }

    /// <summary>
    /// The unit of measure of this InvoiceItem is stored as a text string and must be between 0 and 100 characters long; examples of units of measure may be: each, kilogram, pound, month.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("um")]
    public string? Um { get; init; }

    /// <summary>
    /// The commodity code for this InvoiceItem. This field is stored as a text string and must be between 0 and 12 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commodityCode")]
    public string? CommodityCode { get; init; }

    /// <summary>
    /// The product code for this invoice item such as: UPC, catalog number, or inventory number. This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productCode")]
    public string? ProductCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
