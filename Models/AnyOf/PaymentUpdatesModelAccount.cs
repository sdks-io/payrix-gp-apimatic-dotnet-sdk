using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The account associated with this Payment being updated. Used for instant funding payouts.
/// </summary>
[JsonConverter(typeof(PaymentUpdatesModelAccountConverter))]
public record PaymentUpdatesModelAccount
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AccountsResponse> _accountsResponseValue;

    private PaymentUpdatesModelAccount(Optional<string> stringValue, Optional<AccountsResponse> accountsResponseValue)
    {
        _stringValue = stringValue;
        _accountsResponseValue = accountsResponseValue;
    }

    public static PaymentUpdatesModelAccount String(string value) => new(Optional<string>.Some(value), default);

    public static PaymentUpdatesModelAccount AccountsResponse(AccountsResponse value) =>
        new(default, Optional<AccountsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAccountsResponse(out AccountsResponse value) => _accountsResponseValue.TryGetValue(out value);

    public static implicit operator PaymentUpdatesModelAccount(string value) => String(value);

    public static implicit operator PaymentUpdatesModelAccount(AccountsResponse value) => AccountsResponse(value);
}

file sealed class PaymentUpdatesModelAccountConverter : JsonConverter<PaymentUpdatesModelAccount>
{
    public override PaymentUpdatesModelAccount Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PaymentUpdatesModelAccount.String(value);
        }
        if (JsonSerializer.TryDeserialize<AccountsResponse>(root, options, out var accountsResponseValue))
        {
            return PaymentUpdatesModelAccount.AccountsResponse(accountsResponseValue);
        }
        throw new JsonException($"JSON does not match string or AccountsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PaymentUpdatesModelAccount value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(PaymentUpdatesModelAccount)} contains no valid value to serialize.");
        }
    }
}
