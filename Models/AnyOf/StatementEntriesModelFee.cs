using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If the activity that this StatementEntry refers to is the charging of a Fee, then this field stores the identifier of the corresponding Fee resource.
/// </summary>
[JsonConverter(typeof(StatementEntriesModelFeeConverter))]
public record StatementEntriesModelFee
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<FeesResponse> _feesResponseValue;

    private StatementEntriesModelFee(Optional<string> stringValue, Optional<FeesResponse> feesResponseValue)
    {
        _stringValue = stringValue;
        _feesResponseValue = feesResponseValue;
    }

    public static StatementEntriesModelFee String(string value) => new(Optional<string>.Some(value), default);

    public static StatementEntriesModelFee FeesResponse(FeesResponse value) =>
        new(default, Optional<FeesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetFeesResponse(out FeesResponse value) => _feesResponseValue.TryGetValue(out value);

    public static implicit operator StatementEntriesModelFee(string value) => String(value);

    public static implicit operator StatementEntriesModelFee(FeesResponse value) => FeesResponse(value);
}

file sealed class StatementEntriesModelFeeConverter : JsonConverter<StatementEntriesModelFee>
{
    public override StatementEntriesModelFee Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return StatementEntriesModelFee.String(value);
        }
        if (JsonSerializer.TryDeserialize<FeesResponse>(root, options, out var feesResponseValue))
        {
            return StatementEntriesModelFee.FeesResponse(feesResponseValue);
        }
        throw new JsonException($"JSON does not match string or FeesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, StatementEntriesModelFee value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetFeesResponse(out var feesResponseValue))
        {
            JsonSerializer.Serialize(writer, feesResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(StatementEntriesModelFee)} contains no valid value to serialize.");
        }
    }
}
