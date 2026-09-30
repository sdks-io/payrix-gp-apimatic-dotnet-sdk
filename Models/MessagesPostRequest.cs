using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

public record MessagesPostRequest
{
    /// <summary>
    /// The identifier of the messageThreads that owns this Messages resource.
    /// </summary>
    [JsonPropertyName("messageThread")]
    public required string MessageThread { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secure")]
    public MessagesSecure1? Secure { get; init; }

    [JsonPropertyName("read")]
    public required MessagesRead1 Read { get; init; }

    /// <summary>
    /// Free-form text for adding a message to a messageThread resource.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
