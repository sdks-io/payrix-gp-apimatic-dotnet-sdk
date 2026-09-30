using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record FeeModifiersPostRequest
{
    /// <summary>
    /// The identifier of the Fee that this Fee Modifier applies.
    /// </summary>
    [JsonPropertyName("fee")]
    public required string Fee { get; init; }

    /// <summary>
    /// The identifier of the Entity that this Fee Modifier applies for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    /// <summary>
    /// The identifier of the Org this Fee Modifiers should apply for on behalf of the Entity identified in the value of the 'entity' field.
    /// This field is optional. If it is set, then the Fee Modifier is applied to this Org instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("org")]
    public string? Org { get; init; }

    /// <summary>
    /// The identifier of the Entity who should pay this Fee on behalf of the Entity identified in the value of the 'entity' or 'org' field.
    /// This field is optional. If it is set, then the Fee is charged to this Entity instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fromentity")]
    public string? Fromentity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("markupUm")]
    public FeeModifiersMarkupUm1? MarkupUm { get; init; }

    /// <summary>
    /// The total amount of the markup value for this Fee.
    /// The units used in this field are determined by the value of the 'markupUm' field on the Fee. If the 'markupUm' field is set to 'percentage', then this field specifies the Fee percentage to levy in basis points. If the 'markupUm' field is set to 'actual', then this field specifies the markup amount in cents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("markupAmount")]
    public int? MarkupAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
