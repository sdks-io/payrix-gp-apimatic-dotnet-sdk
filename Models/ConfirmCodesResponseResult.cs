using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record ConfirmCodesResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public ConfirmCodesResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
