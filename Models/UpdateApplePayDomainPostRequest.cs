using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record UpdateApplePayDomainPostRequest
{
    /// <summary>
    /// The Fully Qualified Domain Name (FQDN) associated with the registered Merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domain")]
    public string? Domain { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
