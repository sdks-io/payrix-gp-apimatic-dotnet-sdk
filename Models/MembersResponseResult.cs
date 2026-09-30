using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record MembersResponseResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public MembersResponseItem? Response { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
