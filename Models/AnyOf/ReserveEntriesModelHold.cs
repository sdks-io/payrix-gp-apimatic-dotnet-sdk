using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The ID of the hold that generated this reserveEntry.
/// </summary>
[JsonConverter(typeof(ReserveEntriesModelHoldConverter))]
public record ReserveEntriesModelHold
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<HoldsResponse> _holdsResponseValue;

    private ReserveEntriesModelHold(Optional<string> stringValue, Optional<HoldsResponse> holdsResponseValue)
    {
        _stringValue = stringValue;
        _holdsResponseValue = holdsResponseValue;
    }

    public static ReserveEntriesModelHold String(string value) => new(Optional<string>.Some(value), default);

    public static ReserveEntriesModelHold HoldsResponse(HoldsResponse value) =>
        new(default, Optional<HoldsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetHoldsResponse(out HoldsResponse value) => _holdsResponseValue.TryGetValue(out value);

    public static implicit operator ReserveEntriesModelHold(string value) => String(value);

    public static implicit operator ReserveEntriesModelHold(HoldsResponse value) => HoldsResponse(value);
}

file sealed class ReserveEntriesModelHoldConverter : JsonConverter<ReserveEntriesModelHold>
{
    public override ReserveEntriesModelHold Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ReserveEntriesModelHold.String(value);
        }
        if (JsonSerializer.TryDeserialize<HoldsResponse>(root, options, out var holdsResponseValue))
        {
            return ReserveEntriesModelHold.HoldsResponse(holdsResponseValue);
        }
        throw new JsonException($"JSON does not match string or HoldsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ReserveEntriesModelHold value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(ReserveEntriesModelHold)} contains no valid value to serialize.");
        }
    }
}
