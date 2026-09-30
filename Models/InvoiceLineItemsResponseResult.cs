using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record InvoiceLineItemsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public InvoiceLineItemsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
