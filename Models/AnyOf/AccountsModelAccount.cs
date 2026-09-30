using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Payment associated with this Account.
/// </summary>
[JsonConverter(typeof(AccountsModelAccountConverter))]
public record AccountsModelAccount
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AccountPayment> _accountPaymentValue;

    private AccountsModelAccount(Optional<string> stringValue, Optional<AccountPayment> accountPaymentValue)
    {
        _stringValue = stringValue;
        _accountPaymentValue = accountPaymentValue;
    }

    public static AccountsModelAccount String(string value) => new(Optional<string>.Some(value), default);

    public static AccountsModelAccount AccountPayment(AccountPayment value) =>
        new(default, Optional<AccountPayment>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAccountPayment(out AccountPayment value) => _accountPaymentValue.TryGetValue(out value);

    public static implicit operator AccountsModelAccount(string value) => String(value);

    public static implicit operator AccountsModelAccount(AccountPayment value) => AccountPayment(value);
}

file sealed class AccountsModelAccountConverter : JsonConverter<AccountsModelAccount>
{
    public override AccountsModelAccount Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AccountsModelAccount.String(value);
        }
        if (JsonSerializer.TryDeserialize<AccountPayment>(root, options, out var accountPaymentValue))
        {
            return AccountsModelAccount.AccountPayment(accountPaymentValue);
        }
        throw new JsonException($"JSON does not match string or AccountPayment schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AccountsModelAccount value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetAccountPayment(out var accountPaymentValue))
        {
            JsonSerializer.Serialize(writer, accountPaymentValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AccountsModelAccount)} contains no valid value to serialize.");
        }
    }
}
