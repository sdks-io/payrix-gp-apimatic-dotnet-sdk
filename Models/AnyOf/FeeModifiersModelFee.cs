using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Fee that this Fee Modifier applies.
/// </summary>
[JsonConverter(typeof(FeeModifiersModelFeeConverter))]
public record FeeModifiersModelFee
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<FeesResponse> _feesResponseValue;

    private FeeModifiersModelFee(Optional<string> stringValue, Optional<FeesResponse> feesResponseValue)
    {
        _stringValue = stringValue;
        _feesResponseValue = feesResponseValue;
    }

    public static FeeModifiersModelFee String(string value) => new(Optional<string>.Some(value), default);

    public static FeeModifiersModelFee FeesResponse(FeesResponse value) =>
        new(default, Optional<FeesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetFeesResponse(out FeesResponse value) => _feesResponseValue.TryGetValue(out value);

    public static implicit operator FeeModifiersModelFee(string value) => String(value);

    public static implicit operator FeeModifiersModelFee(FeesResponse value) => FeesResponse(value);
}

file sealed class FeeModifiersModelFeeConverter : JsonConverter<FeeModifiersModelFee>
{
    public override FeeModifiersModelFee Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return FeeModifiersModelFee.String(value);
        }
        if (JsonSerializer.TryDeserialize<FeesResponse>(root, options, out var feesResponseValue))
        {
            return FeeModifiersModelFee.FeesResponse(feesResponseValue);
        }
        throw new JsonException($"JSON does not match string or FeesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, FeeModifiersModelFee value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(FeeModifiersModelFee)} contains no valid value to serialize.");
        }
    }
}
