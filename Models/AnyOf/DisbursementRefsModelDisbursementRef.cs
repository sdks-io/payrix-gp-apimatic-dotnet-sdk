using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Payrix.Core.Extensions;
using Payrix.Core.Models;

namespace Payrix.Models.AnyOf;

/// <summary>
/// The identifier of the DisbursementRef that this disbursementRef resource refers to.
/// </summary>
[JsonConverter(typeof(DisbursementRefsModelDisbursementRefConverter))]
public record DisbursementRefsModelDisbursementRef
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<DisbursementRefsResponse> _disbursementRefsResponseValue;

    private DisbursementRefsModelDisbursementRef(Optional<string> stringValue,
        Optional<DisbursementRefsResponse> disbursementRefsResponseValue)
    {
        _stringValue = stringValue;
        _disbursementRefsResponseValue = disbursementRefsResponseValue;
    }

    public static DisbursementRefsModelDisbursementRef String(string value) =>
        new(Optional<string>.Some(value), default);

    public static DisbursementRefsModelDisbursementRef DisbursementRefsResponse(DisbursementRefsResponse value) =>
        new(default, Optional<DisbursementRefsResponse>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDisbursementRefsResponse(out DisbursementRefsResponse value) =>
        _disbursementRefsResponseValue.TryGetValue(out value);

    public static implicit operator DisbursementRefsModelDisbursementRef(string value) => String(value);

    public static implicit operator DisbursementRefsModelDisbursementRef(DisbursementRefsResponse value) =>
        DisbursementRefsResponse(value);
}

file sealed class DisbursementRefsModelDisbursementRefConverter : JsonConverter<DisbursementRefsModelDisbursementRef>
{
    public override DisbursementRefsModelDisbursementRef Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return DisbursementRefsModelDisbursementRef.String(value);
        }
        if (JsonSerializer.TryDeserialize<DisbursementRefsResponse>(
            root,
            options,
            out var disbursementRefsResponseValue))
        {
            return DisbursementRefsModelDisbursementRef.DisbursementRefsResponse(disbursementRefsResponseValue);
        }
        throw new JsonException($"JSON does not match string or DisbursementRefsResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DisbursementRefsModelDisbursementRef value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetDisbursementRefsResponse(out var disbursementRefsResponseValue))
        {
            JsonSerializer.Serialize(writer, disbursementRefsResponseValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(DisbursementRefsModelDisbursementRef)} contains no valid value to serialize.");
        }
    }
}
