using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record DivisionsPostRequest
{
    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    /// <summary>
    /// The name of the division, which may be used for some white-label purposes.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The white-labeled outgoing email for all automated emails generated throughout this division.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("saferPaymentNonComplianceFeeManaged")]
    public SaferPaymentNonComplianceFeeManagedModel2? SaferPaymentNonComplianceFeeManaged { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("changeManagementEnabled")]
    public ChangeManagementEnabled2? ChangeManagementEnabled { get; init; }

    /// <summary>
    /// Limit for password validations length.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minPasswordLength")]
    public int? MinPasswordLength { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minPasswordComplexity")]
    public MinPasswordComplexity2? MinPasswordComplexity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hosts")]
    public IReadOnlyList<HostsPostRequest>? Hosts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
