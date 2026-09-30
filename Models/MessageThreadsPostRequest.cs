using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record MessageThreadsPostRequest
{
    /// <summary>
    /// The identifier of the Login that owns this messageThreads resource.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

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
    [JsonPropertyName("folder")]
    public string? Folder { get; init; } = "default";

    /// <summary>
    /// Free-form text that represents the name of the sender of a messageThread resource.
    /// </summary>
    [JsonPropertyName("sender")]
    public required string Sender { get; init; }

    /// <summary>
    /// Free-form text that represents the name of the recipient of a messageThread resource.
    /// </summary>
    [JsonPropertyName("recipient")]
    public required string Recipient { get; init; }

    /// <summary>
    /// Free-form text for adding a subject to a messageThread resource.
    /// </summary>
    [JsonPropertyName("subject")]
    public required string Subject { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messages")]
    public IReadOnlyList<MessagesPostRequest>? Messages { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
