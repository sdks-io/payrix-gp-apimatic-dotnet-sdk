using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Entity Hold from which this Reserve was generated.
/// </summary>
[JsonConverter(typeof(ReservesModelHoldConverter))]
public record ReservesModelHold
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<HoldsResponse> _holdsResponseValue;

    private ReservesModelHold(Optional<string> stringValue, Optional<HoldsResponse> holdsResponseValue)
    {
        _stringValue = stringValue;
        _holdsResponseValue = holdsResponseValue;
    }

    public static ReservesModelHold String(string value) => new(Optional<string>.Some(value), default);

    public static ReservesModelHold HoldsResponse(HoldsResponse value) =>
        new(default, Optional<HoldsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetHoldsResponse(out HoldsResponse value) => _holdsResponseValue.TryGetValue(out value);

    public static implicit operator ReservesModelHold(string value) => String(value);

    public static implicit operator ReservesModelHold(HoldsResponse value) => HoldsResponse(value);
}

file sealed class ReservesModelHoldConverter : JsonConverter<ReservesModelHold>
{
    public override ReservesModelHold Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ReservesModelHold.String(value);
        }
        if (JsonSerializer.TryDeserialize<HoldsResponse>(root, options, out var holdsResponseValue))
        {
            return ReservesModelHold.HoldsResponse(holdsResponseValue);
        }
        throw new JsonException($"JSON does not match string or HoldsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ReservesModelHold value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetHoldsResponse(out var holdsResponseValue))
        {
            JsonSerializer.Serialize(writer, holdsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ReservesModelHold)} contains no valid value to serialize.");
        }
    }
}
