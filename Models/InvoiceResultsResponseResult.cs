using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record InvoiceResultsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public InvoiceResultsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
