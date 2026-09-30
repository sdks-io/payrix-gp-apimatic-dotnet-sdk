using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record VendorsPostRequest
{
    [JsonPropertyName("entity")]
    public required EntitiesPostRequest Entity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public DivisionsPostRequest? Division { get; init; }

    /// <summary>
    /// This holds the different emails the partners will want to be reached for onboarding related queries/concerns, this is a way of allowing the risk team to manage contacts more efficiently.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onboardingContactEmails")]
    public string? OnboardingContactEmails { get; init; }

    /// <summary>
    /// This holds the different emails the partners will want to be reached for risk related queries/concerns, this is a way of allowing the risk team to manage contacts more efficiently.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskContactEmails")]
    public string? RiskContactEmails { get; init; }

    [JsonPropertyName("inactive")]
    public required Inactive1 Inactive { get; init; }

    [JsonPropertyName("frozen")]
    public required Frozen1 Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
