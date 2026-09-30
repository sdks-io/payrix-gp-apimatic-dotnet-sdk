using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// This holds the ID of the related vendor record.
/// </summary>
[JsonConverter(typeof(MembersModelVendorConverter))]
public record MembersModelVendor
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<VendorsResponse> _vendorsResponseValue;

    private MembersModelVendor(Optional<string> stringValue, Optional<VendorsResponse> vendorsResponseValue)
    {
        _stringValue = stringValue;
        _vendorsResponseValue = vendorsResponseValue;
    }

    public static MembersModelVendor String(string value) => new(Optional<string>.Some(value), default);

    public static MembersModelVendor VendorsResponse(VendorsResponse value) =>
        new(default, Optional<VendorsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetVendorsResponse(out VendorsResponse value) => _vendorsResponseValue.TryGetValue(out value);

    public static implicit operator MembersModelVendor(string value) => String(value);

    public static implicit operator MembersModelVendor(VendorsResponse value) => VendorsResponse(value);
}

file sealed class MembersModelVendorConverter : JsonConverter<MembersModelVendor>
{
    public override MembersModelVendor Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return MembersModelVendor.String(value);
        }
        if (JsonSerializer.TryDeserialize<VendorsResponse>(root, options, out var vendorsResponseValue))
        {
            return MembersModelVendor.VendorsResponse(vendorsResponseValue);
        }
        throw new JsonException($"JSON does not match string or VendorsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MembersModelVendor value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetVendorsResponse(out var vendorsResponseValue))
        {
            JsonSerializer.Serialize(writer, vendorsResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(MembersModelVendor)} contains no valid value to serialize.");
        }
    }
}
