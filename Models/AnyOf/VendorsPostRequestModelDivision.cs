using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// ID of the division associated with this vendor.
/// </summary>
[JsonConverter(typeof(VendorsPostRequestModelDivisionConverter))]
public record VendorsPostRequestModelDivision
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<DivisionsPostRequest> _divisionsPostRequestValue;

    private VendorsPostRequestModelDivision(Optional<string> stringValue,
        Optional<DivisionsPostRequest> divisionsPostRequestValue)
    {
        _stringValue = stringValue;
        _divisionsPostRequestValue = divisionsPostRequestValue;
    }

    public static VendorsPostRequestModelDivision String(string value) => new(Optional<string>.Some(value), default);

    public static VendorsPostRequestModelDivision DivisionsPostRequest(DivisionsPostRequest value) =>
        new(default, Optional<DivisionsPostRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDivisionsPostRequest(out DivisionsPostRequest value) =>
        _divisionsPostRequestValue.TryGetValue(out value);

    public static implicit operator VendorsPostRequestModelDivision(string value) => String(value);

    public static implicit operator VendorsPostRequestModelDivision(DivisionsPostRequest value) =>
        DivisionsPostRequest(value);
}

file sealed class VendorsPostRequestModelDivisionConverter : JsonConverter<VendorsPostRequestModelDivision>
{
    public override VendorsPostRequestModelDivision Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return VendorsPostRequestModelDivision.String(value);
        }
        if (JsonSerializer.TryDeserialize<DivisionsPostRequest>(root, options, out var divisionsPostRequestValue))
        {
            return VendorsPostRequestModelDivision.DivisionsPostRequest(divisionsPostRequestValue);
        }
        throw new JsonException($"JSON does not match string or DivisionsPostRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        VendorsPostRequestModelDivision value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetDivisionsPostRequest(out var divisionsPostRequestValue))
        {
            JsonSerializer.Serialize(writer, divisionsPostRequestValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(VendorsPostRequestModelDivision)} contains no valid value to serialize.");
        }
    }
}
