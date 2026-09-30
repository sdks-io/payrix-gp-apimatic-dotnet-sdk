using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The payment method associated with this Transaction, including the card details.
/// </summary>
[JsonConverter(typeof(TxnsPostModelPaymentConverter))]
public record TxnsPostModelPayment
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PaymentPostRequest> _paymentPostRequestValue;

    private TxnsPostModelPayment(Optional<string> stringValue, Optional<PaymentPostRequest> paymentPostRequestValue)
    {
        _stringValue = stringValue;
        _paymentPostRequestValue = paymentPostRequestValue;
    }

    public static TxnsPostModelPayment String(string value) => new(Optional<string>.Some(value), default);

    public static TxnsPostModelPayment PaymentPostRequest(PaymentPostRequest value) =>
        new(default, Optional<PaymentPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPaymentPostRequest(out PaymentPostRequest value) =>
        _paymentPostRequestValue.TryGetValue(out value);

    public static implicit operator TxnsPostModelPayment(string value) => String(value);

    public static implicit operator TxnsPostModelPayment(PaymentPostRequest value) => PaymentPostRequest(value);
}

file sealed class TxnsPostModelPaymentConverter : JsonConverter<TxnsPostModelPayment>
{
    public override TxnsPostModelPayment Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TxnsPostModelPayment.String(value);
        }
        if (JsonSerializer.TryDeserialize<PaymentPostRequest>(root, options, out var paymentPostRequestValue))
        {
            return TxnsPostModelPayment.PaymentPostRequest(paymentPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or PaymentPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TxnsPostModelPayment value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TxnsPostModelPayment)} contains no valid value to serialize.");
        }
    }
}
