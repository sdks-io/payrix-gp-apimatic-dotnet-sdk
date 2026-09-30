using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Adjustment that this fund origin relates to.
/// </summary>
[JsonConverter(typeof(FundOriginsModelAdjustmentConverter))]
public record FundOriginsModelAdjustment
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AdjustmentsResponse> _adjustmentsResponseValue;

    private FundOriginsModelAdjustment(Optional<string> stringValue,
        Optional<AdjustmentsResponse> adjustmentsResponseValue)
    {
        _stringValue = stringValue;
        _adjustmentsResponseValue = adjustmentsResponseValue;
    }

    public static FundOriginsModelAdjustment String(string value) => new(Optional<string>.Some(value), default);

    public static FundOriginsModelAdjustment AdjustmentsResponse(AdjustmentsResponse value) =>
        new(default, Optional<AdjustmentsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAdjustmentsResponse(out AdjustmentsResponse value) =>
        _adjustmentsResponseValue.TryGetValue(out value);

    public static implicit operator FundOriginsModelAdjustment(string value) => String(value);

    public static implicit operator FundOriginsModelAdjustment(AdjustmentsResponse value) => AdjustmentsResponse(value);
}

file sealed class FundOriginsModelAdjustmentConverter : JsonConverter<FundOriginsModelAdjustment>
{
    public override FundOriginsModelAdjustment Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return FundOriginsModelAdjustment.String(value);
        }
        if (JsonSerializer.TryDeserialize<AdjustmentsResponse>(root, options, out var adjustmentsResponseValue))
        {
            return FundOriginsModelAdjustment.AdjustmentsResponse(adjustmentsResponseValue);
        }
        throw new JsonException($"JSON does not match string or AdjustmentsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, FundOriginsModelAdjustment value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetAdjustmentsResponse(out var adjustmentsResponseValue))
        {
            JsonSerializer.Serialize(writer, adjustmentsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(FundOriginsModelAdjustment)} contains no valid value to serialize.");
        }
    }
}
