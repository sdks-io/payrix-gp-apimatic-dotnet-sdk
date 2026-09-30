using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The token of the Account that this Payout is associated with.
/// This account will either receive the funds or be debited for the funds every time a Disbursement occurs, depending on the direction of the Disbursement.
/// </summary>
[JsonConverter(typeof(PayoutsModelAccountConverter))]
public record PayoutsModelAccount
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AccountsResponse> _accountsResponseValue;

    private PayoutsModelAccount(Optional<string> stringValue, Optional<AccountsResponse> accountsResponseValue)
    {
        _stringValue = stringValue;
        _accountsResponseValue = accountsResponseValue;
    }

    public static PayoutsModelAccount String(string value) => new(Optional<string>.Some(value), default);

    public static PayoutsModelAccount AccountsResponse(AccountsResponse value) =>
        new(default, Optional<AccountsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAccountsResponse(out AccountsResponse value) => _accountsResponseValue.TryGetValue(out value);

    public static implicit operator PayoutsModelAccount(string value) => String(value);

    public static implicit operator PayoutsModelAccount(AccountsResponse value) => AccountsResponse(value);
}

file sealed class PayoutsModelAccountConverter : JsonConverter<PayoutsModelAccount>
{
    public override PayoutsModelAccount Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PayoutsModelAccount.String(value);
        }
        if (JsonSerializer.TryDeserialize<AccountsResponse>(root, options, out var accountsResponseValue))
        {
            return PayoutsModelAccount.AccountsResponse(accountsResponseValue);
        }
        throw new JsonException($"JSON does not match string or AccountsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PayoutsModelAccount value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetAccountsResponse(out var accountsResponseValue))
        {
            JsonSerializer.Serialize(writer, accountsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PayoutsModelAccount)} contains no valid value to serialize.");
        }
    }
}
