using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record Payment6
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public TokenPaymentMethod1? Method { get; init; }

    /// <summary>
    /// For credit payment method, the card number of the credit card associated with this Token.
    /// For eCheck payment method, the bank account number associated with this Token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// If the payment method associated with this Token is a bank account, then this field contains the routing code for the bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routing")]
    public string? Routing { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
