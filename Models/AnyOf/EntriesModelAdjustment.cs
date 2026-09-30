using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The adjustment ID from which the funding activity was triggered.
/// </summary>
[JsonConverter(typeof(EntriesModelAdjustmentConverter))]
public record EntriesModelAdjustment
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AdjustmentsResponse> _adjustmentsResponseValue;

    private EntriesModelAdjustment(Optional<string> stringValue, Optional<AdjustmentsResponse> adjustmentsResponseValue)
    {
        _stringValue = stringValue;
        _adjustmentsResponseValue = adjustmentsResponseValue;
    }

    public static EntriesModelAdjustment String(string value) => new(Optional<string>.Some(value), default);

    public static EntriesModelAdjustment AdjustmentsResponse(AdjustmentsResponse value) =>
        new(default, Optional<AdjustmentsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAdjustmentsResponse(out AdjustmentsResponse value) =>
        _adjustmentsResponseValue.TryGetValue(out value);

    public static implicit operator EntriesModelAdjustment(string value) => String(value);

    public static implicit operator EntriesModelAdjustment(AdjustmentsResponse value) => AdjustmentsResponse(value);
}

file sealed class EntriesModelAdjustmentConverter : JsonConverter<EntriesModelAdjustment>
{
    public override EntriesModelAdjustment Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EntriesModelAdjustment.String(value);
        }
        if (JsonSerializer.TryDeserialize<AdjustmentsResponse>(root, options, out var adjustmentsResponseValue))
        {
            return EntriesModelAdjustment.AdjustmentsResponse(adjustmentsResponseValue);
        }
        throw new JsonException($"JSON does not match string or AdjustmentsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EntriesModelAdjustment value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(EntriesModelAdjustment)} contains no valid value to serialize.");
        }
    }
}
