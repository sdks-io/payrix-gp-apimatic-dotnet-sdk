using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The PaymentGroup resource that this PaymentUpdate belongs to.
/// </summary>
[JsonConverter(typeof(PaymentUpdatesModelPaymentUpdateGroupConverter))]
public record PaymentUpdatesModelPaymentUpdateGroup
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PaymentUpdateGroupsResponse> _paymentUpdateGroupsResponseValue;

    private PaymentUpdatesModelPaymentUpdateGroup(Optional<string> stringValue,
        Optional<PaymentUpdateGroupsResponse> paymentUpdateGroupsResponseValue)
    {
        _stringValue = stringValue;
        _paymentUpdateGroupsResponseValue = paymentUpdateGroupsResponseValue;
    }

    public static PaymentUpdatesModelPaymentUpdateGroup String(string value) =>
        new(Optional<string>.Some(value), default);

    public static PaymentUpdatesModelPaymentUpdateGroup PaymentUpdateGroupsResponse(PaymentUpdateGroupsResponse value) =>
        new(default, Optional<PaymentUpdateGroupsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPaymentUpdateGroupsResponse(out PaymentUpdateGroupsResponse value) =>
        _paymentUpdateGroupsResponseValue.TryGetValue(out value);

    public static implicit operator PaymentUpdatesModelPaymentUpdateGroup(string value) => String(value);

    public static implicit operator PaymentUpdatesModelPaymentUpdateGroup(PaymentUpdateGroupsResponse value) =>
        PaymentUpdateGroupsResponse(value);
}

file sealed class PaymentUpdatesModelPaymentUpdateGroupConverter : JsonConverter<PaymentUpdatesModelPaymentUpdateGroup>
{
    public override PaymentUpdatesModelPaymentUpdateGroup Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PaymentUpdatesModelPaymentUpdateGroup.String(value);
        }
        if (JsonSerializer.TryDeserialize<PaymentUpdateGroupsResponse>(
            root,
            options,
            out var paymentUpdateGroupsResponseValue))
        {
            return PaymentUpdatesModelPaymentUpdateGroup.PaymentUpdateGroupsResponse(paymentUpdateGroupsResponseValue);
        }
        throw new JsonException(
            $"JSON does not match string or PaymentUpdateGroupsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        PaymentUpdatesModelPaymentUpdateGroup value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetPaymentUpdateGroupsResponse(out var paymentUpdateGroupsResponseValue))
        {
            JsonSerializer.Serialize(writer, paymentUpdateGroupsResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(PaymentUpdatesModelPaymentUpdateGroup)} contains no valid value to serialize.");
        }
    }
}
