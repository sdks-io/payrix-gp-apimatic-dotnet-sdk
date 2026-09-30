using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The payment associated with this PaymentUpdate.
/// </summary>
[JsonConverter(typeof(PaymentUpdatesModelPaymentConverter))]
public record PaymentUpdatesModelPayment
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PaymentResponse> _paymentResponseValue;

    private PaymentUpdatesModelPayment(Optional<string> stringValue, Optional<PaymentResponse> paymentResponseValue)
    {
        _stringValue = stringValue;
        _paymentResponseValue = paymentResponseValue;
    }

    public static PaymentUpdatesModelPayment String(string value) => new(Optional<string>.Some(value), default);

    public static PaymentUpdatesModelPayment PaymentResponse(PaymentResponse value) =>
        new(default, Optional<PaymentResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPaymentResponse(out PaymentResponse value) => _paymentResponseValue.TryGetValue(out value);

    public static implicit operator PaymentUpdatesModelPayment(string value) => String(value);

    public static implicit operator PaymentUpdatesModelPayment(PaymentResponse value) => PaymentResponse(value);
}

file sealed class PaymentUpdatesModelPaymentConverter : JsonConverter<PaymentUpdatesModelPayment>
{
    public override PaymentUpdatesModelPayment Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PaymentUpdatesModelPayment.String(value);
        }
        if (JsonSerializer.TryDeserialize<PaymentResponse>(root, options, out var paymentResponseValue))
        {
            return PaymentUpdatesModelPayment.PaymentResponse(paymentResponseValue);
        }
        throw new JsonException($"JSON does not match string or PaymentResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PaymentUpdatesModelPayment value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(PaymentUpdatesModelPayment)} contains no valid value to serialize.");
        }
    }
}
