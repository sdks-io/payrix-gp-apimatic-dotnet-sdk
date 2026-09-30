using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record Txn1
{
    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
