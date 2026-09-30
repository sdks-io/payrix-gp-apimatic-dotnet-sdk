using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record ChargebackStatusesResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ChargebackStatusesResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
