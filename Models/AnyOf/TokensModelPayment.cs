using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The payment method that is associated with this Token.
/// </summary>
[JsonConverter(typeof(TokensModelPaymentConverter))]
public record TokensModelPayment
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PaymentResponse> _paymentResponseValue;

    private TokensModelPayment(Optional<string> stringValue, Optional<PaymentResponse> paymentResponseValue)
    {
        _stringValue = stringValue;
        _paymentResponseValue = paymentResponseValue;
    }

    public static TokensModelPayment String(string value) => new(Optional<string>.Some(value), default);

    public static TokensModelPayment PaymentResponse(PaymentResponse value) =>
        new(default, Optional<PaymentResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPaymentResponse(out PaymentResponse value) => _paymentResponseValue.TryGetValue(out value);

    public static implicit operator TokensModelPayment(string value) => String(value);

    public static implicit operator TokensModelPayment(PaymentResponse value) => PaymentResponse(value);
}

file sealed class TokensModelPaymentConverter : JsonConverter<TokensModelPayment>
{
    public override TokensModelPayment Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TokensModelPayment.String(value);
        }
        if (JsonSerializer.TryDeserialize<PaymentResponse>(root, options, out var paymentResponseValue))
        {
            return TokensModelPayment.PaymentResponse(paymentResponseValue);
        }
        throw new JsonException($"JSON does not match string or PaymentResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TokensModelPayment value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetPaymentResponse(out var paymentResponseValue))
        {
            JsonSerializer.Serialize(writer, paymentResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TokensModelPayment)} contains no valid value to serialize.");
        }
    }
}
