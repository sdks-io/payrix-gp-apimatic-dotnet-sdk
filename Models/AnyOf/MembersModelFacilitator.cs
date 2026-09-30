using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// This holds the ID of the related facilitator record.
/// </summary>
[JsonConverter(typeof(MembersModelFacilitatorConverter))]
public record MembersModelFacilitator
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<FacilitatorsResponse> _facilitatorsResponseValue;

    private MembersModelFacilitator(Optional<string> stringValue,
        Optional<FacilitatorsResponse> facilitatorsResponseValue)
    {
        _stringValue = stringValue;
        _facilitatorsResponseValue = facilitatorsResponseValue;
    }

    public static MembersModelFacilitator String(string value) => new(Optional<string>.Some(value), default);

    public static MembersModelFacilitator FacilitatorsResponse(FacilitatorsResponse value) =>
        new(default, Optional<FacilitatorsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetFacilitatorsResponse(out FacilitatorsResponse value) =>
        _facilitatorsResponseValue.TryGetValue(out value);

    public static implicit operator MembersModelFacilitator(string value) => String(value);

    public static implicit operator MembersModelFacilitator(FacilitatorsResponse value) => FacilitatorsResponse(value);
}

file sealed class MembersModelFacilitatorConverter : JsonConverter<MembersModelFacilitator>
{
    public override MembersModelFacilitator Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return MembersModelFacilitator.String(value);
        }
        if (JsonSerializer.TryDeserialize<FacilitatorsResponse>(root, options, out var facilitatorsResponseValue))
        {
            return MembersModelFacilitator.FacilitatorsResponse(facilitatorsResponseValue);
        }
        throw new JsonException($"JSON does not match string or FacilitatorsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MembersModelFacilitator value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetFacilitatorsResponse(out var facilitatorsResponseValue))
        {
            JsonSerializer.Serialize(writer, facilitatorsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(MembersModelFacilitator)} contains no valid value to serialize.");
        }
    }
}
