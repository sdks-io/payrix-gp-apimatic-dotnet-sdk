using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If this hold resource was triggered through a verification, then this field stores the identifier of the Verification.
/// </summary>
[JsonConverter(typeof(HoldsModelVerificationConverter))]
public record HoldsModelVerification
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<VerificationsResponse> _verificationsResponseValue;

    private HoldsModelVerification(Optional<string> stringValue,
        Optional<VerificationsResponse> verificationsResponseValue)
    {
        _stringValue = stringValue;
        _verificationsResponseValue = verificationsResponseValue;
    }

    public static HoldsModelVerification String(string value) => new(Optional<string>.Some(value), default);

    public static HoldsModelVerification VerificationsResponse(VerificationsResponse value) =>
        new(default, Optional<VerificationsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetVerificationsResponse(out VerificationsResponse value) =>
        _verificationsResponseValue.TryGetValue(out value);

    public static implicit operator HoldsModelVerification(string value) => String(value);

    public static implicit operator HoldsModelVerification(VerificationsResponse value) => VerificationsResponse(value);
}

file sealed class HoldsModelVerificationConverter : JsonConverter<HoldsModelVerification>
{
    public override HoldsModelVerification Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return HoldsModelVerification.String(value);
        }
        if (JsonSerializer.TryDeserialize<VerificationsResponse>(root, options, out var verificationsResponseValue))
        {
            return HoldsModelVerification.VerificationsResponse(verificationsResponseValue);
        }
        throw new JsonException($"JSON does not match string or VerificationsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, HoldsModelVerification value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetVerificationsResponse(out var verificationsResponseValue))
        {
            JsonSerializer.Serialize(writer, verificationsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(HoldsModelVerification)} contains no valid value to serialize.");
        }
    }
}
