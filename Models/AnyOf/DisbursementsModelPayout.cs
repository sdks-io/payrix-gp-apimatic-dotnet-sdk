using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Payout that represents the schedule for this Disbursement.
/// </summary>
[JsonConverter(typeof(DisbursementsModelPayoutConverter))]
public record DisbursementsModelPayout
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PayoutsResponse> _payoutsResponseValue;

    private DisbursementsModelPayout(Optional<string> stringValue, Optional<PayoutsResponse> payoutsResponseValue)
    {
        _stringValue = stringValue;
        _payoutsResponseValue = payoutsResponseValue;
    }

    public static DisbursementsModelPayout String(string value) => new(Optional<string>.Some(value), default);

    public static DisbursementsModelPayout PayoutsResponse(PayoutsResponse value) =>
        new(default, Optional<PayoutsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPayoutsResponse(out PayoutsResponse value) => _payoutsResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementsModelPayout(string value) => String(value);

    public static implicit operator DisbursementsModelPayout(PayoutsResponse value) => PayoutsResponse(value);
}

file sealed class DisbursementsModelPayoutConverter : JsonConverter<DisbursementsModelPayout>
{
    public override DisbursementsModelPayout Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementsModelPayout.String(value);
        }
        if (JsonSerializer.TryDeserialize<PayoutsResponse>(root, options, out var payoutsResponseValue))
        {
            return DisbursementsModelPayout.PayoutsResponse(payoutsResponseValue);
        }
        throw new JsonException($"JSON does not match string or PayoutsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DisbursementsModelPayout value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetPayoutsResponse(out var payoutsResponseValue))
        {
            JsonSerializer.Serialize(writer, payoutsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DisbursementsModelPayout)} contains no valid value to serialize.");
        }
    }
}
