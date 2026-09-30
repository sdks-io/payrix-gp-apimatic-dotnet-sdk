using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Account that owns this holds resource.
/// </summary>
[JsonConverter(typeof(HoldsModelAccountConverter))]
public record HoldsModelAccount
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AccountsResponse> _accountsResponseValue;

    private HoldsModelAccount(Optional<string> stringValue, Optional<AccountsResponse> accountsResponseValue)
    {
        _stringValue = stringValue;
        _accountsResponseValue = accountsResponseValue;
    }

    public static HoldsModelAccount String(string value) => new(Optional<string>.Some(value), default);

    public static HoldsModelAccount AccountsResponse(AccountsResponse value) =>
        new(default, Optional<AccountsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAccountsResponse(out AccountsResponse value) => _accountsResponseValue.TryGetValue(out value);

    public static implicit operator HoldsModelAccount(string value) => String(value);

    public static implicit operator HoldsModelAccount(AccountsResponse value) => AccountsResponse(value);
}

file sealed class HoldsModelAccountConverter : JsonConverter<HoldsModelAccount>
{
    public override HoldsModelAccount Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return HoldsModelAccount.String(value);
        }
        if (JsonSerializer.TryDeserialize<AccountsResponse>(root, options, out var accountsResponseValue))
        {
            return HoldsModelAccount.AccountsResponse(accountsResponseValue);
        }
        throw new JsonException($"JSON does not match string or AccountsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, HoldsModelAccount value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(HoldsModelAccount)} contains no valid value to serialize.");
        }
    }
}
