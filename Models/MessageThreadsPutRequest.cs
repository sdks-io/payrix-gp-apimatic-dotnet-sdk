using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record MessageThreadsPutRequest
{
    /// <summary>
    /// The identifier of the Login that owns this messageThreads resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("login")]
    public string? Login { get; init; }

    /// <summary>
    /// The identifier of the receiving Login of this messageThreads resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forlogin")]
    public string? Forlogin { get; init; }

    /// <summary>
    /// The identifier of the Hold that is related to this messageThread.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hold")]
    public string? Hold { get; init; }

    /// <summary>
    /// This field has the ID from the EntityReturns table that hold ACH returns for disbursements or eCheck txns.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityReturn")]
    public string? EntityReturn { get; init; }

    /// <summary>
    /// Specifies whether this is the opposing MessageThread.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("opposingMessageThread")]
    public string? OpposingMessageThread { get; init; }

    /// <summary>
    /// Free-form text. By default, a messageThread resource is set as 'default'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("folder")]
    public string? Folder { get; init; }

    /// <summary>
    /// Free-form text that represents the name of the sender of a messageThread resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sender")]
    public string? Sender { get; init; }

    /// <summary>
    /// Free-form text that represents the name of the recipient of a messageThread resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient")]
    public string? Recipient { get; init; }

    /// <summary>
    /// Free-form text for adding a subject to a messageThread resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subject")]
    public string? Subject { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
