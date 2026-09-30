using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record AlertsPostRequest
{
    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    /// <summary>
    /// The identifier of the Login that this Alert relates to.
    /// The Alert is triggered based on the activity of this Login.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forlogin")]
    public string? Forlogin { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team")]
    public TeamsPostRequest? Team { get; init; }

    /// <summary>
    /// The division for which this Alerts applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public string? Division { get; init; }

    /// <summary>
    /// The partition for which this Alerts applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partition")]
    public string? Partition { get; init; }

    /// <summary>
    /// The name of this Alert.
    /// This field is stored as a text string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Description of Alerts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alertActions")]
    public IReadOnlyList<AlertActionsPostRequest>? AlertActions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alertTriggers")]
    public IReadOnlyList<AlertTriggersPostRequest>? AlertTriggers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
