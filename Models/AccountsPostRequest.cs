using System.Collections.Generic;
using System.Text.Json.Serialization;
using Payrix.Core.Models;
using Payrix.Models.Enums;

namespace Payrix.Models;

/// <summary>
/// A request body for creating new bank account information for one or more entities.
/// </summary>
public record AccountsPostRequest
{
    /// <summary>
    /// The identifier of the Entity associated with this Account.
    /// </summary>
    [JsonPropertyName("entity")]
    public required string Entity { get; init; }

    [JsonPropertyName("account")]
    public required Account4 Account { get; init; }

    /// <summary>
    /// A client-supplied name for this bank account.
    /// This field is stored as a string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A client-supplied description for this bank account.
    /// This field is stored as a string and must be between 0 and 100 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary")]
    public AccountPrimary1? Primary { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public AccountType1? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public AccountStatus1? Status { get; init; }

    /// <summary>
    /// The expiration date of the related debit account. The date is specified as a four-digit string in MMYY format, for example, <c>0118</c> for January 2018.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration")]
    public string? Expiration { get; init; }

    [JsonPropertyName("currency")]
    public required object Currency { get; init; }

    /// <summary>
    /// The token received from the Plaid account connection process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publicToken")]
    public string? PublicToken { get; init; }

    /// <summary>
    /// The account number mask, showing the last four digits of the account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mask")]
    public string? Mask { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive")]
    public Inactive1? Inactive { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozen")]
    public Frozen1? Frozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payouts")]
    public IReadOnlyList<PayoutPostRequest>? Payouts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
