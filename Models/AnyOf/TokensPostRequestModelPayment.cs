using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The payment method that is associated with this Token.
/// </summary>
[JsonConverter(typeof(TokensPostRequestModelPaymentConverter))]
public record TokensPostRequestModelPayment
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PaymentPostRequest> _paymentPostRequestValue;

    private TokensPostRequestModelPayment(Optional<string> stringValue,
        Optional<PaymentPostRequest> paymentPostRequestValue)
    {
        _stringValue = stringValue;
        _paymentPostRequestValue = paymentPostRequestValue;
    }

    public static TokensPostRequestModelPayment String(string value) => new(Optional<string>.Some(value), default);

    public static TokensPostRequestModelPayment PaymentPostRequest(PaymentPostRequest value) =>
        new(default, Optional<PaymentPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPaymentPostRequest(out PaymentPostRequest value) =>
        _paymentPostRequestValue.TryGetValue(out value);

    public static implicit operator TokensPostRequestModelPayment(string value) => String(value);

    public static implicit operator TokensPostRequestModelPayment(PaymentPostRequest value) =>
        PaymentPostRequest(value);
}

file sealed class TokensPostRequestModelPaymentConverter : JsonConverter<TokensPostRequestModelPayment>
{
    public override TokensPostRequestModelPayment Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TokensPostRequestModelPayment.String(value);
        }
        if (JsonSerializer.TryDeserialize<PaymentPostRequest>(root, options, out var paymentPostRequestValue))
        {
            return TokensPostRequestModelPayment.PaymentPostRequest(paymentPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or PaymentPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        TokensPostRequestModelPayment value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetPaymentPostRequest(out var paymentPostRequestValue))
        {
            JsonSerializer.Serialize(writer, paymentPostRequestValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TokensPostRequestModelPayment)} contains no valid value to serialize.");
        }
    }
}
