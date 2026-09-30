using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The attached billing for which recurring payments should be made to pay off statements.
/// </summary>
[JsonConverter(typeof(PlansModelBillingConverter))]
public record PlansModelBilling
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<BillingsResponse> _billingsResponseValue;

    private PlansModelBilling(Optional<string> stringValue, Optional<BillingsResponse> billingsResponseValue)
    {
        _stringValue = stringValue;
        _billingsResponseValue = billingsResponseValue;
    }

    public static PlansModelBilling String(string value) => new(Optional<string>.Some(value), default);

    public static PlansModelBilling BillingsResponse(BillingsResponse value) =>
        new(default, Optional<BillingsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetBillingsResponse(out BillingsResponse value) => _billingsResponseValue.TryGetValue(out value);

    public static implicit operator PlansModelBilling(string value) => String(value);

    public static implicit operator PlansModelBilling(BillingsResponse value) => BillingsResponse(value);
}

file sealed class PlansModelBillingConverter : JsonConverter<PlansModelBilling>
{
    public override PlansModelBilling Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return PlansModelBilling.String(value);
        }
        if (JsonSerializer.TryDeserialize<BillingsResponse>(root, options, out var billingsResponseValue))
        {
            return PlansModelBilling.BillingsResponse(billingsResponseValue);
        }
        throw new JsonException($"JSON does not match string or BillingsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PlansModelBilling value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetBillingsResponse(out var billingsResponseValue))
        {
            JsonSerializer.Serialize(writer, billingsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PlansModelBilling)} contains no valid value to serialize.");
        }
    }
}
