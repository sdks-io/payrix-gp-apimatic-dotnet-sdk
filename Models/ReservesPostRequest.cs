using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record ReservesPostRequest
{
    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("org")]
    public OrgsPostRequest? Org { get; init; }

    /// <summary>
    /// The division on which this reserve applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("division")]
    public string? Division { get; init; }

    /// <summary>
    /// The partition on which this reserve applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partition")]
    public string? Partition { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("level")]
    public ReservesLevel2? Level { get; init; }

    /// <summary>
    /// The identifier of the Entity that this Reserve applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    /// <summary>
    /// The entity hold from which this reserve was generated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hold")]
    public string? Hold { get; init; }

    /// <summary>
    /// The name of this Reserve. This field is stored as a text string and must be between 1 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A description of this Reserve. This field is stored as a text string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The percentage of funds to reserve, expressed in basis points. For example, 25.3% is expressed as '2530'.
    /// </summary>
    [JsonPropertyName("percent")]
    public required int Percent { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("release")]
    public ReservesRelease2? Release { get; init; }

    /// <summary>
    /// A multiplier that you can use to adjust the schedule set in the 'release' field, which is specified as an integer and its value determines how the schedule is multiplied.
    /// </summary>
    [JsonPropertyName("releaseFactor")]
    public int? ReleaseFactor { get; init; } = 1;

    /// <summary>
    /// The date on which this Reserve resource should start reserving funds from the Entity or Org. The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start")]
    public int? Start { get; init; }

    /// <summary>
    /// The date on which this Reserve resource should stop reserving funds from the Entity or Org. The date is specified as an eight digit string in YYYYMMDD format, for example, '20160120' for January 20, 2016.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finish")]
    public int? Finish { get; init; }

    /// <summary>
    /// The maximum amount to reserve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max")]
    public long? Max { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
