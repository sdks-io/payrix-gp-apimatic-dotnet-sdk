using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Plan that this Subscription is associated with. The Plan determines the frequency and amount of each payment.
/// </summary>
[JsonConverter(typeof(SubscriptionsModelPlanConverter))]
public record SubscriptionsModelPlan
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<PlansResponse> _plansResponseValue;

    private SubscriptionsModelPlan(Optional<string> stringValue, Optional<PlansResponse> plansResponseValue)
    {
        _stringValue = stringValue;
        _plansResponseValue = plansResponseValue;
    }

    public static SubscriptionsModelPlan String(string value) => new(Optional<string>.Some(value), default);

    public static SubscriptionsModelPlan PlansResponse(PlansResponse value) =>
        new(default, Optional<PlansResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetPlansResponse(out PlansResponse value) => _plansResponseValue.TryGetValue(out value);

    public static implicit operator SubscriptionsModelPlan(string value) => String(value);

    public static implicit operator SubscriptionsModelPlan(PlansResponse value) => PlansResponse(value);
}

file sealed class SubscriptionsModelPlanConverter : JsonConverter<SubscriptionsModelPlan>
{
    public override SubscriptionsModelPlan Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SubscriptionsModelPlan.String(value);
        }
        if (JsonSerializer.TryDeserialize<PlansResponse>(root, options, out var plansResponseValue))
        {
            return SubscriptionsModelPlan.PlansResponse(plansResponseValue);
        }
        throw new JsonException($"JSON does not match string or PlansResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, SubscriptionsModelPlan value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetPlansResponse(out var plansResponseValue))
        {
            JsonSerializer.Serialize(writer, plansResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SubscriptionsModelPlan)} contains no valid value to serialize.");
        }
    }
}
