using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record RevShareSchedulesPostRequest
{
    /// <summary>
    /// The Entities object which is collecting the money.
    /// </summary>
    [JsonPropertyName("entity")]
    public required string Entity { get; init; }

    /// <summary>
    /// The Entities object which is paying the money.
    /// </summary>
    [JsonPropertyName("forentity")]
    public required string Forentity { get; init; }

    /// <summary>
    /// The start date of rev share. The format should be YYYY-MM-DD HH:MM:SS.
    /// </summary>
    [JsonPropertyName("start")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}")]
    public required string Start { get; init; }

    /// <summary>
    /// The end date of rev share. The format should be YYYY-MM-DD HH:MM:SS.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end")]
    [RegularExpression("^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}")]
    public string? End { get; init; }

    /// <summary>
    /// The percentage that payrix receives.
    /// </summary>
    [JsonPropertyName("share")]
    public required int Share { get; init; }

    [JsonPropertyName("event")]
    public required RevShareScheduleEvent1 Event { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
