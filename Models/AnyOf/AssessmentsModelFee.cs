using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the Fee that this assessment resource refers to.
/// </summary>
[JsonConverter(typeof(AssessmentsModelFeeConverter))]
public record AssessmentsModelFee
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<FeesResponse> _feesResponseValue;

    private AssessmentsModelFee(Optional<string> stringValue, Optional<FeesResponse> feesResponseValue)
    {
        _stringValue = stringValue;
        _feesResponseValue = feesResponseValue;
    }

    public static AssessmentsModelFee String(string value) => new(Optional<string>.Some(value), default);

    public static AssessmentsModelFee FeesResponse(FeesResponse value) =>
        new(default, Optional<FeesResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetFeesResponse(out FeesResponse value) => _feesResponseValue.TryGetValue(out value);

    public static implicit operator AssessmentsModelFee(string value) => String(value);

    public static implicit operator AssessmentsModelFee(FeesResponse value) => FeesResponse(value);
}

file sealed class AssessmentsModelFeeConverter : JsonConverter<AssessmentsModelFee>
{
    public override AssessmentsModelFee Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AssessmentsModelFee.String(value);
        }
        if (JsonSerializer.TryDeserialize<FeesResponse>(root, options, out var feesResponseValue))
        {
            return AssessmentsModelFee.FeesResponse(feesResponseValue);
        }
        throw new JsonException($"JSON does not match string or FeesResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AssessmentsModelFee value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(AssessmentsModelFee)} contains no valid value to serialize.");
        }
    }
}
