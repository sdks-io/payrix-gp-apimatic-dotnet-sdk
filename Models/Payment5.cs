using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record Payment5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public TerminalTxnPaymentMethod1? Method { get; init; }

    /// <summary>
    /// The last four numbers of the credit card associated with this Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// The routing code for the eCheck or bank account payment associated with this Transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routing")]
    public string? Routing { get; init; }

    /// <summary>
    /// The expiration date of the credit card associated with this Transaction. This field is stored as a text string in 'MMYY' format, where 'MM' is the number of a month and 'YY' is the last two digits of a year. For example, '0623' for June 2023.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration")]
    public string? Expiration { get; init; }

    /// <summary>
    /// The Card Verification Value (CVV) number of the credit card associated with this Transaction. This field is expressed as an integer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvv")]
    public int? Cvv { get; init; }

    /// <summary>
    /// The 'Track' data (either Track 1, Track 2, or both) of the card associated with this Transaction. This field is stored as a text string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("track")]
    public string? Track { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
