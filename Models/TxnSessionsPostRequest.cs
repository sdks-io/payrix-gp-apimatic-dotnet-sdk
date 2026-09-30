using System.Text.Json.Serialization;
using Payrix.Core.Models;

namespace Payrix.Models;

public record TxnSessionsPostRequest
{
    /// <summary>
    /// The login under which to perform this action. If you do not supply a login in this field, then the API defaults to the login that is currently authenticated.
    /// </summary>
    [JsonPropertyName("login")]
    public required string Login { get; init; }

    /// <summary>
    /// The Merchant being used to create this txn session.
    /// </summary>
    [JsonPropertyName("merchant")]
    public required string Merchant { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configurations")]
    public Configurations? Configurations { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
