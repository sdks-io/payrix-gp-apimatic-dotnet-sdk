using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record Payment4
{
    [JsonPropertyName("method")]
    public required TxnPaymentMethod1 Method { get; init; }

    /// <summary>
    /// For credit payment method, the card number of the credit card associated with this Transaction.
    /// For eCheck payment method, the bank account number associated with this Transaction.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; init; }

    /// <summary>
    /// The routing code for the eCheck or bank account payment associated with this Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routing")]
    public string? Routing { get; init; }

    /// <summary>
    /// The expiration date of the credit card associated with this Transaction.
    /// This field is stored as a text string in 'MMYY' format, where 'MM' is the number of a month and 'YY' is the last two digits of a year. For example, '0623' for June 2023.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration")]
    public string? Expiration { get; init; }

    /// <summary>
    /// The Card Verification Value (CVV) number of the credit card associated with this Transaction.
    /// This field is expressed as an integer.
    /// </summary>
    [JsonPropertyName("cvv")]
    public string? Cvv { get; init; } = "0";

    /// <summary>
    /// The 'Track' data (either Track 1, Track 2, or both) of the card associated with this Transaction.
    /// This field is stored as a text string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("track")]
    public object? Track { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
