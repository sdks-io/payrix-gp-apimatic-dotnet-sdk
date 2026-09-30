using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record ApplePayForMerchantListPostRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantIdDomainPairs")]
    public IReadOnlyList<AppleDomainsMassEnablementDataPreviewItem>? MerchantIdDomainPairs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
