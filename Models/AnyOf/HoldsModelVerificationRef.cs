using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// If this hold resource was triggered through Payrix Integration Risk, then this field stores the identifier of the VerificationRef.
/// </summary>
[JsonConverter(typeof(HoldsModelVerificationRefConverter))]
public record HoldsModelVerificationRef
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<VerificationRefsResponse> _verificationRefsResponseValue;

    private HoldsModelVerificationRef(Optional<string> stringValue,
        Optional<VerificationRefsResponse> verificationRefsResponseValue)
    {
        _stringValue = stringValue;
        _verificationRefsResponseValue = verificationRefsResponseValue;
    }

    public static HoldsModelVerificationRef String(string value) => new(Optional<string>.Some(value), default);

    public static HoldsModelVerificationRef VerificationRefsResponse(VerificationRefsResponse value) =>
        new(default, Optional<VerificationRefsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetVerificationRefsResponse(out VerificationRefsResponse value) =>
        _verificationRefsResponseValue.TryGetValue(out value);

    public static implicit operator HoldsModelVerificationRef(string value) => String(value);

    public static implicit operator HoldsModelVerificationRef(VerificationRefsResponse value) =>
        VerificationRefsResponse(value);
}

file sealed class HoldsModelVerificationRefConverter : JsonConverter<HoldsModelVerificationRef>
{
    public override HoldsModelVerificationRef Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return HoldsModelVerificationRef.String(value);
        }
        if (JsonSerializer.TryDeserialize<VerificationRefsResponse>(
            root,
            options,
            out var verificationRefsResponseValue))
        {
            return HoldsModelVerificationRef.VerificationRefsResponse(verificationRefsResponseValue);
        }
        throw new JsonException($"JSON does not match string or VerificationRefsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, HoldsModelVerificationRef value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetVerificationRefsResponse(out var verificationRefsResponseValue))
        {
            JsonSerializer.Serialize(writer, verificationRefsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(HoldsModelVerificationRef)} contains no valid value to serialize.");
        }
    }
}
