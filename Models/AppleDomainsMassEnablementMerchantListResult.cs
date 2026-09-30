using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record AppleDomainsMassEnablementMerchantListResult
{
    /// <summary>
    /// Current verification status of the Apple Pay domain registration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("msg")]
    public string? Msg { get; init; }

    /// <summary>
    /// Status of the Apple domain change
    /// <para>
    /// &lt;details&gt;
    /// &lt;summary&gt;Valid Values&lt;/summary&gt;
    /// - <c>success</c> - <b>Domain successfully verified</b>
    /// - <c>failed</c> - <b>Domain verification failed</b>
    /// &lt;/details&gt;
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
