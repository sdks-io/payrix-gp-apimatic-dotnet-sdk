using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the PayoutFlow associated with this Payout.
/// </summary>
[JsonConverter(typeof(PayoutsModelPayoutFlowConverter))]
public record PayoutsModelPayoutFlow
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PayoutFlowsResponse> _payoutFlowsResponseValue;

    private PayoutsModelPayoutFlow(Optional<string> stringValue, Optional<PayoutFlowsResponse> payoutFlowsResponseValue)
    {
        _stringValue = stringValue;
        _payoutFlowsResponseValue = payoutFlowsResponseValue;
    }

    public static PayoutsModelPayoutFlow String(string value) => new(Optional<string>.Some(value), default);

    public static PayoutsModelPayoutFlow PayoutFlowsResponse(PayoutFlowsResponse value) =>
        new(default, Optional<PayoutFlowsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPayoutFlowsResponse(out PayoutFlowsResponse value) =>
        _payoutFlowsResponseValue.TryGetValue(out value);

    public static implicit operator PayoutsModelPayoutFlow(string value) => String(value);

    public static implicit operator PayoutsModelPayoutFlow(PayoutFlowsResponse value) => PayoutFlowsResponse(value);
}

file sealed class PayoutsModelPayoutFlowConverter : JsonConverter<PayoutsModelPayoutFlow>
{
    public override PayoutsModelPayoutFlow Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PayoutsModelPayoutFlow.String(value);
        }
        if (JsonSerializer.TryDeserialize<PayoutFlowsResponse>(root, options, out var payoutFlowsResponseValue))
        {
            return PayoutsModelPayoutFlow.PayoutFlowsResponse(payoutFlowsResponseValue);
        }
        throw new JsonException($"JSON does not match string or PayoutFlowsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PayoutsModelPayoutFlow value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetPayoutFlowsResponse(out var payoutFlowsResponseValue))
        {
            JsonSerializer.Serialize(writer, payoutFlowsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PayoutsModelPayoutFlow)} contains no valid value to serialize.");
        }
    }
}
