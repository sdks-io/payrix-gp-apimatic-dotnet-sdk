using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record AppleDomainsMassEnablementDataPreviewItem
{
    /// <summary>
    /// The Payrix Pro Merchant ID associated with the domain or domains being verified for Apple Pay.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantId")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The Fully Qualified Domain Name (FQDN) associated with the registered Merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domain")]
    public string? Domain { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
