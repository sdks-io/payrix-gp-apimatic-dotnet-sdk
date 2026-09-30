using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record TaxFormRequestsPostRequest
{
    /// <summary>
    /// The identifies of the Merchant requesting the tax document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public string? Merchant { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TaxFormType1? Type { get; init; }

    /// <summary>
    /// The tax year for which the document is requested.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxYear")]
    public int? TaxYear { get; init; }

    /// <summary>
    /// The API call response code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseCode")]
    public int? ResponseCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
