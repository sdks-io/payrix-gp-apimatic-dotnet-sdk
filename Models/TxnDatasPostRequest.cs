using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TxnDatasPostRequest
{
    /// <summary>
    /// The identifier of the Transaction associated with this TxnDatas resource.
    /// </summary>
    [JsonPropertyName("txn")]
    public required string Txn { get; init; }

    /// <summary>
    /// The Base64 encoded image of the signature captured at the time of entering the Transaction.
    /// </summary>
    [JsonPropertyName("signature")]
    public required string Signature { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
