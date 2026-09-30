using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record IplistsPutRequest
{
    /// <summary>
    /// The Login that owns this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public IplistType1? Type { get; init; }

    /// <summary>
    /// The lowest IP address that should be included in this IP List.
    /// The valid data type for this field depends on whether the IP list is set to be an IPv4 or IPv6 list in the 'type' field.
    /// For an IPv4 list, only IPv4 addresses such as 198.51.100.113 are permitted. For an IPv6 list, only IPv6 addresses such as 2001:0db8:85a3:0000:0000:8a2e:0370:7334 are permitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start")]
    public string? Start { get; init; }

    /// <summary>
    /// The highest IP address that should be included in this IP List.
    /// The valid values for this field depend on whether the IP list is set to be an IPv4 or IPv6 list in the 'type' field.
    /// For an IPv4 list, only IPv4 addresses, such as '198.51.100.113', are permitted. For an IPv6 list, only IPv6 addresses, such as '2001:0db8:85a3:0000:0000:8a2e:0370:7334' are permitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finish")]
    public string? Finish { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
