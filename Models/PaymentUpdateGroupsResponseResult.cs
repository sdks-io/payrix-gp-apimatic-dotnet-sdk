using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record PaymentUpdateGroupsResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public PaymentUpdateGroupsResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
