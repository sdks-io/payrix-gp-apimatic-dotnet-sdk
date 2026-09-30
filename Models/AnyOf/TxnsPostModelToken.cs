using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The token of the Tokens resource this Transaction is associated with.
/// </summary>
[JsonConverter(typeof(TxnsPostModelTokenConverter))]
public record TxnsPostModelToken
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PaymentPostRequest> _paymentPostRequestValue;

    private TxnsPostModelToken(Optional<string> stringValue, Optional<PaymentPostRequest> paymentPostRequestValue)
    {
        _stringValue = stringValue;
        _paymentPostRequestValue = paymentPostRequestValue;
    }

    public static TxnsPostModelToken String(string value) => new(Optional<string>.Some(value), default);

    public static TxnsPostModelToken PaymentPostRequest(PaymentPostRequest value) =>
        new(default, Optional<PaymentPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPaymentPostRequest(out PaymentPostRequest value) =>
        _paymentPostRequestValue.TryGetValue(out value);

    public static implicit operator TxnsPostModelToken(string value) => String(value);

    public static implicit operator TxnsPostModelToken(PaymentPostRequest value) => PaymentPostRequest(value);
}

file sealed class TxnsPostModelTokenConverter : JsonConverter<TxnsPostModelToken>
{
    public override TxnsPostModelToken Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TxnsPostModelToken.String(value);
        }
        if (JsonSerializer.TryDeserialize<PaymentPostRequest>(root, options, out var paymentPostRequestValue))
        {
            return TxnsPostModelToken.PaymentPostRequest(paymentPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or PaymentPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TxnsPostModelToken value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TxnsPostModelToken)} contains no valid value to serialize.");
        }
    }
}
