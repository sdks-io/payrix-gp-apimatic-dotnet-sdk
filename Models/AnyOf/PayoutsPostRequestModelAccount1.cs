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
[JsonConverter(typeof(PayoutsPostRequestModelAccount1Converter))]
public record PayoutsPostRequestModelAccount1
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PayoutsPostRequestModelAccount> _payoutsPostRequestModelAccountValue;

    private PayoutsPostRequestModelAccount1(Optional<string> stringValue,
        Optional<PayoutsPostRequestModelAccount> payoutsPostRequestModelAccountValue)
    {
        _stringValue = stringValue;
        _payoutsPostRequestModelAccountValue = payoutsPostRequestModelAccountValue;
    }

    public static PayoutsPostRequestModelAccount1 String(string value) => new(Optional<string>.Some(value), default);

    public static PayoutsPostRequestModelAccount1 PayoutsPostRequestModelAccount(PayoutsPostRequestModelAccount value) =>
        new(default, Optional<PayoutsPostRequestModelAccount>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPayoutsPostRequestModelAccount(out PayoutsPostRequestModelAccount value) =>
        _payoutsPostRequestModelAccountValue.TryGetValue(out value);

    public static implicit operator PayoutsPostRequestModelAccount1(string value) => String(value);

    public static implicit operator PayoutsPostRequestModelAccount1(PayoutsPostRequestModelAccount value) =>
        PayoutsPostRequestModelAccount(value);
}

file sealed class PayoutsPostRequestModelAccount1Converter : JsonConverter<PayoutsPostRequestModelAccount1>
{
    public override PayoutsPostRequestModelAccount1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PayoutsPostRequestModelAccount1.String(value);
        }
        if (JsonSerializer.TryDeserialize<PayoutsPostRequestModelAccount>(
            root,
            options,
            out var payoutsPostRequestModelAccountValue))
        {
            return PayoutsPostRequestModelAccount1.PayoutsPostRequestModelAccount(payoutsPostRequestModelAccountValue);
        }
        throw new JsonException(
            $"JSON does not match string or PayoutsPostRequestModelAccount schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        PayoutsPostRequestModelAccount1 value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetPayoutsPostRequestModelAccount(out var payoutsPostRequestModelAccountValue))
        {
            JsonSerializer.Serialize(writer, payoutsPostRequestModelAccountValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PayoutsPostRequestModelAccount1)} contains no valid value to serialize.");
        }
    }
}
